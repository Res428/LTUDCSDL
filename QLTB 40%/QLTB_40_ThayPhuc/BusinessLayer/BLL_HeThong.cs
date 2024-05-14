using QuanLyBanHang.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB_40_ThayPhuc.BusinessLayer
{
    public class BLL_HeThong
    {
        MyDatabase db;
        
        public BLL_HeThong(string path)
        {
            db = new MyDatabase(ClsMain.path);
        }

        public DataTable KiemTraDangNhap(ref string err, string taiKhoan, string matKhau)
        {
            SqlParameter[] sql = new SqlParameter[]
            {
                new SqlParameter("@TaiKhoan", taiKhoan),
                new SqlParameter("@MatKhau", matKhau)
            };

            return db.GetDataTable(ref err, "HSP_NhanVien_KiemTraDangNhap", CommandType.StoredProcedure, sql);
        }
       

        #region PhanQuyen

        public DataTable LayDanhSachQuyen(ref string err, string maNV)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaNV",maNV)
            };
            return db.GetDataTable(ref err, "PSP_PhanQuyen_Select", 
                CommandType.StoredProcedure, sqlParameters);
        }

        #endregion
        
    }
}
