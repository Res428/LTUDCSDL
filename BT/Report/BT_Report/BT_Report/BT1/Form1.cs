using BT_Report.Business_Layer;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BT_Report
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bll_Rpt_KhachHang brptkh;
        SqlCommand cmd;
        SqlConnection cnn;
        SqlDataAdapter da;
        DataTable dt;

        private DataTable LayDuLieuKhachHang(int makh)
        {
            cmd = new SqlCommand("sp_rptkhachhangSelect", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@makh", SqlDbType.Int).Value = makh;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        private void dudulieuvaocombox()
        {
            DataTable dtdulieu = new DataTable();
            dtdulieu = LayDuLieuKhachHang(-1);
            cbokhachhang.DataSource = dtdulieu;
            cbokhachhang.ValueMember = "makh";
            cbokhachhang.DisplayMember = "tencty";

        }
        private void loaddulieuvaoreport(int makh)
        {
            DataTable table = new DataTable();
            table.Clear();
            table = LayDuLieuKhachHang(makh);
            //reset lai khung hiển thị report
            reportViewer1.Reset();
            //gán tên report cần hiển thị trong khung nhìn viewer
            reportViewer1.LocalReport.ReportPath = @"D:\STUDY\LTUDCSDL\LTUDCSDL\BT\Report\BT_Report\BT_Report\BT1\report\rpt_KhachHang.rdlc";
            //làm sạch khung nhìn
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource newDataSource = new
            ReportDataSource("ds_khachhang", table);
            reportViewer1.LocalReport.DataSources.Add(newDataSource);
            //lam tuoi report
            // rptViewer.LocalReport.DataSources.Add(new ReportDataSource("ds_sanpham", table));
            reportViewer1.RefreshReport();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connectionstring);
            dudulieuvaocombox();
            this.reportViewer1.RefreshReport();
            loaddulieuvaoreport(
            cbokhachhang.SelectedValue.ToString());
        }
    }
}
