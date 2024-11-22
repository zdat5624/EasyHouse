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

namespace DesignEasyHouse1.formsGiamDoc
{
    public partial class formThongTinToaNha : Form
    {
        public formThongTinToaNha()
        {
            InitializeComponent();
            LoadForm();
        }

        void LoadForm()
        {
            ThongTinToaNha thongTinToaNha = ThongTinToaNhaDAO.Instance.GetThongTinToaNha();

            if (thongTinToaNha != null)
            {
                txtTenToaNha.Text = thongTinToaNha.TenToaNha;
                txtMoTa.Text = thongTinToaNha.MoTa;
                txtChuDauTu.Text = thongTinToaNha.ChuDauTu;
                txtDonViQuanLi.Text = thongTinToaNha.DonViQuanLi;
                txtThongTinThanhToan.Text = thongTinToaNha.ThongTinThanhToan;
                txtThongTinLienHeVoiCuDan.Text = thongTinToaNha.ThongTinLienHeVoiCuDan;
            }

        }

        void CapNhatThongTinToaNha()
        {
            string tenToaNha = txtTenToaNha.Text.Trim();
            string moTa = txtMoTa.Text.Trim();
            string chuDauTu = txtChuDauTu.Text.Trim();
            string donViQuanLi = txtDonViQuanLi.Text.Trim();
            string thongTinThanhToan = txtThongTinThanhToan.Text.Trim();
            string thongTinLienHeVoiCuDan = txtThongTinLienHeVoiCuDan.Text.Trim();

            if (string.IsNullOrEmpty(tenToaNha) || string.IsNullOrEmpty(chuDauTu) || string.IsNullOrEmpty(donViQuanLi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các thông tin bắt buộc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng ThongTinToaNha để lưu trữ thông tin
            ThongTinToaNha thongTinToaNha = new ThongTinToaNha
            {
                TenToaNha = tenToaNha,
                MoTa = moTa,
                ChuDauTu = chuDauTu,
                DonViQuanLi = donViQuanLi,
                ThongTinThanhToan = thongTinThanhToan,
                ThongTinLienHeVoiCuDan = thongTinLienHeVoiCuDan
            };

            bool result = ThongTinToaNhaDAO.Instance.CapNhatThongTinToaNha(thongTinToaNha);

            if (result)
            {
                MessageBox.Show("Cập nhật thông tin tòa nhà thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin tòa nhà thất bại. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ThemThongTinToaNha()
        {
            // Lấy dữ liệu từ các control
            string tenToaNha = txtTenToaNha.Text.Trim();
            string moTa = txtMoTa.Text.Trim();
            string chuDauTu = txtChuDauTu.Text.Trim();
            string donViQuanLi = txtDonViQuanLi.Text.Trim();
            string thongTinThanhToan = txtThongTinThanhToan.Text.Trim();
            string thongTinLienHeVoiCuDan = txtThongTinLienHeVoiCuDan.Text.Trim();

            // Kiểm tra thông tin
            if (string.IsNullOrEmpty(tenToaNha) || string.IsNullOrEmpty(chuDauTu) || string.IsNullOrEmpty(donViQuanLi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các thông tin bắt buộc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gọi DAO để thêm thông tin
            bool result = ThongTinToaNhaDAO.Instance.ThemThongTinToaNha(new ThongTinToaNha
            {
                TenToaNha = tenToaNha,
                MoTa = moTa,
                ChuDauTu = chuDauTu,
                DonViQuanLi = donViQuanLi,
                ThongTinThanhToan = thongTinThanhToan,
                ThongTinLienHeVoiCuDan = thongTinLienHeVoiCuDan
            });

            if (result)
            {
                MessageBox.Show("Thêm thông tin tòa nhà thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm thông tin tòa nhà thất bại. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnLuu_Click(object sender, EventArgs e)
        {
            ThongTinToaNha thongTinToaNha = ThongTinToaNhaDAO.Instance.GetThongTinToaNha();

            if (thongTinToaNha == null)
            {
                ThemThongTinToaNha();
            }
            else
            {
                CapNhatThongTinToaNha();
            }
            LoadForm();
        }
    }
}
