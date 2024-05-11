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

namespace qlbh
{
    public partial class frm_QuanLyKhachHang_Main : Frm_Base
    {
        public frm_QuanLyKhachHang_Main()
        {
            InitializeComponent();
        }
        Bll_KhachHang bll_KhachHang;
        string err = string.Empty;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void frm_QuanLyKhachHang_Main_Load_1(object sender, EventArgs e)
        {
            bll_KhachHang = new Bll_KhachHang(ClsMain.path);
            HienThiKhachHangs();
        }

        DataTable dtKhachHangs;
        private void HienThiKhachHangs()
        {
            dtKhachHangs = new DataTable();
            dtKhachHangs = bll_KhachHang.LayKhachHangs(ref err, "0");
            dgvKhachHangs.DataSource = dtKhachHangs.DefaultView;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ClsMain.CheckQuyen(this, QUYEN.THEM))
            {
                frmModifies frmM = new frmModifies();
                frmM.isThem = true;
                frmM.ShowDialog();
                HienThiKhachHangs();
                
            }else
	        {
                MessageBox.Show("Khong co quyen");
	        }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (khachHang != null)
            {
                frmModifies frmM = new frmModifies();
                frmM.isThem = false;
                frmM.khachHang = khachHang;
                frmM.ShowDialog();
                HienThiKhachHangs();
                khachHang = null;
            }
            else
            {
                MessageBox.Show("chua chon kh");
            }
        }
        KhachHang khachHang;
        private void dgvKhachHangs_Click(object sender, EventArgs e)
        {
            if (dgvKhachHangs.Rows.Count > 0)
            {
                khachHang = new KhachHang()
                {
                    MaKH = dgvKhachHangs.CurrentRow.Cells["colMaKH"].Value.ToString(),
                    HoKH = dgvKhachHangs.CurrentRow.Cells["colHoKH"].Value.ToString(),
                    TenKh = dgvKhachHangs.CurrentRow.Cells["colTenKH"].Value.ToString(),
                    DcKH = dgvKhachHangs.CurrentRow.Cells["colDcKH"].Value.ToString(),
                    DtKH = dgvKhachHangs.CurrentRow.Cells["colDtKH"].Value.ToString()

                };
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (khachHang != null)
            {
                if (bll_KhachHang.XoaKhachHang(ref err, khachHang) > 0)
                {
                    MessageBox.Show("xoa thanh cong");
                    HienThiKhachHangs();
                    khachHang = null;
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            deDongtab();
        }
    }
}
