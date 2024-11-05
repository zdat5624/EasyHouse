using DesignEasyHouse1.DAO;
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

namespace DesignEasyHouse1.formsCuDan.moduleVeSinh
{
    public partial class formYeuCauVeSinh : Form
    {
        public formYeuCauVeSinh()
        {
            InitializeComponent();
        }

        private void btnGuiYeuCau_Click(object sender, EventArgs e)
        {

            string LoaiVeSinh = cbLoaiVeSinh.Text.Trim();
            string KhuVucVeSinh = cbKhuVucVeSinh.Text.Trim();
            string KhuVucCuThe = txtKhuVucCuThe.Text.Trim();
            DateTime ThoiGianVeSinh = dtpThoiGianVeSinh.Value;
            string KieuVeSinh;
            //Khi Đăng nhập ta sẽ lấy đc cuDanid 
            int CuDanID = SessionCuDan.CuDanID;
            if (radVeSinhThuong.Checked)
            {
                KieuVeSinh = "Thường";
            }
            else if(radVeSinhDinhKyTuan.Checked)
            {
                KieuVeSinh = "Định kỳ theo tuần";
            }
            else
            {
               KieuVeSinh = "Định kỳ theo tháng";
            }

            if(DichVuVeSinhDAO.Instance.ThemYeuCau(KhuVucVeSinh, LoaiVeSinh,KieuVeSinh, KhuVucCuThe, ThoiGianVeSinh, CuDanID))
            {
                MessageBox.Show("Thêm yêu cầu vệ sinh vào " + ThoiGianVeSinh + " thành công");

                // xóa dữ liệu 
                cbLoaiVeSinh.Text = "";
                cbKhuVucVeSinh.Text = "";
                txtKhuVucCuThe.Text = "";
                dtpThoiGianVeSinh.Value = DateTime.Now;
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
