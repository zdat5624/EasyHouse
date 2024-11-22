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

namespace DesignEasyHouse1.formsPhongBan.PhongCuDan
{
    public partial class formThemHoaDon : Form
    {
        string phanLoai;
        public formThemHoaDon(string phanLoai)
        {
            InitializeComponent();
            this.phanLoai = phanLoai;
            txtPhanLoai.Text = phanLoai;
            txtNoiDung.Text = "Căn hộ: () |  " + Environment.NewLine
                + "Chỉ số điện cũ: () Chỉ số điện mới: () Điện năng tiêu thụ: () Đơn giá: () Thành tiền: () |" + Environment.NewLine
                + "Chỉ số nước cũ: () Chỉ số nước mới: () Lượng nước tiêu thụ: () Đơn giá: () Thành tiền: () |   " + Environment.NewLine
                + "Tiền thuê căn hộ: () |    " + Environment.NewLine
                + "Phí dịch vụ: () |     ";
        }

        void ThemHoaDon()
        {
            try
            {
                string phanLoai = this.phanLoai;
                string noiDung = txtNoiDung.Text.Trim();
                float tongTien = (float)nudTongTien.Value;
                int cuDanID;



                if (!int.TryParse(txtCuDanID.Text, out cuDanID) || cuDanID < 0)
                {
                    MessageBox.Show("ID cư dân phải không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                CuDan cd = CuDanDAO.Instance.GetCuDanByCuDanID(cuDanID);
                if (cd == null)
                {
                    MessageBox.Show("Không tìm thấy cư dân với ID đã nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                HoaDon hoaDon = new HoaDon
                {
                    PhanLoai = phanLoai,
                    TongTien = tongTien,
                    NoiDung = noiDung,
                    CuDanID = cuDanID,
                    TrangThai = "Chưa thanh toán",
                    NgayTao = DateTime.Now
                };

                bool result = HoaDonDAO.Instance.ThemHoaDon(hoaDon);

                if (result)
                {
                    MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm hóa đơn thất bại. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemHoaDon();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCuDanID_TextChanged(object sender, EventArgs e)
        {
            CuDan cd = CuDanDAO.Instance.GetCuDanByCuDanID(Convert.ToInt32(txtCuDanID.Text));
            if (cd != null)
            {
                txtTenCuDan.Text = cd.HoTen;
            } else
            {
                txtTenCuDan.Text = "";
            }
        }

        private void txtCuDanID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
