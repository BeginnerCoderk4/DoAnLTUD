using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsDonHang
    {
        private String _MaDonHang;
        private String _MaKhachHang;
        private String _TenKhachhang;
        private String _DiaChi;
        private String _NgayTao;
        private String _SDT;
        private String _NgayGiaoHang;
        private String _DiaDiem;
        private String _ThanhTien;
        private String _MaNhanVien;

        public clsDonHang(string maDonHang, string maKhachHang, string tenKhachhang, string diaChi, string ngayTao, string sDT, string ngayGiaoHang, string diaDiem, string thanhTien, string maNhanVien)
        {
            this._MaDonHang = maDonHang;
            this._MaKhachHang = maKhachHang;
            this._TenKhachhang = tenKhachhang;
            this._DiaChi = diaChi;
            this._NgayTao = ngayTao;
            this._SDT = sDT;
            this._NgayGiaoHang = ngayGiaoHang;
            this._DiaDiem = diaDiem;
            this._ThanhTien = thanhTien;
            this._MaNhanVien = maNhanVien;
        }

        public string MaDonHang { get => _MaDonHang; set => _MaDonHang = value; }
        public string MaKhachHang { get => _MaKhachHang; set => _MaKhachHang = value; }
        public string TenKhachhang { get => _TenKhachhang; set => _TenKhachhang = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string NgayTao { get => _NgayTao; set => _NgayTao = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string NgayGiaoHang { get => _NgayGiaoHang; set => _NgayGiaoHang = value; }
        public string DiaDiem { get => _DiaDiem; set => _DiaDiem = value; }
        public string ThanhTien { get => _ThanhTien; set => _ThanhTien = value; }
        public string MaNhanVien { get => _MaNhanVien; set => _MaNhanVien = value; }
    }
}
