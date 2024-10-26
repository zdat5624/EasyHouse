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
    public partial class tableDoanhThu : Form
    {
        private List<DoanhThu> dsDoanhThu;
        public tableDoanhThu()
        {
            InitializeComponent();
        }

        public void loadDoanhThuTheothoiGian(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            dsDoanhThu = DoanhThuDAO.Instance.GetDanhSachDoanhThuVeSinh(ngayBatDau, ngayKetThuc);
            DataTable tableDt = DoanhThuDAO.Instance.ConvertToDataTable(dsDoanhThu);
            double totalDoanhThu = DoanhThuDAO.Instance.GetTotalDoanhThu(dsDoanhThu);
            dgvDoanhThuVeSinh.DataSource = tableDt;
            lblTongDoanhThu.Text = "Tổng doanh thu: " + totalDoanhThu.ToString();
        }

        private void tableDoanhThu_Load(object sender, EventArgs e)
        {
            DateTime ngayBatDau = dtpThoiGianBatDau.Value;
            DateTime ngayKetThuc = dtpThoiGianKetThuc.Value;
            loadDoanhThuTheothoiGian(ngayBatDau, ngayKetThuc);
        }


        private void btnChonThoiGian_Click_1(object sender, EventArgs e)
        {
            DateTime ngayBatDau = dtpThoiGianBatDau.Value;
            DateTime ngayKetThuc = dtpThoiGianKetThuc.Value;
            loadDoanhThuTheothoiGian(ngayBatDau, ngayKetThuc);
        }
    }
}
