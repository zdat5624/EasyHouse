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

namespace DesignEasyHouse1.formsPhongBan.PhongVeSinh
{
    public partial class formXemKeHoachVeSinh : Form
    {
        public formXemKeHoachVeSinh()
        {
            InitializeComponent();
        }

        private void formXemKeHoachVeSinh_Load(object sender, EventArgs e)
        {
            DataTable dt;

            if(cbTrangThaiCongViec.Text == "Hoàn thành")
            {
                dt = YeuCauDAO.Instance.GetDanhSachYeuCauDuocPhanCongDaHoanThanh(SessionNhanVien.id);
            }
            else if(cbTrangThaiCongViec.Text == "Chưa hoàn thành")
            {
                dt = YeuCauDAO.Instance.GetDanhSachYeuCauDuocPhanCongChuaHoanThanh(SessionNhanVien.id);

            }
            else
            {
                dt = YeuCauDAO.Instance.GetDanhSachYeuCauDuocPhanCong(SessionNhanVien.id);
            }
            dtgvKeHoachCongViec.DataSource = dt;
            // Đặt tên cột bằng tiếng Việt
            dtgvKeHoachCongViec.Columns["YeuCauID"].HeaderText = "Mã Yêu Cầu";
            dtgvKeHoachCongViec.Columns["TieuDe"].HeaderText = "Tiêu Đề";
            dtgvKeHoachCongViec.Columns["NoiDung"].HeaderText = "Nội Dung";
            dtgvKeHoachCongViec.Columns["NgayGui"].HeaderText = "Ngày Gửi";
            dtgvKeHoachCongViec.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dtgvKeHoachCongViec.Columns["ThoiGianPhanCong"].HeaderText = "Thời Gian Phân Công";

            // Tùy chọn: Định dạng ngày
            dtgvKeHoachCongViec.Columns["NgayGui"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtgvKeHoachCongViec.Columns["ThoiGianPhanCong"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

            // Tùy chọn: Điều chỉnh độ rộng cột
            foreach (DataGridViewColumn column in dtgvKeHoachCongViec.Columns)
            {
                if(column.HeaderText !="Hoàn thành")
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                }
               
            }
            dtgvKeHoachCongViec.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void dtgvKeHoachCongViec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra chỉ số hàng và cột hợp lệ
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy tên cột của ô được nhấp
                string columnName = dtgvKeHoachCongViec.Columns[e.ColumnIndex].Name;

                // Kiểm tra xem người dùng có nhấp vào cột hình ảnh "HoanThanh" không
                if (columnName == "HoanThanh") // Thay "HoanThanh" bằng tên cột hình ảnh của bạn
                {
                    // Lấy mã yêu cầu từ ô tương ứng trong hàng
                    int maYeuCau = int.Parse(dtgvKeHoachCongViec.Rows[e.RowIndex].Cells["YeuCauID"].Value.ToString());

                    // Thực hiện cập nhật trạng thái hoàn thành
                    if (YeuCauDAO.Instance.CapNhatTrangThaiHoanThanh(maYeuCau)) // Giả định bạn có phương thức cập nhật trạng thái
                    {
                        MessageBox.Show($"Yêu cầu {maYeuCau} đã được đánh dấu là hoàn thành.");

                        // Cập nhật trạng thái hiển thị trong DataGridView
                        dtgvKeHoachCongViec.Rows[e.RowIndex].Cells["TrangThai"].Value = "Hoàn thành";

                        // Thay đổi màu nền của ô hình ảnh để chỉ báo đã hoàn thành
                        dtgvKeHoachCongViec.Rows[e.RowIndex].Cells["HoanThanh"].Style.BackColor = Color.Gray;
                    }
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnChonThoiGian_Click(object sender, EventArgs e)
        {
            formXemKeHoachVeSinh_Load(sender, e);
        }
    }
}
