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
    public partial class formChiTietHoaDon : Form
    {
        HoaDonGuiDo hoaDon = null;
        public formChiTietHoaDon(int hoaDonGuiDoID)
        {
            InitializeComponent();
            this.hoaDon = HoaDonGuiDoDAO.Instance.LayHoaDonBangID(hoaDonGuiDoID);
        }

        void LoadForm()
        {
            if (this.hoaDon == null)
            {
                MessageBox.Show("Hóa đơn không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị thông tin hóa đơn vào các TextBox, Label hoặc các điều khiển khác
            txtHoaDonID.Text = this.hoaDon.HoaDonGuiDoID.ToString();
            txtLoaiDo.Text = this.hoaDon.LoaiDo;
            txtKichCo.Text = this.hoaDon.KichCo;
            txtViTri.Text = this.hoaDon.ViTri;
            if (this.hoaDon.CuDanID==0)
            {
                cbbNguoiGui.Text = "Khách";
                txtHoTenCuDan.Visible = false;
                txtCuDanID.Visible = false;
                labelCuDanID.Visible = false;
                labelHoTen.Visible = false;
            } else
            {
                cbbNguoiGui.Text = "Cư dân";
                txtCuDanID.Text = this.hoaDon.CuDanID.ToString();
                CuDan cd = CuDanDAO.Instance.GetCuDanByCuDanID(this.hoaDon.CuDanID);
                if (cd != null) 
                {
                    txtHoTenCuDan.Text = cd.HoTen;
                }
            }

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

            dtpNgayTao.Value = this.hoaDon.NgayTao;

            NhanVien nvTaoHoaDon = NhanVienDAO.Instance.LayNhanVienBangID(this.hoaDon.NguoiTaoID);
            if (nvTaoHoaDon!=null)
            {
                txtNguoiTao.Text = $"{nvTaoHoaDon.Ten} (ID: {nvTaoHoaDon.Id})";
            }

            if (this.hoaDon.TrangThai=="Chưa thanh toán")
            {
                nudSoTien.Visible = false;
                cbbLoaiThanhToan.Visible = false;
                lblThanhToan.Text = "*Hóa đơn chưa thanh toán";
                lblThanhToan.Font = new Font(lblThanhToan.Font, FontStyle.Bold | FontStyle.Italic);
                txtNguoiThanhToan.Visible = false;
                lblNguoiThanhToan.Visible = false;
                lblNgayThanhToan.Visible = false;
                dtpNgayThanhToan.Visible = false ;
            }
            else
            {
                cbbLoaiThanhToan.Text = this.hoaDon.LoaiThanhToan;
                nudSoTien.Value = (decimal)this.hoaDon.SoTien;
                dtpNgayThanhToan.Value = (DateTime)this.hoaDon.NgayThanhToan;
                NhanVien nvThanhToan = NhanVienDAO.Instance.LayNhanVienBangID((int)this.hoaDon.NguoiThanhToanID);
                if (nvTaoHoaDon != null)
                {
                    txtNguoiThanhToan.Text = $"{nvThanhToan.Ten} (ID: {nvThanhToan.Id})";
                }
            } 
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formChiTietHoaDon_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }
    }
}
