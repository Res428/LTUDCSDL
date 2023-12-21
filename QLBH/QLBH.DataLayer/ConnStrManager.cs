using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace QLBH.DataLayer
{
    //single ton
    public class ConnStrManager
    {
        //doi tuong single ton
        private static ConnStrManager instance;

        //doi tuong quan ly chuoi ket noi
        SqlConnectionStringBuilder scsb;

        public SqlConnectionStringBuilder _scsb
        {
            get { return _scsb;  }
            set { _scsb = value; }
        }

        public static ConnStrManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ConnStrManager();
                }
                return instance;
            }
        }

        private ConnStrManager()
        {
            scsb = new SqlConnectionStringBuilder();
        }

        //doc chuoi ket noi tu file ini(text)
        public void ReadConnStr(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line = string.Empty;
                    while ((line = sr.ReadLine()) != null)
	                {
                        line = line.Trim();
                        string[] strings = line.Split(new char[] { ':' });
                        switch (strings[0].ToLower().Trim())
                        {
                            case "server":
                                scsb.DataSource = strings[1];
                                break;
                            case "database":
                                scsb.InitialCatalog = strings[1];//database
                                break;
                            case "uid":
                                scsb.UserID = strings[1];//user name
                                break;
                            case "pwd":
                                scsb.Password = strings[1];//password
                                break;
                            case "winnt":
                                scsb.IntegratedSecurity = Convert.ToBoolean(strings[1]);//winnt
                                break;

                        }
	                }
                }
            }
        }

        //ghi chuoi ket noi vao file ini
        public void WriteConnStr(string path, SqlConnectionStringBuilder scsb)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(string.Format("server={0}", scsb.DataSource));
                    sw.WriteLine(string.Format("database={0}", scsb.InitialCatalog));
                    sw.WriteLine(string.Format("uid={0}", scsb.UserID));
                    sw.WriteLine(string.Format("pwd={0}", scsb.Password));
                    sw.WriteLine(string.Format("winnt={0}", scsb.IntegratedSecurity.ToString()));

                }
            }
        }

    }
}
