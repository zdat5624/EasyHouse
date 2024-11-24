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
using OfficeOpenXml;

namespace DesignEasyHouse1.formsPhongBan.PhongCuDan
{
    public partial class formHoaDonCanHo : Form
    {
        public formHoaDonCanHo()
        {
            InitializeComponent();
            cbbLocHoaDon.SelectedIndexChanged += cbbLocHoaDon_SelectedIndexChanged;
            if (cbbLocHoaDon.Items.Count > 0)
            {
                cbbLocHoaDon.SelectedIndex = 0;
            }
            dtgvHoaDonCanHo.CellContentClick += dtgvHoaDonCanHo_CellContentClick;

            string thangHienTai = DateTime.Now.ToString("MM");

            btnTaoPhieuGhiThang.Text = $"Tạo phiếu ghi tháng {thangHienTai}";
        }

        #region Medthods

        void LoadDtgvHoaDonChuaThanhToan()
        {
            dtgvHoaDonCanHo.DataSource = HoaDonDAO.Instance.LayDTHoaDonChuaThanhToan("Hóa đơn điện-nước-thuê nhà-phí dịch vụ");
            dtgvHoaDonCanHo.Columns["HoaDonID"].HeaderText = "ID";
            dtgvHoaDonCanHo.Columns["PhanLoai"].HeaderText = "Phân Loại";
            dtgvHoaDonCanHo.Columns["TongTien"].HeaderText = "Tổng Tiền";
            dtgvHoaDonCanHo.Columns["NoiDung"].HeaderText = "Nội Dung";
            dtgvHoaDonCanHo.Columns["NgayTao"].HeaderText = "Ngày Tạo";
            dtgvHoaDonCanHo.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dtgvHoaDonCanHo.Columns["CuDanID"].HeaderText = "ID Cư Dân Trả";
            dtgvHoaDonCanHo.Columns["TenCuDan"].HeaderText = "Tên Cư Dân Trả";
            MyGUI.chuyenCotDenCuoiDTGV(dtgvHoaDonCanHo, new List<string> { "Delete", "Details"});
            MyGUI.dinhDangCotAllCellsDTGV(dtgvHoaDonCanHo, new List<string> { "HoaDonID" });
        }

        void LoadDtgvHoaDonChoXacNhan()
        {
            dtgvHoaDonCanHo.DataSource = HoaDonDAO.Instance.LayDTHoaDonChuaThanhToan("Hóa đơn điện-nước-thuê nhà-phí dịch vụ");
            dtgvHoaDonCanHo.Columns["HoaDonID"].HeaderText = "ID";
            dtgvHoaDonCanHo.Columns["PhanLoai"].HeaderText = "Phân Loại";
            dtgvHoaDonCanHo.Columns["TongTien"].HeaderText = "Tổng Tiền";
            dtgvHoaDonCanHo.Columns["NoiDung"].HeaderText = "Nội Dung";
            dtgvHoaDonCanHo.Columns["NgayTao"].HeaderText = "Ngày Tạo";
            dtgvHoaDonCanHo.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dtgvHoaDonCanHo.Columns["CuDanID"].HeaderText = "ID Cư Dân Trả";
            dtgvHoaDonCanHo.Columns["TenCuDan"].HeaderText = "Tên Cư Dân Trả";
            MyGUI.chuyenCotDenCuoiDTGV(dtgvHoaDonCanHo, new List<string> { "Delete", "Details" });
            MyGUI.dinhDangCotAllCellsDTGV(dtgvHoaDonCanHo, new List<string> { "HoaDonID" });
        }

        void LoadDtgvTatCaHoaDon()
        {
            dtgvHoaDonCanHo.DataSource = HoaDonDAO.Instance.LayDTHoaDon("Hóa đơn điện-nước-thuê nhà-phí dịch vụ");
            dtgvHoaDonCanHo.Columns["HoaDonID"].HeaderText = "ID";
            dtgvHoaDonCanHo.Columns["PhanLoai"].HeaderText = "Phân Loại";
            dtgvHoaDonCanHo.Columns["TongTien"].HeaderText = "Tổng Tiền";
            dtgvHoaDonCanHo.Columns["NoiDung"].HeaderText = "Nội Dung";
            dtgvHoaDonCanHo.Columns["NgayTao"].HeaderText = "Ngày Tạo";
            dtgvHoaDonCanHo.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dtgvHoaDonCanHo.Columns["CuDanID"].HeaderText = "ID Cư Dân Trả";
            dtgvHoaDonCanHo.Columns["TenCuDan"].HeaderText = "Tên Cư Dân Trả";
            MyGUI.chuyenCotDenCuoiDTGV(dtgvHoaDonCanHo, new List<string> { "Delete", "Details" });
            MyGUI.dinhDangCotAllCellsDTGV(dtgvHoaDonCanHo, new List<string> { "HoaDonID" });
        }

        

        void XoaHoaDon(int hoaDonID)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa hóa đơn này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            bool kq = HoaDonDAO.Instance.XoaHoaDon(hoaDonID);

            if (kq)
            {
                MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (cbbLocHoaDon.SelectedItem.ToString() == "Hóa đơn chưa thanh toán")
                {
                    LoadDtgvHoaDonChuaThanhToan();
                }
                else
                {
                    LoadDtgvTatCaHoaDon();
                }
            }
            else
            {
                MessageBox.Show("Xóa hóa đơn thất bại. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LoadDTGV()
        {
            string selectedItem = cbbLocHoaDon.SelectedItem?.ToString();

            if (selectedItem == "Hóa đơn chưa thanh toán")
            {
                LoadDtgvHoaDonChuaThanhToan();
            }
            else if (selectedItem == "Tất cả hóa đơn")
            {
                LoadDtgvTatCaHoaDon();
            }
            else if (selectedItem == "Hóa đơn chờ xác nhận")
            {
                LoadDtgvHoaDonChoXacNhan();
            }
        }

        void XemChiTietHoaDon(int hoaDonID)
        {
            formChiTietHoaDon f = new formChiTietHoaDon(hoaDonID);
            f.ShowDialog();
            LoadDTGV();
        }

        #endregion

        private void cbbLocHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbbLocHoaDon
            //Hóa đơn chưa thanh toán
            //Tất cả hóa đơn

            LoadDTGV();
        }

        private void dtgvHoaDonCanHo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý xóa, xem chi tiết
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dtgvHoaDonCanHo.Columns["Delete"].Index)
                {
                    int hoaDonID = Convert.ToInt32(dtgvHoaDonCanHo.Rows[e.RowIndex].Cells["HoaDonID"].Value);
                    XoaHoaDon(hoaDonID);
                } else if (e.ColumnIndex == dtgvHoaDonCanHo.Columns["Details"].Index)
                {
                    int hoaDonID = Convert.ToInt32(dtgvHoaDonCanHo.Rows[e.RowIndex].Cells["HoaDonID"].Value);
                    XemChiTietHoaDon(hoaDonID);
                }
            }
        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            formThemHoaDon f = new formThemHoaDon("Hóa đơn điện-nước-thuê nhà-phí dịch vụ");
            f.ShowDialog();
            LoadDTGV();
        }

        private void btnTaoPhieuGhiThang_Click(object sender, EventArgs e)
        {
            formTaoPhieuGhi f = new formTaoPhieuGhi();
            f.ShowDialog();
        }

        private void btnNhapPhieuGhi_Click(object sender, EventArgs e)
        {

        }
    }
}
