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
    public partial class Frm_QuanLyNhanVien_Modifies : Form
    {
        public Frm_QuanLyNhanVien_Modifies()
        {
            InitializeComponent(); 
            this.AcceptButton = btnUpdate;
            this.CancelButton = huy;

        }
        BLL_NhanVien bd;
        string err = string.Empty;
        public NhanVien nhanVien = null;
        public bool isThem = false;

        private void Frm_QuanLyNhanVien_Modifies_Load(object sender, EventArgs e)
        {
            bd = new BLL_NhanVien(ClsMain.path);
            if (isThem)
            {
                txtMaNV.Text = bd.SinhMaLonNhat(ref err).ToString();
                txtHoTenNV.Focus();
            }
            else
            {
                //sua
                if (nhanVien != null)
                {
                    txtMaNV.Text = nhanVien.MaNV;
                    txtHoTenNV.Text = nhanVien.HoTenNV;
                    txtEmail.Text = nhanVien.Email;
                    txtSoDT.Text = nhanVien.SoDT;
                    
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtHoTenNV.Text))
            {
                nhanVien = new NhanVien()
                {
                    MaNV = txtMaNV.Text,
                    HoTenNV = txtHoTenNV.Text,
                    Email = txtEmail.Text,
                    SoDT = txtSoDT.Text

                };
                if (bd.CapNhatNhanVien(ref err, nhanVien) >= 1)
                {
                    MessageBox.Show("Thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thành công \n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUpdate_Click(this, EventArgs.Empty);
            }
        }
    }
}
