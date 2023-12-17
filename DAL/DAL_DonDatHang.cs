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
    public class DAL_DonDatHang:connectDB
    {
        public DataTable LayDSDonHang(string NameTable)
        {
            DataTable dtDonDatHang = new DataTable();
            string sSQL = "sp_Get_Table";
            SqlCommand cmdSQL = new SqlCommand(sSQL, conn);
            cmdSQL.Parameters.AddWithValue("@Table_Name", NameTable);
            SqlDataAdapter daNhanVien = new SqlDataAdapter(cmdSQL);
            daNhanVien.Fill(dtDonDatHang);
            return dtDonDatHang;
        }
        public int themDonDatHang(clsDonHang cDonHang)
        {
            string sp_insertDonDatHang = "insertDonDatHang";
            SqlCommand CmdSQL = new SqlCommand(sp_insertDonDatHang, conn);
            CmdSQL.CommandType = CommandType.StoredProcedure;
            CmdSQL.Parameters.AddWithValue("@sMaDonHang",cDonHang.MaDonHang);
            CmdSQL.Parameters.AddWithValue("@sMaKhachHang",cDonHang.MaKhachHang);
            CmdSQL.Parameters.AddWithValue("@sTenKhachHang",cDonHang.TenKhachhang);
            CmdSQL.Parameters.AddWithValue("@sDiaChi",cDonHang.DiaChi);
            CmdSQL.Parameters.AddWithValue("@sNgayTao",cDonHang.NgayTao);
            CmdSQL.Parameters.AddWithValue("@sSDT",cDonHang.SDT);
            CmdSQL.Parameters.AddWithValue("@sNgayGiaoHang",cDonHang.NgayGiaoHang);
            CmdSQL.Parameters.AddWithValue("@sDiaDiem",cDonHang.DiaDiem);
            CmdSQL.Parameters.AddWithValue("@sThanhTien",cDonHang.ThanhTien);
            CmdSQL.Parameters.AddWithValue("@sMaNhanVien",cDonHang.MaNhanVien);
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
        public int suaDonDatHang(clsDonHang cDonHang)
        {
            string sp_updateDonDatHang = "updateDonDatHang";
            SqlCommand CmdSQL = new SqlCommand(sp_updateDonDatHang, conn);
            CmdSQL.CommandType = CommandType.StoredProcedure;
            CmdSQL.Parameters.AddWithValue("@sMaDonHang", cDonHang.MaDonHang);
            CmdSQL.Parameters.AddWithValue("@sMaKhachHang", cDonHang.MaKhachHang);
            CmdSQL.Parameters.AddWithValue("@sTenKhachHang", cDonHang.TenKhachhang);
            CmdSQL.Parameters.AddWithValue("@sDiaChi", cDonHang.DiaChi);
            CmdSQL.Parameters.AddWithValue("@sNgayTao", cDonHang.NgayTao);
            CmdSQL.Parameters.AddWithValue("@sSDT", cDonHang.SDT);
            CmdSQL.Parameters.AddWithValue("@sNgayGiaoHang", cDonHang.NgayGiaoHang);
            CmdSQL.Parameters.AddWithValue("@sDiaDiem", cDonHang.DiaDiem);
            CmdSQL.Parameters.AddWithValue("@sThanhTien", cDonHang.ThanhTien);
            CmdSQL.Parameters.AddWithValue("@sMaNhanVien", cDonHang.MaNhanVien);
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
        public int xoaDonDatHang(clsDonHang cDonHang)
        {
            string sp_deleteDonDatHang = "deleteDonDatHang";
            SqlCommand CmdSQL = new SqlCommand(sp_deleteDonDatHang, conn);
            CmdSQL.CommandType = CommandType.StoredProcedure;
            CmdSQL.Parameters.AddWithValue("@sMaDonHang", cDonHang.MaDonHang);
            //CmdSQL.Parameters.AddWithValue("@sMaKhachHang", cDonHang.MaKhachHang);
            //CmdSQL.Parameters.AddWithValue("@sTenKhachHang", cDonHang.TenKhachhang);
            //CmdSQL.Parameters.AddWithValue("@sDiaChi", cDonHang.DiaChi);
            //CmdSQL.Parameters.AddWithValue("@sNgayTao", cDonHang.NgayTao);
            //CmdSQL.Parameters.AddWithValue("@sSDT", cDonHang.SDT);
            //CmdSQL.Parameters.AddWithValue("@sNgayGiaoHang", cDonHang.NgayGiaoHang);
            //CmdSQL.Parameters.AddWithValue("@sDiaDiem", cDonHang.DiaDiem);
            //CmdSQL.Parameters.AddWithValue("@sThanhTien", cDonHang.ThanhTien);
            //CmdSQL.Parameters.AddWithValue("@sMaNhanVien", cDonHang.MaNhanVien);
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
