using DesignEasyHouse1.DAO;
using DesignEasyHouse1.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DesignEasyHouse1.formsPhongBan.PhongGuiDo
{
    public partial class formThemHoaDon : Form
    {
        public formThemHoaDon()
        {
            InitializeComponent();
        }
        #region Methods

        void ThemHoaDon()
        {
            try
            {
                // Lấy dữ liệu từ các trường nhập liệu
                string loaiDo = cbbLoaiDo.Text;
                string kichCo = txtKichCo.Text;
                string viTri = cbbViTri.Text;
                string ghiChu = txtGhiChu.Text;
                int cuDanID = 0; // Mặc định là khách
                DateTime? ngayLayDuKien = null;

                // Kiểm tra nếu người gửi là cư dân
                if (cbbNguoiGui.Text == "Cư dân" && !string.IsNullOrEmpty(txtCuDanID.Text))
                {
                    cuDanID = Convert.ToInt32(txtCuDanID.Text);
                    if (CuDanDAO.Instance.GetCuDanByCuDanID(cuDanID)==null)
                    {
                        MessageBox.Show($"Không tìm thấy cư dân ID {cuDanID}");
                        return;
                    }
                }

                // Kiểm tra ngày lấy dự kiến nếu người dùng chọn
                if (checkBoxNgayLayDuKien.Checked)
                {
                    ngayLayDuKien = dtpNgayLayDuKien.Value;
                }

                // Tạo đối tượng HoaDonGuiDo để thêm vào cơ sở dữ liệu
                HoaDonGuiDo hoaDon = new HoaDonGuiDo
                {
                    LoaiDo = loaiDo,
                    KichCo = kichCo,
                    ViTri = viTri,
                    GhiChu = ghiChu,
                    CuDanID = cuDanID,
                    NgayLayDuKien = ngayLayDuKien,
                    NguoiTaoID = SessionNhanVien.id, // Thay thế với ID của nhân viên hiện tại
                    TrangThai = "Chưa thanh toán",

                };

                // Thêm hóa đơn vào cơ sở dữ liệu qua DAO
                bool result = HoaDonGuiDoDAO.Instance.ThemHoaDon(hoaDon);

                if (result)
                {
                    MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm hóa đơn thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LoadLoaiDo()
        {
            List<string> loaiDos = HoaDonGuiDoDAO.Instance.LayDanhSachLoaiDo();

            cbbLoaiDo.Items.Clear();
            cbbLoaiDo.Items.AddRange(loaiDos.ToArray());

            if (cbbLoaiDo.Items.Count > 0)
            {
                cbbLoaiDo.SelectedIndex = 0;
            }
        }

        #endregion

        #region Events

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemHoaDon();
        }

        private void formThemHoaDon_Load(object sender, EventArgs e)
        {
            LoadLoaiDo();
            cbbNguoiGui.SelectedIndex = 0;
        }

        private void cbbNguoiGui_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbNguoiGui.SelectedItem != null && cbbNguoiGui.SelectedItem.ToString() == "Cư dân")
            {
                labelCuDanID.Visible = true;
                txtCuDanID.Visible = true;
                labelHoTen.Visible = true;
                txtHoTenCuDan.Visible = true;
            }
            else
            {
                labelCuDanID.Visible = false;
                txtCuDanID.Visible = false;
                labelHoTen.Visible = false;
                txtHoTenCuDan.Visible = false;
            }
        }

        private void checkBoxNgayLayDuKien_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNgayLayDuKien.Checked)
            {
                dtpNgayLayDuKien.Enabled = true;
            }
            else
            {
                dtpNgayLayDuKien.Enabled = false;
            }
        }

        private void txtCuDanID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Hủy sự kiện nhập nếu ký tự không hợp lệ
                e.Handled = true;
            }
        }

        #endregion

        private void txtCuDanID_TextChanged(object sender, EventArgs e)
        {
            CuDan cd = CuDanDAO.Instance.GetCuDanByCuDanID(Convert.ToInt32(txtCuDanID.Text));
            if (cd != null)
            {
                txtHoTenCuDan.Text = cd.HoTen;
            }
            else
            {
                txtHoTenCuDan.Text = "";
            }
            
        }
    }
}
