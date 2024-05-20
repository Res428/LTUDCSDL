using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTB_40_ThayPhuc.DTO;
using QuanLyBanHang.DataLayer;

namespace QLTB_40_ThayPhuc.BusinessLayer
{
    public class BLL_ThietBi
    {
        MyDatabase db;
        public BLL_ThietBi(string path)
        {
            db = new MyDatabase(path);
        }
        public DataTable LayThietBi(ref string err, string maLH)
        {
            return db.GetDataTable(ref err, "HSP_ThietBi_Select", CommandType.StoredProcedure, new SqlParameter("@MaTB", maLH));
        }

        public int CapNhatThietBi(ref string err, ThietBi thietBi)
        {
            SqlParameter[] sq = new SqlParameter[]{
                new SqlParameter("@MaTB",thietBi.MaTB),
                 new SqlParameter("@TenTB",thietBi.TenTB)
            };
            return db.MyExcuteNonQuery(ref err, "HSP_ThietBi_InsertAndUpdate", CommandType.StoredProcedure, sq);
        }
        public int XoaThietBi(ref string err, ThietBi thietBi)
        {
            SqlParameter[] sq = new SqlParameter[]{
                new SqlParameter("@MaTB",thietBi.MaTB)
            };
            return db.MyExcuteNonQuery(ref err, "HSP_ThietBi_Delete", CommandType.StoredProcedure, sq);
        }
    }
}
