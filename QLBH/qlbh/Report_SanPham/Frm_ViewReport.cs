using Microsoft.Reporting.WinForms;
using qlbh.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlbh.Report
{
    public partial class Frm_ViewReport : Form
    {
        public Frm_ViewReport()
        {
            InitializeComponent();
        }
        Bll_Report bd;
        string err = string.Empty;
        DataTable dtDsSanPham;

        private void Report_test_Load(object sender, EventArgs e)
        {
            bd = new Bll_Report(ClsMain.path);
            this.reportViewer1.RefreshReport();
            HienThiCboThanhPho();

        }

        private void HienThiReportSanPhamDangBan()
        {
            //1. lay du lieu
            DataTable dtspdangban = new DataTable();
            dtspdangban = bd.LayDanhSachSanPhamDangBan(ref err);

            //2. Khai bao report path
            reportViewer1.Reset();

            reportViewer1.LocalReport.ReportPath = "D:\\STUDY\\LTUDCSDL\\LTUDCSDL\\BT\\hau\\qlbh\\qlbh\\Report_SanPham\\rp_SPDaBan.rdlc";

            //3. khai baos datareport sources
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource reportDataSource = new ReportDataSource("ds_SanPham", dtspdangban);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.RefreshReport();

        }

        private void HienThiCboThanhPho()
        {
            DataTable dataTable = new DataTable();
            dataTable = bd.LayDuLieuComboKhachHang(ref err);

            cboThanhPho.DataSource = dataTable;
            cboThanhPho.ValueMember = "ThanhPho";
            cboThanhPho.DisplayMember = "ThanhPho";

            cboThanhPho.SelectedIndex = -1;
            cboThanhPho.Text = "-- Chọn thành phố --";

        }

        private void LoadReport()
        {
            //Lấy data cho vào dataTable
            dtDsSanPham = new DataTable();
            dtDsSanPham = bd.LayDanhSanPham(ref err);

            reportViewer1.Reset();

            reportViewer1.LocalReport.ReportPath = "D:\\qlbh\\qlbh\\Report_SanPham\\rpDSSP.rdlc";
            //reportViewer1.LocalReport.ReportEmbeddedResource = "qlbh.Report_SanPham.rpDSSP.rdlc";

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource reportDataSource = new ReportDataSource("ds_SanPham", dtDsSanPham);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.RefreshReport();
        }


        private void HienThiReportKhachHang(string thanhPho)
        {
            //Lấy data cho vào dataTable
            DataTable dtDsKhachHang = new DataTable();
            dtDsKhachHang = bd.LayDanhSachKhachHang(ref err, thanhPho);

            reportViewer1.Reset();

            reportViewer1.LocalReport.ReportPath = "D:\\STUDY\\LTUDCSDL\\LTUDCSDL\\BT\\hau\\qlbh\\qlbh\\Report_SanPham\\rpDSKH.rdlc";

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource reportDataSource = new ReportDataSource("DS_KH", dtDsKhachHang);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.RefreshReport();
        }

        private void btndssp_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void btndskh_Click(object sender, EventArgs e)
        {
            if (cboThanhPho.SelectedIndex >= 0)
            {
                HienThiReportKhachHang(cboThanhPho.SelectedValue.ToString());
            }
        }

        private void btndsspdb_Click(object sender, EventArgs e)
        {
            HienThiReportSanPhamDangBan();
        }
    }
}
