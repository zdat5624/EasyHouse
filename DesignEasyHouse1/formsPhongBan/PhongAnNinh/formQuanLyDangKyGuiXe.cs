using DesignEasyHouse1.DAO;
using DesignEasyHouse1.DTO;
using DesignEasyHouse1.formsPhongBan.PhongDuAnThiCong;
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

        private void dtgvThongTinPhuongTien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dtgvThongTinPhuongTien.Columns["XacNhan"].Index)
                {
                    //Cập nhật trạng thái dịch vụ
                    int dichVuGuiXeID = Convert.ToInt32(dtgvThongTinPhuongTien.Rows[e.RowIndex].Cells["DichVuGuiXeID"].Value);
                    if (Convert.ToString(dtgvThongTinPhuongTien.Rows[e.RowIndex].Cells["TrangThai"].Value) == "Đang chờ xác nhận")
                    {
                        if (DichVuGuiXeDAO.Instance.CapNhatTrangThaiHoanThanh(dichVuGuiXeID))
                        {
                            MessageBox.Show($"Cập nhật trạng thái thánh công dịch vụ gửi xe có ID: {dichVuGuiXeID}");
                            LoadForm();
                        }
                        else
                        {
                            MessageBox.Show($"Cập nhật thất bại!");
                        }
                    }
                    else if (Convert.ToString(dtgvThongTinPhuongTien.Rows[e.RowIndex].Cells["TrangThai"].Value) == "Hoàn thành")
                    {
                        if (DichVuGuiXeDAO.Instance.CapNhatTrangThaiHoanThanh(dichVuGuiXeID))
                        {
                            MessageBox.Show($"Cập nhật trạng thái thành công dịch vụ gửi xe có ID: {dichVuGuiXeID}");
                            LoadForm();
                        }
                        else
                        {
                            MessageBox.Show($"Cập nhật thất bại!");
                        }
                    }

                }
                else if (e.ColumnIndex == dtgvThongTinPhuongTien.Columns["HuyBo"].Index)
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn hủy thủ tục đăng ký này?", "Hủy đăng ký", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // Lấy thông tin từ hàng được chọn
                        int dichVuGuiXeID = Convert.ToInt32(dtgvThongTinPhuongTien.Rows[e.RowIndex].Cells["DichVuGuiXeID"].Value);
                        int cuDanID = Convert.ToInt32(dtgvThongTinPhuongTien.Rows[e.RowIndex].Cells["CuDanID"].Value);

                        // Mở form với dữ liệu đã lấy
                        formThongBaoDangKyLai f = new formThongBaoDangKyLai(dichVuGuiXeID, cuDanID);
                        f.ShowDialog();
                        LoadForm();
                    }
                    
                }
            }
        }
    }
}
