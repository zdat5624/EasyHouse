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

namespace DesignEasyHouse1.formsPhongBan.PhongAnNinh
{
    public partial class formThongBaoDangKyLai : Form
    {
        private int cuDanID;
        private int dichVuGuiXeiD;
        public formThongBaoDangKyLai(int dichVuGuiXeiD, int cuDanID)
        {
            InitializeComponent();
            this.dichVuGuiXeiD = dichVuGuiXeiD;
            this.cuDanID = cuDanID;
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            string noiDung = this.txtNoiDungThongBao.Text;
            if (DichVuGuiXeDAO.Instance.GuiThongBaoDangKyLai(this.dichVuGuiXeiD, this.cuDanID, noiDung))
            {
                MessageBox.Show("Gửi thông báo thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Gửi thông báo thất bại vui lòng gửi lại");
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
