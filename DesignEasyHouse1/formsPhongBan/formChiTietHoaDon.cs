using DesignEasyHouse1.DAO;
using DesignEasyHouse1.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignEasyHouse1.formsPhongBan
{
    public partial class formChiTietHoaDon : Form
    {
        HoaDon hoaDon = null;
        CuDan cuDan = null;
        public formChiTietHoaDon(int hoaDonID)
        {
            InitializeComponent();
            this.hoaDon = HoaDonDAO.Instance.LayHoaDonTheoID(hoaDonID);
            if (hoaDon != null)
                this.cuDan = CuDanDAO.Instance.GetCuDanByCuDanID(hoaDon.CuDanID);
            LoadForm();
        }

        public formChiTietHoaDon(int hoaDonID, int cuDanID)
        {
            InitializeComponent();
            this.hoaDon = HoaDonDAO.Instance.LayHoaDonTheoID(hoaDonID);
            if (hoaDon != null)
                this.cuDan = CuDanDAO.Instance.GetCuDanByCuDanID(hoaDon.CuDanID);
            LoadFormDanhChoCuDan();
        }

        void LoadForm()
        {
            if (hoaDon == null || cuDan == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn hoặc người trả hóa đơn. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txtPhanLoai.Text = hoaDon.PhanLoai;
            nudTongTien.Value = Convert.ToDecimal(hoaDon.TongTien);
            txtCuDanID.Text = hoaDon.CuDanID.ToString();
            txtTenCuDan.Text = cuDan.HoTen;
            txtTrangThai.Text = hoaDon.TrangThai;

            if (hoaDon.TrangThai == "Đã thanh toán")
            {
                btnXacNhanDaThanhToan.Enabled = false;
                btnXacNhanDaThanhToan.Visible = false;
                btnXacNhanChuaThanhToan.Enabled = true;
                btnXacNhanChuaThanhToan.Visible = true;
                txtTrangThai.ForeColor = Color.Green;
            }
            else if (hoaDon.TrangThai == "Chưa thanh toán")
            {
                btnXacNhanDaThanhToan.Enabled = true;
                btnXacNhanDaThanhToan.Visible = true;
                btnXacNhanChuaThanhToan.Enabled = false;
                btnXacNhanChuaThanhToan.Visible = false;
                txtTrangThai.ForeColor = Color.Red;
            }
            else if (hoaDon.TrangThai == "Chờ xác nhận")
            {
                btnXacNhanDaThanhToan.Enabled = true;
                btnXacNhanDaThanhToan.Visible = true;
                btnXacNhanChuaThanhToan.Enabled = true;
                btnXacNhanChuaThanhToan.Visible = true;
                txtTrangThai.ForeColor = Color.Orange;
            }
        }

        void LoadFormDanhChoCuDan()
        {
            if (hoaDon == null || cuDan == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn hoặc người trả hóa đơn. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txtPhanLoai.Text = hoaDon.PhanLoai;
            nudTongTien.Value = Convert.ToDecimal(hoaDon.TongTien);
            txtCuDanID.Text = hoaDon.CuDanID.ToString();
            txtTenCuDan.Text = cuDan.HoTen;
            txtTrangThai.Text = hoaDon.TrangThai;

            if (hoaDon.TrangThai == "Đã thanh toán")
            {
                txtTrangThai.ForeColor = Color.Green;
            }
            else if (hoaDon.TrangThai == "Chưa thanh toán")
            {
                txtTrangThai.ForeColor = Color.Red;
            }
            else if (hoaDon.TrangThai == "Chờ xác nhận")
            {
                txtTrangThai.BackColor = Color.Yellow;
            }
        }

        void CapNhatHoaDonChuaThanhToan()
        {
            if (hoaDon == null)
            {
                MessageBox.Show("Hóa đơn không tồn tại hoặc không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult confirm = MessageBox.Show("Xác nhận chuyển hóa đơn thành 'Chưa thanh toán'?",
                                                   "Xác nhận",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    string trangThaiMoi = "Chưa thanh toán";
                    HoaDonDAO.Instance.CapNhatTrangThaiHoaDon(hoaDon.HoaDonID, trangThaiMoi);
                    hoaDon.TrangThai = trangThaiMoi;
                    MessageBox.Show("Cập nhật trạng thái hóa đơn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi cập nhật hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void CapNhatHoaDonDaThanhToan()
        {
            if (hoaDon == null)
            {
                MessageBox.Show("Hóa đơn không tồn tại hoặc không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult confirm = MessageBox.Show("Xác nhận chuyển hóa đơn thành 'Đã thanh toán'?",
                                                   "Xác nhận",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    string trangThaiMoi = "Đã thanh toán";
                    HoaDonDAO.Instance.CapNhatTrangThaiHoaDon(hoaDon.HoaDonID, trangThaiMoi);
                    hoaDon.TrangThai = trangThaiMoi;
                    MessageBox.Show("Cập nhật trạng thái hóa đơn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi cập nhật hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnXacNhanDaThanhToan_Click(object sender, EventArgs e)
        {
            CapNhatHoaDonDaThanhToan();
        }

        private void btnXacNhanChuaThanhToan_Click(object sender, EventArgs e)
        {
            CapNhatHoaDonChuaThanhToan();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
