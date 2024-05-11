using qlbh.DTO;
using QuanLyBanHang.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlbh.BusinessLayer
{
    public class Bll_KhachHang
    {
        MyDatabase db;
        public Bll_KhachHang(string path)
        {
            db = new MyDatabase(path);
        }

        //lay dskh
        public DataTable LayKhachHangs(ref string err, string maKH)
        {
            return db.GetDataTable(ref err, "HSP_240305_KhachHang_Select", CommandType.StoredProcedure, new SqlParameter("@MaKH", maKH));
        }


        public int CapNhatKhachHang(ref string err, KhachHang khachHang)
        {
            SqlParameter[] sq = new SqlParameter[]{
                new SqlParameter("@MaKH",khachHang.MaKH),
                new SqlParameter("@HoKH",khachHang.HoKH),
                 new SqlParameter("@TenKh",khachHang.TenKh),
                  new SqlParameter("@DcKH",khachHang.DcKH),
                   new SqlParameter("@DtKH",khachHang.DtKH)
            };
            return db.MyExcuteNonQuery(ref err, "HSP_240305_KhachHang_InsertAndUpdate", CommandType.StoredProcedure, sq);
        }
        public int XoaKhachHang(ref string err, KhachHang khachHang)
        {
            SqlParameter[] sq = new SqlParameter[]{
                new SqlParameter("@MaKH",khachHang.MaKH)
            };
            return db.MyExcuteNonQuery(ref err, "HSP_240305_KhachHang_Delete", CommandType.StoredProcedure, sq);
        }
    }
}
