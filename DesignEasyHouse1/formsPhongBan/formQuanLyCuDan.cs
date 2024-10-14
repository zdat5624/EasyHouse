using DesignEasyHouse1.DAO;
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

namespace DesignEasyHouse1.formsPhongBan
{
    public partial class formQuanLyCuDan : Form
    {
        public formQuanLyCuDan()
        {
            InitializeComponent();
            loadForm();
        }

        void loadForm()
        {

            string query = "SELECT PhanHoiYeuCau.* FROM  YeuCau, PhanHoiYeuCau\r\nWHERE YeuCau.YeuCauID = PhanHoiYeuCau.YeuCauID";

            dtgvThongTinCuDan.DataSource = DataProvider.Instance.ExecuteQuery(query);

            
            
            dtgvThongTinCuDan.Columns["Edit"].DisplayIndex = dtgvThongTinCuDan.Columns.Count - 1;
            dtgvThongTinCuDan.Columns["Delete"].DisplayIndex = dtgvThongTinCuDan.Columns.Count - 2;
            dtgvThongTinCuDan.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Cột đầu tiên
            dtgvThongTinCuDan.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Cột thứ hai
            dtgvThongTinCuDan.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Cột thứ hai
            dtgvThongTinCuDan.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Cột thứ hai
        }
    }
}
