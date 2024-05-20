using QLTB_40_ThayPhuc.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTB_40_ThayPhuc.DataLayer;

namespace QLTB_40_ThayPhuc.BusinessLayer
{
    public class BLL_NhanVien
    {
        MyDatabase db;
        public BLL_NhanVien(string path)
        {
            db = new MyDatabase(path);
        }
        public DataTable LayNhanVien(ref string err, string maNV)
        {
            return db.GetDataTable(ref err, "HSP_NhanVien_Select", CommandType.StoredProcedure, new SqlParameter("@MaNV", maNV));
        }


        public int CapNhatNhanVien(ref string err, NhanVien nhanVien)
        {
            SqlParameter[] sq = new SqlParameter[]{
                 new SqlParameter("@MaKH",nhanVien.MaNV),
                 new SqlParameter("@HoKH",nhanVien.HoTenNV),
                 new SqlParameter("@TenKH",nhanVien.Email),
                 new SqlParameter("@SoDT",nhanVien.SoDT)
            };
            return db.MyExcuteNonQuery(ref err, "HSP_NhanVien_InsertAndUpdate", CommandType.StoredProcedure, sq);
        }
        public int XoaNhanVien(ref string err, NhanVien nhanVien)
        {
            SqlParameter[] sq = new SqlParameter[]{
                new SqlParameter("@MaNV",nhanVien.MaNV)
            };
            return db.MyExcuteNonQuery(ref err, "HSP_NhanVien_Delete", CommandType.StoredProcedure, sq);
        }

        // Phương thức thêm mã phiếu nhập và database 
        public int ThemNhanVien(ref string err, string maNV)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaNV",maNV)
            };
            return db.MyExcuteNonQuery(ref err, "HSP_NhanVien_InsertAndUpdate", CommandType.StoredProcedure, sqlParameters);
        }


        public object SinhMaLonNhat(ref string err)
        {
            return db.MyExcuteScalar(ref err, "HSP_NhanVien_LayMaNV", CommandType.StoredProcedure, null);
        }
    }
}
