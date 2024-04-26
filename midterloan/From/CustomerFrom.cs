using midterloan.Data;
using midterloan.Entity;
using System.Data;

namespace midterloan.From
{
    public partial class CustomerFrom : Form
    {
        int score = 0;
        BindingSource bsCustomer;
        DataTable dtAddress;


        public CustomerFrom()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            score = 1;
            btnSave.Enabled = true;
            if (dtAddress != null)
                dtAddress.Rows.Clear();
            btnSave.BackColor = Color.FromArgb(32, 85, 131);
            Clear();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            score = 2;
            btnSave.Enabled = true;
            btnSave.BackColor = Color.FromArgb(32, 85, 131);
            Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidate())
            {
                return;
            }
            Customer customer = new Customer();
            customer.CustomerName = txtCustomerName.Text.Trim();
            customer.Sex = SetGender();
            customer.DoB = DtpDateOfBirth.Value;
            customer.PoB = txtPob.Text.Trim();
            customer.Phone = txtPhone.Text.Trim();
            customer.Email = txtEmail.Text.Trim();
            if (score == 1)
            {
                try
                {
                    int id = Customers.Add(customer);
                    if (id > 0)
                    {
                        foreach (DataRow row in dtAddress.Rows)
                        {
                            Address addr = new Address();
                            addr.AddressName = row["AddressName"].ToString();
                            addr.CustomerId = id;
                            Addresses.Add(addr);
                        }
                    }
                    MessageBox.Show("Record is saving!.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception is " + ex.Message);
                }
            }
            else if (score == 2)
            {
                int id = int.Parse(dgCustomerName.SelectedRows[0].Cells[0].Value.ToString());
                if (id > 0)
                {
                    try
                    {
                        customer.CustomerId = id;
                        Customers.Update(customer);
                        Addresses.Delete(id);
                        foreach (DataRow row in dtAddress.Rows)
                        {
                            Address addr = new Address();
                            addr.AddressName = row["AddressName"].ToString();
                            addr.CustomerId = id;
                            Addresses.Add(addr);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                MessageBox.Show("Record is Updating!.");
            }
            else
            {
                MessageBox.Show("the system is erroring!.");
                return;
            }
            CustomerFrom_Load(null, null);
        }


        void GetGender(char gender)
        {
            if (gender == 'F')
            {
                RdFemale.Checked = true;
            }
            else
            {
                RdMale.Checked = true;
            }
        }
        char SetGender()
        {
            char gender;
            if (RdFemale.Checked)
            {
                gender = 'F';
            }
            else
            {
                gender = 'M';
            }
            return gender;
        }
        public void loadData()
        {
            DataTable dt = new DataTable();
            dt = Customers.GetAll();
            bsCustomer = new BindingSource();
            dgCustomerName.DataSource = dt;
            bsCustomer.DataSource = dt;
        }

        private void CustomerFrom_Load(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.FromArgb(166, 187, 205);
            btnSave.Enabled = false;
            EnableControl(false);

            LoadData();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgCustomerName.SelectedRows[0].Cells[0].Value.ToString());
            Customers.Delete(id);
            CustomerFrom_Load(null, null);
        }

        private void DgCustomerName_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EnableControl(false);
            btnSave.Enabled = false;
            int id = int.Parse(dgCustomerName.SelectedRows[0].Cells[0].Value.ToString());
            Customer customer = Customers.Get(id);
            if (customer == null)
            {
                txtCustomerName.Text = customer.CustomerName;
                txtEmail.Text = customer.Email;
                txtPhone.Text = customer.Phone;
                txtPob.Text = customer.PoB;
                GetGender(customer.Sex);
                DtpDateOfBirth.Value = customer.DoB;

            }
            dtAddress = new DataTable();
            dtAddress = Addresses.Get(id);
            DgAddress.DataSource = dtAddress;

            DgAddress.RowHeadersVisible = false;
            DgAddress.Columns[0].DataPropertyName = "AddressId";
            DgAddress.Columns[0].Visible = false;
            DgAddress.Columns[1].DataPropertyName = "CustomerID";
            DgAddress.Columns[1].Visible = false;
            DgAddress.Columns[2].DataPropertyName = "AddressName";
            DgAddress.Columns[2].Visible = true;
            DgAddress.Columns[2].HeaderText = "Address";
            DgAddress.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void LoadData()
        {
            DataTable dt = new DataTable();
            dt = Customers.GetAll();
            bsCustomer = new BindingSource();
            dgCustomerName.DataSource = dt;
            bsCustomer.DataSource = dt;

            Setup();
        }
        void Setup()
        {
            dgCustomerName.ReadOnly = true;
            dgCustomerName.RowHeadersVisible = false;
            dgCustomerName.Columns[0].DataPropertyName = "CustomerID";
            dgCustomerName.Columns[0].Visible = false;
            dgCustomerName.Columns[1].DataPropertyName = "CustomerName";
            dgCustomerName.Columns[1].Visible = true;
            dgCustomerName.Columns[1].HeaderText = "Customer Name";
            dgCustomerName.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgCustomerName.Columns[2].DataPropertyName = "Sex";
            dgCustomerName.Columns[2].Visible = false;
            dgCustomerName.Columns[3].DataPropertyName = "DOB";
            dgCustomerName.Columns[3].Visible = false;
            dgCustomerName.Columns[4].DataPropertyName = "POB";
            dgCustomerName.Columns[4].Visible = false;
            dgCustomerName.Columns[5].DataPropertyName = "Phone";
            dgCustomerName.Columns[5].Visible = false;
            dgCustomerName.Columns[6].DataPropertyName = "Email";
            dgCustomerName.Columns[6].Visible = false;
            dgCustomerName.Columns[7].DataPropertyName = "ishidden";
            dgCustomerName.Columns[7].Visible = false;
        }
        void EnableControl(bool result)
        {
            txtCustomerName.Enabled = result;
            txtPob.Enabled = result;
            txtPhone.Enabled = result;
            txtEmail.Enabled = result;
            DtpDateOfBirth.Enabled = result;
            RdFemale.Enabled = result;
            RdFemale.Enabled = result;
            if (result == false)
            {
                ePCustomerName.Clear();
                ePPob.Clear();
                ePPhone.Clear();
                ePDateOfBirht.Clear();
                DgAddress.ReadOnly = true;
            }
            else
            {
                DgAddress.ReadOnly = false;
            }
        }
        void Clear()
        {
            EnableControl(true);
            if (score == 1)
            {
                txtCustomerName.Clear();
                txtPob.Clear();
                txtPhone.Clear();
                txtEmail.Clear();
                DtpDateOfBirth.Value = DateTime.Now.Date;
                RdFemale.Checked = false;
                RdMale.Checked = false;
            }
        }
        bool CheckValidate()
        {
            bool result = true;
            if (txtCustomerName.Text == "")
            {
                ePCustomerName.SetError(txtCustomerName, "please enter customer name");
            }
            else
            {
                ePCustomerName.Clear();
            }
            if (txtPob.Text == "")
            {
                ePPob.SetError(txtPob, "Please enter place of brith");

            }
            else
            {
                ePPob.Clear();
            }
            if (txtPhone.Text == "")
            {
                ePPhone.SetError(txtPhone, "please enter your phonenumber");
            }
            else
            {
                ePPhone.Clear();
            }
            if (txtEmail.Text == "")
            {
                ePEmail.SetError(txtEmail, "Please enter your email");
            }
            else
            {
                ePEmail.Clear();
            }
            if (DtpDateOfBirth.Value == DateTime.Now.Date)
            {
                ePDateOfBirht.SetError(DtpDateOfBirth, "please enter your date of birth");
            }
            else
            {
                ePDateOfBirht.Clear();
            }
            return result;
        }
    }
}
