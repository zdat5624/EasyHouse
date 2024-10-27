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

        void KetThucHopDong()
        {
            DateTime ngayKetThuc_new = DateTime.Now;
            if (ChiTietHopDongThueCanHoDAO.Instance.CapNhatNgayKetThuc(ctHopDongThue.HopDongID, ngayKetThuc_new))
            {
                MessageBox.Show("Kết thúc hợp đồng thành công, đã cập nhật ngày kết thúc và trạng thái hợp đồng là 'Kết thúc'");
                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra vui lòng kiểm tra lại");
            }
        }

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
            dtgvCuDanThue.Enabled = !dtgvCuDanThue.Enabled;

            txtDieuKhoan.ReadOnly = !txtDieuKhoan.ReadOnly;

            if ((ctHopDongThue.TrangThai).Equals("Kết thúc"))
            {
                btnKetThucHopDong.Visible = false;
            } else
            {
                btnKetThucHopDong.Visible = !btnLuu.Visible;
            }

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

            LoadDtgvCuDanThue();

            if ((ctHopDongThue.TrangThai).Equals("Kết thúc"))
            {
                btnKetThucHopDong.Visible = false;
            }
        }
       
        void LoadDtgvCuDanThue()
        {
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


        void ThemCuDanDTGV()
        {
            int cuDanID;

            if (string.IsNullOrWhiteSpace(tbCuDanID.Text))
            {
                MessageBox.Show("Vui lòng nhập ID cư dân.");
                return;
            }
            else if (int.TryParse(tbCuDanID.Text, out cuDanID))
            {
            }
            else
            {
                MessageBox.Show("ID cư dân không hợp lệ. Vui lòng kiểm tra lại.");
                return;
            }

            string vaiTro = tbVaiTro.Text;
            CuDan cd = CuDanDAO.Instance.GetCuDanByCuDanID(cuDanID);
            if (cd == null)
            {
                MessageBox.Show("Cư dân không tồn tại hoặc nhập sai, vui lòng nhập lại");
                return;
            }
            bool flag = false;
            foreach (var item in ctHopDongThue.DanhSachThueCanHo)
            {
                if (item.CuDanID == cuDanID)
                {
                    flag = true;
                    break;
                }
            }

            if (flag)
            {
                MessageBox.Show("Cư dân đã thêm, vui lòng chọn cư dân khác");
            }
            else
            {
                ctHopDongThue.AddThueCanHo(new ThueCanHo(cuDanID, cd.HoTen, vaiTro));
                LoadDtgvCuDanThue();
            }
        }

        void CapNhatHopDong()
        {
            string maCanHo = cbbMaCanHo.SelectedValue.ToString();
            DateTime ngayBatDau = dtpNgayBatDau.Value;
            DateTime ngayKetThuc = dtpNgayKetThuc.Value;
            double tienThue = Convert.ToDouble(nudTienThue.Value);
            string dieuKhoan = txtDieuKhoan.Text;
            if (ngayBatDau > ngayKetThuc)
            {
                MessageBox.Show("Vui lòng kiểm tra lại ngày bắt đầu và ngày kết thúc hợp đồng");
                return;
            }

            if (ChiTietHopDongThueCanHoDAO.Instance.CapNhatHopDongThue(ctHopDongThue.HopDongID, maCanHo, ngayBatDau, ngayKetThuc, tienThue, dieuKhoan))
            {
                MessageBox.Show("Cập nhật hợp đồng thuê thành công");
            } else
            {
                MessageBox.Show("Cập nhật hợp đồng thuê thất bại! vui lòng thử lại");
                return;
            }

            bool flag = true;
            if (!ChiTietHopDongThueCanHoDAO.Instance.XoaThueCanHoByHopDongID(ctHopDongThue.HopDongID))
            {
                flag = false;
            }

            foreach (var item in ctHopDongThue.DanhSachThueCanHo)
            {
                //int id, string hopdongid, string vaitro
                if (!ChiTietHopDongThueCanHoDAO.Instance.ThemThueCanHo(item.CuDanID, ctHopDongThue.HopDongID, item.VaiTro))
                {
                    flag = false;
                }
            }

            if (flag == false)
            {
                MessageBox.Show("Có lỗi trong quá trình thêm thông tin cư dân vào hợp đồng, vui lòng kiểm tra lại");
                return;
            }

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
            CapNhatHopDong();
        }

        private void formXemChiTietHopDongThue_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnKetThucHopDong_Click(object sender, EventArgs e)
        {
            KetThucHopDong();
        }

        private void dtgvCuDanThue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dtgvCuDanThue.Columns["Delete"].Index)
                {
                    //Xóa cư dân
                    int cuDanID = Convert.ToInt32(dtgvCuDanThue.Rows[e.RowIndex].Cells["ID"].Value);
                    ctHopDongThue.DanhSachThueCanHo.RemoveAll(item => item.CuDanID == cuDanID);
                    LoadDtgvCuDanThue();
                }
            }
        }

        private void btnThemCuDan_Click(object sender, EventArgs e)
        {
            ThemCuDanDTGV();
        }
    }
}
