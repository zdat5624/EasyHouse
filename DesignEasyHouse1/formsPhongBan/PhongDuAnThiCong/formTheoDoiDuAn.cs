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

namespace DesignEasyHouse1.formsPhongBan.PhongDuAnThiCong
{
    public partial class formTheoDoiDuAn : Form
    {
        private DuAnThiCong duAnThiCong = null;

        public formTheoDoiDuAn()
        {
            InitializeComponent();
            LoadCbbDuAnThiCong();
        }

        private void LoadCbbDuAnThiCong()
        {
            // Lấy danh sách tất cả các dự án thi công
            List<DuAnThiCong> duAnList = DuAnThiCongDAO.Instance.GetAllDuAnThiCongList();

            // Gán dữ liệu vào ComboBox
            cbbDuAnThiCong.DisplayMember = "TenDuAn";  // Tên của dự án sẽ được hiển thị trong ComboBox
            cbbDuAnThiCong.ValueMember = "DuAnThiCongID";  // ID của dự án sẽ là giá trị của ComboBox

            // Đưa danh sách dự án vào ComboBox
            cbbDuAnThiCong.DataSource = duAnList;
            cbbDuAnThiCong.SelectedIndexChanged += cbbDuAnThiCong_SelectedIndexChanged;

        }


        void LoadForm(DuAnThiCong datt)
        {
            this.duAnThiCong = datt;

            if (this.duAnThiCong.FileTaiLieu != null)
            {
                btnTaiTaiLieu.Visible = true;
            }
            else
            {
                btnTaiTaiLieu.Visible = false;
            }

            foreach (var item in cbbDuAnThiCong.Items)
            {
                if (item is DuAnThiCong duAn && duAn.DuAnThiCongID == datt.DuAnThiCongID)
                {
                    cbbDuAnThiCong.SelectedItem = item;
                    break;
                }
            }

            groupBoxThongTinDuAn.Visible = true;
            groupBoxTienDo.Visible = true;
            groupBoxThongKe.Visible = true;
            btnLapKeHoach.Visible = true;
            btnThoThiCong.Visible = true;
            btnVatTu.Visible = true;

            txtTenDuAn.Text = duAnThiCong.TenDuAn;
            txtTenNhaThau.Text = duAnThiCong.TenNhaThau;
            cbbTrangThai.SelectedItem = duAnThiCong.TrangThai;
            cbbChuDuAn.SelectedItem = duAnThiCong.ChuDuAn;
            dtpNgayBatDau.Value = (DateTime)duAnThiCong.NgayBatDau;
            dtpNgayKetThuc.Value = (DateTime)duAnThiCong.NgayKetThuc;

            TinhTienDoDuAn(this.duAnThiCong.DuAnThiCongID);
            TinhSoThoThiCong(this.duAnThiCong.DuAnThiCongID);
            TinhSoNgayConLaiDuAnThiCong();
            LoadflowLayoutPanelKeHoach();

        }

        // Tính tiến độ dự án thi công
        private void TinhTienDoDuAn(int duAnThiCongID)
        {
            // Lấy danh sách các giai đoạn của dự án thi công
            List<GiaiDoanThiCong> giaiDoanList = GiaiDoanThiCongDAO.Instance.GetGiaiDoanListByDuAnID(duAnThiCongID);

            // Tính tổng số giai đoạn
            int tongSoGiaiDoan = giaiDoanList.Count;

            // Tính số giai đoạn đã hoàn thành
            int giaiDoanHoanThanh = giaiDoanList.Count(g => g.TrangThai == "Hoàn thành" && g.NgayKetThuc.HasValue);

            // Tính tiến độ (tỷ lệ phần trăm)
            double tienDo = tongSoGiaiDoan > 0 ? (double)giaiDoanHoanThanh / tongSoGiaiDoan * 100 : 0;

            // Cập nhật label hoặc control hiển thị tiến độ
            lblTienDo.Text = $"{tienDo:0}%";
        }

