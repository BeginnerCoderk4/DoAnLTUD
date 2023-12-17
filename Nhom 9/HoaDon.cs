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
    }
}
