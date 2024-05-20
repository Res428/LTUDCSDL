﻿using DevComponents.DotNetBar;
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
    public partial class Form_Main : Form
    {

        public Form_Main()
        {
            InitializeComponent();
        }

        bool bKTraMotab = false;
        string sTieuDe;
        public Form_Main frm_Main;


        public delegate void _deDongTab();
        public _deDongTab deDongTab;

        private void Form_Main_Load(object sender, EventArgs e)
        {
            Frm_Login forml = new Frm_Login ();
            forml.ShowDialog();
            lblErr.Text = string.Format("Current User: {0}", ClsMain.tenQL);
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

        private void MoFormDangNhap()
        {
            Frm_Login frml = new Frm_Login();
            frml.ShowDialog();
            lblErr.Text = string.Format("Current User: {0}", ClsMain.tenQL);
        }



        private void loaithietbi_Click(object sender, EventArgs e)
        {
            OpenForm(true, "Khách Hàng", new frm_KhachHang());
            //frm_KhachHang frm_kh = new frm_KhachHang();
            //frm_kh.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mmnuQLTB_Click(object sender, EventArgs e)
        {
            OpenForm(true, "Quản lý thiết bị", new frm_QLTB());
            //frm_QLTB frmqltb = new frm_QLTB();
            //frmqltb.ShowDialog();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            MoFormDangNhap();
        }

        private void mnuQLNV_Click(object sender, EventArgs e)
        {

            OpenForm(true, "Quản lý nhân viên", new Frm_QuanLyNhanVien_Main());

            //if (ClsMain.tenQL == "admin")
            //{
            //    // Nếu user có quyền truy cập, mở form Frm_QuanLyNhanVien_Main
            //    OpenForm(true, "Quản lý nhân viên", new Frm_QuanLyNhanVien_Main());
            //}
            //else if (ClsMain.tenQL == "User")
            //{
            //    // Nếu user không có quyền truy cập, hiển thị thông báo
            //    MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

        }
    }
}
