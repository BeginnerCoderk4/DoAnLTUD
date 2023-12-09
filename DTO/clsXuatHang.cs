using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsXuatHang
    {
        private String _MaHangHoa;
        private String _TenHangHoa;
        private String _SoLuong;
        private String _GiaTien;
        private String _XuatXu;
        private String _PCS;
        private String _LoaiHangHoa;
        private String _NgayXuatHang;
        private String _MaNhanVien;
        private String _MaKhoHang;

        public clsXuatHang(string maHangHoa, string tenHangHoa, string soLuong, string giaTien, string xuatXu, string pCS, string loaiHangHoa, string ngayXuatHang, string maNhanVien, string maKhoHang)
        {
            this._MaHangHoa = maHangHoa;
            this._TenHangHoa = tenHangHoa;
            this._SoLuong = soLuong;
            this._GiaTien = giaTien;
            this._XuatXu = xuatXu;
            this._PCS = pCS;
            this._LoaiHangHoa = loaiHangHoa;
            this._NgayXuatHang = ngayXuatHang;
            this._MaNhanVien = maNhanVien;
            this._MaKhoHang = maKhoHang;
        }

        public string MaHangHoa { get => _MaHangHoa; set => _MaHangHoa = value; }
        public string TenHangHoa { get => _TenHangHoa; set => _TenHangHoa = value; }
        public string SoLuong { get => _SoLuong; set => _SoLuong = value; }
        public string GiaTien { get => _GiaTien; set => _GiaTien = value; }
        public string XuatXu { get => _XuatXu; set => _XuatXu = value; }
        public string PCS { get => _PCS; set => _PCS = value; }
        public string LoaiHangHoa { get => _LoaiHangHoa; set => _LoaiHangHoa = value; }
        public string NgayXuatHang { get => _NgayXuatHang; set => _NgayXuatHang = value; }
        public string MaNhanVien { get => _MaNhanVien; set => _MaNhanVien = value; }
        public string MaKhoHang { get => _MaKhoHang; set => _MaKhoHang = value; }
    }
}
