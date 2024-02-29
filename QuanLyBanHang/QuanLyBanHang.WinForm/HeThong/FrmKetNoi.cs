using QuanLyBanHang.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.WinForm.HeThong
{
    public partial class FrmKetNoi : Form
    {
        public FrmKetNoi()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        BLL_HeThong bLL;
        SqlConnectionStringBuilder stringBuilder;
        private void FrmKetNoi_Load(object sender, EventArgs e)
        {
            bLL = new BLL_HeThong();
            HienThiChuoiKetNoi(ClsMain.pathConnectFile);
        }

        private void HienThiChuoiKetNoi(string pathConnectFile)
        {
            stringBuilder = bLL.ReadConnectionString(pathConnectFile);

            txtServer.Text = stringBuilder.DataSource;
            txtDatabase.Text = stringBuilder.InitialCatalog;
            txtUserID.Text = stringBuilder.UserID;
            txtPassword.Text = stringBuilder.Password;
            cboAuthentication.SelectedIndex =
            stringBuilder.IntegratedSecurity ? 0 : 1;
        }

        private void cboAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAuthentication.SelectedIndex == 0)
            {
                txtUserID.Enabled = false;
                txtPassword.Enabled = false;
            }
            else
            {
                txtUserID.Enabled = true;
                txtPassword.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtServer.Text))
            {
                if (!string.IsNullOrEmpty(txtDatabase.Text))
                {
                    if (cboAuthentication.SelectedIndex == 0)
                    {
                        //win
                        stringBuilder.DataSource = txtServer.Text;
                        stringBuilder.InitialCatalog = txtDatabase.Text;
                        stringBuilder.IntegratedSecurity = true;
                        stringBuilder.UserID = string.Empty;
                        stringBuilder.Password = string.Empty;

                        bLL.WriteConnectionString(ClsMain.pathConnectFile, stringBuilder);
                        MessageBox.Show("Lưu file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(txtUserID.Text))
                        {
                            if (!string.IsNullOrEmpty(txtPassword.Text))
                            {
                                stringBuilder.DataSource = txtServer.Text;
                                stringBuilder.InitialCatalog = txtDatabase.Text;
                                stringBuilder.IntegratedSecurity = false;
                                stringBuilder.UserID = txtUserID.Text;
                                stringBuilder.Password = txtPassword.Text;
                                bLL.WriteConnectionString(ClsMain.pathConnectFile, stringBuilder);
                                MessageBox.Show("Lưu file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Chua co database");
                }
            }
            else
            {
                MessageBox.Show("Chua co server");
            }

        }
        string err = string.Empty;
        private void btnTest_Click(object sender, EventArgs e)
        {
            bLL = new BLL_HeThong(ClsMain.pathConnectFile);
            if (bLL.CheckConnnect(ref err))
            {
                MessageBox.Show("ket noi thanh cong");
            }
            else
            {
                MessageBox.Show("ket noi khong thanh cong" + err);
            }
        }
    }
}
