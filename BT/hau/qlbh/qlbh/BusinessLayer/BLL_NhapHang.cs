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
    public class BLL_NhapHang
    {
        MyDatabase db;
        public BLL_NhapHang(string path)
        {
            db = new MyDatabase(path);
        }

        // Phương thức Lấy mã phiếu lớn nhất
        public string LayPhieuNhapLonNhat(ref string err)
        {
            return db.MyExcuteScalar(ref err, "PSP_PhieuNhap_LayMaxID", CommandType.StoredProcedure, null).ToString();
        }

        // Phương thức thêm mã phiếu nhập và database 
        public int ThemPhieuNhap(ref string err, string maPhieuNhap, string maNhanVien)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaPhieuNhap",maPhieuNhap),
                new SqlParameter("@MaNV",maNhanVien)
            };
            return db.MyExcuteNonQuery(ref err, "PSP_PhieuNhap_Insert", CommandType.StoredProcedure, sqlParameters);
        }

        // Phương thức kiểm tra mã phiếu chưa hoàn thành theo Mã nhân viên
        public string KiemTraMaPhieuChuaHoanThanh(ref string err, string maNhanVien)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaNhanVien",maNhanVien)
            };
            return db.MyExcuteScalar(ref err, "PSP_PhieuNhap_KiemTraPhieuTonTaiTheoUser", CommandType.StoredProcedure, sqlParameters).ToString();
        }


        public DataTable LayLoaiSanPham(ref string err)
        {
            return db.GetDataTable(ref err, "PSP_LoaiSanPham_SelecToComboBox", CommandType.StoredProcedure, null);
        }

        public DataTable LayDonViTinh(ref string err)
        {
            return db.GetDataTable(ref err, "PSP_DonViTinh_SelectToComboBox", CommandType.StoredProcedure, null);
        }

        public DataTable LaySanPham(ref string err, string maLoaiSanPham)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
        {
            new SqlParameter("@MaLoaiSanPham",maLoaiSanPham)
        };

            return db.GetDataTable(ref err, "PSP_SanPham_SelectToComboBox", CommandType.StoredProcedure, sqlParameters);
        }

        public int ThemChiTietPhieuNhap(ref string err, string maPhieuNhap, string maSanPham, string soLuongNhap, string donGiaNhap, string donViTinh)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaPhieuNhap",maPhieuNhap),
                new SqlParameter("@MaSanPham",maSanPham),
                new SqlParameter("@SoLuongNhap",soLuongNhap),
                new SqlParameter("@DonGiaNhap",donGiaNhap),
                new SqlParameter("@DonViTinh",donViTinh)
            };
            return db.MyExcuteNonQuery(ref err, "PSP_ChiTietPhieuNhap_InsertAndUpdate", CommandType.StoredProcedure, sqlParameters);
        }

        public DataTable LayChiTietPhieuNhap(ref string err, string maPhieuNhap)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
         {
             new SqlParameter("@MaPhieuNhap",maPhieuNhap)
         };
            return db.GetDataTable(ref err, "PSP_ChiTietPhieuNhap_Select", CommandType.StoredProcedure, sqlParameters);
        }

        public int HoanTatPhieuNhap(ref string err, string maPhieuNhap)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaPhieuNhap",maPhieuNhap)
            };

            return db.MyExcuteNonQuery(ref err, "PSP_PhieuNhap_HoanTatPhieuNhap", CommandType.StoredProcedure, sqlParameters);
        }
        public int CapNhatMoTaPhieuNhap(ref string err, string maPhieuNhap, string moTa)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaPhieuNhap", maPhieuNhap),
                new SqlParameter("@MoTa", moTa)
            };

            return db.MyExcuteNonQuery(ref err, "PSP_PhieuNhap_CapNhatMoTa", CommandType.StoredProcedure, sqlParameters);
        }

        public DataTable LayPhieuNhap(ref string err, string maPhieuNhap)
        {
            return db.GetDataTable(ref err, "HSP_PhieuNhap_Select", CommandType.StoredProcedure, new SqlParameter("@MaPhieuNhap", maPhieuNhap));
        }

        public int HuyPhieuNhap(ref string err, string maPhieuNhap)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaPhieuNhap",maPhieuNhap)
            };
            return db.MyExcuteNonQuery(ref err, "HSP_PhieuNhap_HuyPhieuNhap", CommandType.StoredProcedure, sqlParameters);
        }

        public int XoaPhieuNhap(ref string err, PhieuNhap phieuNhap)
        {
            SqlParameter[] sq = new SqlParameter[]{
                new SqlParameter("@MaPhieuNhap",phieuNhap.MaPhieuNhap)
            };
            return db.MyExcuteNonQuery(ref err, "HSP_PhieuNhap_Delete", CommandType.StoredProcedure, sq);
        }

        internal DataTable LayDuLieuPhieuNhap(ref string err, DateTime tuNgay, DateTime denNgay)
        {
            throw new NotImplementedException();
        }
    }
}
