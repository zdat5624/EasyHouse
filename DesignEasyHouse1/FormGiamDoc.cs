using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignEasyHouse1
{
    public partial class FormGiamDoc : Form
    {
        public FormGiamDoc()
        {
            InitializeComponent();
        }

        #region Slide form
        private Form currentChildForm = null;

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #endregion

        private void button10_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formsGiamDoc.moduleVeSinh.tableDoanhThu());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formsGiamDoc.moduleVeSinh.formBaoCaoChiPhi());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formsGiamDoc.moduleVeSinh.bieuDoHoatDong());
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            btnUserName.Text = "Xin chào," + Session.TenDangNhap;
        }

        private void btnDanhSachNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formsGiamDoc.QuanLyNhanVien.DanhSachNhanVien());
        }

        private void button30_Click(object sender, EventArgs e)
        {
            // Đặt lại thông tin phiên người dùng
            Session.TenDangNhap = null;
            Session.UserId = -1;

            // Ẩn form chính
            this.Hide();

            // Tạo và hiển thị lại form đăng nhập
            FormDangNhap loginForm = new FormDangNhap();
            loginForm.FormClosed += (s, args) => Application.Exit(); // Đảm bảo form chính sẽ hiển thị lại khi form đăng nhập đóng
            loginForm.Show(); // Hiện form đăng nhập
        }
        

    }
}
