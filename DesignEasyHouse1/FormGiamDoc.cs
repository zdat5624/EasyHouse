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
    }
}
