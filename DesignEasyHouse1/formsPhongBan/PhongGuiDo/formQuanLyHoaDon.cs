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

namespace DesignEasyHouse1.formsPhongBan.PhongGuiDo
{
    public partial class formQuanLyHoaDon : Form
    {
        public formQuanLyHoaDon()
        {
            InitializeComponent();
        }

        void LoadDTGV()
        {
            dtgvQuanLyHoaDon.DataSource = HoaDonGuiDoDAO.Instance.LayDanhSachHoaDon();
            MyGUI.chuyenCotDenCuoiDTGV(dtgvQuanLyHoaDon, new List<string> {"Delete" ,"Details" });
        }

        private void formQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            LoadDTGV();
        }

        void XoaHoaDon(int hoaDonGuiDoID)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                bool kq = HoaDonGuiDoDAO.Instance.XoaHoaDonBangID(hoaDonGuiDoID);
                if (kq)
                {
                    MessageBox.Show("Xóa hóa đơn thành công.");
                    LoadDTGV(); // Refresh lại DataGridView sau khi xóa
                }
                else
                {
                    MessageBox.Show("Xóa hóa đơn thất bại. Vui lòng thử lại.");
                }
            }
        }

        void XemChiTietHoaDon(int hoaDonGuiDoID)
        {
            formChiTietHoaDon f = new formChiTietHoaDon(hoaDonGuiDoID);
            f.ShowDialog();
            //LoadDTGV();
        }

        private void dtgvQuanLyHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu cột được click là cột "Details"
            if (e.ColumnIndex == dtgvQuanLyHoaDon.Columns["Delete"].Index)
            {
                int hoaDonGuiDoID = Convert.ToInt32(dtgvQuanLyHoaDon.Rows[e.RowIndex].Cells["HoaDonGuiDoID"].Value);
                XoaHoaDon(hoaDonGuiDoID);
            }
            else if (e.ColumnIndex == dtgvQuanLyHoaDon.Columns["Details"].Index)
            {
                int hoaDonGuiDoID = Convert.ToInt32(dtgvQuanLyHoaDon.Rows[e.RowIndex].Cells["HoaDonGuiDoID"].Value);
                XemChiTietHoaDon(hoaDonGuiDoID);
            }
        }
    }
}
