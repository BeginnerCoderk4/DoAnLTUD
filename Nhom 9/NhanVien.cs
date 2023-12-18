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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        BLL_NhanVien nhanVien = new BLL_NhanVien();
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 nk = new Form1();
            nk.Show();
        }

        private void xuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XuatKho xk = new XuatKho();
            xk.Show();
        }

        private void khoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyKhachhang qlkh = new QuanLyKhachhang();
            qlkh.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyKhachhang qlkh = new QuanLyKhachhang();
            qlkh.Show();
        }

        private void thốngKêHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeHangHoa tkhh = new ThongKeHangHoa();
            tkhh.Show();
        }

        private void đơnĐặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonDatHang ddh = new DonDatHang();
            ddh.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            hd.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            dgvDataNV.DataSource = nhanVien.getNhanVien();
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nu");
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string hoten = txtTenNV.Text;
            string gioiTinh = cboGioiTinh.Text;
            string ngaySinh = txtNgaySinh.Text;
            string diaChi = txtDiaChi.Text;
            string chucVu = txtChucVu.Text;
            clsNhanVien cNhanVien = new clsNhanVien(maNV, hoten, gioiTinh, ngaySinh, diaChi, chucVu);
            try
            {
                if (nhanVien.themNhanVien(cNhanVien) >= 0)
                {
                    MessageBox.Show("Thêm thành công");
                    dgvDataNV.DataSource = nhanVien.getNhanVien();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm không thành công");
                throw;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string hoten = txtTenNV.Text;
            string gioiTinh = cboGioiTinh.Text;
            string ngaySinh = txtNgaySinh.Text;
            string diaChi = txtDiaChi.Text;
            string chucVu = txtChucVu.Text;
            clsNhanVien cNhanVien = new clsNhanVien(maNV, hoten, gioiTinh, ngaySinh, diaChi, chucVu);
            try
            {
                if (nhanVien.xoaNhanVien(cNhanVien) >= 0)
                {
                    MessageBox.Show("xóa thành công");
                    dgvDataNV.DataSource = nhanVien.getNhanVien();
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
            string maNV = txtMaNV.Text;
            string hoten = txtTenNV.Text;
            string gioiTinh = cboGioiTinh.Text;
            string ngaySinh = txtNgaySinh.Text;
            string diaChi = txtDiaChi.Text;
            string chucVu = txtChucVu.Text;
            clsNhanVien cNhanVien = new clsNhanVien(maNV, hoten, gioiTinh, ngaySinh, diaChi, chucVu);
            try
            {
                if (nhanVien.suaNhanVien(cNhanVien) >= 0)
                {
                    MessageBox.Show("sửa thành công");
                    dgvDataNV.DataSource = nhanVien.getNhanVien();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("sửa không thành công");
                throw;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            cboGioiTinh.Text = null;
            txtNgaySinh.Text = "";
            txtDiaChi.Text = "";
            txtChucVu.Text = "";    
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void dgvDataNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow=e.RowIndex;
            txtMaNV.Text = dgvDataNV.Rows[numrow].Cells[0].Value.ToString();
            txtTenNV.Text = dgvDataNV.Rows[numrow].Cells[1].Value.ToString();
            cboGioiTinh.Text = dgvDataNV.Rows[numrow].Cells[2].Value.ToString();
            txtNgaySinh.Text = dgvDataNV.Rows[numrow].Cells[3].Value.ToString();
            txtDiaChi.Text = dgvDataNV.Rows[numrow].Cells[4].Value.ToString();
            txtChucVu.Text = dgvDataNV.Rows[numrow].Cells[5].Value.ToString();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
