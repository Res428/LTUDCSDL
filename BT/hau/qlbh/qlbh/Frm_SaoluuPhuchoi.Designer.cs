namespace qlbh
{
    partial class Frm_SaoluuPhuchoi
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
            this.txtSaoluu = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.btnSaoluu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDoimk = new System.Windows.Forms.GroupBox();
            this.txtPhuchoi = new System.Windows.Forms.TextBox();
            this.btnPhuchoi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPathRestore = new System.Windows.Forms.Button();
            this.grpReset.SuspendLayout();
            this.grpDoimk.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpReset
            // 
            this.grpReset.Controls.Add(this.txtSaoluu);
            this.grpReset.Controls.Add(this.btnPath);
            this.grpReset.Controls.Add(this.btnSaoluu);
            this.grpReset.Controls.Add(this.label1);
            this.grpReset.Location = new System.Drawing.Point(3, 6);
            this.grpReset.Name = "grpReset";
            this.grpReset.Size = new System.Drawing.Size(555, 151);
            this.grpReset.TabIndex = 2;
            this.grpReset.TabStop = false;
            this.grpReset.Text = "Sao lưu database";
            // 
            // txtSaoluu
            // 
            this.txtSaoluu.Location = new System.Drawing.Point(106, 65);
            this.txtSaoluu.Name = "txtSaoluu";
            this.txtSaoluu.Size = new System.Drawing.Size(271, 20);
            this.txtSaoluu.TabIndex = 3;
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(396, 65);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(75, 23);
            this.btnPath.TabIndex = 2;
            this.btnPath.Text = "....";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnSaoluu
            // 
            this.btnSaoluu.Location = new System.Drawing.Point(396, 103);
            this.btnSaoluu.Name = "btnSaoluu";
            this.btnSaoluu.Size = new System.Drawing.Size(75, 23);
            this.btnSaoluu.TabIndex = 2;
            this.btnSaoluu.Text = "Sao lưu";
            this.btnSaoluu.UseVisualStyleBackColor = true;
            this.btnSaoluu.Click += new System.EventHandler(this.btnSaoluu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đường dẫn:";
            // 
            // grpDoimk
            // 
            this.grpDoimk.Controls.Add(this.btnPathRestore);
            this.grpDoimk.Controls.Add(this.txtPhuchoi);
            this.grpDoimk.Controls.Add(this.btnPhuchoi);
            this.grpDoimk.Controls.Add(this.label2);
            this.grpDoimk.Location = new System.Drawing.Point(3, 163);
            this.grpDoimk.Name = "grpDoimk";
            this.grpDoimk.Size = new System.Drawing.Size(555, 188);
            this.grpDoimk.TabIndex = 3;
            this.grpDoimk.TabStop = false;
            this.grpDoimk.Text = "Phục hồi database";
            // 
            // txtPhuchoi
            // 
            this.txtPhuchoi.Location = new System.Drawing.Point(106, 74);
            this.txtPhuchoi.Name = "txtPhuchoi";
            this.txtPhuchoi.Size = new System.Drawing.Size(271, 20);
            this.txtPhuchoi.TabIndex = 3;
            // 
            // btnPhuchoi
            // 
            this.btnPhuchoi.Location = new System.Drawing.Point(396, 109);
            this.btnPhuchoi.Name = "btnPhuchoi";
            this.btnPhuchoi.Size = new System.Drawing.Size(75, 23);
            this.btnPhuchoi.TabIndex = 3;
            this.btnPhuchoi.Text = "Phục hồi";
            this.btnPhuchoi.UseVisualStyleBackColor = true;
            this.btnPhuchoi.Click += new System.EventHandler(this.btnPhuchoi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đường dẫn:";
            // 
            // btnPathRestore
            // 
            this.btnPathRestore.Location = new System.Drawing.Point(396, 74);
            this.btnPathRestore.Name = "btnPathRestore";
            this.btnPathRestore.Size = new System.Drawing.Size(75, 23);
            this.btnPathRestore.TabIndex = 4;
            this.btnPathRestore.Text = "....";
            this.btnPathRestore.UseVisualStyleBackColor = true;
            this.btnPathRestore.Click += new System.EventHandler(this.btnPathRestore_Click);
            // 
            // Frm_SaoluuPhuchoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 622);
            this.Controls.Add(this.grpReset);
            this.Controls.Add(this.grpDoimk);
            this.Name = "Frm_SaoluuPhuchoi";
            this.Text = "Frm_SaoluuPhuchoi";
            this.Load += new System.EventHandler(this.Frm_SaoluuPhuchoi_Load);
            this.grpReset.ResumeLayout(false);
            this.grpReset.PerformLayout();
            this.grpDoimk.ResumeLayout(false);
            this.grpDoimk.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpReset;
        private System.Windows.Forms.TextBox txtSaoluu;
        private System.Windows.Forms.Button btnSaoluu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpDoimk;
        private System.Windows.Forms.TextBox txtPhuchoi;
        private System.Windows.Forms.Button btnPhuchoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button btnPathRestore;
    }
}