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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DesignEasyHouse1.formsPhongBan
{
    public partial class formThemCuDan : Form
    {
        public formThemCuDan()
        {
            InitializeComponent();
        }

        #region Methods
        void ThemCuDan()
        {

            string HoTen = txtHoTen.Text;
            string SoDienThoai = txtSoDienThoai.Text;
            string CCCD = txtCCCD.Text;
            string Email = txtEmail.Text;
            string DiaChi = txtDiaChi.Text;
            string GioiTinh = cbGioiTinh.SelectedItem.ToString();
            DateTime NgaySinh = dtpNgaySinh.Value;
            byte[] HinhAnh = ImageToByteArray(ptbHinhAnh.Image);

            bool result = CuDanDAO.Instance.ThemCuDan(HoTen, SoDienThoai, CCCD, Email, DiaChi, GioiTinh, NgaySinh, HinhAnh);
            if (result)
            {
                MessageBox.Show("Thêm cư dân thành công!");
                //this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng kiểm tra lại.");
            }
        }
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        #endregion


        #region Events
        private void btnChonFileAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ptbHinhAnh.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnThemCuDan_Click(object sender, EventArgs e)
        {
            ThemCuDan();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
