using DesignEasyHouse1.DAO;
using DesignEasyHouse1.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignEasyHouse1.formsPhongBan.PhongGuiDo
{
    public partial class formXemChiTiet : Form
    {
        YeuCauGuiDoLayDo yeuCau = null;
        public formXemChiTiet(int id)
        {
            InitializeComponent();
            this.yeuCau = YeuCauGuiDoLayDoDAO.Instance.LayYeuCauBangID(id);
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
                lblNgayPhanHoi.Visible = false ;
                cbbKetQua.SelectedIndex = 0;
                return;
            } else
            {
                btnPhanHoi.Visible = false;
                cbbKetQua.Enabled = false;
                txtNoiDungPhanHoi.ReadOnly = true;
                txtNhanVien.Visible = true;
                labelNhanVien.Visible = true;
                txtNgayPhanHoi.Visible = true;
                lblNgayPhanHoi.Visible = true;

                cbbKetQua.Text = !string.IsNullOrEmpty(yeuCau.KetQua) ? yeuCau.KetQua : "";
                txtNoiDungPhanHoi.Text = !string.IsNullOrEmpty(yeuCau.NoiDungPhanHoi) ? yeuCau.NoiDungPhanHoi : "";
                txtNgayPhanHoi.Text = yeuCau.NgayPhanHoi.ToString();
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
            // Kiểm tra nếu thông tin phản hồi hợp lệ
            if (string.IsNullOrEmpty(cbbKetQua.Text) || string.IsNullOrEmpty(txtNoiDungPhanHoi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin kết quả và nội dung phản hồi.");
                return;
            }

            bool result = YeuCauGuiDoLayDoDAO.Instance.PhanHoiYeuCau(
                yeuCau.Id,  // ID của yêu cầu
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

        private void formXemChiTiet_Load(object sender, EventArgs e)
        {
            LoadYeuCau();
        }

        private void btnPhanHoi_Click(object sender, EventArgs e)
        {
            PhanHoiYeuCau();
        }
    }
}
