namespace midterloan.From
{
    partial class CustomerFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            panel7 = new Panel();
            dgCustomerName = new DataGridView();
            panel6 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            btnDelete = new Button();
            label1 = new Label();
            btnNew = new Button();
            btnEdit = new Button();
            panel2 = new Panel();
            btnSave = new Button();
            label5 = new Label();
            DtpDateOfBirth = new DateTimePicker();
            txtPob = new TextBox();
            RdFemale = new RadioButton();
            RdMale = new RadioButton();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtCustomerName = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel8 = new Panel();
            DgAddress = new DataGridView();
            panel3 = new Panel();
            ePCustomerName = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            ePGender = new ErrorProvider(components);
            ePDateOfBirht = new ErrorProvider(components);
            ePPhone = new ErrorProvider(components);
            ePPob = new ErrorProvider(components);
            ePEmail = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgCustomerName).BeginInit();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgAddress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ePCustomerName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ePGender).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ePDateOfBirht).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ePPhone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ePPob).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ePEmail).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 688);
            panel1.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(173, 206, 235);
            panel7.Controls.Add(dgCustomerName);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 162);
            panel7.Name = "panel7";
            panel7.Size = new Size(384, 526);
            panel7.TabIndex = 3;
            // 
            // dgCustomerName
            // 
            dgCustomerName.BackgroundColor = Color.FromArgb(173, 206, 235);
            dgCustomerName.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCustomerName.Dock = DockStyle.Fill;
            dgCustomerName.Location = new Point(0, 0);
            dgCustomerName.Name = "dgCustomerName";
            dgCustomerName.RowHeadersWidth = 51;
            dgCustomerName.Size = new Size(384, 526);
            dgCustomerName.TabIndex = 1;
            dgCustomerName.CellContentClick += DgCustomerName_CellContentClick;
            // 
            // panel6
            // 
            panel6.Controls.Add(label2);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 117);
            panel6.Name = "panel6";
            panel6.Size = new Size(384, 45);
            panel6.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 0);
            label2.Name = "label2";
            label2.Size = new Size(216, 38);
            label2.TabIndex = 1;
            label2.Text = "Customer Name";
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(384, 117);
            panel4.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnDelete);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(btnNew);
            panel5.Controls.Add(btnEdit);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(384, 115);
            panel5.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(44, 117, 181);
            btnDelete.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(245, 65);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 37);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(222, 62);
            label1.TabIndex = 1;
            label1.Text = "Customer";
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.FromArgb(44, 117, 181);
            btnNew.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(3, 65);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(115, 37);
            btnNew.TabIndex = 1;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(44, 117, 181);
            btnEdit.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(124, 65);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(115, 37);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(DtpDateOfBirth);
            panel2.Controls.Add(txtPob);
            panel2.Controls.Add(RdFemale);
            panel2.Controls.Add(RdMale);
            panel2.Controls.Add(txtPhone);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtCustomerName);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(384, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1072, 688);
            panel2.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(933, 262);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 36);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 399);
            label5.Name = "label5";
            label5.Size = new Size(132, 46);
            label5.TabIndex = 16;
            label5.Text = "Address";
            // 
            // DtpDateOfBirth
            // 
            DtpDateOfBirth.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DtpDateOfBirth.Location = new Point(688, 84);
            DtpDateOfBirth.Name = "DtpDateOfBirth";
            DtpDateOfBirth.Size = new Size(355, 38);
            DtpDateOfBirth.TabIndex = 15;
            // 
            // txtPob
            // 
            txtPob.Location = new Point(688, 189);
            txtPob.Multiline = true;
            txtPob.Name = "txtPob";
            txtPob.Size = new Size(355, 34);
            txtPob.TabIndex = 14;
            // 
            // RdFemale
            // 
            RdFemale.AutoSize = true;
            RdFemale.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            RdFemale.Location = new Point(351, 129);
            RdFemale.Name = "RdFemale";
            RdFemale.Size = new Size(106, 35);
            RdFemale.TabIndex = 13;
            RdFemale.TabStop = true;
            RdFemale.Text = "Female";
            RdFemale.UseVisualStyleBackColor = true;
            // 
            // RdMale
            // 
            RdMale.AutoSize = true;
            RdMale.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            RdMale.Location = new Point(214, 129);
            RdMale.Name = "RdMale";
            RdMale.Size = new Size(83, 35);
            RdMale.TabIndex = 12;
            RdMale.TabStop = true;
            RdMale.Text = "Male";
            RdMale.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(214, 202);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(254, 34);
            txtPhone.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(214, 293);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(254, 34);
            txtEmail.TabIndex = 10;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(214, 77);
            txtCustomerName.Multiline = true;
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(254, 34);
            txtCustomerName.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic);
            label9.Location = new Point(544, 84);
            label9.Name = "label9";
            label9.Size = new Size(138, 31);
            label9.TabIndex = 8;
            label9.Text = "Date of Birth";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic);
            label8.Location = new Point(544, 198);
            label8.Name = "label8";
            label8.Size = new Size(57, 31);
            label8.TabIndex = 7;
            label8.Text = "POB";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic);
            label7.Location = new Point(15, 205);
            label7.Name = "label7";
            label7.Size = new Size(76, 31);
            label7.TabIndex = 6;
            label7.Text = "Phone";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic);
            label6.Location = new Point(15, 287);
            label6.Name = "label6";
            label6.Size = new Size(69, 31);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic);
            label4.Location = new Point(15, 129);
            label4.Name = "label4";
            label4.Size = new Size(85, 31);
            label4.TabIndex = 3;
            label4.Text = "Gender";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic);
            label3.Location = new Point(15, 71);
            label3.Name = "label3";
            label3.Size = new Size(175, 31);
            label3.TabIndex = 2;
            label3.Text = "Customer Name";
            // 
            // panel8
            // 
            panel8.Controls.Add(DgAddress);
            panel8.Dock = DockStyle.Bottom;
            panel8.Location = new Point(0, 458);
            panel8.Name = "panel8";
            panel8.Size = new Size(1072, 230);
            panel8.TabIndex = 1;
            // 
            // DgAddress
            // 
            DgAddress.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgAddress.Dock = DockStyle.Fill;
            DgAddress.Location = new Point(0, 0);
            DgAddress.Name = "DgAddress";
            DgAddress.RowHeadersWidth = 51;
            DgAddress.Size = new Size(1072, 230);
            DgAddress.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(44, 117, 181);
            panel3.Dock = DockStyle.Top;
            panel3.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1072, 56);
            panel3.TabIndex = 0;
            // 
            // ePCustomerName
            // 
            ePCustomerName.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // ePGender
            // 
            ePGender.ContainerControl = this;
            // 
            // ePDateOfBirht
            // 
            ePDateOfBirht.ContainerControl = this;
            // 
            // ePPhone
            // 
            ePPhone.ContainerControl = this;
            // 
            // ePPob
            // 
            ePPob.ContainerControl = this;
            // 
            // ePEmail
            // 
            ePEmail.ContainerControl = this;
            // 
            // CustomerFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1456, 688);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CustomerFrom";
            Text = "CustomerFrom";
            Load += CustomerFrom_Load;
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgCustomerName).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgAddress).EndInit();
            ((System.ComponentModel.ISupportInitialize)ePCustomerName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)ePGender).EndInit();
            ((System.ComponentModel.ISupportInitialize)ePDateOfBirht).EndInit();
            ((System.ComponentModel.ISupportInitialize)ePPhone).EndInit();
            ((System.ComponentModel.ISupportInitialize)ePPob).EndInit();
            ((System.ComponentModel.ISupportInitialize)ePEmail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Label label1;
        private Panel panel2;
        private Button btnNew;
        private Panel panel3;
        private Panel panel5;
        private Button btnDelete;
        private Button btnEdit;
        private Panel panel6;
        private Label label2;
        private Panel panel7;
        private DataGridView dgCustomerName;
        private Label label3;
        private Panel panel8;
        private DataGridView DgAddress;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtCustomerName;
        private RadioButton RdFemale;
        private RadioButton RdMale;
        private TextBox txtPob;
        private DateTimePicker DtpDateOfBirth;
        private Label label5;
        private Button btnSave;
        private ErrorProvider ePCustomerName;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider ePGender;
        private ErrorProvider ePDateOfBirht;
        private ErrorProvider ePPhone;
        private ErrorProvider ePPob;
        private ErrorProvider ePEmail;
    }
}