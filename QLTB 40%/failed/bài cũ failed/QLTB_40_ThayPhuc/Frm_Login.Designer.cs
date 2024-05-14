
using System.Windows.Forms;

namespace QLTB_40_ThayPhuc
{
    partial class Frm_Login
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
            this.Password = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.FrmĐangNhap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Password.Location = new System.Drawing.Point(65, 141);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(128, 29);
            this.Password.TabIndex = 0;
            this.Password.Text = "Password";
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.User.Location = new System.Drawing.Point(65, 85);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(68, 29);
            this.User.TabIndex = 0;
            this.User.Text = "User";
            // 
            // btnLogin
            // 
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnLogin.Location = new System.Drawing.Point(350, 216);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.Location = new System.Drawing.Point(499, 216);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCancel_MouseClick);
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(304, 87);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(313, 31);
            this.txtUser.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(304, 142);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(313, 31);
            this.txtPass.TabIndex = 2;
            // 
            // FrmĐangNhap
            // 
            this.FrmĐangNhap.AutoSize = true;
            this.FrmĐangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrmĐangNhap.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FrmĐangNhap.Location = new System.Drawing.Point(244, 26);
            this.FrmĐangNhap.Name = "FrmĐangNhap";
            this.FrmĐangNhap.Size = new System.Drawing.Size(190, 37);
            this.FrmĐangNhap.TabIndex = 3;
            this.FrmĐangNhap.Text = "Đăng Nhập";
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 276);
            this.Controls.Add(this.FrmĐangNhap);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Password);
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;

        public Label FrmDangNhap { get; }

        private System.Windows.Forms.Label FrmĐangNhap;
        private System.Windows.Forms.Button btnLogin;
    }
}

