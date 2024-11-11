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
    public partial class formThemVatTuThiCong : Form
    {
        int duAnThiCongID = -1;
        public formThemVatTuThiCong(int duAnThiCongID)
        {
            InitializeComponent();
            this.duAnThiCongID = duAnThiCongID;
        }

        void ThemVatTuThiCong()
        {
            // Lấy thông tin từ các control trên form
            string tenVatTu = txtTenVatTu.Text.Trim();
            string loaiVatTu = cbbLoaiVatTu.Text.Trim();
            int soLuong = (int)nudSoLuong.Value;
            string donVi = cbbDonVi.Text.Trim();
            string ghiChu = txtGhiChu.Text.Trim();

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(tenVatTu) || string.IsNullOrEmpty(loaiVatTu) || string.IsNullOrEmpty(donVi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin các trường bắt buộc!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng VatTuThiCong
            VatTuThiCong vttc = new VatTuThiCong(-1, this.duAnThiCongID, tenVatTu, loaiVatTu, soLuong, donVi, ghiChu);

            // Gọi phương thức DAO để thêm vật tư
            bool result = VatTuThiCongDAO.Instance.ThemVatTuThiCong(vttc);

            // Kiểm tra kết quả thêm vật tư và hiển thị thông báo
            if (result)
            {
                MessageBox.Show("Thêm vật tư thi công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Đóng form sau khi thêm thành công
            }
            else
            {
                MessageBox.Show("Thêm vật tư thi công thất bại. Vui lòng kiểm tra lại dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemVatTuThiCong();
        }
    }
}
