using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesignEasyHouse1.DAO;

namespace DesignEasyHouse1.formsCuDan.moduleThiCong
{
    public partial class formGuiYeuCauThiCong : Form
    {
        public formGuiYeuCauThiCong()
        {
            InitializeComponent();
            cbbLoaiYeuCau.SelectedIndex = 0; // Thiết lập mục chọn mặc định cho ComboBox
        }

        void GuiYeuCau()
        {
            int cuDanID = SessionCuDan.CuDanID;
            string loaiYeuCau = cbbLoaiYeuCau.Text;
            string noiDung = txtNoiDung.Text;

            // Gọi phương thức DAO để thêm yêu cầu thi công
            bool kq = YeuCauThiCongDAO.Instance.ThemYeuCau(cuDanID, loaiYeuCau, noiDung);

            if (kq)
            {
                MessageBox.Show("Yêu cầu thi công của bạn đã được gửi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuiYeuCau_Click(object sender, EventArgs e)
        {
            GuiYeuCau(); // Gọi phương thức gửi yêu cầu khi nhấn nút
        }
    }
}
