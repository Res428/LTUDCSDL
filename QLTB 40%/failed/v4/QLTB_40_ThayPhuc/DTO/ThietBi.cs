using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB_40_ThayPhuc.DTO
{
    public class ThietBi
    {
        string maTB, tenTB, loaiTB, sl, tinhTrang, currentUser;

        public string MaTB { get => maTB; set => maTB = value; }
        public string TenTB { get => tenTB; set => tenTB = value; }
        public string LoaiTB { get => loaiTB; set => loaiTB = value; }
        public string Sl { get => sl; set => sl = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public string CurrentUser { get => currentUser; set => currentUser = value; }
    }
}
