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

        public bool CapNhatTrangThaiHoanThanh(int dichVuGuiXeID)
        {
            // Cập nhật trạng thái cho dịch vụ gửi xe thành "Đã xác nhận"
            string query = "UPDATE DichVuGuiXe SET TrangThai = N'Đã xác nhận' WHERE DichVuGuiXeID = @DichVuGuiXeID";

            // Truyền dichVuGuiXeID vào danh sách tham số
            object[] parameters = new object[] { dichVuGuiXeID };

            // Thực thi câu truy vấn
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0; // Trả về true nếu cập nhật thành công
        }


        private void formQuanLyDangKyGuiXe_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
}
