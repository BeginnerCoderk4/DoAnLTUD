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
    public class BLL_KhoHang
    {
        DAL_KhoHang khoHang = new DAL_KhoHang();
        public int themKhoHang(clsKhoHang cKhoHang)
        {
            return khoHang.themKhoHang(cKhoHang);
        }
        public int suaKhoHang(clsKhoHang cKhoHang)
        {
            return khoHang.suaKhoHang(cKhoHang);
        }
        public int xoaKhoHang(clsKhoHang cKhoHang)
        {
            return khoHang.xoaKhoHang(cKhoHang);
        }
        public DataTable getKhoHang()
        {
            DataTable dtKhoHang;
            dtKhoHang = khoHang.LayDSKhoHang("KhoHang");
            return dtKhoHang;
        }
    }
}
