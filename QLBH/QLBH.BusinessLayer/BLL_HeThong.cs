using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using QLBH.DataLayer;

namespace QLBH.BusinessLayer
{
    public class BLL_HeThong : BLL_Base
    {
        Database _db;
        public BLL_HeThong()
        {

        }

        public BLL_HeThong(string path) : base (path)
        {
            _db = new Database(path);
        }

        //public DataTable GetUser(ref string err)
        //{
        //    return ;
        //}

        public bool checkconn(ref string err)
        {
            return _db.checkconnect(ref err);
        }

        public SqlConnectionStringBuilder ReadConnStr(string path)
        {
            SqlConnectionStringBuilder result = null;
            ConnStrManager.Instance.ReadConnStr(path);
            result = ConnStrManager.Instance._scsb;
            return result;
        }

        public void WriteConnStr(string path, SqlConnectionStringBuilder scsb)
        {
            ConnStrManager.Instance.WriteConnStr(path, scsb);
        }
    }
}
