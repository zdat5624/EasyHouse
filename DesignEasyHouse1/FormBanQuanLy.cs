using DesignEasyHouse1.DAO;
using DesignEasyHouse1.formsCuDan.moduleGuiDo;
using DesignEasyHouse1.formsPhongBan.PhongDuAnThiCong;
using DesignEasyHouse1.formsPhongBan.PhongGuiDo;
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
            childForm.Dock = DockStyle.Fill;
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

        private void FormBanQuanLy_Load(object sender, EventArgs e)
        {
            SessionNhanVien.HoTen  = NhanVienDAO.Instance.GetTenNhanVien(Session.UserId);
            SessionNhanVien.id = NhanVienDAO.Instance.GetNhanVienId(Session.UserId);
            btnTenNguoiDung.Text = "Xin chào ," + SessionNhanVien.HoTen;

            //thực hiện phân quyền giữa các phòng ban 
            SessionNhanVien.PhongBan = NhanVienDAO.Instance.GetPhongBan(Session.UserId);

            //thực hiện phân quyền dựa trên chức vụ 
            SessionNhanVien.ChucVu = NhanVienDAO.Instance.GetChucVu(Session.UserId);

            Console.WriteLine( SessionNhanVien.ChucVu + " "+ SessionNhanVien.PhongBan);

            switch (SessionNhanVien.PhongBan)
            {
                case "Vệ sinh":
                    showVeSinhModule();
                    break;
                case "Quản lý dự án thi công":
                    showDuAnThiCongModule();
                    break;
                case "Quản lý cư dân":
                    showQuanLyCuDanModule();
                    break;
                case "Quản lý gửi đồ":
                    showGuiDoModule();
                    break;
                case "Gửi xe":
                    showGuiXeModule();
                    break;
            }
            


        }

        private void showQuanLyCuDanModule()
        {
            //btnDichVuCuDan.Visible = true;
            panelQuanLyCuDan.Visible = true;
        }

        private void showVeSinhModule()
        {
            //btnDichVuVeSinh.Visible = true;
            panelQuanLyVeSinh.Visible = true;
            if (SessionNhanVien.ChucVu == "Nhân viên") { 
                btnThongBaoTuHeThong.Visible = true;
                btnCongViecVeSinhNhanVien.Visible = true;
                btnHieuSuatNhanVien.Visible= false;
                btnKeHoachVeSinh.Visible= false;
                btnYeuCauVeSinh.Visible=false;
                btnPhanHoi.Visible= false;
                btnBaoCao.Visible= false;
            }
        }
        private void showDuAnThiCongModule()
        {
            //btnDichVuVeSinh.Visible = true;
            panelDuAnThiCong.Visible = true;
        }

        private void showGuiDoModule()
        {
            panelDichVuGuiDo.Visible = true;    
        }

        private void showGuiXeModule()
        {
            panelDichVuGuiXe.Visible = true;
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

        private void btnQuanLyDuAnThiCong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formsPhongBan.PhongDuAnThiCong.formQuanLyDuAnThiCong());
            
        }

        private void btnTheoDoiDuAnThiCong_Click(object sender, EventArgs e)
        {

            OpenChildForm(new formsPhongBan.PhongDuAnThiCong.formTheoDoiDuAn());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formsPhongBan.PhongVeSinh.tableNhanYeuCau());
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCongViecVeSinhNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formsPhongBan.PhongVeSinh.formXemKeHoachVeSinh());
        }

        private void btnThongBaoTuHeThong_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new formsPhongBan.formsThongBaoPhongBan());
        }

        private void btnQuanLyDangKy_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formsPhongBan.PhongAnNinh.formQuanLyDangKyGuiXe());
        }

        private void btnThanhToanHoaDonGuiDo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formsPhongBan.PhongGuiDo.formThanhToanHoaDon());
        }

        private void btnQuanLyHoaDonGuiDo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formsPhongBan.PhongGuiDo.formQuanLyHoaDon());
        }

        private void btnQuanLyYeuCauGuiDoLayDo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formsPhongBan.PhongGuiDo.formQuanLyYeuCauLayDoGuiDo());
            
        }

        private void btnYeuCauThiCong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formsPhongBan.PhongDuAnThiCong.formQuanLyYeuCauThiCong());
        }

        //private void panelMain_Paint(object sender, PaintEventArgs e)
        //{

        //}
    }
}
