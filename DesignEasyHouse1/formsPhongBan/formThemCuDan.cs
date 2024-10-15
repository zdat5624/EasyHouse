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
            CuDan cuDan = new CuDan(
                txtHoTen.Text,
                txtSoDienThoai.Text,
                txtCCCD.Text,
                txtEmail.Text,
                txtDiaChi.Text,
                cbGioiTinh.SelectedItem.ToString(),
                dtpNgaySinh.Value,
                ImageToByteArray(ptbHinhAnh.Image));

            bool result = CuDanDAO.Instance.ThemCuDan(cuDan);
            if (result)
            {
                MessageBox.Show("Thêm cư dân thành công!");
                //this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại.");
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
