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

namespace DesignEasyHouse1.formsCuDan.moduleGuiDo
{
    public partial class formGuiYeuCauGuiDoLayDo : Form
    {
        public formGuiYeuCauGuiDoLayDo()
        {
            InitializeComponent();
            cbbLoaiYeuCau.SelectedIndex = 0;
        }

        void GuiYeuCau()
        {
            int cuDanID = SessionCuDan.CuDanID;
            string loaiYeuCau = cbbLoaiYeuCau.Text;
            string noiDung = txtNoiDung.Text;

            // Gọi phương thức DAO để thêm yêu cầu
            bool kq = YeuCauGuiDoLayDoDAO.Instance.ThemYeuCau(cuDanID, loaiYeuCau, noiDung);

            if (kq)
            {
                MessageBox.Show("Yêu cầu của bạn đã được gửi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuiYeuCau_Click(object sender, EventArgs e)
        {
            GuiYeuCau();
        }
    }
}
