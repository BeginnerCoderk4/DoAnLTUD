using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom_9
{
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }
        BLL_HoaDon hoaDon = new BLL_HoaDon();
        private void HoaDon_Load(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = hoaDon.getHoaDon();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            string mahoadon = txtMaHoaDon.Text;
            string ngayinhoadon = mtbNgayInHD.Text;
            string manhanvien = txtMaNhanVien.Text;
            string tennhanvien = txtTenNhanVien.Text;
            string makhachhang = txtMaKhachHang.Text;
            string tenkhachhang = txtTenKhachHang.Text;
            string diachi = txtDiaChi.Text;
            string sodienthoai = mtbSDT.Text;
            string tongthanhtien = txtTongThanhTien.Text;
            clsHoaDon HoaDon = new clsHoaDon(mahoadon, ngayinhoadon, manhanvien, tennhanvien, makhachhang, tenkhachhang, diachi, tongthanhtien, sodienthoai);
            if (hoaDon.themHoaDon(HoaDon) >= 0)
            {
                MessageBox.Show("tạo thành công");
                dgvHoaDon.DataSource = hoaDon.getHoaDon();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHoaDon.Text = string.Empty;
            mtbNgayInHD.Text = string.Empty;
            txtMaNhanVien.Text = string.Empty;
            txtTenNhanVien.Text = string.Empty;
            txtMaKhachHang.Text = string.Empty;
            txtTenKhachHang.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            mtbSDT.Text = string.Empty;
            txtTongThanhTien.Text = string.Empty;
        }

        private void btnHuyHoaDon_Click(object sender, EventArgs e)
        {
            string mahoadon = txtMaHoaDon.Text;
            clsHoaDon HoaDon = new clsHoaDon(mahoadon);
            if (hoaDon.xoaHoaDon(HoaDon) >= 0)
            {
                MessageBox.Show("hủy thành công");
                dgvHoaDon.DataSource = hoaDon.getHoaDon();
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
