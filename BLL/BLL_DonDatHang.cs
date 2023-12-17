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
    public class BLL_DonDatHang
    {
        DAL_DonDatHang datHang = new DAL_DonDatHang();
        public int themDonDatHang(clsDonHang cDonHang)
        {
            return datHang.themDonDatHang(cDonHang);
        }
        public int suaDonDatHang(clsDonHang cDonHang)
        {
            return datHang.suaDonDatHang(cDonHang);
        }
        public int xoaDonDatHang(clsDonHang cDonHang)
        {
            return datHang.xoaDonDatHang(cDonHang);
        }
        public DataTable getDonDatHang()
        {
            DataTable dtDonDatHang;
            dtDonDatHang = datHang.LayDSDonHang("DonDatHang");
            return dtDonDatHang;
        }
    }
}
