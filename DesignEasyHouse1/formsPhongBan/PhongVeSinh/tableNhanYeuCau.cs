using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignEasyHouse1.formsPhongBan.PhongVeSinh
{
    public partial class tableNhanYeuCau : Form
    {
        public tableNhanYeuCau()
        {
            InitializeComponent();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formNhanYeuCau_Load(object sender, EventArgs e)
        {
            //dgrYeuCauVeSinh.AutoGenerateColumns=false;
            //dgrYeuCauVeSinh.Rows.Add(1, "Nguyen Van A", "Khu A", "Đã xử lý", "Cư dân hài lòng");
            //dgrYeuCauVeSinh.Rows.Add(2, "Le Thi B", "Khu B", "Đang xử lý", "Chưa phản hồi");
            //dgrYeuCauVeSinh.Rows.Add(3, "Tran Van C", "Khu C", "Chưa xử lý", "Yêu cầu khẩn cấp");
            //dgrYeuCauVeSinh.Rows.Add(4, "Pham Thi D", "Khu D", "Đã xử lý", "Cần xem xét lại");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
