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

namespace DesignEasyHouse1.formsPhongBan.PhongDuAnThiCong
{
    public partial class formXemChiTietYeuCau : Form
    {
        YeuCauThiCong yeuCau = null;

        public formXemChiTietYeuCau(int id)
        {
            InitializeComponent();
            this.yeuCau = YeuCauThiCongDAO.Instance.LayYeuCauBangID(id);
            LoadYeuCau();
        }

        void LoadYeuCau()
        {
            if (yeuCau == null)
            {
                return;
            }

            CuDan cd = CuDanDAO.Instance.GetCuDanByCuDanID(yeuCau.CuDanID);
            if (cd != null)
            {
                txtNguoiGui.Text = $"{cd.HoTen} (ID: {cd.CuDanID})";
            }
            cbbLoaiYeuCau.Text = yeuCau.LoaiYeuCau;
            txtNoiDungYeuCau.Text = yeuCau.NoiDungYeuCau;
            txtNgayGui.Text = yeuCau.NgayGui.ToString();

            if (yeuCau.TrangThai == "Chưa phản hồi")
            {
                btnPhanHoi.Visible = true;
                cbbKetQua.Enabled = true;
                txtNoiDungPhanHoi.ReadOnly = false;
                txtNhanVien.Visible = false;
                labelNhanVien.Visible = false;
                txtNgayPhanHoi.Visible = false;
                lblNgayPhanHoi.Visible = false;
                cbbKetQua.SelectedIndex = 0;
                txtNoiDungPhanHoi.Text = "Điền nội dung phản hồi cư đân ở đây";
                return;
            }
            else
            {
                btnPhanHoi.Visible = false;
                cbbKetQua.Enabled = false;
                txtNoiDungPhanHoi.ReadOnly = true;
                txtNhanVien.Visible = true;
                labelNhanVien.Visible = true;
                txtNgayPhanHoi.Visible = true;
                lblNgayPhanHoi.Visible = true;

                txtNgayPhanHoi.Text = yeuCau.NgayPhanHoi.ToString();
                txtNoiDungPhanHoi.Text = yeuCau.NoiDungPhanHoi;
                cbbKetQua.Text = yeuCau.KetQua;

                if (yeuCau.NhanVienID != null)
                {
                    NhanVien nv = NhanVienDAO.Instance.LayNhanVienBangID((int)yeuCau.NhanVienID);
                    if (nv != null)
                    {
                        txtNhanVien.Text = $"{nv.Ten} (ID: {nv.Id})";
                    }
                }
            }
        }

        void PhanHoiYeuCau()
        {
            if (string.IsNullOrEmpty(cbbKetQua.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin kết quả");
                return;
            }

            bool result = YeuCauThiCongDAO.Instance.PhanHoiYeuCau(
                yeuCau.Id,
                SessionNhanVien.id,
                cbbKetQua.Text,
                txtNoiDungPhanHoi.Text);

            if (result)
            {
                MessageBox.Show("Phản hồi thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi phản hồi yêu cầu. Vui lòng thử lại.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnPhanHoi_Click(object sender, EventArgs e)
        {
            PhanHoiYeuCau();
        }
    }
}
