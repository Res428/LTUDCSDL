using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace hau.chialop
{
    public class Database
    {
        private SqlConnection scn;
        private string connectionString = string.Empty;

        public Database(string connectionString)
        {
            scn = new SqlConnection(connectionString);
        }

        public bool checkconn(ref string err)
        {
            try
            {
                if (scn.State == ConnectionState.Open)
                {
                    scn.Close();
                }
                scn.Open();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
                throw;
            }
            finally
            {
                scn.Close();
            }
        }
    }
}
