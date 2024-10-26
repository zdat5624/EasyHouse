using DesignEasyHouse1.DAO;
using DesignEasyHouse1.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignEasyHouse1.formsPhongBan.PhongCuDan
{
    public partial class formXemChiTietHopDongThue : Form
    {
        private ChiTietHopDongThueCanHo ctHopDongThue;
        private DataTable dsMaCanHo;

        public formXemChiTietHopDongThue(ChiTietHopDongThueCanHo chiTietHopDongThueCanHo)
        {
            this.ctHopDongThue = chiTietHopDongThueCanHo;
            InitializeComponent();
        }

        #region Methods

        void BatTatChinhSua()
        {
            btnLuu.Visible = !btnLuu.Visible;
            btnCapNhat.Visible = !btnCapNhat.Visible;

            lbCuDanID.Visible = !lbCuDanID.Visible;
            lbVaiTro.Visible = !lbVaiTro.Visible;
            btnThemCuDan.Visible = !btnThemCuDan.Visible;
            tbCuDanID.Visible = !tbCuDanID.Visible;
            tbVaiTro.Visible = !tbVaiTro.Visible;

            cbbMaCanHo.Enabled = !cbbMaCanHo.Enabled;
            dtpNgayBatDau.Enabled = !dtpNgayBatDau.Enabled;
            dtpNgayKetThuc.Enabled = !dtpNgayKetThuc.Enabled;
            nudTienThue.Enabled = !nudTienThue.Enabled;

            txtDieuKhoan.ReadOnly = !txtDieuKhoan.ReadOnly;

        }

        void LoadCBBMaCanHO()
        {
            cbbMaCanHo.Items.Clear();
            dsMaCanHo = ChiTietHopDongThueCanHoDAO.Instance.GetDanhSachMaCanHo(ctHopDongThue.MaCanHo);
            cbbMaCanHo.DataSource = dsMaCanHo;
            cbbMaCanHo.DisplayMember = "MaCanHo";
            cbbMaCanHo.ValueMember = "MaCanHo";
        }

        void LoadForm()
        {
            LoadCBBMaCanHO();
            tbHopDongID.Text = ctHopDongThue.HopDongID.ToString();
            cbbMaCanHo.SelectedValue = ctHopDongThue.MaCanHo;
            dtpNgayBatDau.Value = ctHopDongThue.NgayBatDau;
            dtpNgayKetThuc.Value = ctHopDongThue.NgayKetThuc;
            nudTienThue.Value = Convert.ToDecimal(ctHopDongThue.TienThue);
            txtDieuKhoan.Text = ctHopDongThue.DieuKhoan;
            tbTrangThai.Text = ctHopDongThue.TrangThai;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Tên", typeof(string));
            dataTable.Columns.Add("Vai trò", typeof(string));

            foreach (var item in ctHopDongThue.DanhSachThueCanHo)
            {
                dataTable.Rows.Add(item.CuDanID, item.HoTen, item.VaiTro);
            }

            dtgvCuDanThue.DataSource = dataTable;

            MyGUI.chuyenCotDenCuoiDTGV(dtgvCuDanThue, new List<string> { "Delete" });

        }

        #endregion

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            BatTatChinhSua();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            BatTatChinhSua();
        }

        private void formXemChiTietHopDongThue_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
}
