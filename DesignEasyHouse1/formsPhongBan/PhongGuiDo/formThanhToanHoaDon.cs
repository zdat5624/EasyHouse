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

namespace DesignEasyHouse1.formsPhongBan.PhongGuiDo
{
    public partial class formThanhToanHoaDon : Form
    {
        HoaDonGuiDo hoaDon = null;
        public formThanhToanHoaDon()
        {
            InitializeComponent();
        }

        void LoadDTGV()
        {
            dtgvHoaDonChuaThanhToan.DataSource = HoaDonGuiDoDAO.Instance.LayDanhSachHoaDonChuaThanhToan();
            MyGUI.chuyenCotDenCuoiDTGV(dtgvHoaDonChuaThanhToan, new List<string> { "Details" });
        }

        void LoadGbThanhThoan()
        {
            if (this.hoaDon == null)
            {
                return;
            }

            foreach(var item in groupBoxThanhToan.Controls)
            {
                Control c = item as Control;
                c.Visible = true;
            }
            cbbLoaiThanhToan.SelectedIndex = 0;

            TimeSpan thoiGianGui = DateTime.Now - this.hoaDon.NgayTao;
            int soNgay = thoiGianGui.Days;
            int soGio = thoiGianGui.Hours;
            int soPhut = thoiGianGui.Minutes;

            if (soNgay <= 0)
            {
                // Hiển thị thời gian dưới dạng "X ngày, Y giờ, Z phút"
                txtTongThoiGian.Text = $"{soGio} giờ, {soPhut} phút";
            } 
            else
            {
                txtTongThoiGian.Text = $"{soNgay} ngày, {soGio} giờ, {soPhut} phút";
            }
            

            // Load thông tin của this.hoaDon vào các control trong groupBoxThanhToan
            txtHoaDonID.Text = hoaDon.HoaDonGuiDoID.ToString();
            txtLoaiDo.Text = hoaDon.LoaiDo;
            txtKichCo.Text = hoaDon.KichCo;
            txtViTri.Text = hoaDon.ViTri;
            if (hoaDon.CuDanID==0)
            {
                cbbNguoiGui.SelectedItem = "Khách";
                labelCuDanID.Visible = false;
                txtCuDanID.Visible = false;
                labelHoTen.Visible = false;
                txtHoTenCuDan.Visible = false;
            }
            else
            {
                cbbNguoiGui.SelectedItem = "Cư dân";
                txtCuDanID.Text = hoaDon.CuDanID.ToString();
                CuDan cd = CuDanDAO.Instance.GetCuDanByCuDanID(hoaDon.CuDanID);
                if (cd != null)
                {
                    txtHoTenCuDan.Text = CuDanDAO.Instance.GetCuDanByCuDanID(hoaDon.CuDanID).HoTen;
                }
            }
            
            dtpNgayTao.Value = hoaDon.NgayTao;

        }

        void ThanhToanHoaDon()
        {
            if (hoaDon == null)
            {
                MessageBox.Show("Không có hóa đơn để thanh toán.");
                return;
            }

            // Cập nhật thông tin từ các control vào đối tượng hoaDon
            hoaDon.LoaiThanhToan = cbbLoaiThanhToan.SelectedItem?.ToString();
            hoaDon.SoTien = Convert.ToDouble(nudSoTien.Value);
            hoaDon.NgayThanhToan = DateTime.Now;
            hoaDon.TrangThai = "Đã thanh toán"; // Thay đổi trạng thái phù hợp
            hoaDon.NguoiThanhToanID = SessionNhanVien.id;

            // Gọi phương thức DAO để cập nhật
            bool ttThanhCong = HoaDonGuiDoDAO.Instance.ThanhToanHoaDon(hoaDon);

            if (ttThanhCong)
            {
                MessageBox.Show("Thanh toán hóa đơn thành công.");
                LoadDTGV(); // Refresh lại DataGridView
            }
            else
            {
                MessageBox.Show("Thanh toán hóa đơn thất bại. Vui lòng thử lại.");
            }
        }


        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToanHoaDon();
        }


        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            formThemHoaDon f = new formThemHoaDon();
            f.ShowDialog();
            LoadDTGV();
        }

        private void formThanhToanHoaDon_Load(object sender, EventArgs e)
        {
            LoadDTGV();
        }

        private void dtgvHoaDonChuaThanhToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Kiểm tra nếu cột được click là cột "Details"
                if (e.ColumnIndex == dtgvHoaDonChuaThanhToan.Columns["Details"].Index)
                {
                    int hoaDonGuiDoID = Convert.ToInt32(dtgvHoaDonChuaThanhToan.Rows[e.RowIndex].Cells["HoaDonGuiDoID"].Value);
                    //XemChiTietVatTuThiCong(vatTuThiCongID);
                }
                else
                {
                    int hoaDonGuiDoID = Convert.ToInt32(dtgvHoaDonChuaThanhToan.Rows[e.RowIndex].Cells["HoaDonGuiDoID"].Value);
                    HoaDonGuiDo hd = HoaDonGuiDoDAO.Instance.LayHoaDonBangID(hoaDonGuiDoID);
                    if (hd != null) 
                    {
                        this.hoaDon = hd;
                        LoadGbThanhThoan();
                    }

                }

            }
        }

        private void nudSoTien_ValueChanged(object sender, EventArgs e)
        {
            nudSoTien.ThousandsSeparator = true;
            //nudSoTien.Text = nudSoTien.Value.ToString("N0");
        }

    }
}
