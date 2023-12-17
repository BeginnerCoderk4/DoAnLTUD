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
    public partial class DonDatHang : Form
    {
        public DonDatHang()
        {
            InitializeComponent();
        }
        BLL_DonDatHang donDatHang = new BLL_DonDatHang();
        private void DonDatHang_Load(object sender, EventArgs e)
        {
            
        }
    }
}
