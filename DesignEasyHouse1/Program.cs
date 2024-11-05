using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignEasyHouse1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new formsPhongBan.formQuanLyHopDongThueCanHo());
            Application.Run(new FormBanQuanLy());
            //Application.Run(new SampleChildForm1());
            Application.Run(new FormGiamDoc());
            Application.Run(new FormDangNhap());
            Application.Run(new FormCuDan());
        }
    }
}
