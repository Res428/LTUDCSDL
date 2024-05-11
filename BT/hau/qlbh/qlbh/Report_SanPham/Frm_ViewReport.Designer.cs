namespace qlbh.Report
{
    partial class Frm_ViewReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboThanhPho = new System.Windows.Forms.ComboBox();
            this.btndsspdb = new System.Windows.Forms.Button();
            this.btndskh = new System.Windows.Forms.Button();
            this.btndssp = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn thành phố";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            // 
            // cboThanhPho
            // 
            this.cboThanhPho.FormattingEnabled = true;
            this.cboThanhPho.Location = new System.Drawing.Point(4, 135);
            this.cboThanhPho.Name = "cboThanhPho";
            this.cboThanhPho.Size = new System.Drawing.Size(190, 21);
            this.cboThanhPho.TabIndex = 3;
            // 
            // btndsspdb
            // 
            this.btndsspdb.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btndsspdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndsspdb.Location = new System.Drawing.Point(4, 221);
            this.btndsspdb.Name = "btndsspdb";
            this.btndsspdb.Size = new System.Drawing.Size(190, 31);
            this.btndsspdb.TabIndex = 6;
            this.btndsspdb.Text = "Danh sách sp đang bán";
            this.btndsspdb.UseVisualStyleBackColor = false;
            this.btndsspdb.Click += new System.EventHandler(this.btndsspdb_Click);
            // 
            // btndskh
            // 
            this.btndskh.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btndskh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndskh.Location = new System.Drawing.Point(4, 173);
            this.btndskh.Name = "btndskh";
            this.btndskh.Size = new System.Drawing.Size(190, 31);
            this.btndskh.TabIndex = 7;
            this.btndskh.Text = "Danh sách khách hàng";
            this.btndskh.UseVisualStyleBackColor = false;
            this.btndskh.Click += new System.EventHandler(this.btndskh_Click);
            // 
            // btndssp
            // 
            this.btndssp.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btndssp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndssp.Location = new System.Drawing.Point(4, 71);
            this.btndssp.Name = "btndssp";
            this.btndssp.Size = new System.Drawing.Size(190, 31);
            this.btndssp.TabIndex = 8;
            this.btndssp.Text = "Danh sách sản phẩm";
            this.btndssp.UseVisualStyleBackColor = false;
            this.btndssp.Click += new System.EventHandler(this.btndssp_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.Location = new System.Drawing.Point(230, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 379);
            this.reportViewer1.TabIndex = 0;
            // 
            // Frm_ViewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 379);
            this.Controls.Add(this.btndsspdb);
            this.Controls.Add(this.btndskh);
            this.Controls.Add(this.btndssp);
            this.Controls.Add(this.cboThanhPho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_ViewReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Report";
            this.Load += new System.EventHandler(this.Report_test_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboThanhPho;
        private System.Windows.Forms.Button btndsspdb;
        private System.Windows.Forms.Button btndskh;
        private System.Windows.Forms.Button btndssp;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}