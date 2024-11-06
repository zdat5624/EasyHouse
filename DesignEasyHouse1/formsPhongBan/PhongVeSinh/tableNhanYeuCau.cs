using DesignEasyHouse1.DAO;
using DesignEasyHouse1.DTO;
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
        public DataTable DanhSachVeSinh(DateTime tu, DateTime den)
        {
            return YeuCauVeSinhDAO.Instance.LayDanhSachYeuCauTuCuDan(tu, den);
        }
        public DataTable DanhSachVeSinhTuan(DateTime tu, DateTime den)
        {
            return YeuCauVeSinhDAO.Instance.LayDanhSachYeuCauTuCuDanTheoTuan(tu, den);
        }
        public DataTable DanhSachVeSinhThang(DateTime tu, DateTime den)
        {
            return YeuCauVeSinhDAO.Instance.LayDanhSachYeuCauTuCuDanTheoThang(tu, den);
        }
        private void formNhanYeuCau_Load(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTu.Value;
            DateTime denNgay = dtpDen.Value;
            DataTable dt;
            if (cbKieuVeSinh.Text == "Định kỳ theo tuần")
            {
                dt = DanhSachVeSinhTuan(tuNgay, denNgay);
            }
            else if (cbKieuVeSinh.Text == "Định kỳ theo tháng")
            {
                dt = DanhSachVeSinhThang(tuNgay, denNgay);
            }
            else
            {
                dt = DanhSachVeSinh( tuNgay, denNgay);
            }
            Console.WriteLine(dt);
            dtgvYeuCauVeSinh.DataSource = dt;
            //if(dtgvTheoDoiVeSinh.Rows.Count == 0)
            //{
            //    MessageBox.Show("Chưa có yêu cầu nào ");
            //}
            // Đặt tiêu đề cột cho DataGridView
            dtgvYeuCauVeSinh.Columns["MaYeuCau"].HeaderText = "Mã Yêu Cầu";
            dtgvYeuCauVeSinh.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dtgvYeuCauVeSinh.Columns["KhuVucVeSinh"].HeaderText = "Khu Vực Vệ Sinh";
            dtgvYeuCauVeSinh.Columns["ThoiGianVeSinh"].HeaderText = "Thời Gian Vệ Sinh";
            dtgvYeuCauVeSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Xóa cột "Thao Tác" nếu đã tồn tại

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbKieuVeSinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            formNhanYeuCau_Load(sender,e);
        }

        private void dtgvYeuCauVeSinh_Resize(object sender, EventArgs e)
        {
            // Thay đổi kích thước của DataGridView theo kích thước form
            dtgvYeuCauVeSinh.Width = this.ClientSize.Width - 20; // Chừa lại khoảng trống nếu cần
            dtgvYeuCauVeSinh.Height = this.ClientSize.Height - 50; // Điều chỉnh chiều cao cho phù hợp
        }
    }
}
