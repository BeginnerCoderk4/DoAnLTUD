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
    public partial class DonDatHang : Form
    {
        public DonDatHang()
        {
            InitializeComponent();
        }
        BLL_DonDatHang donDatHang = new BLL_DonDatHang();
        private void DonDatHang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = donDatHang.getDonDatHang();
        }

        private void btnTaoDon_Click(object sender, EventArgs e)
        {
            string madonhang = txtMaDonHang.Text;
            string makhachhang = txtMaKhachHang.Text;
            string tenkhachhang = txtTenKhachHang.Text;
            string ngaytao = dtbNgayGiao.Text;
            string sodienthoai = mtbSDT.Text;
            string diachi = txtDiaChi.Text;
            string ngaygiaohang = dtbNgayGiao.Text;
            string diadiem = txtDiaDiem.Text;
            string thanhtien = txtThanhTien.Text;
            clsDonHang DonHang = new clsDonHang(madonhang, makhachhang, tenkhachhang, ngaytao, sodienthoai, diachi, ngaygiaohang, diadiem, thanhtien);
            if (donDatHang.themDonDatHang(DonHang) >= 0)
            {
                MessageBox.Show("thêm thành công");
                dataGridView1.DataSource = donDatHang.getDonDatHang();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaDonHang.Text = string.Empty;
            txtMaKhachHang.Text = string.Empty;
            txtTenKhachHang.Text = string.Empty;
            mtbSDT.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtDiaDiem.Text = string.Empty;
            txtThanhTien.Text = string.Empty;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
