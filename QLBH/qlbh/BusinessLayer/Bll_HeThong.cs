using QuanLyBanHang.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlbh.BusinessLayer
{
    public class Bll_HeThong
    {
        MyDatabase db;
        ConnectionStringManager connectionStringManager;
        public SqlConnectionStringBuilder stringBuilder;
        public Bll_HeThong(string path)
        {
            db = new MyDatabase(path);
        }

        public string LayTenDatabase(ref string err, string path)
        {
            connectionStringManager = new ConnectionStringManager();
            stringBuilder = connectionStringManager.ReadConnectionString(ref err, path);
            return stringBuilder.InitialCatalog;
        }

        public DataTable KiemTraDangNhap(ref string err, string taiKhoan, string matKhau)
        {
            return db.GetDataTable(ref err, "PSP_NhanVien_KiemTraDangNhap", CommandType.StoredProcedure,
                  new SqlParameter("@TaiKhoan", taiKhoan),
                  new SqlParameter("@MatKhau", matKhau));
        }

        #region Phân quyền
        // Phương thức lấy danh sách GroupUser để đổ vào ComboBox
        public DataTable LayDSGroupUser(ref string err)
        {
            return db.GetDataTable(ref err, "HSP_GroupUser_SelectToCombo", CommandType.StoredProcedure, null);
        }
        // Phương thức lấy danh sách chức năng theo GroupId để hiển thị lên DataGridView dgvDSFunctionByUser
        public DataTable LayDSFunctionsByUser(ref string err, string groupID)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
     {
         new SqlParameter("@GroupID",groupID)
     };
            return db.GetDataTable(ref err, "HSP_PhanQuyen_SelectToGrid", CommandType.StoredProcedure, sqlParameters);
        }
        // Phương thức sử dụng để cập nhật quyền khi nhấn vào button cập nhật
        public int CapNhatPhanQuyen(ref string err, string funcId, string groupId, int tong)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
     {
         new SqlParameter("@GroupID",groupId),
          new SqlParameter("@FuncID",funcId),
           new SqlParameter("@Total",tong)
     };
            return db.MyExcuteNonQuery(ref err, "HSP_PhanQuyen_InsertAndUpdate", CommandType.StoredProcedure, sqlParameters);
        }
        // Phương thức Lấy danh sách quyền theo Mã số nhân viên
        public DataTable LayDanhSachQuyen(ref string err, string maNV)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                 new SqlParameter("@MaNV",maNV)
             };
             return db.GetDataTable(ref err, "HSP_PhanQuyen_Select", CommandType.StoredProcedure, sqlParameters);
        }
        #endregion


        public bool SaoLuuDatabase(ref string err, string path)
        {
            SqlParameter[] sqlparameter = new SqlParameter[]{
                new SqlParameter("@Path", path),
            };
            return db.MyExcuteNonQuery(ref err, "", CommandType.StoredProcedure, sqlparameter) == 1 ? true : false;
        }

        internal bool PhucHoiDatabase(ref string err, string path)
        {
            string databaseName = LayTenDatabase(ref err, ClsMain.path);
            string commandText = string.Format("Use master ALTER DATABASE {0} SET SINGLE_USER WITH ROLLBACK IMMEDIATE" +
                                                       " RESTORE DATABASE {1} FROM DISK = N'{2}' WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 10" +
                                                       " ALTER DATABASE {3} SET MULTI_USER",
                                                       "Data_QuanLyBanHang_HocTap2021", "Data_QuanLyBanHang_HocTap2021", path , "Data_QuanLyBanHang_HocTap2021");
            ;
            return db.MyExcuteNonQuery(ref err, commandText, CommandType.Text) == 1 ? true : false;
        }

        #region Đổi mật khẩu
        /// <summary>
        /// Phương thức load data vào ComboBox cboTaiKhoan
        /// </summary>
        /// <param name="err"></param>
        /// <returns></returns>
        public DataTable LayTaiKhoanChoCboTaiKhoan(ref string err)
        {
            return db.GetDataTable(ref err, "HSP_NhanVien_SelectToCboTaiKhoan", CommandType.StoredProcedure, null);
        }

        public int DoiMatKhau(ref string err, string taiKhoan, string matKhau)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@TaiKhoan",taiKhoan),
                new SqlParameter("@MatKhau",matKhau)

            };
            return db.MyExcuteNonQuery(ref err, "HSP_NhanVien_DoiMatKhau", CommandType.StoredProcedure, sqlParameters);
        }
        #endregion

    }
}
