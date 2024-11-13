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

namespace DesignEasyHouse1.formsPhongBan.PhongGuiDo
{
    public partial class formQuanLyYeuCauLayDoGuiDo : Form
    {
        public formQuanLyYeuCauLayDoGuiDo()
        {
            InitializeComponent();
        }

        void XemChiTiet(int yeuCauID)
        {
            formXemChiTiet f = new formXemChiTiet(yeuCauID);
            f.ShowDialog();
            LoadDTGV();
        }

        void LoadDTGV()
        {
            dtgvQuanLyYeuCau.DataSource = YeuCauGuiDoLayDoDAO.Instance.LayTatCaYeuCau();
            MyGUI.chuyenCotDenCuoiDTGV(dtgvQuanLyYeuCau, new List<string> { "Details"});
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
