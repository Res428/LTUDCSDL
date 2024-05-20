using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTB_40_ThayPhuc.DTO;
using QuanLyBanHang.DataLayer;
//using QLTB_40_ThayPhuc.DataLayer;

namespace QLTB_40_ThayPhuc.BusinessLayer
{
    public class BLL_KhachHang
    {
        MyDatabase db;

        public BLL_KhachHang(string path)
        {
            db = new MyDatabase(path);
        }

        public DataTable LayKhachHang(ref string err, string maKH)
        {
            return db.GetDataTable(ref err, "HSP_KhachHang_Select", CommandType.StoredProcedure, new SqlParameter("@MaKH", maKH));
        }


        public int CapNhatKhachHang(ref string err, KhachHang khachHang)
        {
            SqlParameter[] sq = new SqlParameter[]{
                 new SqlParameter("@MaKH",khachHang.MaKH),
                 new SqlParameter("@HoKH",khachHang.HoKH),
                 new SqlParameter("@TenKH",khachHang.TenKH),
                 new SqlParameter("@SoDT",khachHang.SoDT)
            };
            return db.MyExcuteNonQuery(ref err, "HSP_KhachHang_InsertAndUpdate", CommandType.StoredProcedure, sq);
        }
        public int XoaKhachHang(ref string err, KhachHang khachHang)
        {
            SqlParameter[] sq = new SqlParameter[]{
                new SqlParameter("@MaKH",khachHang.MaKH)
            };
            return db.MyExcuteNonQuery(ref err, "HSP_KhachHang_Delete", CommandType.StoredProcedure, sq);
        }

        // Phương thức thêm mã khách hàng vào database 
        public int ThemKhachHang(ref string err, string maKH)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaKH",maKH)
            };
            return db.MyExcuteNonQuery(ref err, "HSP_KhachHang_InsertAndUpdate", CommandType.StoredProcedure, sqlParameters);
        }


        public object SinhMaLonNhat(ref string err)
        {
            return db.MyExcuteScalar(ref err, "HSP_KhachHang_LayMaKH", CommandType.StoredProcedure, null);
        }
    }
}
