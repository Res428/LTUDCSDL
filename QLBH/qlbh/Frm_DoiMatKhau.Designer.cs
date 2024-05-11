namespace qlbh
{
    partial class Frm_DoiMatKhau
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
            this.grpReset = new System.Windows.Forms.GroupBox();
            this.btnCaplai = new System.Windows.Forms.Button();
            this.cboTaikhoan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDoimk = new System.Windows.Forms.GroupBox();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.txtMatkhau02 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatkhau01 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpReset.SuspendLayout();
            this.grpDoimk.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpReset
            // 
            this.grpReset.Controls.Add(this.btnCaplai);
            this.grpReset.Controls.Add(this.cboTaikhoan);
            this.grpReset.Controls.Add(this.label1);
            this.grpReset.Location = new System.Drawing.Point(12, 12);
            this.grpReset.Name = "grpReset";
            this.grpReset.Size = new System.Drawing.Size(555, 151);
            this.grpReset.TabIndex = 0;
            this.grpReset.TabStop = false;
            this.grpReset.Text = "Reset Mật Khẩu";
            // 
            // btnCaplai
            // 
            this.btnCaplai.Location = new System.Drawing.Point(396, 65);
            this.btnCaplai.Name = "btnCaplai";
            this.btnCaplai.Size = new System.Drawing.Size(75, 23);
            this.btnCaplai.TabIndex = 2;
            this.btnCaplai.Text = "Cấp lại mk";
            this.btnCaplai.UseVisualStyleBackColor = true;
            this.btnCaplai.Click += new System.EventHandler(this.btnCaplai_Click);
            // 
            // cboTaikhoan
            // 
            this.cboTaikhoan.FormattingEnabled = true;
            this.cboTaikhoan.Location = new System.Drawing.Point(45, 65);
            this.cboTaikhoan.Name = "cboTaikhoan";
            this.cboTaikhoan.Size = new System.Drawing.Size(268, 21);
            this.cboTaikhoan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn tk";
            // 
            // grpDoimk
            // 
            this.grpDoimk.Controls.Add(this.btnCapnhat);
            this.grpDoimk.Controls.Add(this.txtMatkhau02);
            this.grpDoimk.Controls.Add(this.label3);
            this.grpDoimk.Controls.Add(this.txtMatkhau01);
            this.grpDoimk.Controls.Add(this.label2);
            this.grpDoimk.Location = new System.Drawing.Point(12, 169);
            this.grpDoimk.Name = "grpDoimk";
            this.grpDoimk.Size = new System.Drawing.Size(555, 188);
            this.grpDoimk.TabIndex = 1;
            this.grpDoimk.TabStop = false;
            this.grpDoimk.Text = "Đổi Mật Khẩu";
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(396, 74);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapnhat.TabIndex = 3;
            this.btnCapnhat.Text = "Cấp nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // txtMatkhau02
            // 
            this.txtMatkhau02.Location = new System.Drawing.Point(106, 91);
            this.txtMatkhau02.Name = "txtMatkhau02";
            this.txtMatkhau02.Size = new System.Drawing.Size(271, 20);
            this.txtMatkhau02.TabIndex = 2;
            this.txtMatkhau02.Leave += new System.EventHandler(this.txtMatkhau02_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhập lại mk: ";
            // 
            // txtMatkhau01
            // 
            this.txtMatkhau01.Location = new System.Drawing.Point(106, 54);
            this.txtMatkhau01.Name = "txtMatkhau01";
            this.txtMatkhau01.Size = new System.Drawing.Size(271, 20);
            this.txtMatkhau01.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "MK mới: ";
            // 
            // Frm_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 358);
            this.Controls.Add(this.grpDoimk);
            this.Controls.Add(this.grpReset);
            this.Name = "Frm_DoiMatKhau";
            this.Text = "Frm_DoiMatKhau";
            this.Load += new System.EventHandler(this.Frm_DoiMatKhau_Load);
            this.grpReset.ResumeLayout(false);
            this.grpReset.PerformLayout();
            this.grpDoimk.ResumeLayout(false);
            this.grpDoimk.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpReset;
        private System.Windows.Forms.Button btnCaplai;
        private System.Windows.Forms.ComboBox cboTaikhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpDoimk;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.TextBox txtMatkhau02;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatkhau01;
        private System.Windows.Forms.Label label2;
    }
}