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

namespace DesignEasyHouse1
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }


        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string TenDangNhap = txtTenDangNhap.Text.Trim();
            string MatKhau = txtMatKhau.Text.Trim();

            int userId = UsersDAO.Instance.XacThucNguoiDung(TenDangNhap, MatKhau);
            if (userId > 0)
            {
                //lưu thông tin người dùng tạm thời trong phiên đăng nhập 
                Session.TenDangNhap = TenDangNhap;
                Session.UserId = userId;
                this.Hide();
                // Kiểm tra xem người dùng đã đăng nhập chưa
                if (Session.TenDangNhap != null)
                {
                    // Lấy quyền người dùng
                    int quyenNguoiDung = UsersDAO.Instance.PhanQuyenNguoiDung(Session.UserId);

                    // Phân quyền và mở form tương ứng
                    Form mainForm;
                    switch (quyenNguoiDung)
                    {
                        case 0:
                            mainForm = new FormGiamDoc();
                            break;
                        case 1:
                            mainForm = new FormBanQuanLy();
                            break;
                        default:
                            mainForm = new FormCuDan();
                            break;
                    }
                    mainForm.Show();
                }
            }
        }

        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
