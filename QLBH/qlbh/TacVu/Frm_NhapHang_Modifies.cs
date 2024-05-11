using qlbh.BusinessLayer;
using qlbh.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlbh.TacVu
{
    public partial class Frm_NhapHang_Modifies : Form
    {
        public Frm_NhapHang_Modifies()
        {
            InitializeComponent();
        }
        BLL_NhapHang bd;
        string err = string.Empty;
        string maPhieuNhap = string.Empty;

        private void Frm_NhapHang_Modifies_Load(object sender, EventArgs e)
        {
            bd = new BLL_NhapHang(ClsMain.path);
            maPhieuNhap = bd.KiemTraMaPhieuChuaHoanThanh(ref err, ClsMain.maNhanVien);
            if (maPhieuNhap.Equals("no"))
            {
                txtMaPhieuNhap.Text = bd.LayPhieuNhapLonNhat(ref err);
                ThemMaPhieuVaoData(txtMaPhieuNhap.Text);
            }
            else
            {
                //load lại phieu nhập cũ
                MessageBox.Show("Phieu nhap cu");
                HienThiDuLieuChiTietPhieuNhap(maPhieuNhap);
                txtMaPhieuNhap.Text = maPhieuNhap;
            }
            HienThiDuLieuNhapHang();

        }



        private void HienThiDuLieuNhapHang()
        {
            HienThiDuLieuLoaiSanPham();
            HienThiDuLieuDonViTinh();
            lblNhanVien.Text = ClsMain.tenNhanVien;
        }
        private void HienThiDuLieuSanPham(string maLoaiSanPham)
        {
            DataTable dtSanPham = new DataTable();
            dtSanPham = bd.LaySanPham(ref err, maLoaiSanPham);

            cboSanPham.DataSource = dtSanPham;
            cboSanPham.ValueMember = "MaSanPham";
            cboSanPham.DisplayMember = "TenSanPham";

            cboSanPham.SelectedIndex = -1;
            cboSanPham.Text = "-- Chọn sản phẩm --";

        }

        private void HienThiDuLieuDonViTinh()
        {
            DataTable dtDonViTinh = new DataTable();
            dtDonViTinh = bd.LayDonViTinh(ref err);

            cboDonViTinh.DataSource = dtDonViTinh;
            cboDonViTinh.ValueMember = "MaDonViTinh";
            cboDonViTinh.DisplayMember = "TenDonViTinh";

            cboDonViTinh.SelectedIndex = -1;
            cboDonViTinh.Text = "-- Chọn sản phẩm --";
        }
        bool statusLoadLoaiSanPham = false;
        private void HienThiDuLieuLoaiSanPham()
        {
            DataTable dtLoaiSanPham = new DataTable();
            dtLoaiSanPham = bd.LayLoaiSanPham(ref err);

            cboLoaiSanPham.DataSource = dtLoaiSanPham;
            cboLoaiSanPham.ValueMember = "MaLoaiSanPham";
            cboLoaiSanPham.DisplayMember = "TenLoaiSanPham";

            cboLoaiSanPham.SelectedIndex = -1;
            cboLoaiSanPham.Text = "-- Chọn loại sản phẩm --";
            statusLoadLoaiSanPham = true;
        }

        private void HienThiDuLieuChiTietPhieuNhap(string maPhieuNhap)
        {
            dtNhapHang = new DataTable();
            dtNhapHang = bd.LayChiTietPhieuNhap(ref err, "0");
            dgvChiTietPhieuNhap.DataSource = dtNhapHang.DefaultView;
        }

        private void ThemMaPhieuVaoData(string maPhieuNhap)
        {
            bd.ThemPhieuNhap(ref err, maPhieuNhap, ClsMain.maNhanVien);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaPhieuNhap.Text))
            {
                if (cboSanPham.SelectedIndex >= 0)
                {
                    //kiểm tra thêm vế sl, dongia, donvitinh.
                    if (bd.ThemChiTietPhieuNhap(ref err, txtMaPhieuNhap.Text, cboSanPham.SelectedValue.ToString(), txtSoLuongNhap.Text, txtDonGiaNhap.Text, cboDonViTinh.SelectedValue.ToString()) == 1)
                    {
                        MessageBox.Show("Them thanh coong");
                        HienThiDuLieuChiTietPhieuNhap(txtMaPhieuNhap.Text);
                    }
                }
                else
                {
                    MessageBox.Show("chua chon san pham");
                }
            }
            else
            {
                MessageBox.Show("Chưa có phiếu nhập.");
            }

        }

        private void btnHoanTatPhieuNhap_Click(object sender, EventArgs e)
        {
            if(bd.HoanTatPhieuNhap(ref err, maPhieuNhap) == 1)
             {
                 this.Close();
             }

        }

        private void txtMoTa_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaPhieuNhap.Text))
            {
                // Cập nhật mô tả vào phiếu nhập
                if (bd.CapNhatMoTaPhieuNhap(ref err, txtMaPhieuNhap.Text, txtMoTa.Text) == 1)
                {
                    MessageBox.Show("Cập nhật mô tả thành công.");
                }
                else
                {
                    MessageBox.Show("Cập nhật mô tả thất bại.");
                }
            }
            else
            {
                MessageBox.Show("Chưa có phiếu nhập.");
            }
        }

        DataTable dtNhapHang;
        private void HienThiDSPhieuNhap()
        {
            dtNhapHang = new DataTable();
            dtNhapHang = bd.LayChiTietPhieuNhap(ref err, "0");
            dgvChiTietPhieuNhap.DataSource = dtNhapHang.DefaultView;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaPhieuNhap.Text))
            {
                string maPhieuNhap = txtMaPhieuNhap.Text;

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy phiếu nhập này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string err = string.Empty;
                    BLL_NhapHang bllNhapHang = new BLL_NhapHang(ClsMain.path);
                    int rowsAffected = bllNhapHang.HuyPhieuNhap(ref err, maPhieuNhap);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Hủy phiếu nhập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Thực hiện các tác vụ khác sau khi hủy phiếu nhập thành công.
                    }
                    else
                    {
                        MessageBox.Show("Hủy phiếu nhập thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã phiếu nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        PhieuNhap phieuNhap;

        private void btnDel_Click(object sender, EventArgs e)
        {
            //if (dgvChiTietPhieuNhap.SelectedRows.Count > 0)
            //{
            //    string maPhieuNhap = dgvChiTietPhieuNhap.SelectedRows[0].Cells["colMaPhieuNhap"].Value.ToString();

            //    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này khỏi phiếu nhập?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (result == DialogResult.Yes)
            //    {
            //        // Thực hiện xóa sản phẩm khỏi phiếu nhập
            //        // Code xử lý xóa sản phẩm ở đây

            //        MessageBox.Show("Xóa sản phẩm khỏi phiếu nhập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        HienThiDSPhieuNhap();
            //    }
            //}
            if (phieuNhap != null)
            {
                if (bd.XoaPhieuNhap(ref err, phieuNhap) > 0)
                {
                    MessageBox.Show("xoa thanh cong");
                    HienThiDSPhieuNhap();
                    phieuNhap = null;
                }
                else
                {
                    MessageBox.Show("xoa k thanh cong \n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("chua chon khach hang", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cboLoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiSanPham.SelectedIndex >= 0 && statusLoadLoaiSanPham)
            {
                HienThiDuLieuSanPham(cboLoaiSanPham.SelectedValue.ToString());
            }
        }

        private void dgvChiTietPhieuNhap_Click(object sender, EventArgs e)
        {
            if (dgvChiTietPhieuNhap.Rows.Count > 0)
            {
                phieuNhap = new PhieuNhap()
                {
                    STT = dgvChiTietPhieuNhap.CurrentRow.Cells["colSTT"].Value.ToString(),
                    TenSanPham = dgvChiTietPhieuNhap.CurrentRow.Cells["colMaPhieuNhap"].Value.ToString(),
                    SoLuongNhap = dgvChiTietPhieuNhap.CurrentRow.Cells["colSoLuongNhap"].Value.ToString(),
                    DonGiaNhap = dgvChiTietPhieuNhap.CurrentRow.Cells["colDonGiaNhap"].Value.ToString(),
                    ThanhTien = dgvChiTietPhieuNhap.CurrentRow.Cells["colThanhTien"].Value.ToString(),
                    TenDonViTinh = dgvChiTietPhieuNhap.CurrentRow.Cells["colTenDonViTinh"].Value.ToString()

                };
            }
        }
    }
}
