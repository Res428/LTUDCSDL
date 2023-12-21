namespace QLBH_WINFORM.Hệ_thống
{
    partial class FrmKetnoi
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblErr = new System.Windows.Forms.ToolStripStatusLabel();
            this.cboAuthentication = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(172, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(240, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Connect To SQL Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Database:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Authentication:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "User ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password:";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(177, 90);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(325, 20);
            this.txtServer.TabIndex = 6;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(177, 132);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(325, 20);
            this.txtDatabase.TabIndex = 7;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(177, 212);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(325, 20);
            this.txtUserID.TabIndex = 9;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(177, 247);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(325, 20);
            this.txtPass.TabIndex = 10;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(177, 314);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(77, 26);
            this.btnTest.TabIndex = 11;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(301, 314);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 26);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(425, 314);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 26);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblErr});
            this.statusStrip1.Location = new System.Drawing.Point(0, 379);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(568, 25);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblErr
            // 
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(18, 20);
            this.lblErr.Text = "...";
            // 
            // cboAuthentication
            // 
            this.cboAuthentication.FormattingEnabled = true;
            this.cboAuthentication.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.cboAuthentication.Location = new System.Drawing.Point(178, 174);
            this.cboAuthentication.Name = "cboAuthentication";
            this.cboAuthentication.Size = new System.Drawing.Size(323, 21);
            this.cboAuthentication.TabIndex = 15;
            this.cboAuthentication.SelectedIndexChanged += new System.EventHandler(this.cboAuthentication_SelectedIndexChanged);
            // 
            // FrmKetnoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 404);
            this.Controls.Add(this.cboAuthentication);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmKetnoi";
            this.Text = "FrmKetnoi";
            this.Load += new System.EventHandler(this.FrmKetnoi_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblErr;
        private System.Windows.Forms.ComboBox cboAuthentication;
    }
}