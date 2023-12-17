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
    public class BLL_XuatHang
    {
        DAL_XuatHang xuatHang = new DAL_XuatHang();
        public int themHangHoaXuat(clsXuatHang cXuatHang)
        {
            return xuatHang.themHangHoaXuat(cXuatHang);
        }
        public int suaHangHoaXuat(clsXuatHang cXuatHang)
        {
            return xuatHang.suaHangHoaXuat(cXuatHang);
        }
        public int xoaHangHoaXuat(clsXuatHang cXuatHang)
        {
            return xuatHang.xoaHangHoaXuat(cXuatHang);
        }
        public DataTable getHangHoaXuat()
        {
            DataTable dtHangXuat;
            dtHangXuat = xuatHang.LayDSXuatHang("XuatHang");
            return dtHangXuat;
        }
    }
}