        private void TinhSoThoThiCong(int duAnThiCongID)
        {
            // Lấy danh sách thợ thi công của dự án
            List<ThoThiCong> thoThiCongList = ThoThiCongDAO.Instance.GetThoThiCongByDuAnID(duAnThiCongID);

            // Tính số lượng thợ thi công (có thể lọc thêm điều kiện nếu cần)
            int soLuongThoThiCong = thoThiCongList.Count;

            // Cập nhật label hoặc control hiển thị số lượng thợ thi công
            lblSoLuongTho.Text = $"{soLuongThoThiCong}";
        }

        private void TinhSoNgayConLaiDuAnThiCong()
        {
            // Lấy thông tin ngày kết thúc của dự án
            DateTime? ngayKetThuc = this.duAnThiCong.NgayKetThuc;

            // Kiểm tra nếu ngày kết thúc có tồn tại
            if (ngayKetThuc.HasValue)
            {
                // Tính số ngày còn lại (so với ngày hiện tại)
                int soNgayConLai = (ngayKetThuc.Value - DateTime.Now).Days;

                if (duAnThiCong.TrangThai == "Hoàn thành")
                {
                    lblThoiHan.Text = "Dự Án";
                    lblThoiHan.BackColor = Color.FromArgb(0, 119, 200);
                    labelNgayConLai.Text = $"Hoàn Thành";
                    labelNgayConLai.BackColor = Color.FromArgb(0, 119, 200);
                    return;
                }

                if (duAnThiCong.TrangThai == "Tạm Dừng")
                {
                    lblThoiHan.Text = "Dự Án";
                    lblThoiHan.BackColor = Color.Red;
                    labelNgayConLai.Text = "Tạm Dừng";
                    labelNgayConLai.BackColor = Color.Red;
                    return;
                }

                // Nếu số ngày còn lại nhỏ hơn 0 (quá hạn), trả về 0
                if (soNgayConLai <= 0)
                {
                    lblThoiHan.Text = "Dự Án";
                    lblThoiHan.BackColor = Color.Red;
                    labelNgayConLai.Text = "Quá Hạn";
                    labelNgayConLai.BackColor = Color.Red;
                }
                else
                {
                    lblThoiHan.Text = "Hạn còn";
                    lblThoiHan.BackColor = Color.FromArgb(0, 119, 200);
                    labelNgayConLai.Text = $"{soNgayConLai} ngày";
                    labelNgayConLai.BackColor = Color.FromArgb(0, 119, 200);
                }


            }

        }


        private void LoadflowLayoutPanelKeHoach()
        {
            // Lấy danh sách các giai đoạn thi công của dự án hiện tại
            List<GiaiDoanThiCong> giaiDoanList = GiaiDoanThiCongDAO.Instance.GetGiaiDoanListByDuAnID(this.duAnThiCong.DuAnThiCongID);

            // Xóa các button cũ (nếu có)
            flowLayoutPanelKeHoach.Controls.Clear();

            // Tạo và thêm button cho mỗi giai đoạn
            foreach (var giaiDoan in giaiDoanList)
            {
                Button btnGiaiDoan = new Button();

                // Tính số ngày còn lại nếu trạng thái là "Đang thi công"
                string text = $"Giai đoạn {giaiDoan.ThuTu}" + Environment.NewLine + giaiDoan.TrangThai;

                if (giaiDoan.TrangThai == "Đang thi công" && giaiDoan.NgayKetThuc != null)
                {
                    DateTime ngayKetThuc = giaiDoan.NgayKetThuc.Value;
                    int soNgayConLai = (ngayKetThuc - DateTime.Now).Days;

                    // Nếu quá hạn, hiển thị "Quá hạn"
                    if (soNgayConLai <= 0)
                    {
                        text += Environment.NewLine + "Quá hạn";
                    }
                    else
                    {
                        text += Environment.NewLine + $"Còn {soNgayConLai} ngày";
                    }
                }

                btnGiaiDoan.Text = text;
                btnGiaiDoan.Tag = giaiDoan.GiaiDoanID;

                // Cập nhật giao diện button
                btnGiaiDoan.Width = 150;
                btnGiaiDoan.Height = 100;
                btnGiaiDoan.Margin = new Padding(5);
                btnGiaiDoan.FlatStyle = FlatStyle.Flat;
                btnGiaiDoan.FlatAppearance.BorderSize = 0;

                // Thêm màu cho button theo trạng thái
                switch (giaiDoan.TrangThai)
                {
                    case "Chưa thi công":
                        btnGiaiDoan.BackColor = Color.Gainsboro;  // Màu xám cho "Chưa thi công"
                        break;
                    case "Đang thi công":
                        btnGiaiDoan.BackColor = Color.Yellow;  // Màu vàng cho "Đang thi công"
                        break;
                    case "Hoàn thành":
                        btnGiaiDoan.BackColor = Color.GreenYellow;  // Màu xanh lá cho "Hoàn thành"
                        break;
                    default:
                        btnGiaiDoan.BackColor = Color.Gray;  // Màu xám nếu trạng thái không xác định
                        break;
                }

                // Thêm button vào FlowLayoutPanel
                flowLayoutPanelKeHoach.Controls.Add(btnGiaiDoan);
            }
        }

