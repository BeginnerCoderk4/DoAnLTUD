using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsKhachHang
    {
        private String _MaKhachhang;
        private String _TenKhachHang;
        private String _NgaySinh;
        private String _DiaChi;
        private String _SDT;
        private String _Email;

        public clsKhachHang(string maKhachhang, string tenKhachHang, string ngaySinh, string diaChi, string sDT, string email)
        {
            this._MaKhachhang = maKhachhang;
            this._TenKhachHang = tenKhachHang;
            this._NgaySinh = ngaySinh;
            this._DiaChi = diaChi;
            this._SDT = sDT;
            this._Email = email;
        }

        public string MaKhachhang { get => _MaKhachhang; set => _MaKhachhang = value; }
        public string TenKhachHang { get => _TenKhachHang; set => _TenKhachHang = value; }
        public string NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string Email { get => _Email; set => _Email = value; }
    }
}
