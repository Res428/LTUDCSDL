namespace qlbh
{
    partial class Frm_PhanQuyen
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.cboGroupUser = new System.Windows.Forms.ComboBox();
            this.dgvDSFunctionByUser = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFuncID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFuncName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXem = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colThem = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSua = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colXoa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colTong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSFunctionByUser)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btnCapnhat);
            this.groupBox1.Controls.Add(this.cboGroupUser);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1036, 581);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn nhóm người dùng";
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(362, 19);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapnhat.TabIndex = 1;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // cboGroupUser
            // 
            this.cboGroupUser.FormattingEnabled = true;
            this.cboGroupUser.Items.AddRange(new object[] {
            "Admin",
            "User",
            "SubUser",
            "User02"});
            this.cboGroupUser.Location = new System.Drawing.Point(12, 19);
            this.cboGroupUser.Name = "cboGroupUser";
            this.cboGroupUser.Size = new System.Drawing.Size(301, 21);
            this.cboGroupUser.TabIndex = 0;
            this.cboGroupUser.SelectedIndexChanged += new System.EventHandler(this.cboGroupUser_SelectedIndexChanged);
            // 
            // dgvDSFunctionByUser
            // 
            this.dgvDSFunctionByUser.AllowUserToAddRows = false;
            this.dgvDSFunctionByUser.AllowUserToDeleteRows = false;
            this.dgvDSFunctionByUser.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDSFunctionByUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSFunctionByUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colGroupID,
            this.colFuncID,
            this.colFuncName,
            this.colAlias,
            this.colXem,
            this.colThem,
            this.colSua,
            this.colXoa,
            this.colTong});
            this.dgvDSFunctionByUser.Location = new System.Drawing.Point(0, 48);
            this.dgvDSFunctionByUser.Name = "dgvDSFunctionByUser";
            this.dgvDSFunctionByUser.RowHeadersVisible = false;
            this.dgvDSFunctionByUser.Size = new System.Drawing.Size(1036, 581);
            this.dgvDSFunctionByUser.TabIndex = 1;
            this.dgvDSFunctionByUser.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSFunctionByUser_CellEndEdit);
            // 
            // colSTT
            // 
            this.colSTT.DataPropertyName = "STT";
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            this.colSTT.Width = 53;
            // 
            // colGroupID
            // 
            this.colGroupID.DataPropertyName = "GroupID";
            this.colGroupID.HeaderText = "GroupID";
            this.colGroupID.Name = "colGroupID";
            this.colGroupID.Width = 72;
            // 
            // colFuncID
            // 
            this.colFuncID.DataPropertyName = "FuncID";
            this.colFuncID.HeaderText = "FuncID";
            this.colFuncID.Name = "colFuncID";
            this.colFuncID.Width = 67;
            // 
            // colFuncName
            // 
            this.colFuncName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFuncName.DataPropertyName = "FuncName";
            this.colFuncName.HeaderText = "Chức năng";
            this.colFuncName.Name = "colFuncName";
            this.colFuncName.ReadOnly = true;
            // 
            // colAlias
            // 
            this.colAlias.DataPropertyName = "Alias";
            this.colAlias.HeaderText = "Alias";
            this.colAlias.Name = "colAlias";
            this.colAlias.Width = 54;
            // 
            // colXem
            // 
            this.colXem.HeaderText = "Xem";
            this.colXem.Name = "colXem";
            this.colXem.ReadOnly = true;
            this.colXem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colXem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colXem.Width = 53;
            // 
            // colThem
            // 
            this.colThem.HeaderText = "Thêm";
            this.colThem.Name = "colThem";
            this.colThem.ReadOnly = true;
            this.colThem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colThem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colThem.Width = 59;
            // 
            // colSua
            // 
            this.colSua.HeaderText = "Sửa";
            this.colSua.Name = "colSua";
            this.colSua.ReadOnly = true;
            this.colSua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSua.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colSua.Width = 51;
            // 
            // colXoa
            // 
            this.colXoa.HeaderText = "Xóa";
            this.colXoa.Name = "colXoa";
            this.colXoa.ReadOnly = true;
            this.colXoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colXoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colXoa.Width = 51;
            // 
            // colTong
            // 
            this.colTong.DataPropertyName = "Tong";
            this.colTong.HeaderText = "Tổng Quyền";
            this.colTong.Name = "colTong";
            this.colTong.ReadOnly = true;
            this.colTong.Width = 91;
            // 
            // Frm_PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1028, 550);
            this.ControlBox = false;
            this.Controls.Add(this.dgvDSFunctionByUser);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_PhanQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_PhanQuyen";
            this.Load += new System.EventHandler(this.Frm_PhanQuyen_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSFunctionByUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboGroupUser;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.DataGridView dgvDSFunctionByUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFuncID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFuncName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlias;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colXem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colThem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSua;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTong;

    }
}