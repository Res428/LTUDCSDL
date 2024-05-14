using QLTB_40_ThayPhuc.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB_40_ThayPhuc.BusinessLayer
{
    public class BLL_HeThong
    {
        MyDatabase db;
        ConnectionStringManager connectionStringManager;
        public SqlConnectionStringBuilder stringBuilder;
        public BLL_HeThong(string path)
        {
            db = new MyDatabase(ClsMain.path);
        }

        public DataTable KiemTraDangNhap(ref string err, string taiKhoan, string matKhau)
        {
            return db.GetDataTable(ref err, "SP_QuanLy_KiemTraDangNhap", CommandType.StoredProcedure,
                  new SqlParameter("@TaiKhoan", taiKhoan),
                  new SqlParameter("@MatKhau", matKhau));
        }
        public string LayTenDatabase(ref string err, string path)
        {
            connectionStringManager = new ConnectionStringManager();
            stringBuilder = connectionStringManager.ReadConnectionString(ref err, path);
            return stringBuilder.InitialCatalog;
        }

        #region PhanQuyen

        public DataTable LayDanhSachQuyen(ref string err, string maNV)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaNV",maNV)
            };
            return db.GetDataTable(ref err, "PSP_PhanQuyen_Select", 
                CommandType.StoredProcedure, sqlParameters);
        }

        #endregion
        
    }
}
