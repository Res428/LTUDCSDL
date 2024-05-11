using QuanLyBanHang.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTB_40_ThayPhuc.DTO;

namespace QLTB_40_ThayPhuc.BusinessLayer
{
    public class BLL_LoaiThietBi
    {
        MyDatabase db;

        public BLL_LoaiThietBi(string path)
        {
            db = new MyDatabase(path);
        }

        public DataTable LayLoaiTB(ref string err, string maTB)
        {
            return db.GetDataTable(ref err, "SP_LoaiTB_Select", CommandType.StoredProcedure, new SqlParameter("@MaTB", maTB));
        }


        public int CapNhatLoaiTB(ref string err, LoaiThietBi loaiThietBi)
        {
            SqlParameter[] sq = new SqlParameter[]{
                new SqlParameter("@MaTB",loaiThietBi.MaTB),
                 new SqlParameter("@TenTB",loaiThietBi.TenTB)
            };
            return db.MyExcuteNonQuery(ref err, "SP_LoaiTB_InsertAndUpdate", CommandType.StoredProcedure, sq);
        }
        public int XoaLoaiTB(ref string err, LoaiThietBi loaiThietBi)
        {
            SqlParameter[] sq = new SqlParameter[]{
                new SqlParameter("@MaTB",loaiThietBi.MaTB)
            };
            return db.MyExcuteNonQuery(ref err, "SP_LoaiTB_Delete", CommandType.StoredProcedure, sq);
        }
    }
}
