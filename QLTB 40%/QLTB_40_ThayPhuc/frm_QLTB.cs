using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTB_40_ThayPhuc.BusinessLayer;
using QLTB_40_ThayPhuc.DTO;

namespace QLTB_40_ThayPhuc
{
    public partial class frm_QLTB : Frm_Base
    {
        public frm_QLTB()
        {
            InitializeComponent();
        }

        BLL_ThietBi bLL_ThietBi;
        string err = string.Empty;

        private void frm_QLTB_Load(object sender, EventArgs e)
        {
            bLL_ThietBi = new BLL_ThietBi(ClsMain.path);
            LoadTB();
        }
        DataTable dtTB;
        private void LoadTB()
        {
            dtTB = new DataTable();
            dtTB = bLL_ThietBi.LayThietBi(ref err, "0");
            dgvThietBi.DataSource = dtTB.DefaultView;
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            //if (ClsMain.CheckQuyen(this, QUYEN.THEM))
            //{
            //    Frm_QLTB_Modifies frmqltbM = new Frm_QLTB_Modifies();
            //    frmqltbM.isThem = true;
            //    frmqltbM.ShowDialog();
            //    LoadTB();

            //}
            //else
            //{
            //    MessageBox.Show("Khong co quyen");
            //}

            Frm_QLTB_Modifies frmqltbM = new Frm_QLTB_Modifies();
            frmqltbM.isThem = true;
            frmqltbM.ShowDialog();
            LoadTB();
        }

        ThietBi thietBi;

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (thietBi != null)
            {
                Frm_QLTB_Modifies frmM = new Frm_QLTB_Modifies();
                frmM.isThem = false;
                frmM.thietBi = thietBi;
                frmM.ShowDialog();
                LoadTB();
                thietBi = null;
            }
            else
            {
                MessageBox.Show("Chưa chọn thiết bị");
            }
        }

        private void dgvThietBi_Click(object sender, EventArgs e)
        {
            if (dgvThietBi.Rows.Count > 0)
            {
                thietBi = new ThietBi()
                {
                    MaTB = dgvThietBi.CurrentRow.Cells["colMaTB"].Value.ToString(),
                    TenTB = dgvThietBi.CurrentRow.Cells["colTenTB"].Value.ToString(),
                    LoaiTB = dgvThietBi.CurrentRow.Cells["colLoaiTB"].Value.ToString(),
                    Sl = dgvThietBi.CurrentRow.Cells["colSL"].Value.ToString(),
                    TinhTrang = dgvThietBi.CurrentRow.Cells["colTinhTrang"].Value.ToString(),
                    CurrentUser = dgvThietBi.CurrentRow.Cells["colCurrentUser"].Value.ToString()
                };
            }
        }

        private void tsbDel_Click(object sender, EventArgs e)
        {
            if (thietBi != null)
            {
                if (bLL_ThietBi.XoaThietBi(ref err, thietBi) > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    LoadTB();
                    thietBi = null;
                }
                else
                {
                    MessageBox.Show("Xóa không thành công \n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            //this.Close();
            deDongtab();
        }

        private void tsbRefr_Click(object sender, EventArgs e)
        {
            LoadTB();
        }
    }
}
