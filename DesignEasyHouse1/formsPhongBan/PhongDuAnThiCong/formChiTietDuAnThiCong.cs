using DesignEasyHouse1.DAO;
using DesignEasyHouse1.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignEasyHouse1.formsPhongBan.PhongDuAnThiCong
{
    public partial class formChiTietDuAnThiCong : Form
    {
        DuAnThiCong duAnThiCong = null;
        private byte[] fileData = null;

        public formChiTietDuAnThiCong(int duAnThiCongID)
        {
            InitializeComponent();
            this.duAnThiCong = DuAnThiCongDAO.Instance.GetDuAnThiCongByDuAnThiCongID(duAnThiCongID);
        }

        #region Medthods

        void LoadForm()
        {
            txtTenDuAn.Text = duAnThiCong.TenDuAn;
            txtTenNhaThau.Text = duAnThiCong.TenNhaThau;
            cbbTrangThai.SelectedItem = duAnThiCong.TrangThai;
            cbbChuDuAn.SelectedItem = duAnThiCong.ChuDuAn;
            dtpNgayBatDau.Value = (DateTime)duAnThiCong.NgayBatDau;
            dtpNgayKetThuc.Value = (DateTime)duAnThiCong.NgayKetThuc;

        }

        void LuuCapNhatDuAnThiCong()
        {
            // Lấy dữ liệu từ các controls trong form
            string tenDuAn = txtTenDuAn.Text.Trim();
            string tenNhaThau = txtTenNhaThau.Text.Trim();
            string chuDuAn = cbbChuDuAn.Text.Trim();
            DateTime? ngayBatDau = dtpNgayBatDau.Checked ? (DateTime?)dtpNgayBatDau.Value : null;
            DateTime? ngayKetThuc = dtpNgayKetThuc.Checked ? (DateTime?)dtpNgayKetThuc.Value : null;
            string trangThai = cbbTrangThai.Text.Trim();

            // Tạo một đối tượng DuAnThiCong từ dữ liệu người dùng nhập
            DuAnThiCong duAn = new DuAnThiCong
            {
                DuAnThiCongID = this.duAnThiCong.DuAnThiCongID,
                TenDuAn = tenDuAn,
                TenNhaThau = tenNhaThau,
                ChuDuAn = chuDuAn,
                NgayBatDau = ngayBatDau,
                NgayKetThuc = ngayKetThuc,
                TrangThai = trangThai,
                FileTaiLieu = this.fileData
            };


            // Gọi DAO để thêm dự án vào cơ sở dữ liệu
            bool success = DuAnThiCongDAO.Instance.CapNhatDuAn(duAn);

            if (success)
            {
                MessageBox.Show("Cập nhật dự án thành công!", "Thông báo");
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật dự án thất bại. Vui lòng kiểm tra lại dữ liệu.", "Lỗi");
            }
        }

        #endregion

        #region Events
        void BatTatChinhSua()
        {
            btnLuu.Visible = !btnLuu.Visible;
            btnCapNhat.Visible = !btnCapNhat.Visible;

            txtTenDuAn.ReadOnly = !txtTenDuAn.ReadOnly;
            txtTenNhaThau.ReadOnly = !txtTenNhaThau.ReadOnly;

            cbbChuDuAn.Enabled = !cbbChuDuAn.Enabled;
            cbbTrangThai.Enabled = !cbbTrangThai.Enabled;
            dtpNgayBatDau.Enabled = !dtpNgayBatDau.Enabled;
            dtpNgayKetThuc.Enabled = !dtpNgayKetThuc.Enabled;

            lblTaiLieu.Visible = !lblTaiLieu.Visible;
            txtFileTaiLieu.Visible = !txtFileTaiLieu.Visible;

            btnChonFile.Visible = !btnChonFile.Visible;
            lblGhiChu.Visible = !lblGhiChu.Visible;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            LuuCapNhatDuAnThiCong();
            BatTatChinhSua();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            BatTatChinhSua();
        }

        private void formChiTietDuAnThiCong_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
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

        private void btnLapKeHoach_Click(object sender, EventArgs e)
        {
            formLapKeHoach f = new formLapKeHoach(this.duAnThiCong.DuAnThiCongID);
            f.ShowDialog();

        }

        private void btnThoThiCong_Click(object sender, EventArgs e)
        {
            formThoThiCong f = new formThoThiCong(this.duAnThiCong.DuAnThiCongID);
            f.ShowDialog();
        }
        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            formQuanLyVatTuThiCong f = new formQuanLyVatTuThiCong(this.duAnThiCong.DuAnThiCongID);
            f.ShowDialog();
        }
    }
}
