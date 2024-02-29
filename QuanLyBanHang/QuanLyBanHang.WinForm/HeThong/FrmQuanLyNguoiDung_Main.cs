using QuanLyBanHang.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.WinForm.HeThong
{
    public partial class FrmQuanLyNguoiDung_Main : Form
    {
        public FrmQuanLyNguoiDung_Main()
        {
            InitializeComponent();
        }
        BLL_HeThong bll;
        string err = string.Empty;
        DataTable dataTable;
        private void FrmQuanLyNguoiDung_Main_Load(object sender, EventArgs e)
        {
            bll = new BLL_HeThong(ClsMain.pathConnectFile);
            HienThiDanhSach();
        }

        private void HienThiDanhSach()
        {
            dataTable = new DataTable();

            //dataTable = bll.GetUserByID(ref err, 4.ToString());
            dataTable = bll.GetAllNhanVien(ref err);
            dataGridView1.DataSource = dataTable.DefaultView;
        }

        string maNV, hoTenNV, luongCB, congViec, maKV;

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Them_Click(object sender, EventArgs e)
        {
            FrmQuanLyNguoiDung_Modifies frmQuanLyNguoiDung_Modifies = new FrmQuanLyNguoiDung_Modifies();
            frmQuanLyNguoiDung_Modifies.isThem = true;
            frmQuanLyNguoiDung_Modifies.ShowDialog();
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            FrmQuanLyNguoiDung_Modifies frmQuanLyNguoiDung_Modifies = new FrmQuanLyNguoiDung_Modifies();
            frmQuanLyNguoiDung_Modifies.isThem = false;
            frmQuanLyNguoiDung_Modifies.maNV = maNV;
            frmQuanLyNguoiDung_Modifies.hoTenNV = hoTenNV;
            frmQuanLyNguoiDung_Modifies.phai = phai;
            frmQuanLyNguoiDung_Modifies.luongCB = luongCB;
            frmQuanLyNguoiDung_Modifies.congViec = congViec;
            frmQuanLyNguoiDung_Modifies.maKV = maKV;
            frmQuanLyNguoiDung_Modifies.ShowDialog();
            HienThiDanhSach();
        }

        bool phai;
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                maNV = dataGridView1.CurrentRow.Cells["colMaNV"].Value.ToString();
                hoTenNV = dataGridView1.CurrentRow.Cells["colHoTenNV"].Value.ToString();
                phai = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["colPhai"].Value.ToString());
                luongCB = dataGridView1.CurrentRow.Cells["colLuongCB"].Value.ToString();
                congViec = dataGridView1.CurrentRow.Cells["colCongViec"].Value.ToString();
                maKV = dataGridView1.CurrentRow.Cells["colMaKV"].Value.ToString();
            }
        }
    }
}
