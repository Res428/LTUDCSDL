namespace qlbh.TacVu
{
    partial class Frm_NhapHang_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NhapHang_Main));
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.btnLayphieu = new System.Windows.Forms.ToolStripButton();
            this.btnThemPhieu = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cboThuocTinh = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripLabel();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.colMaPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.data_QuanLyBanHang_HocTap2021DataSet1 = new qlbh.Data_QuanLyBanHang_HocTap2021DataSet();
            this.dtptuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpdenNgay = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_QuanLyBanHang_HocTap2021DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1083, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ PHIẾU NHẬP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripTextBox2,
            this.toolStripLabel1,
            this.toolStripTextBox3,
            this.btnLayphieu,
            this.btnThemPhieu,
            this.btnThoat,
            this.toolStripLabel2,
            this.cboThuocTinh,
            this.toolStripTextBox1,
            this.txtSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 40);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1083, 28);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(69, 25);
            this.toolStripButton1.Text = "Từ ngày:";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 28);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(75, 25);
            this.toolStripLabel1.Text = "Đến ngày:";
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 28);
            // 
            // btnLayphieu
            // 
            this.btnLayphieu.Image = ((System.Drawing.Image)(resources.GetObject("btnLayphieu.Image")));
            this.btnLayphieu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLayphieu.Name = "btnLayphieu";
            this.btnLayphieu.Size = new System.Drawing.Size(101, 25);
            this.btnLayphieu.Text = "Lấy dữ liệu";
            this.btnLayphieu.Click += new System.EventHandler(this.btnLayphieu_Click);
            // 
            // btnThemPhieu
            // 
            this.btnThemPhieu.Image = ((System.Drawing.Image)(resources.GetObject("btnThemPhieu.Image")));
            this.btnThemPhieu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemPhieu.Name = "btnThemPhieu";
            this.btnThemPhieu.Size = new System.Drawing.Size(146, 25);
            this.btnThemPhieu.Text = "Thêm Phiếu Nhập";
            this.btnThemPhieu.Click += new System.EventHandler(this.btnThemPhieu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(67, 25);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(113, 25);
            this.toolStripLabel2.Text = "Chọn thuộc tính";
            // 
            // cboThuocTinh
            // 
            this.cboThuocTinh.Name = "cboThuocTinh";
            this.cboThuocTinh.Size = new System.Drawing.Size(121, 28);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(53, 25);
            this.toolStripTextBox1.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 28);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhieuNhap,
            this.colNgayNhap,
            this.colMaNV,
            this.colMoTa,
            this.colTrangThai});
            this.dgvPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(0, 68);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.RowHeadersVisible = false;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(1083, 517);
            this.dgvPhieuNhap.TabIndex = 3;
            this.dgvPhieuNhap.Click += new System.EventHandler(this.dgvPhieuNhap_Click);
            // 
            // colMaPhieuNhap
            // 
            this.colMaPhieuNhap.DataPropertyName = "MaPhieuNhap";
            this.colMaPhieuNhap.HeaderText = "Mã Phiếu Nhập";
            this.colMaPhieuNhap.Name = "colMaPhieuNhap";
            // 
            // colNgayNhap
            // 
            this.colNgayNhap.DataPropertyName = "NgayNhap";
            this.colNgayNhap.HeaderText = "Ngày nhập";
            this.colNgayNhap.Name = "colNgayNhap";
            // 
            // colMaNV
            // 
            this.colMaNV.DataPropertyName = "MaNV";
            this.colMaNV.HeaderText = "MaNV";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Width = 150;
            // 
            // colMoTa
            // 
            this.colMoTa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMoTa.DataPropertyName = "MoTa";
            this.colMoTa.HeaderText = "Mô tả";
            this.colMoTa.Name = "colMoTa";
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTrangThai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // data_QuanLyBanHang_HocTap2021DataSet1
            // 
            this.data_QuanLyBanHang_HocTap2021DataSet1.DataSetName = "Data_QuanLyBanHang_HocTap2021DataSet";
            this.data_QuanLyBanHang_HocTap2021DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtptuNgay
            // 
            this.dtptuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtptuNgay.Location = new System.Drawing.Point(74, 44);
            this.dtptuNgay.Name = "dtptuNgay";
            this.dtptuNgay.Size = new System.Drawing.Size(101, 20);
            this.dtptuNgay.TabIndex = 4;
            // 
            // dtpdenNgay
            // 
            this.dtpdenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdenNgay.Location = new System.Drawing.Point(252, 44);
            this.dtpdenNgay.Name = "dtpdenNgay";
            this.dtpdenNgay.Size = new System.Drawing.Size(101, 20);
            this.dtpdenNgay.TabIndex = 5;
            // 
            // Frm_NhapHang_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 585);
            this.ControlBox = false;
            this.Controls.Add(this.dtpdenNgay);
            this.Controls.Add(this.dtptuNgay);
            this.Controls.Add(this.dgvPhieuNhap);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_NhapHang_Main";
            this.Text = "Frm_NhapHang_Main";
            this.Load += new System.EventHandler(this.Frm_NhapHang_Main_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_QuanLyBanHang_HocTap2021DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThemPhieu;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnLayphieu;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTrangThai;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cboThuocTinh;
        private System.Windows.Forms.ToolStripLabel toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private Data_QuanLyBanHang_HocTap2021DataSet data_QuanLyBanHang_HocTap2021DataSet1;
        private System.Windows.Forms.DateTimePicker dtptuNgay;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.DateTimePicker dtpdenNgay;
    }
}