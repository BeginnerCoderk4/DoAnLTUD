using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class clsHoaDon
    {
        private String _MaHoaDon;
        private String _NgayInHoaDon;
        private String _MaNhanVien;
        private String _TenNhanVien;
        private String _MaKhachHang;
        private String _TenKhachhang;
        private String _SDT;
        private String _DiaChi;
        private String _TongTien;

        public clsHoaDon(string maHoaDon, string ngayInHoaDon, string maNhanVien, string tenNhanVien, string maKhachHang, string tenKhachhang, string diaChi, string tongTien, string sDT)
        {
            this._MaHoaDon = maHoaDon;
            this._NgayInHoaDon = ngayInHoaDon;
            this._MaNhanVien = maNhanVien;
            this._TenNhanVien = tenNhanVien;
            this._MaKhachHang = maKhachHang;
            this._TenKhachhang = tenKhachhang;
            this._SDT = sDT;
            this._DiaChi = diaChi;
            this._TongTien = tongTien;
            
        }

        public clsHoaDon(string maHoaDon)
        {
            this._MaHoaDon = maHoaDon;
        }

        public string MaHoaDon { get => _MaHoaDon; set => _MaHoaDon = value; }
        public string NgayInHoaDon { get => _NgayInHoaDon; set => _NgayInHoaDon = value; }
        public string MaNhanVien { get => _MaNhanVien; set => _MaNhanVien = value; }
        public string TenNhanVien { get => _TenNhanVien; set => _TenNhanVien = value; }
        public string MaKhachHang { get => _MaKhachHang; set => _MaKhachHang = value; }
        public string TenKhachhang { get => _TenKhachhang; set => _TenKhachhang = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string TongTien { get => _TongTien; set => _TongTien = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
    }
}
