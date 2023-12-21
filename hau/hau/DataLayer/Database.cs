using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class Database
    {
        private SqlConnection scn;
        private SqlCommand scm;

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

        //phuong thuc lay data (select)
        public SqlDataReader GetDataReader(ref string err, string cmdtext, CommandType cmtype)
        {
            SqlDataReader result = null;
            try
            {
                //1. Mo ket noi
                if (scn.State == ConnectionState.Open)
                {
                    scn.Close();
                }
                scn.Open();

                //2. khai bao sqlcommand
                scm = new SqlCommand(cmdtext, scn);
                scm.CommandType = cmtype;
                scm.CommandTimeout = 3600;

                //3. thuc thi command
                result = scm.ExecuteReader();
            }
            catch (Exception ex)
            {
                err = ex.Message;
                throw;
            }
            return result;
        }
    }
}
