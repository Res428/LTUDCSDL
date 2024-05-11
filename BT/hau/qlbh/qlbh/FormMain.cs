using DevComponents.DotNetBar;
using qlbh.Report;
using qlbh.TacVu;
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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        bool bKTraMotab = false;
        string sTieuDe;
        public FormMain frm_Main;

        public delegate void _deDongTab();
        public _deDongTab deDongTab;

        private void FormMain_Load(object sender, EventArgs e)
        {
            frmLogin frmL = new frmLogin();
            frmL.ShowDialog();
            //Hien thi thong tin dang nhập
            lblErr.Text = string.Format("Hệ thống đăng nhập bởi: {0}", ClsMain.tenNhanVien);
        }

        private void mnuQLKH_Click(object sender, EventArgs e)
        {
            OpenForm(true, "Quản lý khách hàng", new frm_QuanLyKhachHang_Main());

        }
        
        private void mnuLoaiHang_Click(object sender, EventArgs e)
        {
            frm_LoaiHang frl = new frm_LoaiHang();
            frl.ShowDialog();
        }

        #region Quản lý việc mở form trên TabControll
        /// <summary>
        /// Kiểm tra form có được mở chưa theo tên form

        private bool CheckOpenTab(string name)
        {
            for (int i = 0; i < tabControl1.Tabs.Count; i++)
            {
                if (tabControl1.Tabs[i].Text == name)
                {
                    tabControl1.SelectedTabIndex = i;
                    return true;
                }
            }
            return false;
        }

        private void vDongTab()
        {
            foreach (TabItem iten in tabControl1.Tabs)
            {
                if (iten.IsSelected)
                {
                    tabControl1.Tabs.Remove(iten);
                    return;
                }
            }
        }

        private void tabControl1_TabItemClose(object sender, TabStripActionEventArgs e)
        {
            TabItem t = tabControl1.SelectedTab;
            tabControl1.Tabs.Remove(t);
        }

        private void OpenForm(bool statusOpen, string title, Frm_Base frm, QUYEN quyen)
        {
            if (ClsMain.CheckQuyen(frm, quyen))
            {
                bKTraMotab = statusOpen;
                sTieuDe = title;
                if (!CheckOpenTab(sTieuDe))
                {
                    TabItem t = tabControl1.CreateTab(sTieuDe);
                    t.Name = frm.Name;

                    frm.deDongtab = new Frm_Base._deDongtab(vDongTab);
                    this.frm_Main = this;
                    frm.TopLevel = false;
                    frm.Dock = DockStyle.Fill;
                    t.AttachedControl.Controls.Add(frm);
                    frm.Show();

                    tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
                }
            }
            else
            {
                MessageBox.Show("khong co quyen");
            }  

        }

        private void OpenForm(bool statusOpen, string title, Frm_Base frm)
        {
                bKTraMotab = statusOpen;
                sTieuDe = title;
                if (!CheckOpenTab(sTieuDe))
                {
                    TabItem t = tabControl1.CreateTab(sTieuDe);
                    t.Name = frm.Name;

                    frm.deDongtab = new Frm_Base._deDongtab(vDongTab);
                    this.frm_Main = this;
                    frm.TopLevel = false;
                    frm.Dock = DockStyle.Fill;
                    t.AttachedControl.Controls.Add(frm);
                    frm.Show();

                    tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
                }

        }
        #endregion
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuPhanquyen_Click(object sender, EventArgs e)
        {
            OpenForm(true, "Phân quyền", new Frm_PhanQuyen(), QUYEN.XEM);
        }

        private void thayĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DoiMatKhau frmdmk = new Frm_DoiMatKhau();
            frmdmk.StartPosition = FormStartPosition.Manual;
            frmdmk.ShowDialog();
        }

        private void saoLưuPhụcHồiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_SaoluuPhuchoi frmslph = new Frm_SaoluuPhuchoi();
            frmslph.ShowDialog();
        }

        private void mnuNhapHang_Click(object sender, EventArgs e)
        {
            OpenForm(true, "Quản lý nhập hàng", new Frm_NhapHang_Main());
        }
        private void MoFormDangNhap()
        {
            frmLogin frml = new frmLogin();
            frml.ShowDialog();
            lblErr.Text = string.Format("Hệ thống đăng nhập bởi: {0}", ClsMain.tenNhanVien);
        }
        private void mnuDX_Click(object sender, EventArgs e)
        {
            MoFormDangNhap();
        }

        private void mnuDanhSachSP_Click(object sender, EventArgs e)
        {
            Frm_ViewReport frm_ViewReport = new Frm_ViewReport();
            frm_ViewReport.ShowDialog();
        }
    }
}