using DesignEasyHouse1.DAO;
using DesignEasyHouse1.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignEasyHouse1.formsPhongBan
{
    public partial class formXemChiTietThongTinCuDan : Form
    {
        private CuDan cuDan;
        public formXemChiTietThongTinCuDan(int cuDanID)
        {
            this.cuDan = CuDanDAO.Instance.GetCuDanByCuDanID(cuDanID);
            InitializeComponent();
        }

        #region Methods


        void BatTatChinhSua()
        {
            btnLuu.Visible = !btnLuu.Visible;
            btnCapNhat.Visible = !btnCapNhat.Visible;

            foreach (Control control in gbThongTinCaNhan.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.ReadOnly = !textBox.ReadOnly;
                }
                else if (control is ComboBox || control is DateTimePicker || control is Button)
                {
                    control.Enabled = !control.Enabled;
                }
            }
            cbThanhToan.Enabled = false;
        }

        void LoadThongTinCaNhanCuDan()
        {
            lbCuDanID.Text = "ID: " + cuDan.CuDanID;
            txtHoTen.Text = cuDan.HoTen;
            txtSoDienThoai.Text = cuDan.SoDienThoai;
            txtCCCD.Text = cuDan.CCCD;
            txtEmail.Text = cuDan.Email;
            txtDiaChi.Text =  cuDan.DiaChi;
            cbGioiTinh.SelectedItem = cuDan.GioiTinh;
            dtpNgaySinh.Value = cuDan.NgaySinh;
            cbTrangThai.SelectedItem = cuDan.TrangThai;
            cbThanhToan.SelectedItem = cuDan.ThanhToan;
            dtpNgayChuyenDen.Value = cuDan.NgayChuyenDen;
            ptbHinhAnh.Image = MyGUI.ByteArrayToImage(cuDan.HinhAnh);
        }

        void CapNhatThongTinCuDan()
        {
            CuDan cd = new CuDan(cuDan.CuDanID, txtHoTen.Text, txtSoDienThoai.Text, txtCCCD.Text, txtEmail.Text, txtDiaChi.Text, cbGioiTinh.SelectedItem.ToString(), dtpNgaySinh.Value, cbTrangThai.SelectedItem.ToString(), cbThanhToan.SelectedItem.ToString(), dtpNgayChuyenDen.Value, MyGUI.ImageToByteArray(ptbHinhAnh.Image));
            if (CuDanDAO.Instance.CapNhatThongTinCuDan(cd))
            {
                MessageBox.Show("Sửa thông tin cư dân thành công");
            }
            else
            {
                MessageBox.Show("Sửa thông tin cư dân thất bại!");
            }

            if (LichSuCapNhatCuDanDAO.Instance.ThemLichSuCapNhatCuDan(cd))
            {
                MessageBox.Show("Thêm lịch sử cập nhật thông tin cư dân thành công");
            }
            else
            {
                MessageBox.Show("Thêm lịch sử cập nhật thông tin cư dân thất bại!");
            }

            BatTatChinhSua();
        }

        #endregion


        #region Event

        private void formXemChiTietThongTinCuDan_Load(object sender, EventArgs e)
        {
            LoadThongTinCaNhanCuDan();
        }

        private void btnChonFileAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ptbHinhAnh.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            BatTatChinhSua();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            CapNhatThongTinCuDan();
        }


        #endregion

        private void btnLichSuCapNhat_Click(object sender, EventArgs e)
        {
            formXemLichSuCapNhatCuDan f = new formsPhongBan.formXemLichSuCapNhatCuDan(cuDan.CuDanID);
            f.ShowDialog();
        }
    }
}
