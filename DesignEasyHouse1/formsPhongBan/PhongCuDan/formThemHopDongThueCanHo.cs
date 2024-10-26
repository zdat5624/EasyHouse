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

namespace DesignEasyHouse1.formsPhongBan
{
    public partial class formThemHopDongThueCanHo : Form
    {
        private List<(int id, string ten, string vaitro)> dsThueCanHo = new List<(int id, string ten, string vaitro)>();
        private DataTable dsMaCanHo;
        public formThemHopDongThueCanHo()
        {
            InitializeComponent();
            
        }

        #region Methods

        void LoadDanhSachMaCanHo()
        {
            cbbMaCanHo.Items.Clear();
            dsMaCanHo = ChiTietHopDongThueCanHoDAO.Instance.GetDanhSachMaCanHo();
            cbbMaCanHo.DataSource = dsMaCanHo;
            cbbMaCanHo.DisplayMember = "MaCanHo";
            cbbMaCanHo.ValueMember = "MaCanHo";
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
            foreach (var item in dsThueCanHo)
            {
                if (item.id == cuDanID)
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
                dsThueCanHo.Add((cuDanID, cd.HoTen, vaiTro));
                LoadDtgvCuDanThue();
            }
        }

        void LoadDtgvCuDanThue()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Tên", typeof(string));
            dataTable.Columns.Add("Vai trò", typeof(string));
            
            foreach (var item in dsThueCanHo)
            {
                dataTable.Rows.Add(item.id, item.ten, item.vaitro);
            }

            dtgvCuDanThue.DataSource = dataTable;

            MyGUI.chuyenCotDenCuoiDTGV(dtgvCuDanThue, new List<string> { "Delete" });
        }

        void ThemHopDong()
        {
            if (cbbMaCanHo.SelectedValue==null)
            {
                MessageBox.Show("Vui lòng kiểm tra lại Mã căn hộ");
                return;
            }
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

            int hopDongID_new = ChiTietHopDongThueCanHoDAO.Instance.ThemHopDong(maCanHo, ngayBatDau, ngayKetThuc, tienThue, dieuKhoan);

            bool flag = true;

            foreach(var item in dsThueCanHo)
            {
                //int id, string hopdongid, string vaitro
                if (!ChiTietHopDongThueCanHoDAO.Instance.ThemThueCanHo(item.id, hopDongID_new, item.vaitro))
                {
                    flag = false;
                }
            }

            if (flag==false)
            {
                MessageBox.Show("Có lỗi trong quá trình thêm hợp đồng, vui lòng kiểm tra lại");
                return;
            }

            MessageBox.Show("Thêm hợp đồng thành công");
            this.Close();
        }

        #endregion

        #region Events

        private void formThemHopDongThueCanHo_Load(object sender, EventArgs e)
        {
            LoadDanhSachMaCanHo();
            LoadDtgvCuDanThue();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemCuDan_Click(object sender, EventArgs e)
        {
            ThemCuDanDTGV();
        }

        private void dtgvCuDanThue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dtgvCuDanThue.Columns["Delete"].Index)
                {
                    //Xóa cư dân
                    int cuDanID = Convert.ToInt32(dtgvCuDanThue.Rows[e.RowIndex].Cells["ID"].Value);
                    dsThueCanHo.RemoveAll(item => item.id == cuDanID);
                    LoadDtgvCuDanThue();
                }
            }
        }

        private void btnThemHopDong_Click(object sender, EventArgs e)
        {
            ThemHopDong();
        }

        #endregion
    }
}
