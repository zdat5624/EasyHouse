using DesignEasyHouse1.DAO;
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
    public partial class formQuanLyVatTuThiCong : Form
    {
        int vatTuThiCongID = -1;

        public formQuanLyVatTuThiCong(int vatTuThiCongID)
        {
            InitializeComponent();
            this.vatTuThiCongID = vatTuThiCongID;
        }

        void LoadForm()
        {
            dtgvDanhSachVatTuThiCong.DataSource = VatTuThiCongDAO.Instance.GetVatTuByDuAnID(this.vatTuThiCongID);
            MyGUI.chuyenCotDenCuoiDTGV(dtgvDanhSachVatTuThiCong, new List<string> { "Delete", "Details" });
        }

        // Hàm xóa vật tư thi công
        void XoaVatTuThiCong(int vatTuThiCongID)
        {
            // Xác nhận trước khi xóa
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa vật tư này?", "Xóa Vật Tư", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool result = VatTuThiCongDAO.Instance.XoaVatTuThiCong(vatTuThiCongID);

                if (result)
                {
                    MessageBox.Show("Vật tư đã được xóa thành công.");
                    LoadForm(); // Tải lại danh sách vật tư
                }
                else
                {
                    MessageBox.Show("Xóa vật tư không thành công.");
                }
            }
        }

        // Hàm xem chi tiết vật tư thi công
        void XemChiTietVatTuThiCong(int vatTuThiCongID)
        {
            formChiTietVatTuThiCong f = new formChiTietVatTuThiCong(vatTuThiCongID);
            f.ShowDialog();
            LoadForm(); // Tải lại danh sách sau khi xem chi tiết
        }

        private void formQuanLyVatTuThiCong_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnVatTu_Click(object sender, EventArgs e)
        {
            formThemVatTuThiCong f = new formThemVatTuThiCong(this.vatTuThiCongID);
            f.ShowDialog();
            LoadForm();
        }

        private void dtgvDanhSachVatTuThiCong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý xóa, xem chi tiết
            if (e.RowIndex >= 0)
            {
                // Kiểm tra nếu cột được click là cột "Details"
                if (e.ColumnIndex == dtgvDanhSachVatTuThiCong.Columns["Details"].Index)
                {
                    int vatTuThiCongID = Convert.ToInt32(dtgvDanhSachVatTuThiCong.Rows[e.RowIndex].Cells["VatTuThiCongID"].Value);
                    XemChiTietVatTuThiCong(vatTuThiCongID);
                }
                // Kiểm tra nếu cột được click là cột "Delete"
                else if (e.ColumnIndex == dtgvDanhSachVatTuThiCong.Columns["Delete"].Index)
                {
                    int vatTuThiCongID = Convert.ToInt32(dtgvDanhSachVatTuThiCong.Rows[e.RowIndex].Cells["VatTuThiCongID"].Value);
                    XoaVatTuThiCong(vatTuThiCongID);
                }
            }
        }
    }
}
