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
            MyGUI.dinhDangCotAllCellsDTGV(dtgvQuanLyHoaDon, new List<string> { "HoaDonGuiDoID" });

            dtgvQuanLyHoaDon.Columns["HoaDonGuiDoID"].HeaderText = "ID";
            dtgvQuanLyHoaDon.Columns["LoaiDo"].HeaderText = "Loại Đồ";
            dtgvQuanLyHoaDon.Columns["KichCo"].HeaderText = "Kích Cỡ";
            dtgvQuanLyHoaDon.Columns["ViTri"].HeaderText = "Vị Trí";
            dtgvQuanLyHoaDon.Columns["GhiChu"].HeaderText = "Ghi Chú";
            dtgvQuanLyHoaDon.Columns["CuDanID"].HeaderText = "Cư Dân ID";
            dtgvQuanLyHoaDon.Columns["CuDanID"].Visible = false;
            dtgvQuanLyHoaDon.Columns["NgayTao"].HeaderText = "Ngày Tạo";
            dtgvQuanLyHoaDon.Columns["NguoiTaoID"].HeaderText = "Người Tạo ID";
            dtgvQuanLyHoaDon.Columns["NguoiTaoID"].Visible = false;
            dtgvQuanLyHoaDon.Columns["NgayThanhToan"].HeaderText = "Ngày Thanh Toán";
            dtgvQuanLyHoaDon.Columns["NgayThanhToan"].Visible = false;
            dtgvQuanLyHoaDon.Columns["NgayLayDuKien"].HeaderText = "Ngày Lấy Dự Kiến";
            dtgvQuanLyHoaDon.Columns["NgayLayDuKien"].Visible = false;
            dtgvQuanLyHoaDon.Columns["TrangThai"].HeaderText = "Trạng Thái";
            
            dtgvQuanLyHoaDon.Columns["NguoiThanhToanID"].HeaderText = "Người Thanh Toán ID";
            dtgvQuanLyHoaDon.Columns["NguoiThanhToanID"].Visible = false;
            dtgvQuanLyHoaDon.Columns["LoaiThanhToan"].HeaderText = "Loại Thanh Toán";
            dtgvQuanLyHoaDon.Columns["LoaiThanhToan"].Visible = false;
            dtgvQuanLyHoaDon.Columns["SoTien"].HeaderText = "Số Tiền";
            

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
