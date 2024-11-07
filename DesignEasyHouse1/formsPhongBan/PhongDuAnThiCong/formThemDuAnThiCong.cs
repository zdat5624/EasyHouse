using DesignEasyHouse1.DAO;
using DesignEasyHouse1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignEasyHouse1.formsPhongBan.PhongDuAnThiCong
{
    public partial class formThemDuAnThiCong : Form
    {
        private byte[] fileData = null;

        public formThemDuAnThiCong()
        {
            InitializeComponent();
            cbbChuDuAn.SelectedIndex = 0;
        }


        void ThemDuAn()
        {
            // Lấy dữ liệu từ các controls trong form
            string tenDuAn = txtTenDuAn.Text.Trim();
            string tenNhaThau = txtTenNhaThau.Text.Trim();
            string chuDuAn = cbbChuDuAn.Text.Trim();
            
            DateTime? ngayBatDau = dtpNgayBatDau.Checked ? (DateTime?)dtpNgayBatDau.Value : null;
            DateTime? ngayKetThuc = dtpNgayKetThuc.Checked ? (DateTime?)dtpNgayKetThuc.Value : null;

            // Tạo một đối tượng DuAnThiCong từ dữ liệu người dùng nhập
            DuAnThiCong duAn = new DuAnThiCong
            {
                TenDuAn = tenDuAn,
                TenNhaThau = tenNhaThau,
                ChuDuAn = chuDuAn,
                NgayBatDau = ngayBatDau,
                NgayKetThuc = ngayKetThuc,
                TrangThai = "Đang thi công",
                FileTaiLieu = this.fileData
            };


            // Gọi DAO để thêm dự án vào cơ sở dữ liệu
            bool success = DuAnThiCongDAO.Instance.ThemDuAn(duAn);

            if (success)
            {
                MessageBox.Show("Thêm dự án thành công!", "Thông báo");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm dự án thất bại. Vui lòng kiểm tra lại dữ liệu.", "Lỗi");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            ThemDuAn();
        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            // Tạo một đối tượng OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Zip Files (*.zip;*.rar)|*.zip;*.rar|All Files (*.*)|*.*";  // Hạn chế các loại file

            // Kiểm tra xem người dùng có chọn file không
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lưu đường dẫn file vào TextBox
                txtFileTaiLieu.Text = openFileDialog.FileName;

                // Lưu nội dung file vào biến byte[]
                this.fileData = File.ReadAllBytes(openFileDialog.FileName);

            }
        }
    }
}
