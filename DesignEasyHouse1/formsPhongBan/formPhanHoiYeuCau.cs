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

namespace DesignEasyHouse1.formsPhongBan
{
    public partial class formPhanHoiYeuCau : Form
    {
        public formPhanHoiYeuCau()
        {
            InitializeComponent();
        }

        #region Methods
        void GuiPhanHoi()
        {
            int YeuCauID = Convert.ToInt32(txtYeuCauID.Text);
            if (string.IsNullOrEmpty(txtNguoiPhanHoiID.Text))
            {
                txtNguoiPhanHoiID.Text = "-1";
            }
            int NguoiPhanHoiID = Convert.ToInt32(txtNguoiPhanHoiID.Text);
            string NoiDung = txtNoiDung.Text;

            bool result = PhanHoiDAO.Instance.ThemPhanHoi(YeuCauID, NguoiPhanHoiID, NoiDung);
            if (result)
            {
                MessageBox.Show("Gửi phản hồi thành công!");
                //this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng kiểm tra lại.");
            }
        }

        #endregion

        private void btnGuiPhanHoi_Click(object sender, EventArgs e)
        {
            GuiPhanHoi();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
