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
            if (!string.IsNullOrEmpty(txtUser.Text))
            {
                if (!string.IsNullOrEmpty(txtPass.Text))
                {
                    if (KiemTraDangNhap(txtUser.Text, txtPass.Text))
                    {
                        ClsMain.tenQL = dtQuanLy.Rows[0]["HoTenNV"].ToString();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thong tin tai khoan khong dung \n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Chua nhap Mat khau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Chua nhap tai khoan", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            ClsMain.acc.MaQL = dtQuanLy.Rows[0]["MaNV"].ToString();
            ClsMain.acc.HoTenQL = dtQuanLy.Rows[0]["HoTenNV"].ToString();
            ClsMain.acc.Email = dtQuanLy.Rows[0]["TaiKhoan"].ToString();
            //ClsMain.acc.Matkhau = dtQuanLy.Rows[0]["Mat"].ToString();
            ClsMain.acc.SoDT = dtQuanLy.Rows[0]["SoDT"].ToString();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
        }

    }
}
