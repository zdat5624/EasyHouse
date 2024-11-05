using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignEasyHouse1.formsGiamDoc.QuanLyNhanVien
{
    public partial class DanhSachNhanVien : Form
    {
        public DanhSachNhanVien()
        {
            InitializeComponent();
        }

        private void DanhSachNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btnThemHopDong_Click(object sender, EventArgs e)
        {
            Form themNhanVien = new ThemNhanVien();
            themNhanVien.ShowDialog();
        }

        private void DanhSachNhanVien_Resize(object sender, EventArgs e)
        {
            // Đặt chiều rộng và chiều cao của DataGridView theo tỷ lệ nhất định của form
            dtgvDanhSachNhanVien.Width = (int)(this.ClientSize.Width * 0.4); // 90% chiều rộng
            dtgvDanhSachNhanVien.Height = (int)(this.ClientSize.Height * 0.4); // 90% chiều cao
        }

        private void panelTren_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
