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
    public class BLL_HoaDon
    {
        DAL_HoaDon hoaDon = new DAL_HoaDon();
        public int themHoaDon(clsHoaDon cHoaDon)
        {
            return hoaDon.themHoaDon(cHoaDon);
        }
        public int suaHoaDon(clsHoaDon cHoaDon)
        {
            return hoaDon.suaHoaDon(cHoaDon);
        }
        public int xoaHoaDon(clsHoaDon cHoaDon)
        {
            return hoaDon.xoaHoaDon(cHoaDon);
        }
        public DataTable getHoaDon()
        {
            DataTable dtHoaDon;
            dtHoaDon = hoaDon.LayDSHoaDon("HoaDon");
            return dtHoaDon;
        }

    }
}
