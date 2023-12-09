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
    public class DAL_KhoHang:connectDB
    {
        public DataTable LayDSKhoHang(string NameTable)
        {
            DataTable dtKhoHang = new DataTable();
            string sSQL = "Select * From " + NameTable;
            SqlCommand cmdSQL = new SqlCommand(sSQL, conn);
            SqlDataAdapter daKhoHang = new SqlDataAdapter(cmdSQL);
            daKhoHang.Fill(dtKhoHang);
            return dtKhoHang;
        }
        public int themKhoHang(clsKhoHang cKhoHang)
        {
            string sp_insertKhoHang = "insertKhoHang";
            SqlCommand CmdSQL = new SqlCommand(sp_insertKhoHang, conn);
            CmdSQL.CommandType = CommandType.StoredProcedure;
            CmdSQL.Parameters.AddWithValue("@sMaKhoHang",cKhoHang.MaKhoHang);
            CmdSQL.Parameters.AddWithValue("@sMaHangNhap",cKhoHang.MaHangNhap);
            CmdSQL.Parameters.AddWithValue("@sMaNhanVien",cKhoHang.MaNhanVien);
            int result = 0;
            try
            {
                if (CmdSQL.ExecuteNonQuery() >= 0)
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
        public int suaKhoHang(clsKhoHang cKhoHang)
        {
            string sp_updateKhoHang = "updateKhoHang";
            SqlCommand CmdSQL = new SqlCommand(sp_updateKhoHang, conn);
            CmdSQL.CommandType = CommandType.StoredProcedure;
            CmdSQL.Parameters.AddWithValue("@sMaKhoHang", cKhoHang.MaKhoHang);
            CmdSQL.Parameters.AddWithValue("@sMaHangNhap", cKhoHang.MaHangNhap);
            CmdSQL.Parameters.AddWithValue("@sMaNhanVien", cKhoHang.MaNhanVien);
            int result = 0;
            try
            {
                if (CmdSQL.ExecuteNonQuery() >= 0)
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
        public int xoaKhoHang(clsKhoHang cKhoHang)
        {
            string sp_deleteKhoHang = "deleteKhoHang";
            SqlCommand CmdSQL = new SqlCommand(sp_deleteKhoHang, conn);
            CmdSQL.CommandType = CommandType.StoredProcedure;
            CmdSQL.Parameters.AddWithValue("@sMaKhoHang", cKhoHang.MaKhoHang);
            CmdSQL.Parameters.AddWithValue("@sMaHangNhap", cKhoHang.MaHangNhap);
            CmdSQL.Parameters.AddWithValue("@sMaNhanVien", cKhoHang.MaNhanVien);
            int result = 0;
            try
            {
                if (CmdSQL.ExecuteNonQuery() >= 0)
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
