using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB_40_ThayPhuc.DTO
{
    public class account
    {
        string maQL, hoTenQL, email, matkhau, soDT;

        public string MaQL { get => maQL; set => maQL = value; }
        public string HoTenQL { get => hoTenQL; set => hoTenQL = value; }
        public string Email { get => email; set => email = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string SoDT { get => soDT; set => soDT = value; }
    }
}
