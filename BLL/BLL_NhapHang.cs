using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_NhapHang
    {
        DAL_NhapHang nhapHang = new DAL_NhapHang();
        public int themHangHoaNhap(clsNhapHang cNhapHang)
        {
            return nhapHang.themHangHoaNhap(cNhapHang);
        }
        public int suaHangHoaNhap(clsNhapHang cNhapHang)
        {
            return nhapHang.suaHangHoaNhap(cNhapHang);
        }
        public int xoaHangHoaNhap(clsNhapHang cNhapHang)
        {
            return nhapHang.xoaHangHoaNhap(cNhapHang);
        }
        public DataTable getHangHoaNhap()
        {
            DataTable dtHangNhap;
            dtHangNhap = nhapHang.LayDSNhapHang("NhapHang");
            return dtHangNhap;
        }
    }
}
