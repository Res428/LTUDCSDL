using qlbh.BusinessLayer;
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
    public partial class Frm_DoiMatKhau : Form
    {
        public Frm_DoiMatKhau()
        {
            InitializeComponent();
        }

        Bll_HeThong bd;
        DataTable dtTaiKhoan;
        string err = string.Empty;

        private void Frm_DoiMatKhau_Load(object sender, EventArgs e)
        {
            bd = new Bll_HeThong(ClsMain.path);
            if (ClsMain.account.GroupID.ToString().Equals("1"))
            {
                //Loại tài khoản Admin
                grpReset.Enabled = true;
                grpDoimk.Enabled = true;
                HienThiDuLieuCboTaiKhoan();
            }
            else
            {
                //Loại tài khoản khác Admin
                grpReset.Enabled = false;
            }
        }

        private void HienThiDuLieuCboTaiKhoan()
        {
            dtTaiKhoan = new DataTable();
            dtTaiKhoan = bd.LayTaiKhoanChoCboTaiKhoan(ref err);

            cboTaikhoan.DataSource = dtTaiKhoan;
            cboTaikhoan.ValueMember = "TaiKhoan";
            cboTaikhoan.DisplayMember = "HoTenNV";

            cboTaikhoan.SelectedIndex = -1;
            cboTaikhoan.Text = "---Chọn tài khoản---";
        }

        private void txtMatkhau02_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMatkhau01.Text) && !string.IsNullOrEmpty(txtMatkhau02.Text))
            {
                if (txtMatkhau01.Text.Equals(txtMatkhau02.Text))
                {
                    return;
                }
                else
                {
                    MessageBox.Show("Mật khẩu nhập không trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMatkhau01.ResetText();
                    txtMatkhau02.ResetText();
                    txtMatkhau01.Focus();
                }
            }

        }

        private void btnCaplai_Click(object sender, EventArgs e)
        {
            if (cboTaikhoan.SelectedIndex >= 0)
            {
                if (bd.DoiMatKhau(ref err, cboTaikhoan.SelectedValue.ToString(), "123456") == 1)
                {
                    MessageBox.Show("Cấp lại mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Chưa chọn tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMatkhau01.Text))
            {
                 if (!string.IsNullOrEmpty(txtMatkhau02.Text))
                 {
                     if (bd.DoiMatKhau(ref err, ClsMain.account.TaiKhoan, txtMatkhau01.Text) == 1)
                     {
                         MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     }
                 }
                 else
                 {
                     MessageBox.Show("Chưa nhập lại mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
             }
             else
             {
                 MessageBox.Show("Chưa nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }

        }


    }
}
