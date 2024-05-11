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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            bd = new Bll_HeThong(ClsMain.path);
            txtMK.Text = "hai";
            txtTK.Text = "hai";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Bll_HeThong bd;
        string err = string.Empty;
        DataTable dtNhanVien;

        private void btnDN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTK.Text))
            {
                if (!string.IsNullOrEmpty(txtMK.Text))
                {
                    if (KiemTraDangNhap(txtTK.Text, txtMK.Text))
                    {
                        ClsMain.tenNhanVien = dtNhanVien.Rows[0]["HoTenNV"].ToString();
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
            dtNhanVien = new DataTable();
            dtNhanVien = bd.KiemTraDangNhap(ref err, taiKhoan, matKhau);
            if (dtNhanVien.Rows.Count > 0)
            {
                if (dtNhanVien.Rows[0]["Code"].ToString().Equals("1"))
                {
                    LayGiaTriQuyen(dtNhanVien.Rows[0]["MaNV"].ToString());
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
            ClsMain.tenNhanVien = dtNhanVien.Rows[0]["HoTenNV"].ToString();
            ClsMain.account.MaNV = dtNhanVien.Rows[0]["MaNV"].ToString();
            ClsMain.account.HoTenNV = dtNhanVien.Rows[0]["HoTenNV"].ToString();
            ClsMain.account.TaiKhoan = dtNhanVien.Rows[0]["TaiKhoan"].ToString();
            ClsMain.account.GroupID = dtNhanVien.Rows[0]["GroupID"].ToString();
        }


        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
        }
    }
}
