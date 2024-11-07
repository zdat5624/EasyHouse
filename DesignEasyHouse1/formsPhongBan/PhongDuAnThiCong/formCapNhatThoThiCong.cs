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
    public partial class formCapNhatThoThiCong : Form
    {
        int thoThiCongID = -1;
        ThoThiCong ttc = null;
        public formCapNhatThoThiCong(int thoThiCongID)
        {
            InitializeComponent();
            this.thoThiCongID = thoThiCongID;
            this.ttc = ThoThiCongDAO.Instance.GetThoThiCongByThoThiCongID(thoThiCongID);
            LoadForm();
        }

        void LoadForm()
        {
            txtHoTen.Text = this.ttc.HoTen;
            txtCCCD.Text = this.ttc.CCCD;
            txtNhiemVu.Text = this.ttc.NhiemVu;
        }

        void CapNhatThoThiCong()
        {
            // Lấy thông tin từ các điều khiển nhập liệu (ví dụ: TextBox, ComboBox, ...)
            string hoTen = txtHoTen.Text.Trim();
            string cccd = txtCCCD.Text.Trim();
            string nhiemVu = txtNhiemVu.Text.Trim();

            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(cccd) || string.IsNullOrEmpty(nhiemVu))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng ThoThiCong
            ThoThiCong tho = new ThoThiCong(this.thoThiCongID, 0, hoTen, cccd, nhiemVu);

            // Gọi phương thức cập nhật từ ThoThiCongDAO
            bool success = ThoThiCongDAO.Instance.CapNhatThoThiCong(tho);
            if (success)
            {
                MessageBox.Show("Cập nhật thợ thi công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Đóng form sau khi cập nhật thành công
            }
            else
            {
                MessageBox.Show("Cập nhật thợ thi công thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            CapNhatThoThiCong();
        }
    }
}
