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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DesignEasyHouse1.formsCuDan
{
    public partial class formsThanhToan : Form
    {
        public formsThanhToan()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhanChuyenKhoan_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Xác nhận đã chuyển khoản ", "Xác nhận", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes) {
                //Gửi thông báo chờ xác nhận từ hệ thống cho cư dân 
                try
                {
                    int yeuCauID = Convert.ToInt32(cbYeuCauChuaThanhToan.SelectedValue);
                    YeuCauDAO.Instance.XacNhanThanhToanTuCuDan(yeuCauID);
                    MessageBox.Show("Hệ thống đã ghi nhận , chờ đến khi có xác nhận đã thanh toán thành công ");
                    this.Close();
                }
                catch {
                    MessageBox.Show("Lỗi hãy báo cho phòng hỗ trợ");
                }
                //Đóng form
            }
        }

        private void formsThanhToan_Load(object sender, EventArgs e)
        {
            DataTable dt = YeuCauDAO.Instance.LayYeuCauDaHoanThanhNhungChuaThanhToan(SessionCuDan.CuDanID);
            cbYeuCauChuaThanhToan.DataSource = dt;
            // Kiểm tra nếu có dữ liệu
            if (dt != null && dt.Rows.Count > 0)
            {
                cbYeuCauChuaThanhToan.DataSource = dt;
                cbYeuCauChuaThanhToan.DisplayMember = "YeuCauID";  // Cột hiển thị cho người dùng
                cbYeuCauChuaThanhToan.ValueMember = "YeuCauID";  // Cột giá trị lưu trữ thực tế
            }
        }
    }
}
