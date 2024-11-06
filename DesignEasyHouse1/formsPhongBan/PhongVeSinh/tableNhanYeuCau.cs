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
                dt = DanhSachVeSinh(tuNgay, denNgay);
            }

            dtgvYeuCauVeSinh.DataSource = dt;

            // Đặt tiêu đề cột cho DataGridView
            dtgvYeuCauVeSinh.Columns["MaYeuCau"].HeaderText = "Mã Yêu Cầu";
            dtgvYeuCauVeSinh.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dtgvYeuCauVeSinh.Columns["KhuVucVeSinh"].HeaderText = "Khu Vực Vệ Sinh";
            dtgvYeuCauVeSinh.Columns["ThoiGianVeSinh"].HeaderText = "Thời Gian Vệ Sinh";
            dtgvYeuCauVeSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Thêm cột nút "Chấp nhận" nếu chưa có
            if (!dtgvYeuCauVeSinh.Columns.Contains("Chấp Nhận"))
            {
                DataGridViewButtonColumn btnAccept = new DataGridViewButtonColumn();
                btnAccept.Name = "Chấp Nhận";
                btnAccept.HeaderText = "Chấp Nhận Yêu Cầu";
                btnAccept.Text = "Chấp Nhận";
                btnAccept.UseColumnTextForButtonValue = true; // Hiển thị văn bản trên nút
                btnAccept.FlatStyle = FlatStyle.Popup; // Chọn kiểu hiển thị nút
                btnAccept.DefaultCellStyle.BackColor = Color.LightGreen; // Màu nền của nút
                btnAccept.DefaultCellStyle.ForeColor = Color.White; // Màu chữ của nút
                dtgvYeuCauVeSinh.Columns.Add(btnAccept);
            }
            if (!dtgvYeuCauVeSinh.Columns.Contains("TuChoi"))
            {
                DataGridViewButtonColumn btnTuChoi = new DataGridViewButtonColumn();
                btnTuChoi.Name = "TuChoi";
                btnTuChoi.HeaderText = "Từ Chối";
                btnTuChoi.Text = "Từ Chối";
                btnTuChoi.UseColumnTextForButtonValue = true;
                btnTuChoi.FlatStyle = FlatStyle.Popup; // Chọn kiểu hiển thị nút
                btnTuChoi.DefaultCellStyle.BackColor = Color.Red; // Màu nền của nút
                btnTuChoi.DefaultCellStyle.ForeColor = Color.White; // Màu chữ của nút
                dtgvYeuCauVeSinh.Columns.Add(btnTuChoi);
            }

            // Xử lý sự kiện CellContentClick để nhận sự kiện nhấn nút
            dtgvYeuCauVeSinh.CellContentClick += DtgvYeuCauVeSinh_CellClick;
        }


        private void DtgvYeuCauVeSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu chỉ số hàng hợp lệ và không phải là hàng tiêu đề
            if (e.RowIndex >= 0 && e.RowIndex < dtgvYeuCauVeSinh.Rows.Count)
            {
                int maYeuCau = int.Parse(dtgvYeuCauVeSinh.Rows[e.RowIndex].Cells["MaYeuCau"].Value.ToString());
                // Kiểm tra nếu cột là "Chấp Nhận"
                if (dtgvYeuCauVeSinh.Columns[e.ColumnIndex].Name == "Chấp Nhận")
                {
                    // Kiểm tra nếu cột "TrangThai" tồn tại
                    var cellTrangThai = dtgvYeuCauVeSinh.Rows[e.RowIndex].Cells["TrangThai"];
                        
                    if (cellTrangThai != null && cellTrangThai.Value != null)
                    {
                        string trangThai = cellTrangThai.Value.ToString();
                        
                        if (trangThai == "Đang chờ xử lý")
                        {

                            // Cập nhật trạng thái yêu cầu
                            cellTrangThai.Value = "Nhân viên vệ sinh sẽ xử lý đúng lịch đã đăng ký";

                            // Gọi hàm cập nhật trạng thái, v.v.
                            if (YeuCauDAO.Instance.ChapNhanYeuCauVeSinh(maYeuCau))
                            {
                                MessageBox.Show($"Yêu cầu {maYeuCau} đã được chấp nhận.");
                                // Đổi màu nút thành xám để chỉ báo rằng yêu cầu đã được xử lý
                                var cellChapNhan = dtgvYeuCauVeSinh.Rows[e.RowIndex].Cells["Chấp Nhận"];
                                cellChapNhan.Style.BackColor = Color.Gray;
                                cellChapNhan.Style.ForeColor = Color.DarkGray;
                                cellChapNhan.Value = "Đã xử lý";
                            }
                            else
                            {
                                MessageBox.Show("Lỗi");

                            }


                        }
                    }
                }
                // Kiểm tra nếu cột là "Từ Chối"
                if (dtgvYeuCauVeSinh.Columns[e.ColumnIndex].Name == "TuChoi")
            {
                var cellTrangThai = dtgvYeuCauVeSinh.Rows[e.RowIndex].Cells["TrangThai"];
                if (cellTrangThai != null && cellTrangThai.Value != null)
                {
                    string trangThai = cellTrangThai.Value.ToString();

                    if (trangThai == "Đang chờ xử lý")
                    {
                        // Cập nhật trạng thái yêu cầu thành "Đã từ chối"
                        cellTrangThai.Value = "Đã từ chối";
                            if (YeuCauDAO.Instance.TuChoiYeuCauVeSinh(maYeuCau))
                            {
                                // Đổi màu nút thành xám và thay đổi văn bản thành "Đã từ chối"
                                var cellTuChoi = dtgvYeuCauVeSinh.Rows[e.RowIndex].Cells["TuChoi"];
                                cellTuChoi.Style.BackColor = Color.Gray;
                                cellTuChoi.Style.ForeColor = Color.DarkGray;
                                cellTuChoi.Value = "Đã từ chối";
                                MessageBox.Show($"Yêu cầu {maYeuCau} đã bị từ chối");
                            }
                    }
                }
            }
                // Vô hiệu hóa cả hai nút
                //dtgvYeuCauVeSinh.Rows[e.RowIndex].Cells["Chấp Nhận"].ReadOnly = true;
                //dtgvYeuCauVeSinh.Rows[e.RowIndex].Cells["TuChoi"].ReadOnly = true;
            }
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
