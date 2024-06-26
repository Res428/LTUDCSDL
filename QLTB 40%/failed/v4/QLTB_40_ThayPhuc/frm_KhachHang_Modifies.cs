﻿using QLTB_40_ThayPhuc.BusinessLayer;
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
    public partial class frm_KhachHang_Modifies : Form
    {
        public frm_KhachHang_Modifies()
        {
            InitializeComponent();
        }

        BLL_KhachHang bd;
        string err = string.Empty;
        public KhachHang khachHang = null;
        public bool isThem = false;

        private void frm_KhachHang_Modifies_Load(object sender, EventArgs e)
        {
            bd = new BLL_KhachHang(ClsMain.path);
            if (isThem)
            {
                txtMaKH.Text = bd.SinhMaLonNhat(ref err).ToString();
                txtHoKH.Focus();
            }
            else
            {
                //sua
                if (khachHang != null)
                {
                    txtMaKH.Text = khachHang.MaKH;
                    txtHoKH.Text = khachHang.HoKH;
                    txtTenKH.Text = khachHang.TenKH;
                    txtSoDT.Text = khachHang.SoDT;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtHoKH.Text))
            {
                khachHang = new KhachHang()
                {
                    MaKH = txtMaKH.Text,
                    HoKH = txtHoKH.Text,
                    TenKH = txtTenKH.Text,
                    SoDT = txtSoDT.Text
                };
                if (bd.CapNhatKhachHang(ref err, khachHang) >= 1)
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
                MessageBox.Show("chua nhap ten khach hang", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
