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
    public partial class frm_LoaiHang_Modifies : Form
    {
        public frm_LoaiHang_Modifies()
        {
            InitializeComponent();
        }

        Bll_LoaiHang bd;
        string err = string.Empty;
        public LoaiHang loaiHang = null;
        public bool isThem = false;

        private void frm_LoaiHang_Modifies_Load(object sender, EventArgs e)
        {
            bd = new Bll_LoaiHang(ClsMain.path);
            if (isThem)
            {
                txtMaLH.Text = "0";
                txtTenLH.Focus();
            }
            else
            {
                //sua
                if (loaiHang != null)
                {
                    txtMaLH.Text = loaiHang.MaLH;
                    txtTenLH.Text = loaiHang.TenLH;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenLH.Text))
            {
                loaiHang = new LoaiHang()
                {
                    MaLH = txtMaLH.Text,
                    TenLH = txtTenLH.Text,
                };
                if (bd.CapNhatLoaiHang(ref err, loaiHang) > 0)
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
                MessageBox.Show("chua nhap ten lh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
