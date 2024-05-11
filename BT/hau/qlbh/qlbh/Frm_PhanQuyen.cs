using qlbh.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlbh
{
    public partial class Frm_PhanQuyen : Frm_Base
    {
        // biến khai báo đối tượng businessLayer
        Bll_HeThong bd;
        // Các biến lưu trữ dữ liệu dạng dataTable
        DataTable dtGroupUser;
        DataTable dtFunctionByUser;
        // Biến lưu lỗi của hệ thống
        string err = string.Empty;
        //Biến lưu trạng thái load dữ liệu vào comboBox
        bool trangThaiLoadCombo = false;

        public Frm_PhanQuyen()
        {
            InitializeComponent();
        }

        private void Frm_PhanQuyen_Load(object sender, EventArgs e)
        {
            bd = new Bll_HeThong(ClsMain.path);
            HienThiDuLieuCboGroupUser();
        }

        // Phương thức Hiển thị dữ liệu vào Combobox
        private void HienThiDuLieuCboGroupUser()
        {
            dtGroupUser = new DataTable();
            dtGroupUser = bd.LayDSGroupUser(ref err);

            cboGroupUser.DataSource = dtGroupUser;
            cboGroupUser.DisplayMember = "GroupName";
            cboGroupUser.ValueMember = "GroupID";

            cboGroupUser.SelectedIndex = -1;
            cboGroupUser.Text = "chọn nhóm User ";
            trangThaiLoadCombo = true;

        }

        // Sự kiện khi chọn item trên comboBox Group User
        private void cboGroupUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGroupUser.SelectedIndex >= 0 && trangThaiLoadCombo == true)
            {
                HienThiDSFunctionsByUser(cboGroupUser.SelectedValue.ToString());
            }
        }
        // Phương thức hiển thị dữ liệu lên DataGridView dgvDSFunctionByUser
        private void HienThiDSFunctionsByUser(string groupID)
        {
            dtFunctionByUser = new DataTable();
            dtFunctionByUser = bd.LayDSFunctionsByUser(ref err, groupID);

            dgvDSFunctionByUser.DataSource = dtFunctionByUser.DefaultView;
        }

        // Sự kiện bắt thao tác sau khi chọn checkBox trên DataGridView
        // Sử dụng để tính điểm phân quyền cho chức năng
        private void dgvDSFunctionByUser_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSFunctionByUser.CurrentCell.ColumnIndex >= 5 && dgvDSFunctionByUser.CurrentCell.ColumnIndex <= 8)
            {
                int diem = 0;
                for (int i = 5; i <= 8; i++)
                {
                    if (dgvDSFunctionByUser.CurrentRow.Cells[i].Value.ToString().Equals("1"))
                    {
                        switch (i)
                        {
                            case 5:
                                diem += 1;
                                break;
                            case 6:
                                diem += 2;
                                break;
                            case 7:
                                diem += 4;
                                break;
                            case 8:
                                diem += 8;
                                break;
                        }
                    }
                }
                dgvDSFunctionByUser.CurrentRow.Cells["colTong"].Value = string.Format("{0}", diem);
            }
        }

        string funcId, groupId;
        int toltal = 0;

        // Button cập nhật quyền cho Group User
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (ClsMain.CheckQuyen(this, QUYEN.SUA))
            {
                for (int i = 0; i < dgvDSFunctionByUser.Rows.Count; i++)
                {
                    funcId = dgvDSFunctionByUser.Rows[i].Cells["colFuncID"].Value.ToString();
                    groupId = dgvDSFunctionByUser.Rows[i].Cells["colGroupID"].Value.ToString();
                    toltal = Convert.ToInt32(dgvDSFunctionByUser.Rows[i].Cells["colTong"].Value.ToString());
                    bd.CapNhatPhanQuyen(ref err, funcId, groupId, toltal);
                }
                HienThiDSFunctionsByUser(cboGroupUser.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("Khong co quyen");
                HienThiDSFunctionsByUser(cboGroupUser.SelectedValue.ToString());
            }
        }


    }
}
