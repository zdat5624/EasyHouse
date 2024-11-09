using DesignEasyHouse1.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignEasyHouse1.formsCuDan
{
    public partial class formThongBaoCuaCuDan : Form
    {
        public formThongBaoCuaCuDan()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            DataTable dt = ThongBaoDAO.Instance.LayDanhSachThongBao(Session.UserId);
            dtgvThongBao.DataSource = dt;
            dtgvThongBao.Columns["TieuDe"].HeaderText = "Tiêu Đề";
            dtgvThongBao.Columns["ThoiGian"].HeaderText = "Thời Gian";
            dtgvThongBao.Columns["NoiDung"].HeaderText = "Nội Dung";
            int totalWidth = dtgvThongBao.ClientSize.Width;
            dtgvThongBao.Columns["TieuDe"].Width = (int)(totalWidth * 0.2);  // 2/10
            dtgvThongBao.Columns["ThoiGian"].Width = (int)(totalWidth * 0.3); // 5/10
            dtgvThongBao.Columns["NoiDung"].Width = (int)(totalWidth * 0.5);  // 3/10
            dtgvThongBao.DefaultCellStyle.ForeColor = Color.Black;
            dtgvThongBao.DefaultCellStyle.BackColor = Color.White;

        }

        private void formThongBaoCuaCuDan_Load(object sender, EventArgs e)
        {

        }
    }
}
