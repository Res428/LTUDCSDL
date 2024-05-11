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
    public partial class Frm_NhapHang_Main : Frm_Base
    {
        public Frm_NhapHang_Main()
        {
            InitializeComponent();
        }
        BLL_NhapHang bLL_NhapHang;
        string err = string.Empty;

        private void Frm_NhapHang_Main_Load(object sender, EventArgs e)
        {
            ClsMain.DinhDangDGV(dgvPhieuNhap);
            bLL_NhapHang = new BLL_NhapHang(ClsMain.path);
            HienThiDSPhieuNhap();
        }

        DataTable dtNhapHang;
        private void HienThiDSPhieuNhap()
        {
            dtNhapHang = new DataTable();
            dtNhapHang = bLL_NhapHang.LayPhieuNhap(ref err, "0");
            dgvPhieuNhap.DataSource = dtNhapHang.DefaultView;

        }

        private void btnThemPhieu_Click(object sender, EventArgs e)
        {
            Frm_NhapHang_Modifies frm_NhapHang_Modidies=new Frm_NhapHang_Modifies();
            frm_NhapHang_Modidies.StartPosition = FormStartPosition.CenterScreen;
            frm_NhapHang_Modidies.ShowDialog();
        }

        PhieuNhap phieuNhap;
        private void dgvPhieuNhap_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.Rows.Count > 0)
            {
                phieuNhap = new PhieuNhap()
                {
                    MaPhieuNhap = dgvPhieuNhap.CurrentRow.Cells["colMaPhieuNhap"].Value.ToString(),
                    NgayNhap = dgvPhieuNhap.CurrentRow.Cells["colNgayNhap"].Value.ToString(),
                    MaNV = dgvPhieuNhap.CurrentRow.Cells["colMaNV"].Value.ToString(),
                    MoTa = dgvPhieuNhap.CurrentRow.Cells["colMoTa"].Value.ToString(),
                    TrangThai = dgvPhieuNhap.CurrentRow.Cells["colTrangThai"].Value.ToString()

                };
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            deDongtab();
        }

        private void LayDuLieuPhieuNhap(DateTime tuNgay, DateTime denNgay)
        {
            dtNhapHang = new DataTable();
            dtNhapHang = bLL_NhapHang.LayDuLieuPhieuNhap(ref err, tuNgay, denNgay);

            dgvPhieuNhap.DataSource = dtNhapHang.DefaultView;

            LayThuocTinhTrenLuoiToCombo();
        }

        private void LayThuocTinhTrenLuoiToCombo()
        {
            foreach (DataColumn item in dtNhapHang.Columns)
            {
                cboThuocTinh.Items.Add(item.ColumnName.ToString());
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dtNhapHang.DefaultView;
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                dv.RowFilter = string.Format("{0} like '{%1}'", cboThuocTinh.Text, txtSearch.Text);
            }
            else
	        {
                dv.RowFilter = "";
	        }
        }

        private void btnLayphieu_Click(object sender, EventArgs e)
        {

        }
    }
}
