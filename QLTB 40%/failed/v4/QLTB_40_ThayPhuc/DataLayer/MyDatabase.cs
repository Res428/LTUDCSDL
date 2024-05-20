#region Assembly QuanLyBanHang.DataLayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\STUDY\LTUDCSDL\LTUDCSDL\BT\hau\qlbh\qlbh\bin\Debug\QuanLyBanHang.DataLayer.dll
// Decompiled with ICSharpCode.Decompiler 8.1.1.7464
#endregion

using QuanLyBanHang.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB_40_ThayPhuc.DataLayer
{
    public class MyDatabase
    {
        private SqlConnection conn;

        private SqlCommand cmd;

        private SqlDataAdapter adapter;

        private ConnectionStringManager connectionStringManager;

        private string err = string.Empty;

        public MyDatabase(string path)
        {
            connectionStringManager = new ConnectionStringManager();
            conn = new SqlConnection(connectionStringManager.ReadConnectionString(ref err, path).ConnectionString);
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

        public int MyExcuteNonQuery(ref string err, string commandText, CommandType commandType, params SqlParameter[] sqlParameters)
        {
            int result = 0;
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                conn.Open();
                cmd = new SqlCommand(commandText, conn);
                cmd.CommandType = commandType;
                cmd.CommandTimeout = 600;
                if (sqlParameters != null)
                {
                    foreach (SqlParameter value in sqlParameters)
                    {
                        cmd.Parameters.Add(value);
                    }
                }

                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }

        public object MyExcuteScalar(ref string err, string commandText, CommandType commandType, params SqlParameter[] sqlParameters)
        {
            object result = null;
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                conn.Open();
                cmd = new SqlCommand(commandText, conn);
                cmd.CommandType = commandType;
                cmd.CommandTimeout = 600;
                if (sqlParameters != null)
                {
                    foreach (SqlParameter value in sqlParameters)
                    {
                        cmd.Parameters.Add(value);
                    }
                }

                result = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }

        public SqlDataReader MyExcuteReader(ref string err, string commandText, CommandType commandType, params SqlParameter[] sqlParameters)
        {
            SqlDataReader result = null;
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                conn.Open();
                cmd = new SqlCommand(commandText, conn);
                cmd.CommandType = commandType;
                cmd.CommandTimeout = 600;
                if (sqlParameters != null)
                {
                    foreach (SqlParameter value in sqlParameters)
                    {
                        cmd.Parameters.Add(value);
                    }
                }

                result = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }

            return result;
        }

        public DataTable GetDataTable(ref string err, string commandText, CommandType commandType, params SqlParameter[] sqlParameters)
        {
            DataTable dataTable = null;
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                conn.Open();
                cmd = new SqlCommand(commandText, conn);
                cmd.CommandType = commandType;
                cmd.CommandTimeout = 600;
                if (sqlParameters != null)
                {
                    foreach (SqlParameter value in sqlParameters)
                    {
                        cmd.Parameters.Add(value);
                    }
                }

                dataTable = new DataTable();
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return dataTable;
        }
    }


}
#if false // Decompilation log
'17' items in cache
------------------
Resolve: 'mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Load from: 'C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.8\mscorlib.dll'
------------------
Resolve: 'System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Load from: 'C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.8\System.Data.dll'
#endif