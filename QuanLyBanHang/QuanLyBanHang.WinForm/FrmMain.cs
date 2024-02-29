using QuanLyBanHang.WinForm.HeThong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.WinForm
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void mnuKetNoi_Click(object sender, EventArgs e)
        {
            FrmKetNoi frmKetNoi = new FrmKetNoi();
            frmKetNoi.ShowDialog();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            FrmQuanLyNguoiDung_Main frmQuanLyNguoiDung_Main = new FrmQuanLyNguoiDung_Main();
            frmQuanLyNguoiDung_Main.ShowDialog();
        }
    }
}
