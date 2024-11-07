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
    public partial class formLapKeHoach : Form
    {
        DuAnThiCong duAnThiCong = null;
        public formLapKeHoach(int duAnThiCongID)
        {
            this.duAnThiCong = DuAnThiCongDAO.Instance.GetDuAnThiCongByDuAnThiCongID(duAnThiCongID);
            InitializeComponent();
        }

        #region Methods

        void LoadForm()
        {
            dtgvGiaiDoanThiCong.DataSource = GiaiDoanThiCongDAO.Instance.GetGiaiDoanByDuAnID(this.duAnThiCong.DuAnThiCongID);
            MyGUI.chuyenCotDenCuoiDTGV(dtgvGiaiDoanThiCong, new List<string> { "Delete", "Details" });
        }

        void XemChiTietGiaiDoanThiCong(int giaiDoanThiCongID)
        {
            formCapNhatGiaiDoan f = new formCapNhatGiaiDoan(giaiDoanThiCongID);
            f.ShowDialog();
            LoadForm();
        }

        void XoaGiaiDoanThiCong(int giaiDoanThiCongID)
        {
            // Hiển thị thông báo xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa giai đoạn thi công này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Gọi DAO để xóa giai đoạn thi công
                bool success = GiaiDoanThiCongDAO.Instance.XoaGiaiDoanThiCongByID(giaiDoanThiCongID);

                if (success)
                {
                    MessageBox.Show("Xóa giai đoạn thi công thành công!", "Thông báo");
                    LoadForm(); // Tải lại dữ liệu lên DataGridView
                }
                else
                {
                    MessageBox.Show("Xóa giai đoạn thi công thất bại. Vui lòng thử lại.", "Lỗi");
                }
            }
        }


        #endregion

        #region Events

        private void btnGiaiDoan_Click(object sender, EventArgs e)
        {
            formThemGiaiDoan f = new formThemGiaiDoan(this.duAnThiCong.DuAnThiCongID);
            f.ShowDialog();
            LoadForm();
        }

        private void formLapKeHoach_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void dtgvGiaiDoanThiCong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý xóa, xem chi tiết
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dtgvGiaiDoanThiCong.Columns["Details"].Index)
                {
                    //Xem chi tiết cư dân
                    int giaiDoanThiCongID = Convert.ToInt32(dtgvGiaiDoanThiCong.Rows[e.RowIndex].Cells["GiaiDoanID"].Value);
                    XemChiTietGiaiDoanThiCong(giaiDoanThiCongID);
                    
                }
                else if (e.ColumnIndex == dtgvGiaiDoanThiCong.Columns["Delete"].Index)
                {
                    //Xóa cư dân
                    int giaiDoanThiCongID = Convert.ToInt32(dtgvGiaiDoanThiCong.Rows[e.RowIndex].Cells["GiaiDoanID"].Value);
                    XoaGiaiDoanThiCong(giaiDoanThiCongID);
                }
            }
        }

        #endregion
    }
}
