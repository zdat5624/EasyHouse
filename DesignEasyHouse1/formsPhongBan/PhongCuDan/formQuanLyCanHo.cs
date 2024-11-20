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

namespace DesignEasyHouse1.formsPhongBan.PhongCuDan
{
    public partial class formQuanLyCanHo : Form
    {
        public formQuanLyCanHo()
        {
            InitializeComponent();
        }

        void LoadForm()
        {
            dtgvQuanLyCanHo.DataSource = CanHoDAO.Instance.LayTatCaCanHo();
            MyGUI.chuyenCotDenCuoiDTGV(dtgvQuanLyCanHo, new List<string> { "Delete", "Details" });
            dtgvQuanLyCanHo.Columns["MaCanHo"].HeaderText = "Căn Hộ";
            dtgvQuanLyCanHo.Columns["ViTri"].HeaderText = "Vị Trí";
            dtgvQuanLyCanHo.Columns["DienTich"].HeaderText = "Diện Tích (m²)";
            dtgvQuanLyCanHo.Columns["SoPhongNgu"].HeaderText = "Số Phòng Ngủ";
            dtgvQuanLyCanHo.Columns["SoPhongTam"].HeaderText = "Số Phòng Tắm";
            dtgvQuanLyCanHo.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dtgvQuanLyCanHo.Columns["CuDanID"].HeaderText = "ID Cư Dân";
            dtgvQuanLyCanHo.Columns["CuDanID"].Visible = false;
            MyGUI.dinhDangCotAllCellsDTGV(dtgvQuanLyCanHo, new List<string> { "MaCanHo"});
        }

        private void XoaCanHo(string maCanHo)
        {
            // Xác nhận xóa
            DialogResult kq = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa căn hộ '{maCanHo}'?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (kq == DialogResult.Yes)
            {
                bool xoaThanhCong = CanHoDAO.Instance.XoaCanHo(maCanHo);

                if (xoaThanhCong)
                {
                    MessageBox.Show("Xóa căn hộ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadForm();
                }
                else
                {
                    MessageBox.Show("Xóa căn hộ thất bại. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void ChiTietCanHo(string maCanHo)
        {
            formChiTietCanHo f = new formChiTietCanHo(maCanHo);
            f.ShowDialog();
        }

        private void dtgvQuanLyCanHo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dtgvQuanLyCanHo.Columns["Details"].Index)
                {
                    string maCanHo = Convert.ToString(dtgvQuanLyCanHo.Rows[e.RowIndex].Cells["MaCanHo"].Value);
                    ChiTietCanHo(maCanHo);
                }
                else if (e.ColumnIndex == dtgvQuanLyCanHo.Columns["Delete"].Index)
                {
                    string maCanHo = Convert.ToString(dtgvQuanLyCanHo.Rows[e.RowIndex].Cells["MaCanHo"].Value);
                    XoaCanHo(maCanHo);
                }
            }
        }

        

        private void formQuanLyCanHo_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnThemCanHo_Click(object sender, EventArgs e)
        {
            formThemCanHo f = new formThemCanHo();
            f.ShowDialog();
            LoadForm();
        }
    }
}
