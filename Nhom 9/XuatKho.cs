﻿using BLL;
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
    public partial class XuatKho : Form
    {
        public XuatKho()
        {
            InitializeComponent();
        }
        BLL_XuatHang xuatHang = new BLL_XuatHang();
        private void XuatKho_Load(object sender, EventArgs e)
        {

        }
    }
}
