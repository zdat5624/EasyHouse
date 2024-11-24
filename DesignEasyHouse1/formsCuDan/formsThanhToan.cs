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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DesignEasyHouse1.formsCuDan
{
    public partial class formsThanhToan : Form
    {
        public formsThanhToan()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void LoadForm()
        {
            int cuDanID = SessionCuDan.CuDanID;
            CuDan cd = CuDanDAO.Instance.GetCuDanByCuDanID(SessionCuDan.CuDanID);

            List<HoaDon> listHoaDon = HoaDonDAO.Instance.LayDanhSachHoaDonChuaThanhToanTheoCuDanID(cuDanID);

            if (listHoaDon.Count > 0)
            {
                var hoaDonDisplayList = listHoaDon.Select(hd => new
                {
                    hd.HoaDonID,
                    DisplayText = $"ID: {hd.HoaDonID} - Số tiền: {(Decimal)hd.TongTien} - Phân loại: {hd.PhanLoai}"
                }).ToList();

                cbbHoaDonChuaThanhToan.DataSource = hoaDonDisplayList;
                cbbHoaDonChuaThanhToan.DisplayMember = "DisplayText";
                cbbHoaDonChuaThanhToan.ValueMember = "HoaDonID";

                cbbHoaDonChuaThanhToan.SelectedIndexChanged += cbbHoaDonChuaThanhToan_SelectedIndexChanged;
                cbbHoaDonChuaThanhToan.SelectedIndex = 0;

                if (cbbHoaDonChuaThanhToan.SelectedValue is int idHoaDon)
                {
                    //int cuDanID = SessionCuDan.CuDanID;
                    string hoTen = SessionCuDan.TenCuDan;
                    string sdt = cd != null ? cd.SoDienThoai : "Không xác định";

                    // Hiển thị nội dung chuyển khoản
                    txtNoiDungChuyenKhoan.Text = $"{idHoaDon} {cuDanID} {hoTen} {sdt}";
                }
            }
            else
            {
                btnXacNhanChuyenKhoan.Visible = false;
            }

            

            ThongTinToaNha tt = ThongTinToaNhaDAO.Instance.GetThongTinToaNha();
            lblThongTinToaNha.Text += tt.ThongTinLienHeVoiCuDan;
            txtThongTinThanhToan.Text = tt.ThongTinThanhToan;

            
        }

        private void btnXacNhanChuyenKhoan_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Xác nhận chắc chắn bạn đã chuyển khoản ", "Xác nhận", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                try
                {
                    if (cbbHoaDonChuaThanhToan.SelectedValue is int idHoaDon)
                    {
                        bool kq = HoaDonDAO.Instance.CapNhatTrangThaiHoaDon(idHoaDon, "Chờ xác nhận");

                        if (kq)
                        {
                            MessageBox.Show("Hệ thống đã ghi nhận, chờ đến khi có xác nhận đã thanh toán thành công.");
                            LoadForm();
                        }
                        else
                        {
                            MessageBox.Show("Không thể cập nhật trạng thái hóa đơn. Vui lòng thử lại.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hóa đơn được chọn không hợp lệ.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xảy ra: " + ex.Message + ". Hãy báo cho phòng hỗ trợ.");
                }
            }
        }


        private void formsThanhToan_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void cbbHoaDonChuaThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            CuDan cd = CuDanDAO.Instance.GetCuDanByCuDanID(SessionCuDan.CuDanID);

            if (cbbHoaDonChuaThanhToan.SelectedValue is int idHoaDon)
            {
                int cuDanID = SessionCuDan.CuDanID;
                string hoTen = SessionCuDan.TenCuDan;
                string sdt = cd != null ? cd.SoDienThoai : "Không xác định";

                // Hiển thị nội dung chuyển khoản
                txtNoiDungChuyenKhoan.Text = $"{idHoaDon} {cuDanID} {hoTen} {sdt}";
            }
            else
            {
                txtNoiDungChuyenKhoan.Text = "Dữ liệu không hợp lệ.";
            }
        }

    }
}
