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
    public partial class QuanLyKhachhang : Form
    {
        public QuanLyKhachhang()
        {
            InitializeComponent();
        }
        BLL_KhachHang khachHang = new BLL_KhachHang();
        private void btnThem_Click(object sender, EventArgs e)
        {
            string makh = txtMaKH.Text;
            string tenkh=txtTenKH.Text;
            string ngaysinh=mtbNgaySinh.Text;
            string diachi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            string email = txtEmail.Text;
            clsKhachHang ckhachhang = new clsKhachHang(makh, tenkh, ngaysinh, diachi, sdt, email);
            try
            {
                if (khachHang.themKhachHang(ckhachhang) >= 0)
                {
                    MessageBox.Show("thêm thành công");
                    dgvKhachHang.DataSource = khachHang.getKhachHang();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("thêm không thành công");
                throw;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string makh = txtMaKH.Text;
            string tenkh = txtTenKH.Text;
            string ngaysinh = mtbNgaySinh.Text;
            string diachi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            string email = txtEmail.Text;
            clsKhachHang ckhachhang = new clsKhachHang(makh, tenkh, ngaysinh, diachi, sdt, email);
            try
            {
                if (khachHang.xoaKhachHang(ckhachhang) >= 0)
                {
                    MessageBox.Show("xóa thành công");
                    dgvKhachHang.DataSource = khachHang.getKhachHang();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("xóa không thành công");
                throw;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string makh = txtMaKH.Text;
            string tenkh = txtTenKH.Text;
            string ngaysinh = mtbNgaySinh.Text;
            string diachi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            string email = txtEmail.Text;
            clsKhachHang ckhachhang = new clsKhachHang(makh, tenkh, ngaysinh, diachi, sdt, email);
            try
            {
                if (khachHang.suaKhachHang(ckhachhang) >= 0)
                {
                    MessageBox.Show("sửa thành công");
                    dgvKhachHang.DataSource = khachHang.getKhachHang();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("sửa không thành công");
                throw;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuanLyKhachhang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = khachHang.getKhachHang();
        }
    }
}
