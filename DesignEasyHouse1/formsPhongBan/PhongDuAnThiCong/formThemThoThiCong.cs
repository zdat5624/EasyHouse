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
    public partial class formThemThoThiCong : Form
    {
        int duAnThiCongID = -1;
        public formThemThoThiCong(int duAnThiCongID)
        {
            InitializeComponent();
            this.duAnThiCongID = duAnThiCongID;
        }

        void ThemThoThiCong()
        {
            try
            {
                // Lấy dữ liệu từ các control trong form
                string hoTen = txtHoTen.Text.Trim();
                string cccd = txtCCCD.Text.Trim();
                string nhiemVu = txtNhiemVu.Text.Trim();

                // Kiểm tra dữ liệu đầu vào (Ví dụ: kiểm tra CCCD có trùng không)
                if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(cccd) || string.IsNullOrEmpty(nhiemVu))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo đối tượng ThoThiCong mới
                ThoThiCong thoThiCong = new ThoThiCong(0, this.duAnThiCongID, hoTen, cccd, nhiemVu); // 0 cho ThoThiCongID, sẽ tự động tạo

                // Thêm vào cơ sở dữ liệu thông qua DAO
                bool success = ThoThiCongDAO.Instance.ThemThoThiCong(thoThiCong);

                if (success)
                {
                    MessageBox.Show("Thêm thợ thi công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form sau khi thêm thành công
                }
                else
                {
                    MessageBox.Show("Thêm thợ thi công thất bại. Vui lòng kiểm tra lại dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            ThemThoThiCong();
        }
    }
}
