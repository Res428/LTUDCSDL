using qlbh.BusinessLayer;
using qlbh.DTO;
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
    public partial class frmModifies : Form
    {
        public frmModifies()
        {
            InitializeComponent();
        }

        Bll_KhachHang bd;
        string err = string.Empty;
        public KhachHang khachHang = null;
        public bool isThem = false;

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void frmModifies_Load(object sender, EventArgs e)
        {
            bd = new Bll_KhachHang(ClsMain.path);
            if (isThem)
            {
                txtMaKH.Text = "0";
                txtHoKH.Focus();
            }
            else
            {
                //sua
                if (khachHang!= null)
                {
                    txtMaKH.Text = khachHang.MaKH;
                    txtHoKH.Text = khachHang.HoKH;
                    txtTenKH.Text = khachHang.TenKh;
                    txtDcKH.Text = khachHang.DcKH;
                    txtDtKH.Text = khachHang.DtKH;
                }
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenKH.Text))
            {
                khachHang = new KhachHang(){
                    MaKH = txtMaKH.Text,
                    HoKH = txtHoKH.Text,
                    TenKh = txtTenKH.Text,
                    DcKH = txtDcKH.Text,
                    DtKH = txtDtKH.Text
                };
                if (bd.CapNhatKhachHang(ref err, khachHang) > 0)
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
                MessageBox.Show("chua nhap ten kh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
