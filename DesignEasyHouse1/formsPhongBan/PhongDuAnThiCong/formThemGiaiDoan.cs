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

namespace DesignEasyHouse1.formsPhongBan.PhongDuAnThiCong
{
    public partial class formThemGiaiDoan : Form
    {
        private int duAnThiCongID = -1;
        public formThemGiaiDoan(int duAnThiCongID)
        {
            this.duAnThiCongID=duAnThiCongID;
            InitializeComponent();
        }

        void ThemGiaiDoan()
        {
            DateTime ngayKetThuc = dtpNgayKetThuc.Value;
            string noiDung = txtNoiDung.Text;
            string trangThai = "Đang thi công";

            bool success = GiaiDoanThiCongDAO.Instance.ThemGiaiDoanThiCong(this.duAnThiCongID, ngayKetThuc, trangThai, noiDung);

            // Kiểm tra kết quả và hiển thị thông báo cho người dùng
            if (success)
            {
                MessageBox.Show("Thêm giai đoạn thi công thành công!", "Thông báo");
                this.Close();
                // Cập nhật lại danh sách giai đoạn nếu cần
            }
            else
            {
                MessageBox.Show("Thêm giai đoạn thi công thất bại. Vui lòng kiểm tra lại dữ liệu.", "Lỗi");
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemGiaiDoan();
        }
    }
}
