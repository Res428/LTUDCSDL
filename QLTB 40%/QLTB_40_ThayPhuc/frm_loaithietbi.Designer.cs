
namespace QLTB_40_ThayPhuc
{
    partial class frm_loaithietbi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_loaithietbi));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.nap = new System.Windows.Forms.ToolStripButton();
            this.tsbthem = new System.Windows.Forms.ToolStripButton();
            this.tsbsua = new System.Windows.Forms.ToolStripButton();
            this.tsbxoa = new System.Windows.Forms.ToolStripButton();
            this.tsbthoat = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dgvLoaiTB = new System.Windows.Forms.DataGridView();
            this.colMaTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTB)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nap,
            this.tsbthem,
            this.tsbsua,
            this.tsbxoa,
            this.tsbthoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(640, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // nap
            // 
            this.nap.Image = ((System.Drawing.Image)(resources.GetObject("nap.Image")));
            this.nap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nap.Name = "nap";
            this.nap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nap.Size = new System.Drawing.Size(55, 22);
            this.nap.Text = "Nạp ";
            this.nap.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.nap.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // tsbthem
            // 
            this.tsbthem.Image = ((System.Drawing.Image)(resources.GetObject("tsbthem.Image")));
            this.tsbthem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbthem.Name = "tsbthem";
            this.tsbthem.Size = new System.Drawing.Size(55, 22);
            this.tsbthem.Text = "Thêm";
            this.tsbthem.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.tsbthem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsbthem.Click += new System.EventHandler(this.tsbthem_Click);
            // 
            // tsbsua
            // 
            this.tsbsua.Image = ((System.Drawing.Image)(resources.GetObject("tsbsua.Image")));
            this.tsbsua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbsua.Name = "tsbsua";
            this.tsbsua.Size = new System.Drawing.Size(48, 22);
            this.tsbsua.Text = "Sửa";
            this.tsbsua.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.tsbsua.Click += new System.EventHandler(this.tsbsua_Click);
            // 
            // tsbxoa
            // 
            this.tsbxoa.Image = ((System.Drawing.Image)(resources.GetObject("tsbxoa.Image")));
            this.tsbxoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbxoa.Name = "tsbxoa";
            this.tsbxoa.Size = new System.Drawing.Size(48, 22);
            this.tsbxoa.Text = "Xóa";
            this.tsbxoa.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.tsbxoa.Click += new System.EventHandler(this.tsbxoa_Click);
            // 
            // tsbthoat
            // 
            this.tsbthoat.Image = ((System.Drawing.Image)(resources.GetObject("tsbthoat.Image")));
            this.tsbthoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbthoat.Name = "tsbthoat";
            this.tsbthoat.Size = new System.Drawing.Size(62, 22);
            this.tsbthoat.Text = "Thoát";
            this.tsbthoat.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.tsbthoat.Click += new System.EventHandler(this.tsbthoat_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 411);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(640, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dgvLoaiTB
            // 
            this.dgvLoaiTB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiTB.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvLoaiTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiTB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaTB,
            this.colTenTB,
            this.colLoaiTB});
            this.dgvLoaiTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoaiTB.Location = new System.Drawing.Point(0, 25);
            this.dgvLoaiTB.Name = "dgvLoaiTB";
            this.dgvLoaiTB.RowHeadersVisible = false;
            this.dgvLoaiTB.Size = new System.Drawing.Size(640, 386);
            this.dgvLoaiTB.TabIndex = 2;
            this.dgvLoaiTB.Click += new System.EventHandler(this.dgvLoaiTB_Click);
            // 
            // colMaTB
            // 
            this.colMaTB.DataPropertyName = "MaTB";
            this.colMaTB.HeaderText = "Mã Thiết Bị";
            this.colMaTB.Name = "colMaTB";
            // 
            // colTenTB
            // 
            this.colTenTB.DataPropertyName = "TenTB";
            this.colTenTB.HeaderText = "Tên Thiết Bị";
            this.colTenTB.Name = "colTenTB";
            // 
            // colLoaiTB
            // 
            this.colLoaiTB.DataPropertyName = "LoaiTB";
            this.colLoaiTB.HeaderText = "Loại";
            this.colLoaiTB.Name = "colLoaiTB";
            // 
            // frm_loaithietbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 433);
            this.Controls.Add(this.dgvLoaiTB);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frm_loaithietbi";
            this.Text = "frm_loaithietbi";
            this.Load += new System.EventHandler(this.frm_loaithietbi_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbthem;
        private System.Windows.Forms.ToolStripButton tsbsua;
        private System.Windows.Forms.ToolStripButton tsbxoa;
        private System.Windows.Forms.ToolStripButton tsbthoat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton nap;
        private System.Windows.Forms.DataGridView dgvLoaiTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiTB;
    }
}