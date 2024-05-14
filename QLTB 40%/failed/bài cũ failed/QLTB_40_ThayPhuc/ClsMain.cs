using QLTB_40_ThayPhuc.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTB_40_ThayPhuc
{
   public class ClsMain
    {
        public static string path = string.Format(@"{0}/Connect.ini", Application.StartupPath);
        public static string tenQL = string.Empty;
        public static account acc = new account();
        //Biến kiểu Hashtable dùng để lưu danh sách quyền theo chức năng của Nhân viên đăng nhập
        public static Hashtable hsQuyenByUser = new Hashtable();

        public static bool CheckQuyen(Form frm, QUYEN quyen)
        {
            foreach (string key in hsQuyenByUser.Keys)
            {
                if (key.Equals(frm.Name))
                {
                    return (Convert.ToInt32(hsQuyenByUser[key].ToString()) & ((int)quyen)) == ((int)quyen) ? true : false;
                }
            }
            return false;
        }

    }
}
