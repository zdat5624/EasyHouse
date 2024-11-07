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
    public partial class formCapNhatGiaiDoan : Form
    {
        GiaiDoanThiCong giaiDoan = null;
        public formCapNhatGiaiDoan(int giaiDoanID)
        {
            this.giaiDoan = GiaiDoanThiCongDAO.Instance.GetGiaiDoanByGiaiDoanID(giaiDoanID);
            InitializeComponent();
        }

        void LoadForm()
        {
            if (giaiDoan != null)
            {
                // Hiển thị thông tin giai đoạn thi công lên các control tương ứng
                txtNoiDung.Text = giaiDoan.NoiDung;
                dtpNgayKetThuc.Value = giaiDoan.NgayKetThuc.HasValue ? giaiDoan.NgayKetThuc.Value : DateTime.Now;

                // Thiết lập trạng thái ngày kết thúc nếu null
                dtpNgayKetThuc.Checked = giaiDoan.NgayKetThuc.HasValue;

                // Chọn trạng thái trong ComboBox
                if (!string.IsNullOrEmpty(giaiDoan.TrangThai))
                {
                    cbbTrangThai.SelectedItem = giaiDoan.TrangThai;
                }
                else
                {
                    cbbTrangThai.SelectedIndex = 0; // Chọn một mục mặc định nếu trạng thái trống
                }

                // Thiết lập thứ tự giai đoạn nếu có combobox hoặc numeric up-down
                nudThuTu.Value = giaiDoan.ThuTu;
            }
            else
            {
                MessageBox.Show("Không thể tải thông tin giai đoạn thi công. Vui lòng thử lại sau.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void LuuCapNhat()
        {
            // Lấy dữ liệu từ các control trong form
            int thuTu = (int)nudThuTu.Value;
            DateTime? ngayKetThuc = dtpNgayKetThuc.Checked ? (DateTime?)dtpNgayKetThuc.Value : null;
            string trangThai = cbbTrangThai.SelectedItem?.ToString();
            string noiDung = txtNoiDung.Text.Trim();

            // Kiểm tra nếu thứ tự đã tồn tại trong các giai đoạn của dự án
            if (GiaiDoanThiCongDAO.Instance.KiemTraThuTuTonTai(this.giaiDoan.DuAnThiCongID, thuTu, this.giaiDoan.GiaiDoanID))
            {
                MessageBox.Show("Thứ tự này đã tồn tại trong giai đoạn thi công. Vui lòng chọn một thứ tự khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng thực hiện nếu thứ tự không hợp lệ
            }

            // Cập nhật thông tin vào đối tượng giai đoạn hiện tại
            GiaiDoanThiCong gd = new GiaiDoanThiCong()
            {
                GiaiDoanID = this.giaiDoan.GiaiDoanID,
                ThuTu = thuTu,
                NgayKetThuc = ngayKetThuc,
                TrangThai = trangThai,
                NoiDung = noiDung,
            };

            // Gọi phương thức DAO để lưu thông tin cập nhật
            bool success = GiaiDoanThiCongDAO.Instance.CapNhatGiaiDoan(gd);

            if (success)
            {
                MessageBox.Show("Cập nhật giai đoạn thi công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Đóng form sau khi cập nhật thành công
            }
            else
            {
                MessageBox.Show("Cập nhật giai đoạn thi công thất bại. Vui lòng kiểm tra lại dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btnLuu_Click(object sender, EventArgs e)
        {
            LuuCapNhat();
        }

        private void formCapNhatGiaiDoan_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
}
