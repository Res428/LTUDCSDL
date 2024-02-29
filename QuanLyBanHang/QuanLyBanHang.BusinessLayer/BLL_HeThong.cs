using QuanLyBanHang.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.BusinessLayer
{
    public class BLL_HeThong : BLL_Base
    {

        public BLL_HeThong() : base()
        {

        }
        public DataTable GetAllNhanVien(ref string err)
        {
            return _db.GetDataTable(ref err, "HSP_240228_NhanVien_Select", CommandType.StoredProcedure, new SqlParameter("@MaNV", 0));
        }
        public int CapNhatNguoiDung(ref string err, string maNV, string hoTenNV, bool phai, string luongCB, string congViec, string maKV)
        {
            SqlParameter[] sqlParameter = new SqlParameter[]{
                new SqlParameter("@MaNV", maNV),
                new SqlParameter("@HoTenNV", hoTenNV),
                new SqlParameter("@Phai", phai),
                new SqlParameter("@LuongCB", luongCB),
                new SqlParameter("@CongViec", congViec),
                new SqlParameter("@MaKV", maKV)
            };
            return _db.MyExcuteNonQuery(ref err, "HSP_240228_NhanVien_InsertAndUpdate", CommandType.StoredProcedure, sqlParameter);
        }
        public DataTable GetUsers(ref string err)
        {
            return _db.GetDataTable(ref err, "select * from nhanvien", CommandType.Text, null);
        }
        public DataTable GetUserByID(ref string err, string id)
        {
            return _db.GetDataTable(ref err, "PSP_NhanVien231220", CommandType.StoredProcedure, new SqlParameter("@MaNhanVien", id));
        }
        public BLL_HeThong(string path) : base(path)
        {
            _db = new MyDatabase(path);
        }

        public bool CheckConnnect(ref string err)
        {
            return _db.CheckConnect(ref err);
        }
        public SqlConnectionStringBuilder ReadConnectionString(string path)
        {
            SqlConnectionStringBuilder result = null;
            ConnectionStringManager.Instance.ReadConnectionString(path);
            result = ConnectionStringManager.Instance._SqlConnectionStringBuilder;
            return result;
        }

        public void WriteConnectionString(SqlConnectionStringBuilder sqlConnectionStringBuilder, string path)
        {
            ConnectionStringManager.Instance._SqlConnectionStringBuilder = sqlConnectionStringBuilder;
            ConnectionStringManager.Instance.WriteConnectionString(path);
        }
        public void WriteConnectionString(string path, SqlConnectionStringBuilder sqlConnectionStringBuilder)
        {
            ConnectionStringManager.Instance.WriteConnectionString(path, sqlConnectionStringBuilder);
        }
    }
}
