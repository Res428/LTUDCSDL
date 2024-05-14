
namespace QLTB_40_ThayPhuc
{
    partial class frm_loaithietbi_Modifies
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.huy = new System.Windows.Forms.Button();
            this.tenthietbi = new System.Windows.Forms.Label();
            this.mathietbi = new System.Windows.Forms.Label();
            this.txtMaTB = new System.Windows.Forms.TextBox();
            this.txtTenTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnUpdate.Location = new System.Drawing.Point(174, 182);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 30);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // huy
            // 
            this.huy.BackColor = System.Drawing.SystemColors.HotTrack;
            this.huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huy.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.huy.Location = new System.Drawing.Point(342, 182);
            this.huy.Name = "huy";
            this.huy.Size = new System.Drawing.Size(106, 30);
            this.huy.TabIndex = 3;
            this.huy.Text = "Hủy ";
            this.huy.UseVisualStyleBackColor = false;
            this.huy.Click += new System.EventHandler(this.huy_Click);
            // 
            // tenthietbi
            // 
            this.tenthietbi.AutoSize = true;
            this.tenthietbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenthietbi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tenthietbi.Location = new System.Drawing.Point(59, 102);
            this.tenthietbi.Name = "tenthietbi";
            this.tenthietbi.Size = new System.Drawing.Size(140, 25);
            this.tenthietbi.TabIndex = 1;
            this.tenthietbi.Text = "Tên Thiết Bị";
            // 
            // mathietbi
            // 
            this.mathietbi.AutoSize = true;
            this.mathietbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mathietbi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.mathietbi.Location = new System.Drawing.Point(59, 54);
            this.mathietbi.Name = "mathietbi";
            this.mathietbi.Size = new System.Drawing.Size(132, 25);
            this.mathietbi.TabIndex = 2;
            this.mathietbi.Text = "Mã Thiết Bị";
            // 
            // txtMaTB
            // 
            this.txtMaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTB.Location = new System.Drawing.Point(241, 53);
            this.txtMaTB.Name = "txtMaTB";
            this.txtMaTB.Size = new System.Drawing.Size(314, 26);
            this.txtMaTB.TabIndex = 0;
            // 
            // txtTenTB
            // 
            this.txtTenTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTB.Location = new System.Drawing.Point(241, 101);
            this.txtTenTB.Name = "txtTenTB";
            this.txtTenTB.Size = new System.Drawing.Size(314, 26);
            this.txtTenTB.TabIndex = 1;
            // 
            // frm_loaithietbi_Modifies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 251);
            this.Controls.Add(this.txtTenTB);
            this.Controls.Add(this.txtMaTB);
            this.Controls.Add(this.mathietbi);
            this.Controls.Add(this.tenthietbi);
            this.Controls.Add(this.huy);
            this.Controls.Add(this.btnUpdate);
            this.Name = "frm_loaithietbi_Modifies";
            this.Text = "frm_loaithietbi";
            this.Load += new System.EventHandler(this.frm_loaithietbi_Modifies_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button huy;
        private System.Windows.Forms.Label tenthietbi;
        private System.Windows.Forms.Label mathietbi;
        private System.Windows.Forms.TextBox txtMaTB;
        private System.Windows.Forms.TextBox txtTenTB;
    }
}