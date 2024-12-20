﻿using DesignEasyHouse1.DAO;
using DesignEasyHouse1.Properties;
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
            labelTieuDe.Text = childForm.Text;
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formsCuDan.formThongBaoCuaCuDan());
        }

        private void btnYeuCauSuaChua_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formsCuDan.moduleThiCong.formYeuCauThiCong());
        }

        //private void btnTheoDoiYeuCau_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new formsCuDan.formYeuCauDichVuCuDan());
        //}

        //private void btnPhanHoiDanhGia_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new formsCuDan.formPhanHoiDanhGia());
        //}

        //private void button10_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new formsCuDan.moduleVeSinh.formYeuCauVeSinh());
        //    //labelTieuDe.Text = "Yêu Cầu Vệ Sinh";
        //}


        //private void button9_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new formsCuDan.moduleVeSinh.tableTheoDoiyeuCauVeSinh());
        //    //labelTieuDe.Text = "Theo Dõi Yêu Cầu Vệ Sinh ";
        //}







        private void FormCuDan_Load(object sender, EventArgs e)
        {
            SessionCuDan.CuDanID = CuDanDAO.Instance.GetCuDanID(Session.UserId);

            //Lấy tên của cư dân 
            SessionCuDan.TenCuDan = CuDanDAO.Instance.GetTenCuDan(Session.UserId);

            //Hiển thị tên người dùng 
            btnChaoUser.Text = SessionCuDan.TenCuDan;

            OpenChildForm(new formsCuDan.formThongBaoCuaCuDan());
        }

        private void button30_Click(object sender, EventArgs e)
        {
            // Đặt lại thông tin phiên người dùng
            Session.TenDangNhap = null;
            Session.UserId = -1;

            // Ẩn form chính
            this.Close();

            // Tạo và hiển thị lại form đăng nhập
            FormDangNhap loginForm = new FormDangNhap();
            //loginForm.FormClosed += (s, args) => Application.Exit(); // Đảm bảo form chính sẽ hiển thị lại khi form đăng nhập đóng
            loginForm.Show(); // Hiện form đăng nhập
        }

        private void btnThongBaoTuHeThong_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new formsCuDan.moduleVeSinh.);
        }

        private void btnThongBaoCuDan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formsCuDan.formThongBaoCuaCuDan());
        }


        private void btnYeuCauGuiDoLayDo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formsCuDan.moduleGuiDo.formYeuCauGuiDoLayDo());
            
        }

        private void btnYeuCauVeSinh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formsCuDan.moduleVeSinh.tableTheoDoiyeuCauVeSinh());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formsCuDan.moduleThanhToan.formHoaDonCuDan());
        }
    }
}
