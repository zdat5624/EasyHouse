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
    public partial class bieuDoHoatDong : Form
    {
        private List<ChiPhi> dsChiPhi;
        private List<DoanhThu> dsDoanhThu;
        public bieuDoHoatDong()
        {
            InitializeComponent();
        }

        private void lblDanhGiaQuaChiPhi_Click(object sender, EventArgs e)
        {

        }


        private void chartSoSanhCPVaDT_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnChonThoiGian_Click(object sender, EventArgs e)
        {
            string thoigian = cbThoiGian.Text;
            string loaiBieuDo = btnXemBieuDo.Text;
            //nếu biểu đồ đang show là so sánh chi phí 
            if(loaiBieuDo == "Xem biểu đồ so sánh tổng chi phí và doanh thu")
            {
                loadBieuDoChiPhi(thoigian);
            }
            else
            {
                loadBieuDoSoSanhCpVaDT(thoigian);
            }

        }

        private void bieuDoHoatDong_Load(object sender, EventArgs e)
        {
            chartSoSanhCPVaDT.Visible = false;
            cbThoiGian.SelectedIndex = 0;
            string thoiGianMacDinh = cbThoiGian.SelectedItem.ToString();
            loadBieuDoChiPhi(thoiGianMacDinh);
        }
        //load dữ liệu so sánh 2  chi phí 
        public void loadBieuDoChiPhi(string thoiGian)
        {
            //xóa dữ liệu truy vấn trước đó
            chartSoSanhCP.Series["Dự kiến"].Points.Clear();
            chartSoSanhCP.Series["Thực tế"].Points.Clear();

            //Thêm tiêu đề trục 
            chartSoSanhCP.ChartAreas["MainArea"].AxisX.Title = "Tháng";
            chartSoSanhCP.ChartAreas["MainArea"].AxisY.Title = "Số tiền (VND)";
            if (thoiGian == "6 tháng")
            {
                loadDataSoSanhCpTrong6Thang();
            }
            else if (thoiGian == "3 tháng")
            {
                loadDataSoSanhCpTrong3Thang();
            }
            else
            {
                loadDataSoSanhCpTrong1nam();
            }
            
        }
        public void loadDataCp(ref DateTime thoiGian)
        {
            DateTime from = thoiGian;
            DateTime to = thoiGian.AddMonths(1);
            dsChiPhi = ChiPhiVeSinhDAO.Instance.GetDanhSachChiPhiVeSinh(from, to);
            double tongChiPhiTrong6Thang = ChiPhiVeSinhDAO.Instance.GetTotalChiPhi(dsChiPhi);
            double tongChiPhiDuKien = ChiPhiVeSinhDAO.Instance.GetChiPhiDuKien(dsChiPhi);
            chartSoSanhCP.Series["Dự kiến"].Points.AddXY(from.ToString("MM"), tongChiPhiDuKien);
            chartSoSanhCP.Series["Thực tế"].Points.AddXY(from.ToString("MM"), tongChiPhiTrong6Thang);
            thoiGian = to;
        }

        public void loadDataSoSanhCpTrong6Thang()
        {
            DateTime homnay = DateTime.Now;
            DateTime truocDo = homnay.AddMonths(-6);
            //loop for 6 months 
            for (int i = 0; i < 6; i++)
            {
                loadDataCp(ref truocDo);
            }
        }

        public void loadDataSoSanhCpTrong3Thang()
        {
            DateTime homnay = DateTime.Now;
            DateTime truocDo = homnay.AddMonths(-3);
            //loop for 3 months 
            for (int i = 0; i < 3; i++)
            {
                loadDataCp(ref truocDo);
            }
        }
        public void loadDataSoSanhCpTrong1nam()
        {
            DateTime homnay = DateTime.Now;
            DateTime truocDo = homnay.AddMonths(-12);
            //loop for 3 months 
            for (int i = 0; i < 12; i++)
            {
                loadDataCp(ref truocDo);
            }
        }

        //load dữ liệu so sánh  chi phí và doanh thu  
        public void loadBieuDoSoSanhCpVaDT( string thoiGian)
        {
            //xóa dữ liệu truy vấn trước đó 
            chartSoSanhCPVaDT.Series["Doanh thu"].Points.Clear();
            chartSoSanhCPVaDT.Series["Chi phí"].Points.Clear();

            //Thêm tiêu đề  trục
            chartSoSanhCPVaDT.ChartAreas["MainArea"].AxisX.Title = "Tháng";
            chartSoSanhCPVaDT.ChartAreas["MainArea"].AxisY.Title = "Số tiền (VND)";
            if (thoiGian == "6 tháng")
            {
                loadDataSoSanhCpVaDtTrong6Thang();
           
            }
            else if (thoiGian == "3 tháng")
            {
                loadDataSoSanhCpVaDtTrong3Thang();
            }
            else
            {
                loadDataSoSanhCpVaDtTrong1nam();
            }
        }

        //Helper Tải dữ liệu chi phí và doanh thu 
        public void loadDataCpVaDoanhThu(ref DateTime thoigian)
        {
            DateTime from = thoigian;
            DateTime to = thoigian.AddMonths(1);
            dsChiPhi = ChiPhiVeSinhDAO.Instance.GetDanhSachChiPhiVeSinh(from, to);
            dsDoanhThu = DoanhThuDAO.Instance.GetDanhSachDoanhThuVeSinh(from, to);

            double tongChiPhiTrong6Thang = ChiPhiVeSinhDAO.Instance.GetTotalChiPhi(dsChiPhi);
            double tongDoanhThuTrong6Thang = DoanhThuDAO.Instance.GetTotalDoanhThu(dsDoanhThu);
            chartSoSanhCPVaDT.Series["Doanh thu"].Points.AddXY(from.ToString("MM"), tongDoanhThuTrong6Thang);
            chartSoSanhCPVaDT.Series["Chi phí"].Points.AddXY(from.ToString("MM"), tongChiPhiTrong6Thang);
            thoigian = to;
        }

        //Tải dữ liệu chi phí và doanh thu 6 tháng 
        public void loadDataSoSanhCpVaDtTrong6Thang()
        {
            DateTime homnay = DateTime.Now;
            DateTime truocDo = homnay.AddMonths(-6);
            //loop for 6 months 
            for (int i = 0; i < 6; i++)
            {
                loadDataCpVaDoanhThu(ref truocDo);
            }
        }
        //Tải dữ liệu chi phí và doanh thu 3 tháng 

        public void loadDataSoSanhCpVaDtTrong3Thang()
        {
            DateTime homnay = DateTime.Now;
            DateTime truocDo = homnay.AddMonths(-3);
            //loop for 3 months 
            for (int i = 0; i < 3; i++)
            {
                loadDataCpVaDoanhThu(ref truocDo);
            }
        }
        public void loadDataSoSanhCpVaDtTrong1nam()
        {
            DateTime homnay = DateTime.Now;
            DateTime truocDo = homnay.AddMonths(-12);
            //loop for 3 months 
            for (int i = 0; i < 3; i++)
            {
                loadDataCpVaDoanhThu(ref truocDo);
            }
        }


        private void chartSoSanhCP_Click(object sender, EventArgs e)
        {

        }

        private void btnXemBieuDo_Click(object sender, EventArgs e)
        {
            string thoiGian =cbThoiGian.SelectedItem.ToString();
            if (btnXemBieuDo.Text == "Xem biểu đồ so sánh tổng chi phí và doanh thu")
            {
                


                chartSoSanhCPVaDT.Visible = true;
                chartSoSanhCP.Visible = false;
                btnXemBieuDo.Text = "Xem biểu đồ so sánh chi phí dự kiến và thực tế";

                loadBieuDoSoSanhCpVaDT(thoiGian);
            }
            else
            {
                

                chartSoSanhCPVaDT.Visible = false;
                chartSoSanhCP.Visible = true;
                btnXemBieuDo.Text = "Xem biểu đồ so sánh tổng chi phí và doanh thu";
                loadBieuDoChiPhi(thoiGian);
            }
        }
    }
}
