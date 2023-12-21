using QLBH.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.BusinessLayer
{
    public class BLL_Base
    {
        protected Database _db;
        public BLL_Base() { }
        public BLL_Base(string path)
        {
            _db = new Database(path);
        }
    }
}
