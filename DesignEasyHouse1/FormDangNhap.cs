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

        private void button1_Click(object sender, EventArgs e)
        {
            string TenDangNhap = txtTenDangNhap.Text.Trim();
            string MatKhau = txtMatKhau.Text.Trim();

            int userId = UsersDAO.Instance.XacThucNguoiDung(TenDangNhap, MatKhau);
            if (userId > 0)
            {
                //lưu thông tin người dùng tạm thời trong phiên đăng nhập 
                Session.TenDangNhap = TenDangNhap;
                Session.UserId = userId;
                
                // đăng nhập vào form 
                this.Close();
            }
        }
    }
}
