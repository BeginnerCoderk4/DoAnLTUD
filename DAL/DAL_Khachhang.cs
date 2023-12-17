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
    public class DAL_Khachhang:connectDB
    {
        public DataTable LayDSKhachhang(string NameTable)
        {
            DataTable dtKhachhang = new DataTable();
            string sSQL = "sp_Get_Table";
            SqlCommand cmdSQL = new SqlCommand(sSQL, conn);
            cmdSQL.Parameters.AddWithValue("@Table_Name", NameTable);
            SqlDataAdapter daKhachhang = new SqlDataAdapter(cmdSQL);
            daKhachhang.Fill(dtKhachhang);
            return dtKhachhang;
        }
        public int themKhachhang(clsKhachHang cKhachhang)
        {
            string sp_insertKhachang = "insertKhachHang";
            SqlCommand CmdSQL =new SqlCommand(sp_insertKhachang, conn);
            CmdSQL.CommandType = CommandType.StoredProcedure;
            CmdSQL.Parameters.AddWithValue("@sMaKH", cKhachhang.MaKhachhang);
            CmdSQL.Parameters.AddWithValue("@sTenKH", cKhachhang.TenKhachHang);
            CmdSQL.Parameters.AddWithValue("@sNgaySinh", cKhachhang.NgaySinh);
            CmdSQL.Parameters.AddWithValue("@sDiaChi", cKhachhang.DiaChi);
            CmdSQL.Parameters.AddWithValue("@sSDT", cKhachhang.SDT);
            CmdSQL.Parameters.AddWithValue("@sEmail", cKhachhang.Email);
            int kq = 0;
            try
            {
                if (CmdSQL.ExecuteNonQuery()>=0)
                {
                    kq = 1;
                }
            }
            catch (Exception ex)
            {

                kq = 0;
            }
            return kq;
        }
        public int suaKhachhang(clsKhachHang cKhachhang)
        {
            string sp_updateKhachHang = "updateKhachHang";
            SqlCommand CmdSQL = new SqlCommand(sp_updateKhachHang, conn);
            CmdSQL.CommandType = CommandType.StoredProcedure;
            CmdSQL.Parameters.AddWithValue("@sMaKH", cKhachhang.MaKhachhang);
            CmdSQL.Parameters.AddWithValue("@sTenKH", cKhachhang.TenKhachHang);
            CmdSQL.Parameters.AddWithValue("@sNgaySinh", cKhachhang.NgaySinh);
            CmdSQL.Parameters.AddWithValue("@sDiaChi", cKhachhang.DiaChi);
            CmdSQL.Parameters.AddWithValue("@sSDT", cKhachhang.SDT);
            CmdSQL.Parameters.AddWithValue("@sEmail", cKhachhang.Email);
            int kq = 0;
            try
            {
                if (CmdSQL.ExecuteNonQuery() >= 0)
                {
                    kq = 1;
                }
            }
            catch (Exception ex)
            {

                kq = 0;
            }
            return kq;
        }
        public int xoaKhachhang(clsKhachHang cKhachhang)
        {
            string sp_deleteKhachHang = "deleteKhachHang";
            SqlCommand CmdSQL = new SqlCommand(sp_deleteKhachHang, conn);
            CmdSQL.CommandType = CommandType.StoredProcedure;
            CmdSQL.Parameters.AddWithValue("@sMaKH", cKhachhang.MaKhachhang);
            //CmdSQL.Parameters.AddWithValue("@sTenKH", cKhachhang.TenKhachHang);
            //CmdSQL.Parameters.AddWithValue("@sNgaySinh", cKhachhang.NgaySinh);
            //CmdSQL.Parameters.AddWithValue("@sDiaChi", cKhachhang.DiaChi);
            //CmdSQL.Parameters.AddWithValue("@sSDT", cKhachhang.SDT);
            //CmdSQL.Parameters.AddWithValue("@sEmail", cKhachhang.Email);
            int kq = 0;
            try
            {
                if (CmdSQL.ExecuteNonQuery() >= 0)
                {
                    kq = 1;
                }
            }
            catch (Exception ex)
            {

                kq = 0;
            }
            return kq;
        }
    }
}
