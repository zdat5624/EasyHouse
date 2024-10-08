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
            //Application.Run(new FormDangNhap());
            //Application.Run(new FormGiamDoc());
            //Application.Run(new FormPhongBan());
            //Application.Run(new FormCuDan());
            //SampleChildForm frm = new SampleChildForm();
            //Application.Run(frm);
            //Application.Run(new formsPhongBan.formQuanLyCuDan());
            //Application.Run(new formsPhongBan.formThemCuDan());
            //Application.Run(new FormDangNhap());
            Application.Run(new SampleChildForm2());
            //Application.Run(new formsPhongBan.formThemCuDan());

        }
    }
}
