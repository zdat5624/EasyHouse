using DesignEasyHouse1.DAO;
using DesignEasyHouse1.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignEasyHouse1.formsPhongBan
{
    public partial class formXemLichSuCapNhatCuDan : Form
    {
        private int cuDanID;
        List<LichSuCapNhatCuDan> dsLichSuCapNhatCuDan;
        public formXemLichSuCapNhatCuDan(int CuDanID)
        {
            this.cuDanID = CuDanID;
            this.dsLichSuCapNhatCuDan = LichSuCapNhatCuDanDAO.Instance.GetDanhSachLichSuCapNhatCuDan(cuDanID);
            InitializeComponent();
        }

        #region Methods

        private void XuLyCellClick(DataGridView dataGridView, DataGridViewCellEventArgs e, string columnName)
        {
            // Kiểm tra nếu hàng được click là hợp lệ
            if (e.RowIndex >= 0)
            {
                // Kiểm tra nếu cột được click là cột cụ thể (ví dụ: "NgayLuu")
                if (e.ColumnIndex == dataGridView.Columns[columnName].Index)
                {
                    // Lấy giá trị của cột "CapNhatID" tại dòng được click
                    int capNhatID = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["CapNhatID"].Value);

                    // Duyệt qua danh sách dsLichSuCapNhatCuDan và tìm đối tượng khớp với CapNhatID
                    foreach (LichSuCapNhatCuDan ls in dsLichSuCapNhatCuDan)
                    {
                        if (ls.CapNhatID == capNhatID)
                        {
                            // Gọi hàm LoadLichSuCapNhat để xử lý
                            LoadLichSuCapNhat(ls);
                            break; // Thoát vòng lặp sau khi tìm được đối tượng
                        }
                    }
                }
            }
        }


        void LoadForm()
        {
            dtgvLichSuCapNhatCuDan.Columns.Add("CapNhatID", "ID Cập Nhật");
            dtgvLichSuCapNhatCuDan.Columns.Add("NgayLuu", "Ngày Lưu");

            dtgvLichSuCapNhatCuDan.Rows.Clear();
            foreach (var lichSu in dsLichSuCapNhatCuDan)
            {
                dtgvLichSuCapNhatCuDan.Rows.Add(lichSu.CapNhatID, lichSu.NgayLuu);
            }

            MyGUI.dinhDangCotAllCellsDTGV(dtgvLichSuCapNhatCuDan, new List<string> { "CapNhatID" });
            dtgvLichSuCapNhatCuDan.Columns["CapNhatID"].Visible = false;
            dtgvLichSuCapNhatCuDan.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvLichSuCapNhatCuDan.Columns["NgayLuu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgvLichSuCapNhatCuDan.Sort(dtgvLichSuCapNhatCuDan.Columns["NgayLuu"], System.ComponentModel.ListSortDirection.Descending);
        }


        void LoadLichSuCapNhat(LichSuCapNhatCuDan ls)
        {
            lbCuDanID.Text = "ID: " + ls.CuDanID;
            txtHoTen.Text = ls.HoTen;
            txtSoDienThoai.Text = ls.SoDienThoai;
            txtCCCD.Text = ls.CCCD;
            txtEmail.Text = ls.Email;
            txtDiaChi.Text = ls.DiaChi;
            cbGioiTinh.SelectedItem = ls.GioiTinh;
            dtpNgaySinh.Value = ls.NgaySinh;
            cbTrangThai.SelectedItem = ls.TrangThai;
            cbThanhToan.SelectedItem = ls.ThanhToan;
            dtpNgayChuyenDen.Value = ls.NgayChuyenDen;
            ptbHinhAnh.Image = MyGUI.ByteArrayToImage(ls.HinhAnh);
        }


        #endregion


        #region Event

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void formXemLichSuCapNhatCuDan_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void dtgvLichSuCapNhatCuDan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            XuLyCellClick(dtgvLichSuCapNhatCuDan, e, "NgayLuu");
        }

        #endregion


    }
}
