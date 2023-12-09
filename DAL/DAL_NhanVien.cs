using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_NhanVien:connectDB
    {
        public DataTable LayDSNhanVien(string NameTable)
        {
            DataTable dtNhanVien = new DataTable();
            string sSQL = "Select * From " + NameTable;
            SqlCommand cmdSQL = new SqlCommand(sSQL, conn);
            SqlDataAdapter daNhanVien = new SqlDataAdapter(cmdSQL);
            daNhanVien.Fill(dtNhanVien);
            return dtNhanVien;
        }
        public int themNhanVien(clsNhanVien cNhanVien) 
        {
            string sp_insert = "insertNhanVien";
            SqlCommand Cmdsql=new SqlCommand(sp_insert, conn);
            Cmdsql.CommandType = CommandType.StoredProcedure;
            Cmdsql.Parameters.AddWithValue("@sMaNV", cNhanVien.MaNhanVien);
            Cmdsql.Parameters.AddWithValue("@sTenNV",cNhanVien.TenNhanVien);
            Cmdsql.Parameters.AddWithValue("@sGioiTinh", cNhanVien.GioiTinh);
            Cmdsql.Parameters.AddWithValue("@sNgaySinh", cNhanVien.NgaySinh);
            Cmdsql.Parameters.AddWithValue("@sDiaChi", cNhanVien.DiaChi);
            Cmdsql.Parameters.AddWithValue("@sChucVu", cNhanVien.ChucVu);
            int result = 0;
            try
            {
                if (Cmdsql.ExecuteNonQuery() >= 0)
                {
                    result = 1;
                }

            }
            catch (Exception ex)
            {
                result = 0;
            }

            return result;
        }

    }
    
}
