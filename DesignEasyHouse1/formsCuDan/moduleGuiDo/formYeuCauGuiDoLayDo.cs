﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesignEasyHouse1.formsCuDan.moduleGuiDo;


namespace DesignEasyHouse1.formsCuDan.moduleGuiDo
{
    public partial class formYeuCauGuiDoLayDo : Form
    {
        public formYeuCauGuiDoLayDo()
        {
            InitializeComponent();
        }

        void LoadForm()
        {
            dtgvYeuCau.DataSource = YeuCauGuiDoLayDoDAO.Instance.LayDanhSachYeuCauCuaCuDan(SessionCuDan.CuDanID);
            MyGUI.chuyenCotDenCuoiDTGV(dtgvYeuCau, new List<string> { "Details" });
            MyGUI.dinhDangCotAllCellsDTGV(dtgvYeuCau, new List<string> { "id" });
            // Giả sử dgvYeuCauGuiDoLayDo là tên của DataGridView
            dtgvYeuCau.Columns["id"].HeaderText = "ID";

            dtgvYeuCau.Columns["CuDanID"].HeaderText = "Cư Dân ID";
            dtgvYeuCau.Columns["CuDanID"].Visible = false;
            dtgvYeuCau.Columns["LoaiYeuCau"].HeaderText = "Loại Yêu Cầu";
            dtgvYeuCau.Columns["NoiDungYeuCau"].HeaderText = "Nội Dung Yêu Cầu";
            dtgvYeuCau.Columns["NoiDungYeuCau"].Visible = false;
            dtgvYeuCau.Columns["NhanVienID"].HeaderText = "Nhân Viên ID";
            dtgvYeuCau.Columns["NhanVienID"].Visible = false;
            dtgvYeuCau.Columns["KetQua"].HeaderText = "Kết Quả";
            dtgvYeuCau.Columns["KetQua"].Visible = false;
            dtgvYeuCau.Columns["NoiDungPhanHoi"].HeaderText = "Nội Dung Phản Hồi";
            dtgvYeuCau.Columns["NoiDungPhanHoi"].Visible = false;
            dtgvYeuCau.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dtgvYeuCau.Columns["NgayGui"].HeaderText = "Ngày Gửi";
            dtgvYeuCau.Columns["NgayPhanHoi"].HeaderText = "Ngày Phản Hồi";
            dtgvYeuCau.Columns["NgayPhanHoi"].Visible = false;
        }

        private void formYeuCauGuiDoLayDo_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        void XemChiTiet(int id)
        {
            formChiTietYeuCauLayDoGuiDo f = new formChiTietYeuCauLayDoGuiDo(id);
            f.ShowDialog();
        }

        private void btnThemCuDan_Click(object sender, EventArgs e)
        {
            formGuiYeuCauGuiDoLayDo f = new formGuiYeuCauGuiDoLayDo();
            f.ShowDialog();
            LoadForm();
        }

        private void dtgvYeuCau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu cột được click là cột "Details"
            if (e.ColumnIndex == dtgvYeuCau.Columns["Details"].Index)
            {
                int id = Convert.ToInt32(dtgvYeuCau.Rows[e.RowIndex].Cells["id"].Value);
                XemChiTiet(id);
            }

        }
    }
}
