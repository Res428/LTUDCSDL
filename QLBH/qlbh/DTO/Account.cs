using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlbh.DTO
{
    public class Account
    {
        string maNV, hoTenNV, taiKhoan, groupID;

        public string GroupID
        {
            get { return groupID; }
            set { groupID = value; }
        }

        public string TaiKhoan
        {
            get { return taiKhoan; }
            set { taiKhoan = value; }
        }

        public string HoTenNV
        {
            get { return hoTenNV; }
            set { hoTenNV = value; }
        }

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }


    }
}
