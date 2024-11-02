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

            string loaiVeSinh = cbLoaiVeSinh.Text.Trim();
            string khuVucVeSinh = cbKhuVucVeSinh.Text.Trim();
            string khuVucTuyChon = txtKhuVucCuThe.Text.Trim();
            DateTime thoiGianVeSinh = dtpThoiGianVeSinh.Value;

            // loại id yêu cầu vệ sinh là 1 
            int loaiYeuCauId = 1;

            //ví dụ cư dân có id là 1 
            int cuDanId = 1;
            DichVuVeSinhDAO.Instance.ThemYeuCau(cuDanId, loaiVeSinh, loaiYeuCauId, khuVucVeSinh, khuVucTuyChon, thoiGianVeSinh);



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
