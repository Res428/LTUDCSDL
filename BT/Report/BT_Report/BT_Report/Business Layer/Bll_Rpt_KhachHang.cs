using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHang.DataLayer;

namespace BT_Report.Business_Layer
{
    public class Bll_Rpt_KhachHang
    {

        MyDatabase db;
        public Bll_Rpt_KhachHang(string path)
        {
            db = new MyDatabase(path);
        }

        public DataTable LayDuLieuComboKhachHang(ref string err)
        {
            return db.GetDataTable(ref err, "PSP_KhachHang_LayKhachHangVaoCombo", CommandType.StoredProcedure, null);

        }
    }
}
