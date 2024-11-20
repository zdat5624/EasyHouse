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

namespace DesignEasyHouse1.formsPhongBan.PhongCuDan
{
    public partial class formChiTietCanHo : Form
    {
        private CanHo canHo = null;

        public formChiTietCanHo(string maCanHo)
        {
            InitializeComponent();
            this.canHo = CanHoDAO.Instance.LayCanHoTheoMa(maCanHo);
        }

        void LoadForm()
        {
            if (canHo == null)
            {
                MessageBox.Show("Không tìm thấy thông tin căn hộ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // Hiển thị thông tin lên các control
            txtMaCanHo.Text = canHo.MaCanHo;
            txtViTri.Text = canHo.ViTri;
            nudDienTich.Value = (decimal)canHo.DienTich;
            nudSoPhongNgu.Value = canHo.SoPhongNgu;
            nudSoPhongTam.Value = canHo.SoPhongTam;
            cbbTrangThai.Text = canHo.TrangThai;
            txtCuDanID.Text = canHo.CuDanID.ToString();
        }

        void CapNhatCanHo()
        {
            // Lấy dữ liệu từ các điều khiển trên form
            string maCanHo = txtMaCanHo.Text.Trim();
            string viTri = txtViTri.Text.Trim();
            float dienTich = (float)nudDienTich.Value;
            int soPhongNgu = (int)nudSoPhongNgu.Value;
            int soPhongTam = (int)nudSoPhongTam.Value;
            string trangThai = cbbTrangThai.SelectedItem?.ToString();
            int cuDanID;

            // Kiểm tra dữ liệu nhập
            if (string.IsNullOrEmpty(maCanHo) || string.IsNullOrEmpty(viTri))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (trangThai == "Trống" || trangThai == "Đang thuê")
            {
                cuDanID = 0;
            } 
            else if (!int.TryParse(txtCuDanID.Text, out cuDanID) || cuDanID < 0)
            {
                MessageBox.Show("ID cư dân phải là một số nguyên không âm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (trangThai == "Đã bán")
            {
                bool cuDanTT = CuDanDAO.Instance.KiemTraCuDanTonTai(cuDanID);
                if (!cuDanTT)
                {
                    MessageBox.Show($"Không tìm thấy cư dân với ID: {cuDanID}. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (canHo.TrangThai == "Đang thuê")
            {
                // Cảnh báo người dùng kiểm tra hợp đồng thuê
                DialogResult kq = MessageBox.Show(
                    "Căn hộ đang được thuê. Vui lòng kiểm tra hợp đồng thuê trước khi tiếp tục cập nhật. Bạn có muốn tiếp tục không?",
                    "Cảnh báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (kq == DialogResult.No)
                {
                    return;
                }
            }

            bool result = CanHoDAO.Instance.CapNhatCanHo(new CanHo
            {
                MaCanHo = maCanHo,
                ViTri = viTri,
                DienTich = dienTich,
                SoPhongNgu = soPhongNgu,
                SoPhongTam = soPhongTam,
                TrangThai = trangThai,
                CuDanID = cuDanID
            });

            if (result)
            {
                MessageBox.Show("Cập nhật căn hộ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật căn hộ thất bại. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            CapNhatCanHo();
        }

        private void formChiTietCanHo_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void txtTenCuDan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCuDanID_TextChanged(object sender, EventArgs e)
        {
            if (txtCuDanID.Text == "")
            {
                return;
            }

            if (Convert.ToInt32(txtCuDanID.Text)==0)
            {
                return;
            }
            CuDan cd = CuDanDAO.Instance.GetCuDanByCuDanID(canHo.CuDanID);
            if (cd!= null)
            {
                txtTenCuDan.Text = cd.HoTen;
            }
        }

        private void txtCuDanID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cbbTrangThai.SelectedItem.ToString();

            if (trangThai == "Trống" || trangThai == "Đang thuê")
            {
                txtCuDanID.Visible = false;
                txtTenCuDan.Visible = false;
                lblCuDanID.Visible = false;
                lblTenCuDan.Visible = false;

                txtCuDanID.Text = string.Empty;
                txtTenCuDan.Text = string.Empty;
            }
            else
            {
                txtCuDanID.Visible = true;
                txtTenCuDan.Visible = true;
                lblCuDanID.Visible = true;
                lblTenCuDan.Visible = true;
                txtCuDanID.Text = canHo.CuDanID.ToString();
                CuDan cd = CuDanDAO.Instance.GetCuDanByCuDanID(canHo.CuDanID);
                if (cd != null)
                {
                    txtTenCuDan.Text = cd.HoTen;
                }

            }
        }

    }
}
