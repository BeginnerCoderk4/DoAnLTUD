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
    public class DAL_NhapHang:connectDB
    {
        public DataTable LayDSNhapHang(string NameTable)
        {
            DataTable dtNhapHang = new DataTable();
            string sSQL = "sp_Get_Table";
            SqlCommand cmdSQL = new SqlCommand(sSQL, conn);
            cmdSQL.Parameters.AddWithValue("@Table_Name", NameTable);
            SqlDataAdapter daNhapHang = new SqlDataAdapter(cmdSQL);
            daNhapHang.Fill(dtNhapHang);
            return dtNhapHang;
        }
        public int themHangHoaNhap(clsNhapHang cNhapHang)
        {
            string sp_NhapHang = "insertNhapHang";
            SqlCommand cmdSQL = new SqlCommand(sp_NhapHang, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@sMaHangHoa", cNhapHang.MaHangHoa);
            cmdSQL.Parameters.AddWithValue("@sTenHangHoa", cNhapHang.TenHangHoa);
            cmdSQL.Parameters.AddWithValue("@iSoLuong", cNhapHang.SoLuong);
            cmdSQL.Parameters.AddWithValue("@iGiaTien", cNhapHang.GiaTien);
            cmdSQL.Parameters.AddWithValue("@sXuatXu", cNhapHang.XuatXu);
            cmdSQL.Parameters.AddWithValue("@sPCS", cNhapHang.PCS);
            cmdSQL.Parameters.AddWithValue("@sLoaiHangHoa", cNhapHang.LoaiHangHoa);
            cmdSQL.Parameters.AddWithValue("@sNgayNhapHang",  cNhapHang.NgayNhapHang);
            cmdSQL.Parameters.AddWithValue("@sMaNhanVien",  cNhapHang.MaNhanVien);

            int result = 0;
            try
            {
                if (cmdSQL.ExecuteNonQuery() >= 0)
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
        public int suaHangHoaNhap(clsNhapHang cNhapHang)
        {
            string sp_updateNhapHang = "updateNhapHang";
            SqlCommand cmdSQL = new SqlCommand(sp_updateNhapHang, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@sMaHangHoa", cNhapHang.MaHangHoa);
            cmdSQL.Parameters.AddWithValue("@sTenHangHoa", cNhapHang.TenHangHoa);
            cmdSQL.Parameters.AddWithValue("@iSoLuong", cNhapHang.SoLuong);
            cmdSQL.Parameters.AddWithValue("@iGiaTien", cNhapHang.GiaTien);
            cmdSQL.Parameters.AddWithValue("@sXuatXu", cNhapHang.XuatXu);
            cmdSQL.Parameters.AddWithValue("@sPCS", cNhapHang.PCS);
            cmdSQL.Parameters.AddWithValue("@sLoaiHangHoa", cNhapHang.LoaiHangHoa);
            cmdSQL.Parameters.AddWithValue("@sNgayNhapHang", cNhapHang.NgayNhapHang); 
            cmdSQL.Parameters.AddWithValue("@sMaNhanVien", cNhapHang.MaNhanVien);


            int result = 0;
            try
            {
                if (cmdSQL.ExecuteNonQuery() >= 0)
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
        public int xoaHangHoaNhap(clsNhapHang cNhapHang)
        {
            string sp_deleteNhapHang = "deleteNhapHang";
            SqlCommand cmdSQL = new SqlCommand(sp_deleteNhapHang, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@sMaHangHoa", cNhapHang.MaHangHoa);
            //cmdSQL.Parameters.AddWithValue("@sTenHangHoa", cNhapHang.TenHangHoa);
            //cmdSQL.Parameters.AddWithValue("@iSoLuong", cNhapHang.SoLuong);
            //cmdSQL.Parameters.AddWithValue("@iGiaTien", cNhapHang.GiaTien);
            //cmdSQL.Parameters.AddWithValue("@sXuatXu", cNhapHang.XuatXu);
            //cmdSQL.Parameters.AddWithValue("@sPCS", cNhapHang.PCS);
            //cmdSQL.Parameters.AddWithValue("@sLoaiHangHoa", cNhapHang.LoaiHangHoa);
            //cmdSQL.Parameters.AddWithValue("@sNgayNhapHang", cNhapHang.NgayNhapHang);

            int result = 0;
            try
            {
                if (cmdSQL.ExecuteNonQuery() >= 0)
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
