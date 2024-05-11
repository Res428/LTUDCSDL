using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlbh.DTO
{
    public class KhachHang
    {
        string maKH, hoKH, tenKh, dcKH, dtKH;

        public string DcKH
        {
            get { return dcKH; }
            set { dcKH = value; }
        }

        public string DtKH
        {
            get { return dtKH; }
            set { dtKH = value; }
        }

        public string TenKh
        {
            get { return tenKh; }
            set { tenKh = value; }
        }

        public string HoKH
        {
            get { return hoKH; }
            set { hoKH = value; }
        }

        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }

    }
}
