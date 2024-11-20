using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesignEasyHouse1.DAO;
using DesignEasyHouse1.DTO;

namespace DesignEasyHouse1.formsPhongBan.PhongCuDan
{
    public partial class formThemCanHo : Form
    {
        public formThemCanHo()
        {
            InitializeComponent();
        }

        void ThemCanHo()
        {
            string maCanHo = txtMaCanHo.Text.Trim();
            string viTri = txtViTri.Text.Trim();
            float dienTich = (float)nudDienTich.Value;
            int soPhongNgu = (int)nudSoPhongNgu.Value;
            int soPhongTam = (int)nudSoPhongTam.Value;

            // Kiểm tra tính hợp lệ của dữ liệu
            if (string.IsNullOrEmpty(maCanHo) || string.IsNullOrEmpty(viTri))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dienTich <= 0)
            {
                MessageBox.Show("Diện tích phải là một số thực dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (soPhongNgu < 0)
            {
                MessageBox.Show("Số phòng ngủ phải là một số nguyên không âm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (soPhongTam < 0)
            {
                MessageBox.Show("Số phòng tắm phải là một số nguyên không âm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Gọi DAO để thêm căn hộ
            bool result = CanHoDAO.Instance.ThemCanHo(new CanHo
            {
                MaCanHo = maCanHo,
                ViTri = viTri,
                DienTich = dienTich,
                SoPhongNgu = soPhongNgu,
                SoPhongTam = soPhongTam,
                TrangThai = "Trống",
                CuDanID = 0
            });

            if (result)
            {
                MessageBox.Show("Thêm căn hộ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm căn hộ thất bại. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemCanHo();
        }
    }
}
