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
    public partial class frm_loaithietbi_Modifies : Form
    {
        public frm_loaithietbi_Modifies()
        {
            InitializeComponent();
        }

        BLL_LoaiThietBi bd;
        string err = string.Empty;
        public LoaiThietBi loaiThietBi = null;
        public bool isThem = false;

        private void frm_loaithietbi_Modifies_Load(object sender, EventArgs e)
        {
            bd = new BLL_LoaiThietBi(ClsMain.path);
            if (isThem)
            {
                txtMaTB.Text = "0";
                txtTenTB.Focus();
            }
            else
            {
                //sua
                if (loaiThietBi != null)
                {
                    txtMaTB.Text = loaiThietBi.MaTB;
                    txtTenTB.Text = loaiThietBi.TenTB;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenTB.Text))
            {
                loaiThietBi = new LoaiThietBi()
                {
                    MaTB = txtMaTB.Text,
                    TenTB = txtTenTB.Text,
                };
                if (bd.CapNhatLoaiTB(ref err, loaiThietBi) > 0)
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
                MessageBox.Show("chua nhap ten loai thiet bi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
