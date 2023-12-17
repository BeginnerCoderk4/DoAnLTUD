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
    public class BLL_NhanVien
    {
        DAL_NhanVien nhanVien = new DAL_NhanVien();
        public int themNhanVien(clsNhanVien cNhanVien)
        {
            return nhanVien.themNhanVien(cNhanVien);
        }
        public int suaNhanVien(clsNhanVien cNhanVien)
        {
            return nhanVien.suaNhanVien(cNhanVien);
        }
        public int xoaNhanVien(clsNhanVien cNhanVien)
        {
            return nhanVien.xoaNhanVien(cNhanVien);
        }
        public DataTable getNhanVien()
        {
            DataTable dtNhanVien;
            dtNhanVien = nhanVien.LayDSNhanVien("NhanVien");
            return dtNhanVien;
        }

    }
}
