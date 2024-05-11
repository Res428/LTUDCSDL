using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB_40_ThayPhuc.DTO
{
    public class LoaiThietBi
    {
        string maTB, tenTB, loaiTB;

        public string MaTB { get => maTB; set => maTB = value; }
        public string TenTB { get => tenTB; set => tenTB = value; }
        public string LoaiTB { get => loaiTB; set => loaiTB = value; }
    }
}
