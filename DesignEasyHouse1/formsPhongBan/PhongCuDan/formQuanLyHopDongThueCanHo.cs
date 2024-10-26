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
    public partial class formQuanLyHopDongThueCanHo : Form
    {
        List<ChiTietHopDongThueCanHo> dsChiTietHopDong;

        public formQuanLyHopDongThueCanHo()
        {
            InitializeComponent();
        }


        #region Methods

        void LoadForm()
        {
            dsChiTietHopDong = ChiTietHopDongThueCanHoDAO.Instance.GetDanhSachChiTietHopDongThueCanHo();
            LoadDtgvHopDongThue(dsChiTietHopDong);
        }

        void LoadDtgvHopDongThue(List<ChiTietHopDongThueCanHo> lst)
        {
            dtgvHopDongThue.DataSource = ChiTietHopDongThueCanHoDAO.Instance.GetDtTbChiTietHopDongThueCanHo();

            MyGUI.chuyenCotDenCuoiDTGV(dtgvHopDongThue, new List<string> { "Delete", "Details" });
            MyGUI.dinhDangCotAllCellsDTGV(dtgvHopDongThue, new List<string> { "HopDongID", "NgayBatDau", "NgayKetThuc", "NgayKetThucSom" });

            dtgvHopDongThue.Columns["HopDongID"].HeaderText = "ID Hợp Đồng";
            dtgvHopDongThue.Columns["MaCanHo"].HeaderText = "Căn hộ";
            dtgvHopDongThue.Columns["NgayBatDau"].HeaderText = "Ngày bắt đầu";
            dtgvHopDongThue.Columns["NgayKetThuc"].HeaderText = "Ngày kết thúc";
            dtgvHopDongThue.Columns["TienThue"].HeaderText = "Tiền Thuê";
            dtgvHopDongThue.Columns["DieuKhoan"].HeaderText = "Điều khoản";
            dtgvHopDongThue.Columns["NgayKetThucSom"].HeaderText = "Ngày kết thúc sớm";
            dtgvHopDongThue.Columns["TrangThai"].HeaderText = "Trạng thái";

        }

        void XemChiTietThongTinHopDongThue(ChiTietHopDongThueCanHo hdt)
        {
            formXemChiTietHopDongThue f = new formXemChiTietHopDongThue(hdt);
            f.ShowDialog();
            LoadForm();
        }

        void XoaHopDongThue(int hopDongID)
        {
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa hợp đồng ID '{hopDongID}' không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (ChiTietHopDongThueCanHoDAO.Instance.XoaHopDongThue(hopDongID))
                {
                    MessageBox.Show("Xóa hợp đồng ID '" + hopDongID + "' thành công");
                }
                else
                {
                    MessageBox.Show("Xóa hợp đồng thất bại, vui lòng thử lại");
                }
            }

        }

        ChiTietHopDongThueCanHo GetCTHDTCanHoByHopDongID(int hopDongID)
        {
            foreach(var item in dsChiTietHopDong)
            {
                if (item.HopDongID == hopDongID)
                {
                    return item;
                }
            }
            return null;
        }

        #endregion

        #region Events

        private void btnThemHopDong_Click(object sender, EventArgs e)
        {
            formThemHopDongThueCanHo f = new formsPhongBan.formThemHopDongThueCanHo();
            f.ShowDialog();
            LoadForm();
        }

        private void formQuanLyHopDongThueCanHo_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void dtgvHopDongThue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý xóa, xem chi tiết
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dtgvHopDongThue.Columns["Details"].Index)
                {
                    //Xem chi tiết
                    int hopDongID = Convert.ToInt32(dtgvHopDongThue.Rows[e.RowIndex].Cells["HopDongID"].Value);
                    XemChiTietThongTinHopDongThue(GetCTHDTCanHoByHopDongID(hopDongID));
                }
                else if (e.ColumnIndex == dtgvHopDongThue.Columns["Delete"].Index)
                {
                    //Xóa
                    int hopDongID = Convert.ToInt32(dtgvHopDongThue.Rows[e.RowIndex].Cells["HopDongID"].Value);
                    XoaHopDongThue(hopDongID);
                }
            }
        }

        #endregion


    }
}
