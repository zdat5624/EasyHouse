﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignEasyHouse1.formsCuDan.moduleThanhToan
{
    public partial class formHoaDonCuDan : Form
    {
        public formHoaDonCuDan()
        {
            InitializeComponent();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Form f = new formsCuDan.formsThanhToan();
            f.ShowDialog();
        }
    }
}
