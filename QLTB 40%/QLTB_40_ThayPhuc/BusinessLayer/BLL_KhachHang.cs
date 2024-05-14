using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTB_40_ThayPhuc.DTO;
using QuanLyBanHang.DataLayer;

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
                 new SqlParameter("@TenKH",khachHang.TenKH)
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
    }
}
