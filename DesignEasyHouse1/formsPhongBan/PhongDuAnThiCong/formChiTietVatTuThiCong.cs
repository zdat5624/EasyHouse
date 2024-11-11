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
    public partial class formChiTietVatTuThiCong : Form
    {
        int vatTuThiCongID = -1;
        VatTuThiCong vatTu = null;

        public formChiTietVatTuThiCong(int vatTuThiCongID)
        {
            InitializeComponent();
            this.vatTuThiCongID = vatTuThiCongID;
            this.vatTu = VatTuThiCongDAO.Instance.GetVatTuByID(vatTuThiCongID);
            LoadForm();
        }

        void LoadForm()
        {
            if (this.vatTu != null)
            {
                // Gán giá trị từ đối tượng vatTu vào các control trên form
                txtTenVatTu.Text = this.vatTu.TenVatTu;
                cbbLoaiVatTu.Text = this.vatTu.LoaiVatTu;
                nudSoLuong.Value = this.vatTu.SoLuong;
                cbbDonVi.Text = this.vatTu.DonVi;
                txtGhiChu.Text = this.vatTu.GhiChu;

                // Nếu cần thiết, có thể thêm các trường khác vào đây.
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin vật tư.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


        void CapNhatVatTuThiCong()
        {
            // Lấy thông tin từ các điều khiển nhập liệu
            string tenVatTu = txtTenVatTu.Text.Trim();
            string loaiVatTu = cbbLoaiVatTu.Text.Trim();
            int soLuong = (int)nudSoLuong.Value;
            string donVi = cbbDonVi.Text.Trim();
            string ghiChu = txtGhiChu.Text.Trim();

            // Kiểm tra tính hợp lệ của dữ liệu
            if (string.IsNullOrEmpty(tenVatTu) || string.IsNullOrEmpty(loaiVatTu) ||
                string.IsNullOrEmpty(donVi) || string.IsNullOrEmpty(ghiChu))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng VatTuThiCong
            VatTuThiCong updatedVatTu = new VatTuThiCong(this.vatTuThiCongID, -1, tenVatTu, loaiVatTu, soLuong, donVi, ghiChu);

            // Gọi phương thức cập nhật từ VatTuThiCongDAO
            bool success = VatTuThiCongDAO.Instance.CapNhatVatTuThiCong(updatedVatTu);
            if (success)
            {
                MessageBox.Show("Cập nhật vật tư thi công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Đóng form sau khi cập nhật thành công
            }
            else
            {
                MessageBox.Show("Cập nhật vật tư thi công thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            CapNhatVatTuThiCong();
        }
    }
}
