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
    public partial class Frm_QLTB_Modifies : Form
    {
        public Frm_QLTB_Modifies()
        {
            InitializeComponent();
        }

        BLL_ThietBi bd;
        string err = string.Empty;
        public ThietBi thietBi = null;
        public bool isThem = false;

        private void Frm_QLTB_Modifies_Load(object sender, EventArgs e)
        {
            bd = new BLL_ThietBi(ClsMain.path);
            if (isThem)
            {
                txtMaTB.Text = "0";
                txtTenTB.Focus();
            }
            else
            {
                //sua
                if (thietBi != null)
                {
                    txtMaTB.Text = thietBi.MaTB;
                    txtTenTB.Text = thietBi.TenTB;
                    txtLoaiTB.Text = thietBi.LoaiTB;
                    cboTinhtrang.Text = thietBi.TinhTrang;
                    txtNguoiMuon.Text = thietBi.NguoiMuon;
                }
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenTB.Text))
            {
                thietBi = new ThietBi()
                {
                    MaTB = txtMaTB.Text,
                    TenTB = txtTenTB.Text,
                    LoaiTB = txtLoaiTB.Text,
                    TinhTrang = cboTinhtrang.SelectedValue.ToString(),
                    NguoiMuon = txtNguoiMuon.Text
                };
                if (bd.CapNhatThietBi(ref err, thietBi) > 0)
                {
                    MessageBox.Show("thanh cong");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("k thanh cong \n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("chua nhap ten thiet bi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
