using QLTB_40_ThayPhuc.BusinessLayer;
using QLTB_40_ThayPhuc.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTB_40_ThayPhuc
{
    public partial class frm_KhachHang : Form
    {
        public frm_KhachHang()
        {
            InitializeComponent();
        }

        BLL_KhachHang bd;
        string err = string.Empty;

        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            bd = new BLL_KhachHang(ClsMain.path);
            HienThiKhachHang();
        }

        DataTable dtKhachHang;

        private void HienThiKhachHang()
        {
            dtKhachHang = new DataTable();
            dtKhachHang = bd.LayKhachHang(ref err, "0");
            dgvKH.DataSource = dtKhachHang.DefaultView;
        }

        private void tsbthem_Click(object sender, EventArgs e)
        {
            frm_KhachHang_Modifies frlm = new frm_KhachHang_Modifies();
            frlm.isThem = true;
            frlm.ShowDialog();
            HienThiKhachHang();
        }

        KhachHang khachHang;

        private void tsbsua_Click(object sender, EventArgs e)
        {
            if (khachHang != null)
            {
                frm_KhachHang_Modifies frlm = new frm_KhachHang_Modifies();
                frlm.isThem = false;
                frlm.khachHang = khachHang;
                frlm.ShowDialog();
                HienThiKhachHang();
                khachHang = null;
            }
            else
            {
                MessageBox.Show("chua chon lh");
            }
        }

        private void tsbxoa_Click(object sender, EventArgs e)
        {
            if(khachHang != null)
            {
                if (bd.XoaKhachHang(ref err, khachHang) > 0)
                {
                    MessageBox.Show("xoa thanh cong");
                    HienThiKhachHang();
                    khachHang = null;
                }
                else
                {
                    MessageBox.Show("xoa k thanh cong \n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("chua chon loai thiet bi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tsbthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvKH_Click(object sender, EventArgs e)
        {
            if (dgvKH.Rows.Count > 0)
            {
                khachHang = new KhachHang()
                {
                    MaKH = dgvKH.CurrentRow.Cells["colMaKH"].Value.ToString(),
                    HoKH = dgvKH.CurrentRow.Cells["colHoKH"].Value.ToString(),
                    TenKH = dgvKH.CurrentRow.Cells["colTenKH"].Value.ToString(),
                    SoDT = dgvKH.CurrentRow.Cells["colSoDT"].Value.ToString()
                };
            }
        }

        private void nap_Click(object sender, EventArgs e)
        {
            HienThiKhachHang();
        }
    }
}
