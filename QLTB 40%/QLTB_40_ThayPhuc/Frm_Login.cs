using QLTB_40_ThayPhuc.BusinessLayer;
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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
            this.CancelButton = btnCancel;
        }


        BLL_HeThong bd;
        string err = string.Empty;
        DataTable dtQuanLy;

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            bd = new BLL_HeThong(ClsMain.path);
            txtUser.Text = "admin";
            txtPass.Text = "123456";
        }



        private void btnCancel_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //string username = txtUser.Text;
            //string password = txtPass.Text;
            if (!string.IsNullOrEmpty(txtUser.Text))
            {
                if (!string.IsNullOrEmpty(txtPass.Text))
                {

                    if (KiemTraDangNhap(txtUser.Text, txtPass.Text))
                    {
                        //bool hasAccessToQLNV, hasAccessToQLTB;
                        //// Check if the user is an admin
                        //if (username == "admin" && password == "password")
                        //{
                        //    //hasAccessToQLNV = true;
                        //    //hasAccessToQLTB = true;
                        //    ClsMain.tenQL = "Admin";
                        //}
                        //else
                        //{
                        //    //hasAccessToQLNV = false;
                        //    //hasAccessToQLTB = true;
                        //    ClsMain.tenQL = "User";
                        //}

                        ClsMain.tenQL = dtQuanLy.Rows[0]["HoTenNV"].ToString();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thông tin tài khoản không đúng \n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Simulate user authentication
            //string username = txtUser.Text;
            //string password = txtPass.Text;

            //// Check if the user is an admin
            //if (username == "admin" && password == "password")
            //{
            //    // Set the user's access rights
            //    ClsMain.hsQuyenByUser.Add("QLNV", true); // User has access to "QLNV" (Quản lý nhân viên)
            //    ClsMain.hsQuyenByUser.Add("QLTB", true); // User has access to "QLTB" (Quản lý thiết bị)
            //    ClsMain.tenQL = "Admin";
            //}
            //else
            //{
            //    // Set the user's access rights
            //    ClsMain.hsQuyenByUser.Add("QLNV", false); // User does not have access to "QLNV"
            //    ClsMain.hsQuyenByUser.Add("QLTB", true); // User has access to "QLTB"
            //    ClsMain.tenQL = "User";
            //}

            //// Close the login form and open the main form

            //this.Close();
            //Form_Main frm_Main = new Form_Main();
            //frm_Main.Show();

        }

        private bool KiemTraDangNhap(string taiKhoan, string matKhau)
        {
            dtQuanLy = new DataTable();
            dtQuanLy = bd.KiemTraDangNhap(ref err, taiKhoan, matKhau);

            if (dtQuanLy.Rows.Count > 0)
            {
                if (dtQuanLy.Rows[0]["Code"].ToString().Equals("1"))
                {
                    LayGiaTriQuyen(dtQuanLy.Rows[0]["MaNV"].ToString());
                    return true;
                }
            }
            return false;
        }


        private void LayGiaTriQuyen(string maNV)
        {
            DataTable dtquyen = new DataTable();
            dtquyen = bd.LayDanhSachQuyen(ref err, maNV);
            if (dtquyen.Rows.Count > 0)
            {
                ClsMain.hsQuyenByUser = new System.Collections.Hashtable();
                foreach (DataRow item in dtquyen.Rows)
                {
                    if (!ClsMain.hsQuyenByUser.ContainsKey(item["Alias"]))
                    {
                        ClsMain.hsQuyenByUser.Add(item["Alias"], Convert.ToInt32(item["total"].ToString()));
                    }

                }
            }
        }

        private void LuuThongTinDangNhap()
        {
            ClsMain.nhanVien.MaNV = dtQuanLy.Rows[0]["MaNV"].ToString();
            ClsMain.nhanVien.HoTenNV = dtQuanLy.Rows[0]["HoTenNV"].ToString();
            ClsMain.nhanVien.Email = dtQuanLy.Rows[0]["Email"].ToString();
            //ClsMain.acc.Matkhau = dtQuanLy.Rows[0]["Mat"].ToString();
            ClsMain.nhanVien.SoDT = dtQuanLy.Rows[0]["SoDT"].ToString();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, EventArgs.Empty);
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, EventArgs.Empty);
            }
        }



    }



}

