using DesignEasyHouse1.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignEasyHouse1.formsCuDan
{
    public partial class formGuiYeuCauDichVuCuDan : Form
    {
        public formGuiYeuCauDichVuCuDan()
        {
            InitializeComponent();
        }

        #region Methods
        void GuiYeuCau()
        {
            int CuDanID = Convert.ToInt32(txtCuDanID.Text);
            int LoaiYeuCauID = Convert.ToInt32(txtLoaiYeuCauID.Text); 
            string TieuDe = txtTieuDe.Text;
            string NoiDung = txtNoiDung.Text;

            bool result = YeuCauDAO.Instance.ThemYeuCau(CuDanID, LoaiYeuCauID, TieuDe, NoiDung);
            if (result)
            {
                MessageBox.Show("Gửi yêu cầu thành công!");
                //this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng kiểm tra lại.");
            }
        }

        #endregion

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            GuiYeuCau();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formGuiYeuCauDichVuCuDan_Load(object sender, EventArgs e)
        {

        }
    }
}
