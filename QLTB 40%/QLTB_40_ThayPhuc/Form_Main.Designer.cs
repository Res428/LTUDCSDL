
namespace QLTB_40_ThayPhuc
{
    partial class Form_Main
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.hethong = new System.Windows.Forms.ToolStripSplitButton();
            this.phânQuyềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.danhmuc = new System.Windows.Forms.ToolStripSplitButton();
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mmnuQLTB = new System.Windows.Forms.ToolStripMenuItem();
            this.err = new System.Windows.Forms.StatusStrip();
            this.lblErr = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.toolStrip1.SuspendLayout();
            this.err.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hethong,
            this.danhmuc});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // hethong
            // 
            this.hethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phânQuyềnToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.btnThoat});
            this.hethong.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.hethong.Name = "hethong";
            this.hethong.Size = new System.Drawing.Size(114, 28);
            this.hethong.Text = "Hệ Thống";
            // 
            // phânQuyềnToolStripMenuItem
            // 
            this.phânQuyềnToolStripMenuItem.Name = "phânQuyềnToolStripMenuItem";
            this.phânQuyềnToolStripMenuItem.Size = new System.Drawing.Size(190, 28);
            this.phânQuyềnToolStripMenuItem.Text = "Phân Quyền";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(190, 28);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            // 
            // btnThoat
            // 
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(190, 28);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // danhmuc
            // 
            this.danhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKhachHang,
            this.mmnuQLTB});
            this.danhmuc.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.danhmuc.Name = "danhmuc";
            this.danhmuc.Size = new System.Drawing.Size(114, 28);
            this.danhmuc.Text = "Danh Mục";
            // 
            // mnuKhachHang
            // 
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.Size = new System.Drawing.Size(333, 28);
            this.mnuKhachHang.Text = "Khách Hàng";
            this.mnuKhachHang.Click += new System.EventHandler(this.loaithietbi_Click);
            // 
            // mmnuQLTB
            // 
            this.mmnuQLTB.Name = "mmnuQLTB";
            this.mmnuQLTB.Size = new System.Drawing.Size(333, 28);
            this.mmnuQLTB.Text = "Quản Lý Thiết Bị";
            this.mmnuQLTB.Click += new System.EventHandler(this.mmnuQLTB_Click);
            // 
            // err
            // 
            this.err.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblErr});
            this.err.Location = new System.Drawing.Point(0, 428);
            this.err.Name = "err";
            this.err.Size = new System.Drawing.Size(800, 22);
            this.err.TabIndex = 1;
            this.err.Text = "...";
            // 
            // lblErr
            // 
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(28, 17);
            this.lblErr.Text = "...";
            // 
            // tabControl1
            // 
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = -1;
            this.tabControl1.Size = new System.Drawing.Size(800, 397);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Text = "tabControl1";
            this.tabControl1.TabItemClose += new DevComponents.DotNetBar.TabStrip.UserActionEventHandler(this.tabControl1_TabItemClose);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.err);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.err.ResumeLayout(false);
            this.err.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip err;
        private System.Windows.Forms.ToolStripSplitButton hethong;
        private System.Windows.Forms.ToolStripSplitButton danhmuc;
        private System.Windows.Forms.ToolStripMenuItem phânQuyềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mmnuQLTB;
        private DevComponents.DotNetBar.TabControl tabControl1;
        private System.Windows.Forms.ToolStripStatusLabel lblErr;
    }
}