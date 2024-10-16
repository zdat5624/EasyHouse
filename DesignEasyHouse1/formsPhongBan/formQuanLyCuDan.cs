using DesignEasyHouse1.DAO;
using DesignEasyHouse1.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DesignEasyHouse1.formsPhongBan
{
    public partial class formQuanLyCuDan : Form
    {
        public formQuanLyCuDan()
        {
            InitializeComponent();
        }

        #region Methods
        void LoadDtgvThongTinCuDan()
        {
            dtgvThongTinCuDan.DataSource = CuDanDAO.Instance.GetDanhSachCuDanKhongHoanChinh();

            MyGUI.chuyenCotDenCuoiDTGV(dtgvThongTinCuDan, new List<string> { "Delete", "Details"});
            MyGUI.dinhDangCotAllCellsDTGV(dtgvThongTinCuDan, new List<string> { "CuDanID", "TrangThai", "ThanhToan" });

            dtgvThongTinCuDan.Columns["CuDanID"].HeaderText = "ID Cư Dân";
            dtgvThongTinCuDan.Columns["HoTen"].HeaderText = "Họ tên";
            dtgvThongTinCuDan.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            dtgvThongTinCuDan.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dtgvThongTinCuDan.Columns["TrangThai"].HeaderText = "Trạng thái";
            dtgvThongTinCuDan.Columns["ThanhToan"].HeaderText = "Thanh toán";
        }
        
        bool XoaCuDanByCuDanID(int cuDanID)
        {
            return CuDanDAO.Instance.XoaCuDanByCuDanID(cuDanID);
        }

        #endregion

        #region Events

        private void dtgvThongTinCuDan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý Xóa, sửa, xem chi tiết
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dtgvThongTinCuDan.Columns["Details"].Index)
                {
                    //Xem chi tiết cư dân
                    int cuDanID = Convert.ToInt32(dtgvThongTinCuDan.Rows[e.RowIndex].Cells["CuDanID"].Value);
                    Form f = new formsPhongBan.formXemChiTietThongTinCuDan(cuDanID);
                    f.ShowDialog();
                }
                else if (e.ColumnIndex == dtgvThongTinCuDan.Columns["Delete"].Index)
                {
                    //Xóa cư dân
                    int cuDanID = Convert.ToInt32(dtgvThongTinCuDan.Rows[e.RowIndex].Cells["CuDanID"].Value);
                    if (XoaCuDanByCuDanID(cuDanID))
                    {
                        MessageBox.Show($"Xóa thành công cư dân có ID: {cuDanID}");
                        LoadDtgvThongTinCuDan();
                    }
                    else
                    {
                        MessageBox.Show($"Xóa thất bại!");
                    }
                    
                }
            }
        }
        
        private void formQuanLyCuDan_Load(object sender, EventArgs e)
        {
            LoadDtgvThongTinCuDan();
        }
        
        private void btnThemCuDan_Click(object sender, EventArgs e)
        {
            formThemCuDan f = new formsPhongBan.formThemCuDan();
            f.ShowDialog();
            LoadDtgvThongTinCuDan();
        }

        #endregion

    }
}
