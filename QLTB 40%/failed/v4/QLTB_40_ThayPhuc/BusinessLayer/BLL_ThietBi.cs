using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTB_40_ThayPhuc.DTO;
using QuanLyBanHang.DataLayer;
//using QLTB_40_ThayPhuc.DataLayer;

namespace QLTB_40_ThayPhuc.BusinessLayer
{
    public class BLL_ThietBi
    {
        MyDatabase db;
        public BLL_ThietBi(string path)
        {
            db = new MyDatabase(path);
        }
        public DataTable LayThietBi(ref string err, string maTB)
        {
            return db.GetDataTable(ref err, "HSP_ThietBi_Select", CommandType.StoredProcedure, new SqlParameter("@MaTB", maTB));
        }

        public int CapNhatThietBi(ref string err, ThietBi thietBi)
        {
            SqlParameter[] sq = new SqlParameter[]{
                 new SqlParameter("@MaTB",thietBi.MaTB),
                 new SqlParameter("@TenTB",thietBi.TenTB),
                 new SqlParameter("@LoaiTB", thietBi.LoaiTB),
                 new SqlParameter("@Sl", thietBi.Sl),
                 new SqlParameter("@TinhTrang", thietBi.TinhTrang),
                 new SqlParameter("@CurrentUser", thietBi.CurrentUser)
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

        // Phương thức thêm mã phiếu nhập và database 
        public int ThemThietBi(ref string err, string maTB)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaTB",maTB)
            };
            return db.MyExcuteNonQuery(ref err, "HSP_ThietBi_InsertAndUpdate", CommandType.StoredProcedure, sqlParameters);
        }

        public object SinhMaLonNhat(ref string err)
        {
            return db.MyExcuteScalar(ref err, "HSP_ThietBi_LayMaThietBi", CommandType.StoredProcedure, null);
        }

        // Phương thức Lấy mã phiếu lớn nhất
        public string LayThietBiLonNhat(ref string err)
        {
            return db.MyExcuteScalar(ref err, "HSP_ThietBi_LayMaxID", CommandType.StoredProcedure, null).ToString();
        }
    }
}
