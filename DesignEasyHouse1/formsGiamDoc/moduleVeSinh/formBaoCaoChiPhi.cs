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

namespace DesignEasyHouse1.formsGiamDoc.moduleVeSinh
{
    public partial class formBaoCaoChiPhi : Form
    {
        private List<ChiPhi> dsChiPhi;
        public formBaoCaoChiPhi()
        {
            InitializeComponent();
        }
        public void loadChiPhiTheothoiGian()
        {
            DateTime ngayBatDau = dtpThoiGianBatDau.Value;
            DateTime ngayKetThuc = dtpThoiGianKetThuc.Value;
            dsChiPhi = ChiPhiVeSinhDAO.Instance.GetDanhSachChiPhiVeSinh(ngayBatDau, ngayKetThuc);
            DataTable tableDt = ChiPhiVeSinhDAO.Instance.ConvertToDataTable(dsChiPhi);
            double totalChiPhi = ChiPhiVeSinhDAO.Instance.GetTotalChiPhi(dsChiPhi);
            dvgBaoCaoChiPhi.DataSource = tableDt;
            lblTongChiPhi.Text = "Tổng chi phí: " + totalChiPhi.ToString();
        }
        private void formBaoCaoChiPhi_Load(object sender, EventArgs e)
        {
            loadChiPhiTheothoiGian();
        }

        private void btnChonThoiGian_Click(object sender, EventArgs e)
        {
            loadChiPhiTheothoiGian();
        }
    }
}
