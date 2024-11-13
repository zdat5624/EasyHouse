using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignEasyHouse1.formsCuDan.moduleGuiDo
{
    public partial class formYeuCauGuiDoLayDo : Form
    {
        public formYeuCauGuiDoLayDo()
        {
            InitializeComponent();
        }

        void LoadForm()
        {
            dtgvYeuCau.DataSource = YeuCauGuiDoLayDoDAO.Instance.LayDanhSachYeuCauCuaCuDan(SessionCuDan.CuDanID);
            MyGUI.chuyenCotDenCuoiDTGV(dtgvYeuCau, new List<string> { "Details" });
        }

        private void formYeuCauGuiDoLayDo_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        void XemChiTiet(int id)
        {
            formChiTietYeuCauLayDoGuiDo f = new formChiTietYeuCauLayDoGuiDo(id);
            f.ShowDialog();
        }

        private void btnThemCuDan_Click(object sender, EventArgs e)
        {
            formGuiYeuCauGuiDoLayDo f = new formGuiYeuCauGuiDoLayDo();
            f.ShowDialog();
            LoadForm();
        }

        private void dtgvYeuCau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu cột được click là cột "Details"
            if (e.ColumnIndex == dtgvYeuCau.Columns["Details"].Index)
            {
                int id = Convert.ToInt32(dtgvYeuCau.Rows[e.RowIndex].Cells["id"].Value);
                XemChiTiet(id);
            }

        }
    }
}
