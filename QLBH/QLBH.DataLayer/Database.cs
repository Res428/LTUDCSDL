using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.DataLayer
{
    public class Database
    {
        //doi tuong ado
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;

        public Database(string path)
        {
            ConnStrManager.Instance.ReadConnStr(path);
            conn = new SqlConnection(ConnStrManager.Instance._scsb.ConnectionString);
        }

        public bool checkconnect(ref string err)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
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
                conn.Close();
            }
        }

        //insert, update, delete
        public int MyExcuteNonQuery(ref string err, string cmdtext, CommandType cmtype, params SqlParameter[] sqlParameters)
        {
            int result = 0;
            try
            {
                //1. Mo ket noi
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();

                //2. khai bao sqlcommand
                cmd = new SqlCommand(cmdtext, conn);
                cmd.CommandType = cmtype;
                cmd.CommandTimeout = 600;

                if (sqlParameters != null)
                {
                    foreach (SqlParameter param in sqlParameters)
                    {
                        cmd.Parameters.Add(param);
                    }
                }
                //3. thuc thi command
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                err = ex.Message;
                throw;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        //scalar
        public object MyExcuteScalar(ref string err, string cmdtext, CommandType cmtype, params SqlParameter[] sqlParameters)
        {
            object result = 0;
            try
            {
                //1. Mo ket noi
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();

                //2. khai bao sqlcommand
                cmd = new SqlCommand(cmdtext, conn);
                cmd.CommandType = cmtype;
                cmd.CommandTimeout = 600;

                if (sqlParameters != null)
                {
                    foreach (SqlParameter param in sqlParameters)
                    {
                        cmd.Parameters.Add(param);
                    }
                }
                //3. thuc thi command
                result = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                err = ex.Message;
                throw;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        //data
        public SqlDataReader MyExcuteReader(ref string err, string cmdtext, CommandType cmtype, params SqlParameter[] sqlParameters)
        {
            SqlDataReader result = null;
            try
            {
                //1. Mo ket noi
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();

                //2. khai bao sqlcommand
                cmd = new SqlCommand(cmdtext, conn);
                cmd.CommandType = cmtype;
                cmd.CommandTimeout = 600;

                if (sqlParameters != null)
                {
                    foreach (SqlParameter param in sqlParameters)
                    {
                        cmd.Parameters.Add(param);
                    }
                }
                //3. thuc thi command
                result = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                err = ex.Message;
                throw;
            }
            return result;
        }

        //datatable
        public DataTable MyExcuteDataTable(ref string err, string cmdtext, CommandType cmtype, params SqlParameter[] sqlParameters)
        {
            DataTable result = null;
            try
            {
                //1. Mo ket noi
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();

                //2. khai bao sqlcommand
                cmd = new SqlCommand(cmdtext, conn);
                cmd.CommandType = cmtype;
                cmd.CommandTimeout = 600;

                if (sqlParameters != null)
                {
                    foreach (SqlParameter param in sqlParameters)
                    {
                        cmd.Parameters.Add(param);
                    }
                }
                //3. thuc thi command
                result = new DataTable();
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(result);
            }
            catch (Exception ex)
            {
                err = ex.Message;
                throw;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
    }
}
