using qlbh.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlbh
{
    public class ClsMain
    {
        public static string path = string.Format(@"{0}/Connect.ini", Application.StartupPath);
        public static string tenNhanVien = string.Empty;
        public static string maNhanVien = string.Empty;
        public static Account account = new Account();
        //Biến kiểu Hashtable dùng để lưu danh sách quyền theo chức năng của Nhân viên đăng nhập
        public static Hashtable hsQuyenByUser = new Hashtable();
        /// <summary>
        /// Phương thức Kiểm tra quyền theo loại quyền 
        /// </summary>
        /// <param name="frm">Frm cần kiểm tra quyền</param>
        /// <param name="quyen">Một Emum về danh sách quyền (Xem, Thêm, Sửa, Xóa</param>
        /// <returns></returns>
        public static bool CheckQuyen(Form frm, QUYEN quyen)
        {
            foreach (string key in hsQuyenByUser.Keys)
            {
                if (key.Equals(frm.Name))
                {
                    return (Convert.ToInt32(hsQuyenByUser[key].ToString()) & ((int)quyen)) == ((int)quyen) ? true : false;
                    //15&2==2?true:false
                }
            }
            return false;
        }

        public static void DinhDangDGV(DataGridView dgv)
        {
            dgv.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle(){
                BackColor = Color.CornflowerBlue,
            };
            dgv.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle(){
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Font = new Font("Arial", 12F, FontStyle.Bold),
            };
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RowTemplate.Height = 32;

            dgv.Font = new Font("Arial", 11F, FontStyle.Regular);
        }

    }


}
