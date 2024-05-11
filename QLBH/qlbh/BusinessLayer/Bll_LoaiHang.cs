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
    public class Bll_LoaiHang
    {
        MyDatabase db;
        public Bll_LoaiHang(string path)
        {
            db = new MyDatabase(path);
        }
        public DataTable LayLoaiHangs(ref string err, string maLH)
        {
            return db.GetDataTable(ref err, "HSP_240306_LoaiHang_Select", CommandType.StoredProcedure, new SqlParameter("@MaLH", maLH));
        }


        public int CapNhatLoaiHang(ref string err, LoaiHang loaiHang)
        {
            SqlParameter[] sq = new SqlParameter[]{
                new SqlParameter("@MaLH",loaiHang.MaLH),
                 new SqlParameter("@TenLH",loaiHang.TenLH)
            };
            return db.MyExcuteNonQuery(ref err, "HSP_240306_LoaiHang_InsertAndUpdate", CommandType.StoredProcedure, sq);
        }
        public int XoaLoaiHang(ref string err, LoaiHang loaiHang)
        {
            SqlParameter[] sq = new SqlParameter[]{
                new SqlParameter("@MaLH",loaiHang.MaLH)
            };
            return db.MyExcuteNonQuery(ref err, "HSP_240306_LoaiHang_Delete", CommandType.StoredProcedure, sq);
        }
    }
}
