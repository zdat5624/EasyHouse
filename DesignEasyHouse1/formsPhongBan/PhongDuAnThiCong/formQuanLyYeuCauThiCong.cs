using DesignEasyHouse1.formsPhongBan.PhongGuiDo;
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
    public partial class formQuanLyYeuCauThiCong : Form
    {
        public formQuanLyYeuCauThiCong()
        {
            InitializeComponent();
        }


        void XemChiTiet(int yeuCauID)
        {
            formXemChiTietYeuCau f = new formXemChiTietYeuCau(yeuCauID);
            f.ShowDialog();
            LoadDTGV();
        }

        void LoadDTGV()
        {
            dtgvQuanLyYeuCau.DataSource = YeuCauThiCongDAO.Instance.LayTatCaYeuCau();
            MyGUI.chuyenCotDenCuoiDTGV(dtgvQuanLyYeuCau, new List<string> { "Details" });
            MyGUI.dinhDangCotAllCellsDTGV(dtgvQuanLyYeuCau, new List<string> { "id" });
            dtgvQuanLyYeuCau.Columns["id"].HeaderText = "ID";
            dtgvQuanLyYeuCau.Columns["CuDanID"].HeaderText = "Cư Dân ID";
            dtgvQuanLyYeuCau.Columns["CuDanID"].Visible = false;
            dtgvQuanLyYeuCau.Columns["LoaiYeuCau"].HeaderText = "Loại Yêu Cầu";
            dtgvQuanLyYeuCau.Columns["NoiDungYeuCau"].HeaderText = "Nội Dung Yêu Cầu";
            dtgvQuanLyYeuCau.Columns["NoiDungYeuCau"].Visible = false;
            dtgvQuanLyYeuCau.Columns["NhanVienID"].HeaderText = "Nhân Viên ID";
            dtgvQuanLyYeuCau.Columns["NhanVienID"].Visible = false;
            dtgvQuanLyYeuCau.Columns["KetQua"].HeaderText = "Kết Quả";
            dtgvQuanLyYeuCau.Columns["KetQua"].Visible = false;
            dtgvQuanLyYeuCau.Columns["NoiDungPhanHoi"].HeaderText = "Nội Dung Phản Hồi";
            dtgvQuanLyYeuCau.Columns["NoiDungPhanHoi"].Visible = false;
            dtgvQuanLyYeuCau.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dtgvQuanLyYeuCau.Columns["NgayGui"].HeaderText = "Ngày Gửi";
            dtgvQuanLyYeuCau.Columns["NgayPhanHoi"].HeaderText = "Ngày Phản Hồi";
            dtgvQuanLyYeuCau.Columns["NgayPhanHoi"].Visible = false;

        }

        private void dtgvThongTinCuDan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu cột được click là cột "Details"
            if (e.ColumnIndex == dtgvQuanLyYeuCau.Columns["Details"].Index)
            {
                int yeuCauID = Convert.ToInt32(dtgvQuanLyYeuCau.Rows[e.RowIndex].Cells["id"].Value);
                XemChiTiet(yeuCauID);
            }

        }

        private void formQuanLyYeuCauLayDoGuiDo_Load(object sender, EventArgs e)
        {
            LoadDTGV();
        }
    }
}
