using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DataLayer
{
    public class MyDatabase
    {
        //Đối tượng Ado
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;

        public MyDatabase(string path)
        {
            ConnectionStringManager.Instance.ReadConnectionString(path);

            conn = new SqlConnection(ConnectionStringManager.Instance._SqlConnectionStringBuilder.ConnectionString);
        }
        public bool CheckConnect(ref string err)
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
            }
            finally
            {
                conn.Close();
            }
        }

        //insert, update, delete
        public int MyExcuteNonQuery(ref string err, string commandText, CommandType commandType, params SqlParameter[] sqlParameters)
        {
            int result = 0;
            try
            {
                //1. step 1 Open connect
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();

                //2. Init Command
                cmd = new SqlCommand(commandText, conn);
                cmd.CommandType = commandType;
                cmd.CommandTimeout = 600;
                if (sqlParameters != null)
                {
                    foreach (SqlParameter param in sqlParameters)
                    {
                        cmd.Parameters.Add(param);
                    }
                }
                //3. Excute Command
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            finally { conn.Close(); }
            return result;
        }

        //Scalar
        public object MyExcuteScalar(ref string err, string commandText, CommandType commandType, params SqlParameter[] sqlParameters)
        {
            object result = null;
            try
            {
                //1. step 1 Open connect
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();

                //2. Init Command
                cmd = new SqlCommand(commandText, conn);
                cmd.CommandType = commandType;
                cmd.CommandTimeout = 600;
                if (sqlParameters != null)
                {
                    foreach (SqlParameter param in sqlParameters)
                    {
                        cmd.Parameters.Add(param);
                    }
                }
                //3. Excute Command
                result = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            finally { conn.Close(); }
            return result;
        }
        //SqlDataReader
        public SqlDataReader MyExcuteReader(ref string err, string commandText, CommandType commandType, params SqlParameter[] sqlParameters)
        {
            SqlDataReader result = null;
            try
            {
                //1. step 1 Open connect
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();

                //2. Init Command
                cmd = new SqlCommand(commandText, conn);
                cmd.CommandType = commandType;
                cmd.CommandTimeout = 600;
                if (sqlParameters != null)
                {
                    foreach (SqlParameter param in sqlParameters)
                    {
                        cmd.Parameters.Add(param);
                    }
                }
                //3. Excute Command
                result = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }

            return result;
        }

        //DataTable
        public DataTable GetDataTable(ref string err, string commandText, CommandType commandType, params SqlParameter[] sqlParameters)
        {
            DataTable result = null;
            try
            {
                //1. step 1 Open connect
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();

                //2. Init Command
                cmd = new SqlCommand(commandText, conn);
                cmd.CommandType = commandType;
                cmd.CommandTimeout = 600;
                if (sqlParameters != null)
                {
                    foreach (SqlParameter param in sqlParameters)
                    {
                        cmd.Parameters.Add(param);
                    }
                }
                //3. Excute Command
                result = new DataTable();
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(result);
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            finally { conn.Close(); }
            return result;
        }
    }
}
