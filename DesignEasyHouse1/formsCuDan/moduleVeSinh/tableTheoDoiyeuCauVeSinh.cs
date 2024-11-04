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
            if (dtgvTheoDoiVeSinh.Columns.Contains("Chỉnh sửa"))
            {
                dtgvTheoDoiVeSinh.Columns.Remove("Chỉnh sửa");
            }
            // Tạo cột mới cho nút chỉnh sửa và xóa
            DataGridViewButtonColumn DeleteColumn = new DataGridViewButtonColumn();
            DeleteColumn.Name = "Chỉnh sửa";
            DeleteColumn.HeaderText = "Chỉnh sửa";
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
            //int maYeuCau = Convert.ToInt32(dtgvTheoDoiVeSinh.Rows[e.RowIndex].Cells["MaYeuCau"].Value);
            // Kiểm tra nếu hàng và cột đều hợp lệ
            if (e.RowIndex >= 0 && e.ColumnIndex == dtgvTheoDoiVeSinh.Columns["Chỉnh sửa"].Index)
            {
                // Kiểm tra xem ô có giá trị không
                if (dtgvTheoDoiVeSinh.Rows[e.RowIndex].Cells["MaYeuCau"].Value != null &&
                    int.TryParse(dtgvTheoDoiVeSinh.Rows[e.RowIndex].Cells["MaYeuCau"].Value.ToString(), out int maYeuCau) &&
                    (dtgvTheoDoiVeSinh.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString() == "Đang chờ xử lý"))
                {
                    // Xử lý với maYeuCau
                    // Ví dụ: sử dụng maYeuCau để thực hiện các hành động khác
                   
                    MessageBox.Show("Yêu cầu vẫn đang xử lý , bạn có muốn thay đổi yêu cầu này", "Xác nhận", MessageBoxButtons.YesNo);
                }
            }
        }

        private void dtgvTheoDoiVeSinh_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Kiểm tra xem cột có phải là cột "Chỉnh sửa" không
            if (e.ColumnIndex == dtgvTheoDoiVeSinh.Columns["Chỉnh sửa"].Index && e.RowIndex >= 0)
            {
                // Tạo hình ảnh biểu tượng
                Image icon = Properties.Resources.Edit1; ; // Đường dẫn đến tệp hình ảnh

                // Đặt kích thước cho icon
                int iconWidth = 16; // Chiều rộng của biểu tượng
                int iconHeight = 16; // Chiều cao của biểu tượng

                // Tính toán vị trí để vẽ icon
                Rectangle iconRect = new Rectangle(
                    e.CellBounds.Left + 5, // Khoảng cách từ bên trái
                    e.CellBounds.Top + (e.CellBounds.Height - iconHeight) / 2, // Giữa theo chiều dọc
                    iconWidth,
                    iconHeight
                );

                // Vẽ icon
                e.Graphics.DrawImage(icon, iconRect);

                // Căn giữa văn bản
                StringFormat stringFormat = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

                // Vẽ văn bản (có thể điều chỉnh vị trí để tránh bị che khuất bởi icon)
                e.Graphics.DrawString("", e.CellStyle.Font, Brushes.White,
                    new Rectangle(iconRect.Right + 5, e.CellBounds.Top, e.CellBounds.Width - iconRect.Width - 10, e.CellBounds.Height), stringFormat);

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

        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            Form form = new formDanhGiaChatLuong();
            form.ShowDialog();
        }
    }
 }
