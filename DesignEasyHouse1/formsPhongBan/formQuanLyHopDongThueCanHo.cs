using DesignEasyHouse1.DAO;
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
    public partial class formQuanLyHopDongThueCanHo : Form
    {
        public formQuanLyHopDongThueCanHo()
        {
            InitializeComponent();
            loadDtgvHopDongThue();
        }

        #region Methods
        void loadDtgvHopDongThue()
        {
            dtgvHopDongThue.DataSource = ChiTietHopDongTheCanHoDAO.Instance.GetDanhSachChiTietHopDongThueCanHo();
            MyGUI.chuyenCotDenCuoiDTGV(dtgvHopDongThue, new List<string> { "Delete", "Details" });

            dtgvHopDongThue.Columns["HopDongID"].HeaderText = "ID Hợp Đồng";
            dtgvHopDongThue.Columns["MaCanHo"].HeaderText = "Căn hộ";
            dtgvHopDongThue.Columns["NgayBatDau"].HeaderText = "Ngày bắt đầu";
            dtgvHopDongThue.Columns["NgayKetThuc"].HeaderText = "Ngày kết thúc";
            dtgvHopDongThue.Columns["TienThue"].HeaderText = "Tiền Thuê";
            dtgvHopDongThue.Columns["DieuKhoan"].HeaderText = "Điều khoản";
            dtgvHopDongThue.Columns["NgayKetThucSom"].HeaderText = "Ngày kết thúc sớm";
        }
        #endregion

        #region Events



        #endregion
    }
}
