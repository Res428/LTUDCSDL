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
    public partial class frm_LoaiHang : Form
    {
        public frm_LoaiHang()
        {
            InitializeComponent();
        }

        Bll_LoaiHang bd;
        string err = string.Empty;

        DataTable dtLoaiHangs;

        private void frm_LoaiHang_Load(object sender, EventArgs e)
        {
            bd = new Bll_LoaiHang(ClsMain.path);
            HienThiLoaiHangs();
        }

        private void HienThiLoaiHangs()
        {
            dtLoaiHangs = new DataTable();
            dtLoaiHangs = bd.LayLoaiHangs(ref err, "0");
            dgvLoaiHangs.DataSource = dtLoaiHangs.DefaultView;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frm_LoaiHang_Modifies frlm = new frm_LoaiHang_Modifies();
            frlm.isThem = true;
            frlm.ShowDialog();
            HienThiLoaiHangs();
        }
        LoaiHang loaiHang;
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (loaiHang != null)
            {
                frm_LoaiHang_Modifies frlm = new frm_LoaiHang_Modifies();
                frlm.isThem = false;
                frlm.loaiHang = loaiHang;
                frlm.ShowDialog();
                HienThiLoaiHangs();
                loaiHang = null;
            }
            else
            {
                MessageBox.Show("chua chon lh");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (loaiHang != null)
            {
                if (bd.XoaLoaiHang(ref err, loaiHang) > 0)
                {
                    MessageBox.Show("xoa thanh cong");
                    HienThiLoaiHangs();
                    loaiHang = null;
                }
                else
                {
                    MessageBox.Show("xoa k thanh cong \n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("chua chon loai hang", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvLoaiHangs_Click(object sender, EventArgs e)
        {
            if (dgvLoaiHangs.Rows.Count > 0)
            {
                loaiHang = new LoaiHang()
                {
                    MaLH = dgvLoaiHangs.CurrentRow.Cells["colMaLH"].Value.ToString(),
                    TenLH = dgvLoaiHangs.CurrentRow.Cells["colTenLH"].Value.ToString()

                };
            }
        }

        

    }
}
