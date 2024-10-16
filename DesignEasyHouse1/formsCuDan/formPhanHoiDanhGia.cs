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

namespace DesignEasyHouse1.formsCuDan
{
    public partial class formPhanHoiDanhGia : Form
    {
        public formPhanHoiDanhGia()
        {
            InitializeComponent();
        }

        #region Methods
        void LoadDtgvPhanHoiDanhGia()
        {
            dtgvPhanHoiDanhGia.DataSource = PhanHoiDAO.Instance.GetDanhSachPhanHoiKhongHoanChinh();

            MyGUI.dinhDangCotAllCellsDTGV(dtgvPhanHoiDanhGia, new List<string> { "PhanHoiID", "NguoiPhanHoiID", "YeuCauID", "NoiDung", "NgayPhanHoi" });

            dtgvPhanHoiDanhGia.Columns["PhanHoiID"].HeaderText = "ID Phản Hồi";
            dtgvPhanHoiDanhGia.Columns["NguoiPhanHoiID"].HeaderText = "ID Người Phản Hồi";
            dtgvPhanHoiDanhGia.Columns["YeuCauID"].HeaderText = "Id Yêu Cầu";
            dtgvPhanHoiDanhGia.Columns["NoiDung"].HeaderText = "Nội Dung";
            dtgvPhanHoiDanhGia.Columns["NgayPhanHoi"].HeaderText = "Ngày Phản Hồi";
        }
        private void btnGuiPhanHoi_Click(object sender, EventArgs e)
        {
            formsPhongBan.formPhanHoiYeuCau f = new formsPhongBan.formPhanHoiYeuCau();
            f.ShowDialog();
        }
        private void formPhanHoiDanhGia_Load(object sender, EventArgs e)
        {
            LoadDtgvPhanHoiDanhGia();
        }
        #endregion

        
    }
}
