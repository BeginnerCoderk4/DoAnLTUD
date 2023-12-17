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

        }

        private void xuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void khoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thốngKêHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đơnĐặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            dgvDataNV.DataSource = nhanVien.getNhanVien();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {

        }

        private void dgvDataNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
