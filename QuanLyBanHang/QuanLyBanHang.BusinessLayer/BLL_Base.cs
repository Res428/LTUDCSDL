using QuanLyBanHang.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.BusinessLayer
{
    public class BLL_Base
    {
        protected MyDatabase _db;
        public BLL_Base() { }
        public BLL_Base(string path)
        {
            _db = new MyDatabase(path);
        }
    }
}
