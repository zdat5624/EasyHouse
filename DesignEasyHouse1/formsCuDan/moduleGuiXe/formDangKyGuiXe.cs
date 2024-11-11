using DesignEasyHouse1.DAO;
using DesignEasyHouse1.DTO;
using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignEasyHouse1.formsCuDan.moduleGuiXe
{
    public partial class formDangKyGuiXe : Form
    {
        private byte[] fileData = null;
        private byte[] fileData2 = null;
        public formDangKyGuiXe()
        {
            InitializeComponent();
        }

        void DangKyGuiXe()
        {
            // Lấy dữ liệu từ các controls trong form
            string bienSoXe = txtBienSoXe.Text.Trim();
            int cuDanID = Convert.ToInt32(txtCuDanID.Text.Trim());
            string loaiXe = txtLoaiXe.Text.Trim();

            DateTime? thoiGianGui = dtpThoiGianGuiXe.Checked ? (DateTime?)dtpThoiGianGuiXe.Value : null;

            // Tạo một đối tượng PhuoingTien từ dữ liệu người dùng nhập
            PhuongTien phuongTien = new PhuongTien
            {
                BienSoXe = bienSoXe,
                CuDanID = cuDanID,
                LoaiXe = loaiXe,
                ThoiGianGui = thoiGianGui,
                CavetXe = this.fileData,
                CCCD_CMND = this.fileData2
            };


            // Gọi DAO để thêm dự án vào cơ sở dữ liệu
            bool success = PhuongTienDAO.Instance.ThemPhuongTien(phuongTien);

            if (success)
            {
                MessageBox.Show("Đăng ký xe thành công vui lòng đợi xác nhận từ quản lý!", "Thông báo");
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại. Vui lòng kiểm tra lại dữ liệu.", "Lỗi");
            }
        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            // Tạo một đối tượng OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG Files (*.png)|*.png|All Files (*.*)|*.*";  // Chỉ cho phép chọn file PNG

            // Kiểm tra xem người dùng có chọn file không
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lưu đường dẫn file vào TextBox
                txtCaVetXe.Text = openFileDialog.FileName;

                // Lưu nội dung file vào biến byte[]
                this.fileData = File.ReadAllBytes(openFileDialog.FileName);
            }
        }

        private void btnChonFile2_Click(object sender, EventArgs e)
        {
            // Tạo một đối tượng OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG Files (*.png)|*.png|All Files (*.*)|*.*";  // Chỉ cho phép chọn file PNG

            // Kiểm tra xem người dùng có chọn file không
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lưu đường dẫn file vào TextBox
                txtCCCD_CMND.Text = openFileDialog.FileName;

                // Lưu nội dung file vào biến byte[]
                this.fileData2 = File.ReadAllBytes(openFileDialog.FileName);

            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKyGuiXe();
        }
    }
}
