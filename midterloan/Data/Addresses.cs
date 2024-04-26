using midterloan.Entity;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace midterloan.Data
{
    public static class Addresses
    {
        public static void Add(Address address)
        {
            try
            {
                OracleCommand cmd = new OracleCommand("AddressAdd", Connection.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("AddressName", address.AddressName);
                cmd.Parameters.Add("CustomerId", address.CustomerId);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        public static void Delete(int id)
        {
            try
            {
                OracleCommand cmd = new OracleCommand("AddressDelete", Connection.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("CustomerId", id);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public static DataTable Get(int id)
        {
            OracleCommand cmd = new OracleCommand("AddressGet", Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("CustomerId", id);
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
           
        }
    }
}
