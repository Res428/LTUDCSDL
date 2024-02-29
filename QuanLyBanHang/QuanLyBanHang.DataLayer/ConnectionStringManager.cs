using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DataLayer
{
    public class ConnectionStringManager
    {
        //đối tượng single ton
        private static ConnectionStringManager instance;
        //đối tượng quản lý chuỗi kết nối
        SqlConnectionStringBuilder _sqlConnectionStringBuilder;
        public SqlConnectionStringBuilder _SqlConnectionStringBuilder
        {
            get { return _sqlConnectionStringBuilder; }
            set { _sqlConnectionStringBuilder = value; }
        }
        public static ConnectionStringManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new ConnectionStringManager();
                return instance;
            }
        }
        private ConnectionStringManager()
        {
            _sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
        }
        //Đọc chuoi ket noi tu file ini (text)

        public void ReadConnectionString(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line = string.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        //server:118.69.126.49
                        line = line.Trim();
                        string[] strings = line.Split(new char[] { ':' });
                        switch (strings[0].ToLower().Trim())
                        {
                            case "server":
                                _sqlConnectionStringBuilder.DataSource = strings[1];
                                break;
                            case "database":
                                _sqlConnectionStringBuilder.InitialCatalog = strings[1];
                                break;
                            case "winnt":
                                _sqlConnectionStringBuilder.IntegratedSecurity = Convert.ToBoolean(strings[1]);
                                break;
                            case "uid":
                                _sqlConnectionStringBuilder.UserID = strings[1];
                                break;
                            case "pwd":
                                _sqlConnectionStringBuilder.Password = strings[1];
                                break;
                        }
                    }
                }
            }
        }

        //Ghi chuỗi kết nối vào file ini

        public void WriteConnectionString(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.CreateNew, FileAccess.Write, FileShare.Write))
            {
                using (StreamWriter sr = new StreamWriter(fs))
                {
                    sr.WriteLine(string.Format("server:{0}", _sqlConnectionStringBuilder.DataSource));
                    sr.WriteLine(string.Format("database:{0}", _sqlConnectionStringBuilder.InitialCatalog));
                    sr.WriteLine(string.Format("winnt:{0}", _sqlConnectionStringBuilder.IntegratedSecurity.ToString()));
                    sr.WriteLine(string.Format("uid:{0}", _sqlConnectionStringBuilder.UserID));
                    sr.WriteLine(string.Format("pwd:{0}", _sqlConnectionStringBuilder.Password));
                }
            }
        }
        public void WriteConnectionString(string path, SqlConnectionStringBuilder _sqlConnectionStringBuilder)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                using (StreamWriter sr = new StreamWriter(fs))
                {
                    sr.WriteLine(string.Format("server:{0}", _sqlConnectionStringBuilder.DataSource));
                    sr.WriteLine(string.Format("database:{0}", _sqlConnectionStringBuilder.InitialCatalog));
                    sr.WriteLine(string.Format("winnt:{0}", _sqlConnectionStringBuilder.IntegratedSecurity.ToString()));
                    sr.WriteLine(string.Format("uid:{0}", _sqlConnectionStringBuilder.UserID));
                    sr.WriteLine(string.Format("pwd:{0}", _sqlConnectionStringBuilder.Password));
                }
            }
        }
    }
}
