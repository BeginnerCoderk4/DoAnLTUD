using BLL;
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

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void QuanLyKhachhang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = khachHang.getKhachHang();
        }
    }
}
