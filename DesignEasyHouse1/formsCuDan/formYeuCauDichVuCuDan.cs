using DesignEasyHouse1.DAO;
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

namespace DesignEasyHouse1.formsCuDan
{
    public partial class formYeuCauDichVuCuDan : Form
    {
        public formYeuCauDichVuCuDan()
        {
            InitializeComponent();
        }

        #region Methods
        void LoadDtgvThongTinYeuCau()
        {
            dtgvThongTinYeuCau.DataSource = YeuCauDAO.Instance.GetDanhSachYeuCauKhongHoanChinh();

            MyGUI.dinhDangCotAllCellsDTGV(dtgvThongTinYeuCau, new List<string> { "YeuCauID", "CuDanID", "LoaiYeuCauID", "TieuDe", "NoiDung", "TrangThai", "NgayGui" });

            dtgvThongTinYeuCau.Columns["YeuCauID"].HeaderText = "ID Yêu Cầu";
            dtgvThongTinYeuCau.Columns["CuDanID"].Visible = false;
            dtgvThongTinYeuCau.Columns["LoaiYeuCauID"].Visible = false;
            dtgvThongTinYeuCau.Columns["TieuDe"].HeaderText = "Tiêu Đề";
            dtgvThongTinYeuCau.Columns["NoiDung"].HeaderText = "Nội Dung";
            dtgvThongTinYeuCau.Columns["NoiDung"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvThongTinYeuCau.Columns["NgayGui"].HeaderText = "Ngày Gửi";
            dtgvThongTinYeuCau.Columns["TrangThai"].HeaderText = "Trạng thái";
        }
        private void btnGuiYeuCau_Click(object sender, EventArgs e)
        {
            formGuiYeuCauDichVuCuDan f = new formsCuDan.formGuiYeuCauDichVuCuDan();
            f.ShowDialog();
        }

        private void formYeuCauDichVuCuDan_Load(object sender, EventArgs e)
        {
            LoadDtgvThongTinYeuCau();
        }

        #endregion
    }
}
