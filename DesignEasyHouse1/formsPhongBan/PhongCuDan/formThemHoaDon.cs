using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignEasyHouse1.formsPhongBan.PhongCuDan
{
    public partial class formThemHoaDon : Form
    {
        string phanLoai;
        public formThemHoaDon(string phanLoai)
        {
            InitializeComponent();
            this.phanLoai = phanLoai;
            txtPhanLoai.Text = phanLoai;
        }

        void ThemHoaDon()
        {
            float tongTien;
            string noiDung;
            int cuDanID;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemHoaDon();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
