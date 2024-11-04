using DesignEasyHouse1.DAO;
using System;
using System.Windows.Forms;

namespace DesignEasyHouse1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Đăng nhập
            FormDangNhap loginForm = new FormDangNhap();
            loginForm.ShowDialog(); // Hiện form đăng nhập và chờ người dùng tương tác

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

                // Mở form chính
                Application.Run(mainForm);
            }
            else
            {
                // Nếu không đăng nhập, có thể thoát ứng dụng
                Application.Exit();
            }
        }
    }
}
