using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB_40_ThayPhuc.DTO
{
    public class KhachHang
    {
        string maKH, hoKH, tenKH, soDT;

        public string MaKH { get => maKH; set => maKH = value; }
        public string HoKH { get => hoKH; set => hoKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string SoDT { get => soDT; set => soDT = value; }
    }
}
