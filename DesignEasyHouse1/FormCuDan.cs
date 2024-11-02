﻿using DesignEasyHouse1.Properties;
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
    public partial class FormCuDan : Form
    {
        public FormCuDan()
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
        }

        private void btnYeuCauSuaChua_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formsCuDan.formGuiYeuCauDichVuCuDan());
        }

        private void btnTheoDoiYeuCau_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formsCuDan.formYeuCauDichVuCuDan());
        }

        private void btnPhanHoiDanhGia_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formsCuDan.formPhanHoiDanhGia());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formsCuDan.moduleVeSinh.formYeuCauVeSinh());
            labelTieuDe.Text = "Yêu Cầu Vệ Sinh";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formsCuDan.moduleVeSinh.tableVeSinhDinhKy());
            labelTieuDe.Text = "Vệ Sinh Định Kỳ";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formsCuDan.moduleVeSinh.tableTheoDoiyeuCauVeSinh());
            labelTieuDe.Text = "Theo Dõi Yêu Cầu Vệ Sinh ";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formsCuDan.moduleVeSinh.formDanhGiaChatLuong());
            labelTieuDe.Text = "Đánh Giá Dịch Vụ Vệ Sinh";
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelTieuDe_Click(object sender, EventArgs e)
        {

        }
    }
}
