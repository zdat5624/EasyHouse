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
    public partial class formQuanLyDuAnThiCong : Form
    {
        public formQuanLyDuAnThiCong()
        {
            InitializeComponent();
        }

        void LoadForm()
        {
            var duAnList = DuAnThiCongDAO.Instance.GetAllDuAnThiCong();
            dtgvDuAnThiCong.DataSource = duAnList;
            // Cập nhật vị trí các cột như Delete và Details
            MyGUI.chuyenCotDenCuoiDTGV(dtgvDuAnThiCong, new List<string> { "Delete", "Details" });
            MyGUI.dinhDangCotAllCellsDTGV(dtgvDuAnThiCong, new List<string> { "DuAnThiCongID" });
            dtgvDuAnThiCong.Columns["DuAnThiCongID"].HeaderText = "ID";
            dtgvDuAnThiCong.Columns["TenDuAn"].HeaderText = "Tên Dự Án";
            dtgvDuAnThiCong.Columns["TenNhaThau"].HeaderText = "Tên Nhà Thầu";
            dtgvDuAnThiCong.Columns["ChuDuAn"].HeaderText = "Chủ Dự Án";
            dtgvDuAnThiCong.Columns["NgayBatDau"].HeaderText = "Ngày Bắt Đầu";
            dtgvDuAnThiCong.Columns["NgayKetThuc"].HeaderText = "Ngày Kết Thúc";
            dtgvDuAnThiCong.Columns["TrangThai"].HeaderText = "Trạng Thái";

        }

        // Hàm xóa dự án thi công
        void XoaDuAnThiCong(int duAnThiCongID)
        {
            // Xác nhận trước khi xóa
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa dự án này?", "Xóa Dự Án", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool result = DuAnThiCongDAO.Instance.XoaDuAnThiCong(duAnThiCongID);

                if (result)
                {
                    MessageBox.Show("Dự án đã được xóa thành công.");
                    LoadForm(); // Tải lại danh sách dự án
                }
                else
                {
                    MessageBox.Show("Xóa dự án không thành công.");
                }
            }
        }

        void XemChiTietDuAnThiCong(int duAnThiCongID)
        {
            formChiTietDuAnThiCong f = new formChiTietDuAnThiCong(duAnThiCongID);
            f.ShowDialog();
            LoadForm();
        }



        #region Events

        private void formQuanLyDuAnThiCong_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnThemDuAn_Click(object sender, EventArgs e)
        {
            formThemDuAnThiCong f = new formThemDuAnThiCong();
            f.ShowDialog();
            LoadForm();
        }

        private void dtgvDuAnThiCong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý xóa, xem chi tiết
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dtgvDuAnThiCong.Columns["Details"].Index)
                {
                    //Xem chi tiết cư dân
                    int duAnThiCongID = Convert.ToInt32(dtgvDuAnThiCong.Rows[e.RowIndex].Cells["DuAnThiCongID"].Value);
                    XemChiTietDuAnThiCong(duAnThiCongID);
                }
                else if (e.ColumnIndex == dtgvDuAnThiCong.Columns["Delete"].Index)
                {
                    //Xóa cư dân
                    int duAnThiCongID = Convert.ToInt32(dtgvDuAnThiCong.Rows[e.RowIndex].Cells["DuAnThiCongID"].Value);
                    XoaDuAnThiCong(duAnThiCongID);
                }
            }
        }

        #endregion

    }


}
