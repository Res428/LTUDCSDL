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
    public partial class frm_loaithietbi : Form
    {
        public frm_loaithietbi()
        {
            InitializeComponent();
        }

        BLL_LoaiThietBi bd;
        string err = string.Empty;

        private void frm_loaithietbi_Load(object sender, EventArgs e)
        {
            bd = new BLL_LoaiThietBi(ClsMain.path);
            HienThiLoaiTB();
        }

        DataTable dtLoaiTB;

        private void HienThiLoaiTB()
        {
            dtLoaiTB = new DataTable();
            dtLoaiTB = bd.LayLoaiTB(ref err, "0");
            dgvLoaiTB.DataSource = dtLoaiTB.DefaultView;
        }

        private void tsbthem_Click(object sender, EventArgs e)
        {
            frm_loaithietbi_Modifies frlm = new frm_loaithietbi_Modifies();
            frlm.isThem = true;
            frlm.ShowDialog();
            HienThiLoaiTB();
        }

        LoaiThietBi loaithietBi;

        private void tsbsua_Click(object sender, EventArgs e)
        {
            if (loaithietBi != null)
            {
                frm_loaithietbi_Modifies frlm = new frm_loaithietbi_Modifies();
                frlm.isThem = false;
                frlm.loaiThietBi = loaithietBi;
                frlm.ShowDialog();
                HienThiLoaiTB();
                loaithietBi = null;
            }
            else
            {
                MessageBox.Show("chua chon lh");
            }
        }

        private void tsbxoa_Click(object sender, EventArgs e)
        {
            if(loaithietBi != null)
            {
                if (bd.XoaLoaiTB(ref err, loaithietBi) > 0)
                {
                    MessageBox.Show("xoa thanh cong");
                    HienThiLoaiTB();
                    loaithietBi = null;
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

        private void dgvLoaiTB_Click(object sender, EventArgs e)
        {
            if (dgvLoaiTB.Rows.Count > 0)
            {
                loaithietBi = new LoaiThietBi()
                {
                    MaTB = dgvLoaiTB.CurrentRow.Cells["colMaTB"].Value.ToString(),
                    TenTB = dgvLoaiTB.CurrentRow.Cells["colTenTB"].Value.ToString()
                };
            }
        }
    }
}
