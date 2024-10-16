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

        private Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        void BatTatChinhSua()
        {
            btnLuu.Visible = !btnLuu.Visible;
            btnSua.Visible = !btnSua.Visible;

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
            ptbHinhAnh.Image = ByteArrayToImage(cuDan.HinhAnh);
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
        private void btnSua_Click(object sender, EventArgs e)
        {
            BatTatChinhSua();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //lbCuDanID.Text = "ID: " + cuDan.CuDanID;
            //txtHoTen.Text = cuDan.HoTen;
            //txtSoDienThoai.Text = cuDan.SoDienThoai;
            //txtCCCD.Text = cuDan.CCCD;
            //txtEmail.Text = cuDan.Email;
            //txtDiaChi.Text = cuDan.DiaChi;
            //cbGioiTinh.SelectedItem = cuDan.GioiTinh;
            //dtpNgaySinh.Value = cuDan.NgaySinh;
            //cbTrangThai.SelectedItem = cuDan.TrangThai;
            //cbThanhToan.SelectedItem = cuDan.ThanhToan;
            //dtpNgayChuyenDen.Value = cuDan.NgayChuyenDen;
            //ptbHinhAnh.Image = ByteArrayToImage(cuDan.HinhAnh);
            //CuDan cd = new CuDan(cuDan.CuDanID, txtHoTen.Text, txtSoDienThoai.Text, txtCCCD.Text, txtEmail.Text, txtDiaChi.Text, cbGioiTinh.SelectedItem, dtpNgaySinh.Value, cbTrangThai.SelectedItem, cbThanhToan.SelectedItem, dtpNgayChuyenDen.Value, ImageToByteArray(ptbHinhAnh.Image));
            BatTatChinhSua();
        }

        #endregion


    }
}
