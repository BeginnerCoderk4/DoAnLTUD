using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class clsNhanVien
    {
        private String _MaNhanVien;
        private String _TenNhanVien;
        private String _GioiTinh;
        private String _NgaySinh;
        private String _DiaChi;
        private String _ChucVu;

        public clsNhanVien(string maNhanVien, string tenNhanVien, string gioiTinh, string ngaySinh, string diaChi, string chucVu)
        {
            this._MaNhanVien = maNhanVien;
            this._TenNhanVien = tenNhanVien;
            this._GioiTinh = gioiTinh;
            this._NgaySinh = ngaySinh;
            this._DiaChi = diaChi;
            this._ChucVu = chucVu;
        }

        public string MaNhanVien { get => _MaNhanVien; set => _MaNhanVien = value; }
        public string TenNhanVien { get => _TenNhanVien; set => _TenNhanVien = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string ChucVu { get => _ChucVu; set => _ChucVu = value; }
    }
}
