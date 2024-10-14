using DesignEasyHouse1.DAO;
using DesignEasyHouse1.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DesignEasyHouse1.formsPhongBan
{
    public partial class formQuanLyCuDan : Form
    {
        public formQuanLyCuDan()
        {
            InitializeComponent();
        }

        #region Methods
        void LoadForm()
        {
            dtgvThongTinCuDan.DataSource = CuDanDAO.Instance.GetDanhSachCuDanKhongHoanChinh();

            MyGUI.chuyenCotDenCuoiDTGV(dtgvThongTinCuDan, new List<string> { "Delete", "Edit", "Details"});
            MyGUI.dinhDangCotAllCellsDTGV(dtgvThongTinCuDan, new List<string> { "CuDanID", "TrangThai", "ThanhToan" });

            dtgvThongTinCuDan.Columns["CuDanID"].HeaderText = "ID Cư Dân";
            dtgvThongTinCuDan.Columns["HoTen"].HeaderText = "Họ tên";
            dtgvThongTinCuDan.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            dtgvThongTinCuDan.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dtgvThongTinCuDan.Columns["TrangThai"].HeaderText = "Trạng thái";
            dtgvThongTinCuDan.Columns["ThanhToan"].HeaderText = "Thanh toán";
        }

        #endregion

        #region Events

        private void dtgvThongTinCuDan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có nhấp vào cột hình ảnh không
            if (e.RowIndex >= 0) // Đảm bảo không nhấp vào hàng tiêu đề
            {
                if (e.ColumnIndex == dtgvThongTinCuDan.Columns["Edit"].Index)
                {
                    // Xử lý sự kiện nhấp vào nút "Edit"
                    int cuDanID = Convert.ToInt32(dtgvThongTinCuDan.Rows[e.RowIndex].Cells["CuDanID"].Value);
                    // Gọi hàm chỉnh sửa với cuDanID
                    MessageBox.Show($"Chỉnh sửa cư dân có ID: {cuDanID}");
                }
                else if (e.ColumnIndex == dtgvThongTinCuDan.Columns["Delete"].Index)
                {
                    // Xử lý sự kiện nhấp vào nút "Delete"
                    int cuDanID = Convert.ToInt32(dtgvThongTinCuDan.Rows[e.RowIndex].Cells["CuDanID"].Value);
                    // Gọi hàm xóa với cuDanID
                    MessageBox.Show($"Xóa cư dân có ID: {cuDanID}");
                }
                else if (e.ColumnIndex == dtgvThongTinCuDan.Columns["Details"].Index)
                {
                    // Xử lý sự kiện nhấp vào nút "Delete"
                    int cuDanID = Convert.ToInt32(dtgvThongTinCuDan.Rows[e.RowIndex].Cells["CuDanID"].Value);
                    // Gọi hàm xóa với cuDanID
                    MessageBox.Show($"Xem chi tiết cư dân có ID: {cuDanID}");
                }
            }
        }

        private void formQuanLyCuDan_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        #endregion

        private void btnThemCuDan_Click(object sender, EventArgs e)
        {
            formThemCuDan f = new formsPhongBan.formThemCuDan();
            f.ShowDialog();
        }
    }
}
