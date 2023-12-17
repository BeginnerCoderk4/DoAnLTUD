using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class BLL_KhachHang
    {
        DAL_Khachhang khachhang = new DAL_Khachhang();
        public int themKhachHang(clsKhachHang cKhachHang)
        {
            return khachhang.themKhachhang(cKhachHang);
        }
        public int suaKhachHang(clsKhachHang cKhachHang)
        {
            return khachhang.suaKhachhang(cKhachHang);
        }
        public int xoaKhachHang(clsKhachHang cKhachHang)
        {
            return khachhang.xoaKhachhang(cKhachHang);
        }
        public DataTable getKhachHang()
        {
            DataTable dtKhachHang;
            dtKhachHang = khachhang.LayDSKhachhang("KhachHang");
            return dtKhachHang;
        }
    }
}
