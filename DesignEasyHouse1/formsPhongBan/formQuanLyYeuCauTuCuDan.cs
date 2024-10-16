using DesignEasyHouse1.DAO;
using DesignEasyHouse1.DTO;
using DesignEasyHouse1.formsCuDan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignEasyHouse1.formsPhongBan
{
    public partial class formQuanLyYeuCauTuCuDan : Form
    {
        public formQuanLyYeuCauTuCuDan()
        {
            InitializeComponent();
        }

        #region Methods
        void LoadDtgvThongTinYeuCau()
        {
            dtgvYeuCauCuDan.DataSource = YeuCauDAO.Instance.GetDanhSachYeuCauKhongHoanChinh();

            MyGUI.chuyenCotDenCuoiDTGV(dtgvYeuCauCuDan, new List<string> { "Edit", "Details" });
            MyGUI.dinhDangCotAllCellsDTGV(dtgvYeuCauCuDan, new List<string> { "YeuCauID", "CuDanID", "LoaiYeuCauID", "TieuDe", "NoiDung", "TrangThai", "NgayGui" });

            dtgvYeuCauCuDan.Columns["YeuCauID"].HeaderText = "ID Yêu Cầu";
            dtgvYeuCauCuDan.Columns["CuDanID"].HeaderText = "ID Cư Dân";
            dtgvYeuCauCuDan.Columns["LoaiYeuCauID"].HeaderText = "Id Loại Yêu Cầu";
            dtgvYeuCauCuDan.Columns["TieuDe"].HeaderText = "Tiêu Đề";
            dtgvYeuCauCuDan.Columns["NoiDung"].HeaderText = "Nội Dung";
            dtgvYeuCauCuDan.Columns["NgayGui"].HeaderText = "Ngày Gửi";
            dtgvYeuCauCuDan.Columns["TrangThai"].HeaderText = "Trạng thái";
        }

        bool CapNhatTrangThaiHoanThanh(int yeuCauID)
        {
            return YeuCauDAO.Instance.CapNhatTrangThaiHoanThanh(yeuCauID);
        }

        bool CapNhatTrangThaiDangXuLy(int yeuCauID)
        {
            return YeuCauDAO.Instance.CapNhatTrangThaiDangXuLy(yeuCauID);
        }

        #endregion

        #region Event
        private void btnThemPhanHoi_Click(object sender, EventArgs e)
        {
            formPhanHoiYeuCau f = new formPhanHoiYeuCau();
            f.ShowDialog();
        }

        private void formQuanLyYeuCauTuCuDan_Load(object sender, EventArgs e)
        {
            LoadDtgvThongTinYeuCau();
        }
        

        private void dtgvYeuCauCuDan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                if (e.ColumnIndex == dtgvYeuCauCuDan.Columns["Edit"].Index)
                {
                    //Sửa cư dân
                    int yeuCauID = Convert.ToInt32(dtgvYeuCauCuDan.Rows[e.RowIndex].Cells["YeuCauID"].Value);
                    if (Convert.ToString(dtgvYeuCauCuDan.Rows[e.RowIndex].Cells["TrangThai"].Value) == "Đang chờ xử lý")
                    {
                        if (CapNhatTrangThaiHoanThanh(yeuCauID))
                        {
                            MessageBox.Show($"Cập nhật trạng thái thánh công yêu cầu có ID: {yeuCauID}");
                            LoadDtgvThongTinYeuCau();
                        }
                        else
                        {
                            MessageBox.Show($"Cập nhật thất bại!");
                        }
                    }
                    else if (Convert.ToString(dtgvYeuCauCuDan.Rows[e.RowIndex].Cells["TrangThai"].Value) == "Hoàn thành")
                    {
                        if (CapNhatTrangThaiDangXuLy(yeuCauID))
                        {
                            MessageBox.Show($"Cập nhật trạng thái thành công yêu cầu có ID: {yeuCauID}");
                            LoadDtgvThongTinYeuCau();
                        }
                        else
                        {
                            MessageBox.Show($"Cập nhật thất bại!");
                        }
                    }

                }
                else if (e.ColumnIndex == dtgvYeuCauCuDan.Columns["Details"].Index)
                {
                    //Xem chi tiết yêu cầu
                    int yeuCauID = Convert.ToInt32(dtgvYeuCauCuDan.Rows[e.RowIndex].Cells["YeuCauID"].Value);
                    MessageBox.Show($"Xem chi tiết yêu cầu có ID: {yeuCauID}");
                }
            }
        }

        #endregion
    }
}
