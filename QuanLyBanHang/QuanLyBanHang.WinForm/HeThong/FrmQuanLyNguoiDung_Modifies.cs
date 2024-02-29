using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.BusinessLayer;


namespace QuanLyBanHang.WinForm.HeThong
{
    public partial class FrmQuanLyNguoiDung_Modifies : Form
    {
        public FrmQuanLyNguoiDung_Modifies()
        {
            InitializeComponent();
        }
        BLL_HeThong bll;
        string err = string.Empty;
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        public bool isThem = false;
        public string maNV, hoTenNV, luongCB, congViec, maKV;

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool phai;
        private void FrmQuanLyNguoiDung_Modifies_Load(object sender, EventArgs e)
        {
            bll = new BLL_HeThong(ClsMain.pathConnectFile);
            if (isThem)
            {
                txtMaNV.Text = "0";
                txtHoTenNV.Focus();
            }
            else
            {
                txtMaNV.Text = maNV;
                txtHoTenNV.Text = hoTenNV;
                txtLCB.Text = luongCB;
                txtCV.Text = congViec;
                radNam.Checked = phai;
                cbxkhuvuc.Text = maKV;
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (bll.CapNhatNguoiDung(ref err, txtMaNV.Text, txtHoTenNV.Text, radNam.Checked, txtLCB.Text, txtCV.Text, cbxkhuvuc.Text)==1)
            {
                MessageBox.Show("Thanh cong");
            }
            else
            {
                MessageBox.Show("Khong thanh cong");
            }
        }
    }
}