        private void btnLapKeHoach_Click(object sender, EventArgs e)
        {
            formLapKeHoach f = new formLapKeHoach(this.duAnThiCong.DuAnThiCongID);
            f.ShowDialog();
            LoadForm(this.duAnThiCong);
        }

        private void btnThoThiCong_Click(object sender, EventArgs e)
        {
            formThoThiCong f = new formThoThiCong(this.duAnThiCong.DuAnThiCongID);
            f.ShowDialog();
            LoadForm(this.duAnThiCong);
        }

        private void btnVatTu_Click(object sender, EventArgs e)
        {
            formQuanLyVatTuThiCong f = new formQuanLyVatTuThiCong(this.duAnThiCong.DuAnThiCongID);
            f.ShowDialog();
            LoadForm(this.duAnThiCong);
        }

        private void cbbDuAnThiCong_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy đối tượng DuAnThiCong từ ComboBox
            DuAnThiCong selectedDuAn = (DuAnThiCong)cbbDuAnThiCong.SelectedItem;

            // Cập nhật form với thông tin dự án
            LoadForm(selectedDuAn);
        }

        // Sự kiện khi người dùng nhấn Enter trong txtTimKiem
        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Kiểm tra nếu người dùng đã nhập ID
                string duAnIDText = txtTimKiem.Text.Trim();

                // Kiểm tra nếu giá trị ID không rỗng và có thể chuyển thành int
                if (int.TryParse(duAnIDText, out int duAnID))
                {
                    // Gọi phương thức tìm kiếm dự án thi công bằng ID (kiểu int)
                    duAnThiCong = DuAnThiCongDAO.Instance.GetDuAnThiCongByID(duAnID);

                    // Kiểm tra xem dự án có tồn tại không
                    if (duAnThiCong != null)
                    {
                        // Cập nhật giao diện với thông tin dự án thi công
                        LoadForm(duAnThiCong);
                    }
                    else
                    {
                        MessageBox.Show("Dự án không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập ID dự án hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnTaiTaiLieu_Click(object sender, EventArgs e)
        {
            byte[] fileData = this.duAnThiCong.FileTaiLieu;

            // Kiểm tra nếu tài liệu tồn tại
            if (fileData != null)
            {
                // Mở hộp thoại lưu tệp để người dùng lưu tài liệu
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "ZIP Files (*.zip)|*.zip|RAR Files (*.rar)|*.rar|All Files (*.*)|*.*";
                saveFileDialog.FileName = "DuAnTaiLieu.zip";  // Đặt tên mặc định cho tệp

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lưu dữ liệu vào tệp đã chọn
                    try
                    {
                        System.IO.File.WriteAllBytes(saveFileDialog.FileName, fileData);
                        MessageBox.Show("Tải tài liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tải tài liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Tài liệu của dự án không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
