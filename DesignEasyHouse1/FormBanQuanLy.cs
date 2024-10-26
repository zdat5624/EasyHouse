using DesignEasyHouse1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignEasyHouse1
{
    public partial class FormBanQuanLy : Form
    {
        public FormBanQuanLy()
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
            //childForm.Dock = DockStyle.Fill;
            labelTieuDe.Text = childForm.Text;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }



        private void ptbHideMenu_Click(object sender, EventArgs e)
        {
            if (panelMenu.Visible)
            {
                panelMenu.Visible = false;
                ptbHideMenu.Image = Resources.icons8_less_than_96__1_;
            }
            else
            {
                panelMenu.Visible = true;
                ptbHideMenu.Image = Resources.iconlessthan_2;
            }
        }

        #endregion

        private void btnThongTinCuDan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formsPhongBan.formQuanLyCuDan());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
        }

        private void btnYeuCauCuDan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formsPhongBan.formQuanLyYeuCauTuCuDan());
        }

        private void btnHopDongThue_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formsPhongBan.PhongCuDan.formQuanLyHopDongThueCanHo());
        }
    }
}
