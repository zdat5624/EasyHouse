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

namespace DesignEasyHouse1.formsCuDan.moduleThiCong
{
    public partial class formChiTietYeuCauThiCong : Form
    {
        YeuCauThiCong yeuCau = null;

        public formChiTietYeuCauThiCong(int id)
        {
            InitializeComponent();
            this.yeuCau = YeuCauThiCongDAO.Instance.LayYeuCauBangID(id);
            LoadYeuCau();
        }

        void LoadYeuCau()
        {
            if (yeuCau == null)
            {
                return;
            }

            cbbLoaiYeuCau.Text = yeuCau.LoaiYeuCau;
            txtNoiDungYeuCau.Text = yeuCau.NoiDungYeuCau;
            txtNgayGui.Text = yeuCau.NgayGui.ToString();

            if (yeuCau.TrangThai == "Chưa phản hồi")
            {
                foreach (Control control in gbPhanHoi.Controls)
                {
                    control.Visible = false;
                }
                return;
            }

            txtKetQua.Text = yeuCau.KetQua;
            txtNoiDungPhanHoi.Text = yeuCau.NoiDungPhanHoi;
            txtNgayPhanHoi.Text = yeuCau.NgayPhanHoi.ToString();

            if (yeuCau.NhanVienID != null)
            {
                NhanVien nv = NhanVienDAO.Instance.LayNhanVienBangID((int)yeuCau.NhanVienID);
                if (nv != null)
                {
                    txtNhanVien.Text = $"{nv.Ten} (ID: {nv.Id})";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
