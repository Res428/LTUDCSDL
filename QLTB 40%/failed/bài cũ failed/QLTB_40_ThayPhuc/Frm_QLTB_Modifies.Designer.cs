namespace QLTB_40_ThayPhuc
{
    partial class Frm_QLTB_Modifies
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
            this.cboTinhtrang = new System.Windows.Forms.ComboBox();
            this.txtNguoiMuon = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoaiTB = new System.Windows.Forms.TextBox();
            this.txtTenTB = new System.Windows.Forms.TextBox();
            this.txtMaTB = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblErr = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboTinhtrang
            // 
            this.cboTinhtrang.FormattingEnabled = true;
            this.cboTinhtrang.Location = new System.Drawing.Point(73, 210);
            this.cboTinhtrang.Name = "cboTinhtrang";
            this.cboTinhtrang.Size = new System.Drawing.Size(247, 21);
            this.cboTinhtrang.TabIndex = 53;
            // 
            // txtNguoiMuon
            // 
            this.txtNguoiMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiMuon.Location = new System.Drawing.Point(73, 262);
            this.txtNguoiMuon.Name = "txtNguoiMuon";
            this.txtNguoiMuon.Size = new System.Drawing.Size(248, 22);
            this.txtNguoiMuon.TabIndex = 44;
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(220, 301);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 46;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.Location = new System.Drawing.Point(92, 301);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapnhat.TabIndex = 45;
            this.btnCapnhat.Text = "Cập Nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 52;
            this.label5.Text = "Người mượn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 51;
            this.label4.Text = "Tình trạng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 50;
            this.label3.Text = "Loại TB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Tên TB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Mã TB";
            // 
            // txtLoaiTB
            // 
            this.txtLoaiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiTB.Location = new System.Drawing.Point(73, 149);
            this.txtLoaiTB.Name = "txtLoaiTB";
            this.txtLoaiTB.Size = new System.Drawing.Size(248, 22);
            this.txtLoaiTB.TabIndex = 43;
            // 
            // txtTenTB
            // 
            this.txtTenTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTB.Location = new System.Drawing.Point(73, 94);
            this.txtTenTB.Name = "txtTenTB";
            this.txtTenTB.Size = new System.Drawing.Size(248, 22);
            this.txtTenTB.TabIndex = 42;
            // 
            // txtMaTB
            // 
            this.txtMaTB.Enabled = false;
            this.txtMaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTB.Location = new System.Drawing.Point(73, 36);
            this.txtMaTB.Name = "txtMaTB";
            this.txtMaTB.Size = new System.Drawing.Size(248, 22);
            this.txtMaTB.TabIndex = 47;
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblErr});
            this.statusStrip1.Location = new System.Drawing.Point(0, 332);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(375, 22);
            this.statusStrip1.TabIndex = 54;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblErr
            // 
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(28, 17);
            this.lblErr.Text = "...";
            // 
            // Frm_QLTB_Modifies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 354);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cboTinhtrang);
            this.Controls.Add(this.txtNguoiMuon);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLoaiTB);
            this.Controls.Add(this.txtTenTB);
            this.Controls.Add(this.txtMaTB);
            this.Name = "Frm_QLTB_Modifies";
            this.Text = "Frm_QLTB_Modifies";
            this.Load += new System.EventHandler(this.Frm_QLTB_Modifies_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTinhtrang;
        private System.Windows.Forms.TextBox txtNguoiMuon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoaiTB;
        private System.Windows.Forms.TextBox txtTenTB;
        private System.Windows.Forms.TextBox txtMaTB;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblErr;
    }
}