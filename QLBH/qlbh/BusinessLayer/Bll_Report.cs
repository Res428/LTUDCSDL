using QuanLyBanHang.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlbh.BusinessLayer
{
    public class Bll_Report
    {
        
        MyDatabase db;
        public Bll_Report(string path)
        {
            db = new MyDatabase(path);
        }
        public DataTable LayDanhSanPham(ref string err)
        {
            return db.GetDataTable(ref err, "PSP_ThongKe_DanhSachSanPham", CommandType.StoredProcedure, null);
        }

        public DataTable LayDanhSachKhachHang(ref string err, string thanhPho)
        {
            return db.GetDataTable(ref err, "PSP_KhachHang_LayKhachHangTheoThanhPho", CommandType.StoredProcedure, new System.Data.SqlClient.SqlParameter("@ThanhPho", thanhPho));
        }

        public DataTable LayDuLieuComboKhachHang(ref string err)
        {
            return db.GetDataTable(ref err, "PSP_KhachHang_LayKhachHangVaoCombo", CommandType.StoredProcedure, null);

        }

        public DataTable LayDanhSachSanPhamDangBan(ref string err)
        {
            return db.GetDataTable(ref err, "PSP_240403_ThongKeSoLuongSanPham", CommandType.StoredProcedure, null);
        }

    }
}
