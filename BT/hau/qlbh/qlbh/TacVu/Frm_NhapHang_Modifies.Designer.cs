namespace qlbh.TacVu
{
    partial class Frm_NhapHang_Modifies
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnHoanTatPhieuNhap = new System.Windows.Forms.Button();
            this.btnThemSanPham = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cboDonViTinh = new System.Windows.Forms.ComboBox();
            this.cboSanPham = new System.Windows.Forms.ComboBox();
            this.cboLoaiSanPham = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.colTenDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTongSoLuong = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTongThanhTien = new System.Windows.Forms.ToolStripStatusLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.colTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.txtSoLuongNhap = new System.Windows.Forms.TextBox();
            this.txtMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.colSoLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.colMaPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvChiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.colMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDel = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuNhap)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(197, 20);
            this.toolStripStatusLabel1.Text = "Số lượng sản phẩm của phiếu: ";
            // 
            // btnHoanTatPhieuNhap
            // 
            this.btnHoanTatPhieuNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHoanTatPhieuNhap.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnHoanTatPhieuNhap.Location = new System.Drawing.Point(868, 217);
            this.btnHoanTatPhieuNhap.Name = "btnHoanTatPhieuNhap";
            this.btnHoanTatPhieuNhap.Size = new System.Drawing.Size(180, 78);
            this.btnHoanTatPhieuNhap.TabIndex = 9;
            this.btnHoanTatPhieuNhap.Text = "Hoàn tất phiếu nhập";
            this.btnHoanTatPhieuNhap.UseVisualStyleBackColor = false;
            this.btnHoanTatPhieuNhap.Click += new System.EventHandler(this.btnHoanTatPhieuNhap_Click);
            // 
            // btnThemSanPham
            // 
            this.btnThemSanPham.Location = new System.Drawing.Point(1339, 47);
            this.btnThemSanPham.Name = "btnThemSanPham";
            this.btnThemSanPham.Size = new System.Drawing.Size(54, 32);
            this.btnThemSanPham.TabIndex = 8;
            this.btnThemSanPham.Text = "+";
            this.btnThemSanPham.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.Location = new System.Drawing.Point(1161, 259);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(144, 36);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Location = new System.Drawing.Point(1161, 217);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(144, 36);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboDonViTinh
            // 
            this.cboDonViTinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDonViTinh.FormattingEnabled = true;
            this.cboDonViTinh.Location = new System.Drawing.Point(1084, 138);
            this.cboDonViTinh.Name = "cboDonViTinh";
            this.cboDonViTinh.Size = new System.Drawing.Size(221, 32);
            this.cboDonViTinh.TabIndex = 4;
            // 
            // cboSanPham
            // 
            this.cboSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSanPham.FormattingEnabled = true;
            this.cboSanPham.Location = new System.Drawing.Point(693, 100);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.Size = new System.Drawing.Size(552, 32);
            this.cboSanPham.TabIndex = 2;
            // 
            // cboLoaiSanPham
            // 
            this.cboLoaiSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLoaiSanPham.FormattingEnabled = true;
            this.cboLoaiSanPham.Location = new System.Drawing.Point(693, 62);
            this.cboLoaiSanPham.Name = "cboLoaiSanPham";
            this.cboLoaiSanPham.Size = new System.Drawing.Size(612, 32);
            this.cboLoaiSanPham.TabIndex = 1;
            this.cboLoaiSanPham.SelectedIndexChanged += new System.EventHandler(this.cboLoaiSanPham_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(559, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 24);
            this.label9.TabIndex = 5;
            this.label9.Text = "Đơn giá nhập:";
            // 
            // colTenDonViTinh
            // 
            this.colTenDonViTinh.DataPropertyName = "TenDonViTinh";
            this.colTenDonViTinh.HeaderText = "Đơn vị tính";
            this.colTenDonViTinh.Name = "colTenDonViTinh";
            this.colTenDonViTinh.ReadOnly = true;
            this.colTenDonViTinh.Width = 150;
            // 
            // colMaDonViTinh
            // 
            this.colMaDonViTinh.DataPropertyName = "MaDonViTinh";
            this.colMaDonViTinh.HeaderText = "Đơn vị Tính";
            this.colMaDonViTinh.Name = "colMaDonViTinh";
            this.colMaDonViTinh.ReadOnly = true;
            this.colMaDonViTinh.Visible = false;
            // 
            // colThanhTien
            // 
            this.colThanhTien.DataPropertyName = "ThanhTien";
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            this.colThanhTien.Width = 150;
            // 
            // colDonGiaNhap
            // 
            this.colDonGiaNhap.DataPropertyName = "DonGiaNhap";
            this.colDonGiaNhap.HeaderText = "Đơn giá";
            this.colDonGiaNhap.Name = "colDonGiaNhap";
            this.colDonGiaNhap.ReadOnly = true;
            this.colDonGiaNhap.Width = 150;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMoTa.Location = new System.Drawing.Point(160, 217);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(702, 78);
            this.txtMoTa.TabIndex = 6;
            this.txtMoTa.TextChanged += new System.EventHandler(this.txtMoTa_TextChanged);
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(160, 106);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(376, 29);
            this.dtpNgayNhap.TabIndex = 0;
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Location = new System.Drawing.Point(156, 163);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(67, 24);
            this.lblNhanVien.TabIndex = 2;
            this.lblNhanVien.Text = "dgdsfg";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblTongSoLuong,
            this.toolStripStatusLabel3,
            this.lblTongThanhTien});
            this.statusStrip1.Location = new System.Drawing.Point(0, 617);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1313, 25);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTongSoLuong
            // 
            this.lblTongSoLuong.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTongSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTongSoLuong.Name = "lblTongSoLuong";
            this.lblTongSoLuong.Size = new System.Drawing.Size(36, 20);
            this.lblTongSoLuong.Text = "000";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(114, 20);
            this.toolStripStatusLabel3.Text = "Tổng thành tiền: ";
            // 
            // lblTongThanhTien
            // 
            this.lblTongThanhTien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTongThanhTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTongThanhTien.Name = "lblTongThanhTien";
            this.lblTongThanhTien.Size = new System.Drawing.Size(135, 20);
            this.lblTongThanhTien.Text = "000,000,000 VNĐ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mô tả:";
            // 
            // colTenSanPham
            // 
            this.colTenSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenSanPham.DataPropertyName = "TenSanPham";
            this.colTenSanPham.HeaderText = "Tên sản phẩm";
            this.colTenSanPham.Name = "colTenSanPham";
            this.colTenSanPham.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày nhập:";
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDonGiaNhap.Location = new System.Drawing.Point(693, 182);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(612, 29);
            this.txtDonGiaNhap.TabIndex = 5;
            this.txtDonGiaNhap.Text = "0";
            this.txtDonGiaNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSoLuongNhap
            // 
            this.txtSoLuongNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoLuongNhap.Location = new System.Drawing.Point(693, 141);
            this.txtSoLuongNhap.Name = "txtSoLuongNhap";
            this.txtSoLuongNhap.Size = new System.Drawing.Size(276, 29);
            this.txtSoLuongNhap.TabIndex = 3;
            this.txtSoLuongNhap.Text = "1";
            this.txtSoLuongNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.Enabled = false;
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(160, 62);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(376, 29);
            this.txtMaPhieuNhap.TabIndex = 1;
            // 
            // colSoLuongNhap
            // 
            this.colSoLuongNhap.DataPropertyName = "SoLuongNhap";
            this.colSoLuongNhap.HeaderText = "Số lượng";
            this.colSoLuongNhap.Name = "colSoLuongNhap";
            this.colSoLuongNhap.ReadOnly = true;
            this.colSoLuongNhap.Width = 150;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(548, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số lượng nhập:";
            // 
            // colMaPhieuNhap
            // 
            this.colMaPhieuNhap.DataPropertyName = "MaPhieuNhap";
            this.colMaPhieuNhap.HeaderText = "Mã phiếu";
            this.colMaPhieuNhap.Name = "colMaPhieuNhap";
            this.colMaPhieuNhap.ReadOnly = true;
            this.colMaPhieuNhap.Visible = false;
            // 
            // colSTT
            // 
            this.colSTT.DataPropertyName = "STT";
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            this.colSTT.Width = 60;
            // 
            // dgvChiTietPhieuNhap
            // 
            this.dgvChiTietPhieuNhap.AllowUserToAddRows = false;
            this.dgvChiTietPhieuNhap.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvChiTietPhieuNhap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChiTietPhieuNhap.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTietPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaPhieuNhap,
            this.colMaSanPham,
            this.colTenSanPham,
            this.colSoLuongNhap,
            this.colDonGiaNhap,
            this.colThanhTien,
            this.colMaDonViTinh,
            this.colTenDonViTinh});
            this.dgvChiTietPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietPhieuNhap.Location = new System.Drawing.Point(0, 302);
            this.dgvChiTietPhieuNhap.Name = "dgvChiTietPhieuNhap";
            this.dgvChiTietPhieuNhap.ReadOnly = true;
            this.dgvChiTietPhieuNhap.RowHeadersVisible = false;
            this.dgvChiTietPhieuNhap.RowTemplate.Height = 32;
            this.dgvChiTietPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietPhieuNhap.Size = new System.Drawing.Size(1313, 340);
            this.dgvChiTietPhieuNhap.TabIndex = 4;
            this.dgvChiTietPhieuNhap.Click += new System.EventHandler(this.dgvChiTietPhieuNhap_Click);
            // 
            // colMaSanPham
            // 
            this.colMaSanPham.DataPropertyName = "MaSanPham";
            this.colMaSanPham.HeaderText = "Mã sản phẩm";
            this.colMaSanPham.Name = "colMaSanPham";
            this.colMaSanPham.ReadOnly = true;
            this.colMaSanPham.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(975, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Đơn vi tính:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(586, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sản phẩm:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(549, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Loại sản phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu nhập:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnThemSP);
            this.panel1.Controls.Add(this.btnHoanTatPhieuNhap);
            this.panel1.Controls.Add(this.btnThemSanPham);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.cboDonViTinh);
            this.panel1.Controls.Add(this.cboSanPham);
            this.panel1.Controls.Add(this.cboLoaiSanPham);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtMoTa);
            this.panel1.Controls.Add(this.dtpNgayNhap);
            this.panel1.Controls.Add(this.lblNhanVien);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDonGiaNhap);
            this.panel1.Controls.Add(this.txtSoLuongNhap);
            this.panel1.Controls.Add(this.txtMaPhieuNhap);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1313, 302);
            this.panel1.TabIndex = 3;
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.BackColor = System.Drawing.Color.Red;
            this.btnDel.Location = new System.Drawing.Point(1054, 217);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(101, 78);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1313, 53);
            this.label10.TabIndex = 11;
            this.label10.Text = "Nhập Hàng";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThemSP
            // 
            this.btnThemSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemSP.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThemSP.Location = new System.Drawing.Point(1251, 100);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(56, 32);
            this.btnThemSP.TabIndex = 10;
            this.btnThemSP.Text = "+";
            this.btnThemSP.UseVisualStyleBackColor = false;
            // 
            // Frm_NhapHang_Modifies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 642);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvChiTietPhieuNhap);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_NhapHang_Modifies";
            this.Text = "Frm_NhapHang_Modifies";
            this.Load += new System.EventHandler(this.Frm_NhapHang_Modifies_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuNhap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnHoanTatPhieuNhap;
        private System.Windows.Forms.Button btnThemSanPham;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboDonViTinh;
        private System.Windows.Forms.ComboBox cboSanPham;
        private System.Windows.Forms.ComboBox cboLoaiSanPham;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGiaNhap;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTongSoLuong;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblTongThanhTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSanPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.TextBox txtSoLuongNhap;
        private System.Windows.Forms.TextBox txtMaPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongNhap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridView dgvChiTietPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSanPham;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDel;
    }
}