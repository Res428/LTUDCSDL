using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlbh.DTO
{
    public class PhieuNhap
    {
        string sTT, maPhieuNhap, ngayNhap, maNV, moTa, trangThai, tenSanPham, soLuongNhap, donGiaNhap, thanhTien, tenDonViTinh;

        public string TenDonViTinh
        {
            get { return tenDonViTinh; }
            set { tenDonViTinh = value; }
        }

        public string ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }

        public string DonGiaNhap
        {
            get { return donGiaNhap; }
            set { donGiaNhap = value; }
        }

        public string SoLuongNhap
        {
            get { return soLuongNhap; }
            set { soLuongNhap = value; }
        }

        public string TenSanPham
        {
            get { return tenSanPham; }
            set { tenSanPham = value; }
        }

        public string STT
        {
            get { return sTT; }
            set { sTT = value; }
        }

        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        public string MoTa
        {
            get { return moTa; }
            set { moTa = value; }
        }

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public string NgayNhap
        {
            get { return ngayNhap; }
            set { ngayNhap = value; }
        }

        public string MaPhieuNhap
        {
            get { return maPhieuNhap; }
            set { maPhieuNhap = value; }
        }

        //public string MaPhieuNhap { get => maPhieuNhap; set => maPhieuNhap = value; }
        //public string NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        //public string MaNV { get => maNV; set => maNV = value; }
        //public string MoTa { get => moTa; set => moTa = value; }
        //public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
