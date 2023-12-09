using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsKhoHang
    {
        private string _MaKhoHang;
        private string _MaHangNhap;
        private string _MaNhanVien;

        public clsKhoHang(string maKhoHang, string maHangNhap, string maNhanVien)
        {
            this._MaKhoHang = maKhoHang;
            this._MaHangNhap = maHangNhap;
            this._MaNhanVien = maNhanVien;
        }

        public string MaKhoHang { get => _MaKhoHang; set => _MaKhoHang = value; }
        public string MaHangNhap { get => _MaHangNhap; set => _MaHangNhap = value; }
        public string MaNhanVien { get => _MaNhanVien; set => _MaNhanVien = value; }
    }
}
