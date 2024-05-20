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
    public partial class Frm_QuanLyNhanVien_Main : Frm_Base
    {
        public Frm_QuanLyNhanVien_Main()
        {
            InitializeComponent();
        }
        BLL_NhanVien bd;
        string err = string.Empty;

        DataTable dtNhanVien;

        private void Frm_QuanLyNhanVien_Main_Load(object sender, EventArgs e)
        {
            bd = new BLL_NhanVien(ClsMain.path);
            LoadNV();
        }

        private void LoadNV()
        {
            dtNhanVien = new DataTable();
            dtNhanVien = bd.LayNhanVien(ref err, "0");
            dgvNhanVien.DataSource = dtNhanVien.DefaultView;
        }

        private void tsbRefr_Click(object sender, EventArgs e)
        {
            LoadNV();
        }
        NhanVien nhanVien;
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            Frm_QuanLyNhanVien_Modifies frnvm = new Frm_QuanLyNhanVien_Modifies();
            frnvm.isThem = true;
            frnvm.ShowDialog();
            LoadNV();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (nhanVien != null)
            {
                Frm_QuanLyNhanVien_Modifies frnvm = new Frm_QuanLyNhanVien_Modifies();
                frnvm.isThem = false;
                frnvm.nhanVien = nhanVien;
                frnvm.ShowDialog();
                LoadNV();
                nhanVien = null;
            }
            else
            {
                MessageBox.Show("Chưa chọn nhân viên");
            }
        }

        private void tsbDel_Click(object sender, EventArgs e)
        {
            if (nhanVien != null)
            {
                if (bd.XoaNhanVien(ref err, nhanVien) > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    LoadNV();
                    nhanVien = null;
                }
                else
                {
                    MessageBox.Show("Xóa không thành công \n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            deDongtab();
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.Rows.Count > 0)
            {
                nhanVien = new NhanVien()
                {
                    MaNV = dgvNhanVien.CurrentRow.Cells["colMaNV"].Value.ToString(),
                    HoTenNV = dgvNhanVien.CurrentRow.Cells["colHoTenNV"].Value.ToString(),
                    Email = dgvNhanVien.CurrentRow.Cells["colEmail"].Value.ToString(),
                    SoDT = dgvNhanVien.CurrentRow.Cells["colSoDT"].Value.ToString()
                };
            }
        }
    }
}
