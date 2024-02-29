namespace QuanLyBanHang.WinForm.HeThong
{
    partial class FrmQuanLyNguoiDung_Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyNguoiDung_Main));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLuongCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCongViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NapLai = new System.Windows.Forms.ToolStripButton();
            this.Them = new System.Windows.Forms.ToolStripButton();
            this.Sua = new System.Windows.Forms.ToolStripButton();
            this.Xoa = new System.Windows.Forms.ToolStripButton();
            this.Thoat = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaNV,
            this.colHoTenNV,
            this.colPhai,
            this.colLuongCB,
            this.colCongViec,
            this.colMaKV});
            this.dataGridView1.Location = new System.Drawing.Point(0, 30);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 32;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 395);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // colSTT
            // 
            this.colSTT.DataPropertyName = "STT";
            this.colSTT.FillWeight = 35.13174F;
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Width = 40;
            // 
            // colMaNV
            // 
            this.colMaNV.DataPropertyName = "MaNV";
            this.colMaNV.FillWeight = 92.88183F;
            this.colMaNV.HeaderText = "MaNV";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Width = 106;
            // 
            // colHoTenNV
            // 
            this.colHoTenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colHoTenNV.DataPropertyName = "HoTenNV";
            this.colHoTenNV.FillWeight = 69.83004F;
            this.colHoTenNV.HeaderText = "HoTenNV";
            this.colHoTenNV.Name = "colHoTenNV";
            // 
            // colPhai
            // 
            this.colPhai.DataPropertyName = "Phai";
            this.colPhai.FillWeight = 27.41616F;
            this.colPhai.HeaderText = "Phai";
            this.colPhai.Name = "colPhai";
            this.colPhai.Width = 31;
            // 
            // colLuongCB
            // 
            this.colLuongCB.DataPropertyName = "LuongCB";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "#,###0";
            dataGridViewCellStyle11.NullValue = "0";
            this.colLuongCB.DefaultCellStyle = dataGridViewCellStyle11;
            this.colLuongCB.FillWeight = 146.1116F;
            this.colLuongCB.HeaderText = "LuongCB";
            this.colLuongCB.Name = "colLuongCB";
            this.colLuongCB.Width = 167;
            // 
            // colCongViec
            // 
            this.colCongViec.DataPropertyName = "CongViec";
            this.colCongViec.FillWeight = 177.071F;
            this.colCongViec.HeaderText = "Công việc";
            this.colCongViec.Name = "colCongViec";
            this.colCongViec.Width = 150;
            // 
            // colMaKV
            // 
            this.colMaKV.DataPropertyName = "MaKV";
            this.colMaKV.FillWeight = 151.5576F;
            this.colMaKV.HeaderText = "Khu Vực";
            this.colMaKV.Name = "colMaKV";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NapLai,
            this.Them,
            this.Sua,
            this.Xoa,
            this.Thoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NapLai
            // 
            this.NapLai.Image = ((System.Drawing.Image)(resources.GetObject("NapLai.Image")));
            this.NapLai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NapLai.Name = "NapLai";
            this.NapLai.Size = new System.Drawing.Size(76, 22);
            this.NapLai.Text = "Nạp lại";
            // 
            // Them
            // 
            this.Them.Image = ((System.Drawing.Image)(resources.GetObject("Them.Image")));
            this.Them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(55, 22);
            this.Them.Text = "Thêm";
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // Sua
            // 
            this.Sua.Image = ((System.Drawing.Image)(resources.GetObject("Sua.Image")));
            this.Sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(48, 22);
            this.Sua.Text = "Sửa";
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // Xoa
            // 
            this.Xoa.Image = ((System.Drawing.Image)(resources.GetObject("Xoa.Image")));
            this.Xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(48, 22);
            this.Xoa.Text = "Xóa";
            // 
            // Thoat
            // 
            this.Thoat.Image = ((System.Drawing.Image)(resources.GetObject("Thoat.Image")));
            this.Thoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(62, 22);
            this.Thoat.Text = "Thoát";
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(28, 17);
            this.toolStripStatusLabel1.Text = "...";
            // 
            // FrmQuanLyNguoiDung_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmQuanLyNguoiDung_Main";
            this.Text = "FrmQuanLyNguoiDung_Main";
            this.Load += new System.EventHandler(this.FrmQuanLyNguoiDung_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton NapLai;
        private System.Windows.Forms.ToolStripButton Sua;
        private System.Windows.Forms.ToolStripButton Xoa;
        private System.Windows.Forms.ToolStripButton Thoat;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton Them;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLuongCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCongViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKV;
    }
}