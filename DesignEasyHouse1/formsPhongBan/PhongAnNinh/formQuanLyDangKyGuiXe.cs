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

namespace DesignEasyHouse1.formsPhongBan.PhongAnNinh
{
    public partial class formQuanLyDangKyGuiXe : Form
    {
        public formQuanLyDangKyGuiXe()
        {
            InitializeComponent();
        }
        void LoadForm()
        {
            var danhSachDichVuGuiXe = DichVuGuiXeDAO.Instance.LayThongTinDichVuGuiXe();
            dtgvThongTinPhuongTien.DataSource = danhSachDichVuGuiXe;


            // Cập nhật vị trí các cột như Delete và Details
            MyGUI.chuyenCotDenCuoiDTGV(dtgvThongTinPhuongTien, new List<string> { "Delete", "Details" });
        }
        private void formQuanLyDangKyGuiXe_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
}
