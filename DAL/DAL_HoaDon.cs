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
    public class DAL_HoaDon:connectDB
    {
        public DataTable LayDSHoaDon(string NameTable)
        {
            DataTable dtHoaDon = new DataTable();
            string sSQL = "Select * From " + NameTable;
            SqlCommand cmdSQL = new SqlCommand(sSQL, conn);
            SqlDataAdapter daHoaDon = new SqlDataAdapter(cmdSQL);
            daHoaDon.Fill(dtHoaDon);
            return dtHoaDon;
        }
        public int themHoaDon(clsHoaDon cHoaDon)
        {
            string sp_insertHoaDon = "insertHoaDon";
            SqlCommand CmdSQL = new SqlCommand(sp_insertHoaDon, conn);
            CmdSQL.CommandType = CommandType.StoredProcedure;
            CmdSQL.Parameters.AddWithValue("@sMaHoaDon",cHoaDon.MaHoaDon);
            CmdSQL.Parameters.AddWithValue("@sNgayInHoaDon",cHoaDon.NgayInHoaDon);
            CmdSQL.Parameters.AddWithValue("@sMaNhanVien",cHoaDon.MaNhanVien);
            CmdSQL.Parameters.AddWithValue("@sTenNhanVien", cHoaDon.TenNhanVien);
            CmdSQL.Parameters.AddWithValue("@sMaKhachHang",cHoaDon.MaKhachHang);
            CmdSQL.Parameters.AddWithValue("@sTenKhachHang", cHoaDon.TenKhachhang);
            CmdSQL.Parameters.AddWithValue("@sSDT",cHoaDon.SDT);
            CmdSQL.Parameters.AddWithValue("@sDiaChi",cHoaDon.DiaChi);
            CmdSQL.Parameters.AddWithValue("@sTongTien",cHoaDon.TongTien);
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
        public int suaHoaDon(clsHoaDon cHoaDon)
        {
            string sp_updateHoaDon = "updateHoaDon";
            SqlCommand CmdSQL = new SqlCommand(sp_updateHoaDon, conn);
            CmdSQL.CommandType = CommandType.StoredProcedure;
            CmdSQL.Parameters.AddWithValue("@sMaHoaDon", cHoaDon.MaHoaDon);
            CmdSQL.Parameters.AddWithValue("@sNgayInHoaDon", cHoaDon.NgayInHoaDon);
            CmdSQL.Parameters.AddWithValue("@sMaNhanVien", cHoaDon.MaNhanVien);
            CmdSQL.Parameters.AddWithValue("@sTenNhanVien", cHoaDon.TenNhanVien);
            CmdSQL.Parameters.AddWithValue("@sMaKhachHang", cHoaDon.MaKhachHang);
            CmdSQL.Parameters.AddWithValue("@sTenKhachHang", cHoaDon.TenKhachhang);
            CmdSQL.Parameters.AddWithValue("@sSDT", cHoaDon.SDT);
            CmdSQL.Parameters.AddWithValue("@sDiaChi", cHoaDon.DiaChi);
            CmdSQL.Parameters.AddWithValue("@sTongTien", cHoaDon.TongTien);
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
        public int xoaHoaDon(clsHoaDon cHoaDon)
        {
            string sp_deleteHoaDon = "deleteHoaDon";
            SqlCommand CmdSQL = new SqlCommand(sp_deleteHoaDon, conn);
            CmdSQL.CommandType = CommandType.StoredProcedure;
            CmdSQL.Parameters.AddWithValue("@sMaHoaDon", cHoaDon.MaHoaDon);
            //CmdSQL.Parameters.AddWithValue("@sNgayInHoaDon", cHoaDon.NgayInHoaDon);
            //CmdSQL.Parameters.AddWithValue("@sMaNhanVien", cHoaDon.MaNhanVien);
            //CmdSQL.Parameters.AddWithValue("@sTenNhanVien", cHoaDon.TenNhanVien);
            //CmdSQL.Parameters.AddWithValue("@sMaKhachHang", cHoaDon.MaKhachHang);
            //CmdSQL.Parameters.AddWithValue("@sTenKhachHang", cHoaDon.TenKhachhang);
            //CmdSQL.Parameters.AddWithValue("@sSDT", cHoaDon.SDT);
            //CmdSQL.Parameters.AddWithValue("@sDiaChi", cHoaDon.DiaChi);
            //CmdSQL.Parameters.AddWithValue("@sTongTien", cHoaDon.TongTien);
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
