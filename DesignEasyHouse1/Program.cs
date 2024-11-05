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

            DangNhap();
        }
        public static void DangNhap()
        {
                Form mainForm = new FormDangNhap();
                Application.Run(mainForm);
        }
    }
}
