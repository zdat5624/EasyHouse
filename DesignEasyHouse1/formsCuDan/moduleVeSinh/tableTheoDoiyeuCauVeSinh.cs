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

namespace DesignEasyHouse1.formsCuDan.moduleVeSinh
{
    public partial class tableTheoDoiyeuCauVeSinh : Form
    {
        List<YeuCauDichVuVeSinh> dsVeSinh;
        public tableTheoDoiyeuCauVeSinh()
        {
            InitializeComponent();
        }
        public DataTable DanhSachVeSinh(int cuDanId, DateTime tuNgay, DateTime denNgay)
        {
            return YeuCauVeSinhDAO.Instance.GetDanhSachVeSinh(cuDanId, tuNgay, denNgay);
        }

        public DataTable DanhSachVeSinhThang(int cuDanId, DateTime tuNgay, DateTime denNgay)
        {
            return YeuCauVeSinhDAO.Instance.GetDanhSachVeSinhThang(cuDanId, tuNgay, denNgay);
        }
        public DataTable DanhSachVeSinhTuan(int cuDanId, DateTime tuNgay, DateTime denNgay)
        {
            return YeuCauVeSinhDAO.Instance.GetDanhSachVeSinhTuan(cuDanId, tuNgay, denNgay);
        }
        private void tableTheoDoiyeuCauVeSinh_Load(object sender, EventArgs e)
        {

            int cuDanId = 1;
            DataTable dt = null;
            DateTime tuNgay = dtpTu.Value;
            DateTime denNgay = dtpDen.Value;


            if (cbDinhKy.Text == "Tuần")
            {
                dt = DanhSachVeSinhTuan(cuDanId,tuNgay,denNgay);
            }
            else if (cbDinhKy.Text == "Tháng")
            {
                dt = DanhSachVeSinhThang(cuDanId, tuNgay, denNgay);
            }
            else
            {
                dt = DanhSachVeSinh(cuDanId, tuNgay, denNgay);
            }

            dtgvTheoDoiVeSinh.DataSource = dt;
            //if(dtgvTheoDoiVeSinh.Rows.Count == 0)
            //{
            //    MessageBox.Show("Chưa có yêu cầu nào ");
            //}
            // Đặt tiêu đề cột cho DataGridView
            dtgvTheoDoiVeSinh.Columns["MaYeuCau"].HeaderText = "Mã Yêu Cầu";
            dtgvTheoDoiVeSinh.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dtgvTheoDoiVeSinh.Columns["KhuVucVeSinh"].HeaderText = "Khu Vực Vệ Sinh";
            dtgvTheoDoiVeSinh.Columns["ThoiGianVeSinh"].HeaderText = "Thời Gian Vệ Sinh";
            // Xóa cột "Thao Tác" nếu đã tồn tại
            if (dtgvTheoDoiVeSinh.Columns.Contains("Xóa"))
            {
                dtgvTheoDoiVeSinh.Columns.Remove("Xóa");
            }
            // Tạo cột mới cho nút chỉnh sửa và xóa
            DataGridViewButtonColumn DeleteColumn = new DataGridViewButtonColumn();
            DeleteColumn.Name = "Xóa";
            DeleteColumn.HeaderText = "Thao Tác";
            DeleteColumn.Text = "Xóa";
            DeleteColumn.UseColumnTextForButtonValue = true;
            // Sử dụng cùng một giá trị cho tất cả các nút
            dtgvTheoDoiVeSinh.Columns.Add(DeleteColumn);

            // Đặt chiều rộng cho cột nút
            dtgvTheoDoiVeSinh.Columns[DeleteColumn.Index].Width = 50;
        }

        // Sự kiện khi người dùng nhấn vào nút

        private void dtgvTheoDoiVeSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                // Lấy mã yêu cầu từ hàng tương ứng
                int maYeuCau = Convert.ToInt32(dtgvTheoDoiVeSinh.Rows[e.RowIndex].Cells["MaYeuCau"].Value);

                // Thực hiện hành động xóa yêu cầu
                if (MessageBox.Show("Bạn có muốn xóa yêu cầu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //// Xóa yêu cầu từ cơ sở dữ liệu
                    if (YeuCauVeSinhDAO.Instance.DeleteYeuCauVeSinh(maYeuCau))
                    {
                        MessageBox.Show("Xóa thành công yêu cầu");
                            
                        dtgvTheoDoiVeSinh.DataSource = null; // Xóa nguồn dữ liệu
                        tableTheoDoiyeuCauVeSinh_Load(sender, e);
                    }
            }
        }

        private void dtgvTheoDoiVeSinh_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Kiểm tra xem cột có phải là cột xóa không
            if (e.ColumnIndex == dtgvTheoDoiVeSinh.Columns["Xóa"].Index && e.RowIndex >= 0)
            {
                // Vẽ nền màu đỏ
                e.Graphics.FillRectangle(new SolidBrush(Color.Red), e.CellBounds);

                // Căn giữa văn bản
                StringFormat stringFormat = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

                // Vẽ văn bản
                e.Graphics.DrawString("Xóa", e.CellStyle.Font, Brushes.White, e.CellBounds, stringFormat);

                // Vẽ viền dưới
                e.Graphics.DrawLine(Pens.Black, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1);

                // Đánh dấu rằng chúng ta đã xử lý sự kiện vẽ
                e.Handled = true;
            }
        }

        private void dtpThoiGianKetThuc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnKieuVeSinh_Click(object sender, EventArgs e)
        {
            tableTheoDoiyeuCauVeSinh_Load(sender,e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
 }
