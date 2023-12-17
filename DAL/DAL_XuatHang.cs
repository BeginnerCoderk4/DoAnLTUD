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
    public class DAL_XuatHang:connectDB
    {
        public DataTable LayDSXuatHang(string NameTable)
        {
            DataTable dtXuatHang = new DataTable();
            string sSQL = "sp_Get_Table";
            SqlCommand cmdSQL = new SqlCommand(sSQL, conn);
            cmdSQL.Parameters.AddWithValue("@Table_Name", NameTable);
            SqlDataAdapter daXuatHang = new SqlDataAdapter(cmdSQL);
            daXuatHang.Fill(dtXuatHang);
            return dtXuatHang;
        }

        public int themHangHoaXuat(clsXuatHang cXuatHang)
        {
            string sp_XuatHang = "insertXuatHang";
            SqlCommand cmdSQL = new SqlCommand(sp_XuatHang, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@sMaHangHoa", cXuatHang.MaHangHoa);
            cmdSQL.Parameters.AddWithValue("@sTenHangHoa", cXuatHang.TenHangHoa);
            cmdSQL.Parameters.AddWithValue("@iSoLuong", cXuatHang.SoLuong);
            cmdSQL.Parameters.AddWithValue("@iGiaTien", cXuatHang.GiaTien);
            cmdSQL.Parameters.AddWithValue("@sXuatXu", cXuatHang.XuatXu);
            cmdSQL.Parameters.AddWithValue("@sPCS", cXuatHang.PCS);
            cmdSQL.Parameters.AddWithValue("@sLoaiHangHoa", cXuatHang.LoaiHangHoa);
            cmdSQL.Parameters.AddWithValue("@sNgayXuathang", cXuatHang.NgayXuatHang);
            cmdSQL.Parameters.AddWithValue("@sMaNhanVien", cXuatHang.MaNhanVien);
            cmdSQL.Parameters.AddWithValue("@sMaKhoHang", cXuatHang.MaKhoHang);

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
        public int suaHangHoaXuat(clsXuatHang cXuatHang)
        {
            string sp_updateXuatHang = "updateXuatHang";
            SqlCommand cmdSQL = new SqlCommand(sp_updateXuatHang, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@sMaHangHoa", cXuatHang.MaHangHoa);
            cmdSQL.Parameters.AddWithValue("@sTenHangHoa", cXuatHang.TenHangHoa);
            cmdSQL.Parameters.AddWithValue("@iSoLuong", cXuatHang.SoLuong);
            cmdSQL.Parameters.AddWithValue("@iGiaTien", cXuatHang.GiaTien);
            cmdSQL.Parameters.AddWithValue("@sXuatXu", cXuatHang.XuatXu);
            cmdSQL.Parameters.AddWithValue("@sPCS", cXuatHang.PCS);
            cmdSQL.Parameters.AddWithValue("@sLoaiHangHoa", cXuatHang.LoaiHangHoa);
            cmdSQL.Parameters.AddWithValue("@sNgayXuatHang", cXuatHang.NgayXuatHang);
            cmdSQL.Parameters.AddWithValue("@sMaNhanVien", cXuatHang.MaNhanVien);
            cmdSQL.Parameters.AddWithValue("@sMaKhoHang", cXuatHang.MaKhoHang);

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
        public int xoaHangHoaXuat(clsXuatHang cXuatHang)
        {
            string sp_deleteXuatHang = "deleteXuatHang";
            SqlCommand cmdSQL = new SqlCommand(sp_deleteXuatHang, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@sMaHangHoa", cXuatHang.MaHangHoa);
            //cmdSQL.Parameters.AddWithValue("@sTenHangHoa", cXuatHang.TenHangHoa);
            //cmdSQL.Parameters.AddWithValue("@iSoLuong", cXuatHang.SoLuong);
            //cmdSQL.Parameters.AddWithValue("@iGiaTien", cXuatHang.GiaTien);
            //cmdSQL.Parameters.AddWithValue("@sXuatXu", cXuatHang.XuatXu);
            //cmdSQL.Parameters.AddWithValue("@sPCS", cXuatHang.PCS);
            //cmdSQL.Parameters.AddWithValue("@sLoaiHangHoa", cXuatHang.LoaiHangHoa);
            //cmdSQL.Parameters.AddWithValue("@sNgayXuatHang", cXuatHang.NgayXuatHang);
            //cmdSQL.Parameters.AddWithValue("@sMaNhanVien", cXuatHang.MaNhanVien);
            //cmdSQL.Parameters.AddWithValue("@sMaKhoHang", cXuatHang.MaKhoHang);

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
