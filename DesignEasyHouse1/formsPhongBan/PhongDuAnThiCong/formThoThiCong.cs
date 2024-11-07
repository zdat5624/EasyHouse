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

namespace DesignEasyHouse1.formsPhongBan.PhongDuAnThiCong
{
    public partial class formThoThiCong : Form
    {
        int duAnThiCongID = -1;
        public formThoThiCong(int duAnThiCongID)
        {
            InitializeComponent();

            this.duAnThiCongID=duAnThiCongID;
        }

        void LoadForm()
        {
            dtgvDanhSachThoThiCong.DataSource = ThoThiCongDAO.Instance.GetThoThiCongByDuAnID(duAnThiCongID);
            MyGUI.chuyenCotDenCuoiDTGV(dtgvDanhSachThoThiCong, new List<string> { "Delete", "Details" });
        }

        void XemChiTietThoThiCong(int thoThiCongID)
        {
            formCapNhatThoThiCong f = new formCapNhatThoThiCong(thoThiCongID);
            f.ShowDialog();
            LoadForm();
        }

        void XoaThoThiCong(int thoThiCongID)
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thợ thi công này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Gọi phương thức xóa từ ThoThiCongDAO
                bool success = ThoThiCongDAO.Instance.XoaThoThiCong(thoThiCongID);
                if (success)
                {
                    MessageBox.Show("Xóa thợ thi công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadForm(); // Tải lại danh sách sau khi xóa
                }
                else
                {
                    MessageBox.Show("Xóa thợ thi công thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void formThoThiCong_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnThemDuAn_Click(object sender, EventArgs e)
        {
            formThemThoThiCong f = new formThemThoThiCong(this.duAnThiCongID);
            f.ShowDialog();
            LoadForm();
        }

        private void dtgvDanhSachThoThiCong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý xóa, xem chi tiết
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dtgvDanhSachThoThiCong.Columns["Details"].Index)
                {
                    //Xem chi tiết cư dân
                    int thoThiCongID = Convert.ToInt32(dtgvDanhSachThoThiCong.Rows[e.RowIndex].Cells["ThoThiCongID"].Value);
                    XemChiTietThoThiCong(thoThiCongID);
                }
                else if (e.ColumnIndex == dtgvDanhSachThoThiCong.Columns["Delete"].Index)
                {
                    //Xóa cư dân
                    int thoThiCongID = Convert.ToInt32(dtgvDanhSachThoThiCong.Rows[e.RowIndex].Cells["ThoThiCongID"].Value);
                    XoaThoThiCong(thoThiCongID);
                }
            }
        }
    }
}
