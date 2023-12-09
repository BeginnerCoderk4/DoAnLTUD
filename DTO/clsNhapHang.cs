using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTO
{
    public  class clsNhapHang
    {
        private String _MaHangHoa;
        private String _TenHangHoa;
        private String _SoLuong;
        private String _GiaTien;
        private String _XuatXu;
        private String _PCS;
        private String _LoaiHangHoa;
        private String _NgayNhapHang;
        private String _MaNhanVien;

        public clsNhapHang(string maHangHoa, string tenHangHoa, string soLuong, string giaTien, string xuatXu, string pCS, string loaiHangHoa, string ngayNhapHang, string maNhanVien)
        {
            this._MaHangHoa = maHangHoa;
            this._TenHangHoa = tenHangHoa;
            this._SoLuong = soLuong;
            this._GiaTien = giaTien;
            this._XuatXu = xuatXu;
            this._PCS = pCS;
            this._LoaiHangHoa = loaiHangHoa;
            this._NgayNhapHang = ngayNhapHang;
            this._MaNhanVien = maNhanVien;
        }

        public string MaHangHoa { get => _MaHangHoa; set => _MaHangHoa = value; }
        public string TenHangHoa { get => _TenHangHoa; set => _TenHangHoa = value; }
        public string SoLuong { get => _SoLuong; set => _SoLuong = value; }
        public string GiaTien { get => _GiaTien; set => _GiaTien = value; }
        public string XuatXu { get => _XuatXu; set => _XuatXu = value; }
        public string PCS { get => _PCS; set => _PCS = value; }
        public string LoaiHangHoa { get => _LoaiHangHoa; set => _LoaiHangHoa = value; }
        public string NgayNhapHang { get => _NgayNhapHang; set => _NgayNhapHang = value; }
        public string MaNhanVien { get => _MaNhanVien; set => _MaNhanVien = value; }
    }
}
