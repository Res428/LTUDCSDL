using QLBH.BusinessLayer;
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

namespace QLBH_WINFORM.Hệ_thống
{
    public partial class FrmKetnoi : Form
    {
        public FrmKetnoi()
        {
            InitializeComponent();
        }

        SqlConnectionStringBuilder stringBuilder;
        BLL_HeThong bLL;

        string err = string.Empty;
        string path = "";


        private void FrmKetnoi_Load(object sender, EventArgs e)
        {
            bLL = new BLL_HeThong();
            Hienthichuoiketnoi(ClsMain.pathConnectFile);
        }
        private void Hienthichuoiketnoi(string pathConnectFile)
        {
            stringBuilder = bLL.ReadConnStr(pathConnectFile);

            txtServer.Text = stringBuilder.DataSource;
            txtDatabase.Text = stringBuilder.InitialCatalog;
            txtUserID.Text = stringBuilder.UserID;
            txtPass.Text = stringBuilder.Password;
            cboAuthentication.SelectedIndex = stringBuilder.IntegratedSecurity ? 0 : 1;
        }

        private void CreateConnectionString(ref string err, string path)
        {
            if (cboAuthentication.SelectedIndex == 1)
            {
                if (!string.IsNullOrEmpty(txtUserID.Text))
                {
                    if (!string.IsNullOrEmpty(txtPass.Text))
                    {
                        //tạo chuỗi kết nối sql
                        stringBuilder.DataSource = txtServer.Text;
                        stringBuilder.InitialCatalog = txtDatabase.Text;
                        stringBuilder.UserID = txtUserID.Text;
                        stringBuilder.Password = txtPass.Text;
                        bLL.WriteConnStr(path, stringBuilder);
                    }
                    else
                    {
                        MessageBox.Show("Chưa có password", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Chưa có user name", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //tạo =kêt nói quyen window 
                stringBuilder.DataSource = txtServer.Text;
                stringBuilder.InitialCatalog = txtDatabase.Text;
                stringBuilder.IntegratedSecurity = true;
                bLL.WriteConnStr(path, stringBuilder);
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

                        bLL.WriteConnStr(ClsMain.pathConnectFile, stringBuilder);
                        MessageBox.Show("Luu thanh cong");
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(txtUserID.Text))
                        {
                            if (!string.IsNullOrEmpty(txtPass.Text))
                            {
                                stringBuilder.DataSource = txtServer.Text;
                                stringBuilder.InitialCatalog = txtDatabase.Text;
                                stringBuilder.IntegratedSecurity = false;
                                stringBuilder.UserID = txtUserID.Text;
                                stringBuilder.Password = txtPass.Text;

                                bLL.WriteConnStr(ClsMain.pathConnectFile, stringBuilder);
                                MessageBox.Show("Luu thanh cong");
                            }
                        }
                    }
                }
            }
        }

        private void cboAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAuthentication.SelectedIndex == 0)
            {
                
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            bLL = new BLL_HeThong(ClsMain.pathConnectFile);
            if (bLL.checkconn(ref err))
	        {
                MessageBox.Show("ket noi thanh cong");
	        }
            else
            {
                MessageBox.Show("ket noi thanh cong" + err);
            }
        }

    }
}
