using DesignEasyHouse1.DAO;
using DesignEasyHouse1.DTO;
using DesignEasyHouse1.formsPhongBan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignEasyHouse1.formsCuDan.moduleThanhToan
{
    public partial class formHoaDonCuDan : Form
    {
        public formHoaDonCuDan()
        {
            InitializeComponent();
            LoadForm();
            dtgvHoaDon.CellContentClick += dtgvHoaDon_CellContentClick;
        }



        void LoadForm()
        {
            dtgvHoaDon.DataSource = HoaDonDAO.Instance.LayDTHoaDonTheoCuDanID(SessionCuDan.CuDanID);
            dtgvHoaDon.Columns["HoaDonID"].HeaderText = "ID";
            dtgvHoaDon.Columns["PhanLoai"].HeaderText = "Phân Loại";
            dtgvHoaDon.Columns["TongTien"].HeaderText = "Tổng Tiền";
            dtgvHoaDon.Columns["NoiDung"].HeaderText = "Nội Dung";
            dtgvHoaDon.Columns["NgayTao"].HeaderText = "Ngày Tạo";
            dtgvHoaDon.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dtgvHoaDon.Columns["CuDanID"].Visible = false;
            MyGUI.chuyenCotDenCuoiDTGV(dtgvHoaDon, new List<string> {"Details" });
            MyGUI.dinhDangCotAllCellsDTGV(dtgvHoaDon, new List<string> { "HoaDonID" });
        }

        void XemChiTIet(int hoaDonID)
        {
            formChiTietHoaDon f = new formChiTietHoaDon(hoaDonID, SessionCuDan.CuDanID);
            f.ShowDialog();
            LoadForm();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Form f = new formsCuDan.formsThanhToan();
            f.ShowDialog();
            LoadForm();
        }

        private void dtgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý xóa, xem chi tiết
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dtgvHoaDon.Columns["Details"].Index)
                {
                    int hoaDonID = Convert.ToInt32(dtgvHoaDon.Rows[e.RowIndex].Cells["HoaDonID"].Value);
                    XemChiTIet(hoaDonID);
                }
            }
        }
    }
}
