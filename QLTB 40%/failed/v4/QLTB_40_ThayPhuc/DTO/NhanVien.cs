using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB_40_ThayPhuc.DTO
{
    public class NhanVien
    {
        string maNV, hoTenNV, email, soDT;

        public string MaNV { get => maNV; set => maNV = value; }
        public string HoTenNV { get => hoTenNV; set => hoTenNV = value; }
        public string Email { get => email; set => email = value; }
        public string SoDT { get => soDT; set => soDT = value; }
    }
}
