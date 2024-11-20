﻿using DesignEasyHouse1.DAO;
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
    public partial class formHoaDonCanHo : Form
    {
        public formHoaDonCanHo()
        {
            InitializeComponent();
            cbbLocHoaDon.SelectedIndexChanged += cbbLocHoaDon_SelectedIndexChanged;
            if (cbbLocHoaDon.Items.Count > 0)
            {
                cbbLocHoaDon.SelectedIndex = 0;
            }
        }

        void LoadDtgvHoaDonChuaThanhToan()
        {
            dtgvHoaDonCanHo.DataSource = HoaDonDAO.Instance.LayDTHoaDonChuaThanhToan();
            dtgvHoaDonCanHo.Columns["HoaDonID"].HeaderText = "ID";
            dtgvHoaDonCanHo.Columns["PhanLoai"].HeaderText = "Phân Loại";
            dtgvHoaDonCanHo.Columns["TongTien"].HeaderText = "Tổng Tiền";
            dtgvHoaDonCanHo.Columns["NoiDung"].HeaderText = "Nội Dung";
            dtgvHoaDonCanHo.Columns["NgayTao"].HeaderText = "Ngày Tạo";
            dtgvHoaDonCanHo.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dtgvHoaDonCanHo.Columns["CuDanID"].HeaderText = "ID Cư Dân Trả";
            dtgvHoaDonCanHo.Columns["TenCuDan"].HeaderText = "Tên Cư Dân Trả";
            MyGUI.chuyenCotDenCuoiDTGV(dtgvHoaDonCanHo, new List<string> { "Delete"});
            MyGUI.dinhDangCotAllCellsDTGV(dtgvHoaDonCanHo, new List<string> { "HoaDonID" });
        }

        void LoadDtgvTatCaHoaDon()
        {
            dtgvHoaDonCanHo.DataSource = HoaDonDAO.Instance.LayDTHoaDon();
            dtgvHoaDonCanHo.Columns["HoaDonID"].HeaderText = "ID";
            dtgvHoaDonCanHo.Columns["PhanLoai"].HeaderText = "Phân Loại";
            dtgvHoaDonCanHo.Columns["TongTien"].HeaderText = "Tổng Tiền";
            dtgvHoaDonCanHo.Columns["NoiDung"].HeaderText = "Nội Dung";
            dtgvHoaDonCanHo.Columns["NgayTao"].HeaderText = "Ngày Tạo";
            dtgvHoaDonCanHo.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dtgvHoaDonCanHo.Columns["CuDanID"].HeaderText = "ID Cư Dân Trả";
            dtgvHoaDonCanHo.Columns["TenCuDan"].HeaderText = "Tên Cư Dân Trả";
            MyGUI.chuyenCotDenCuoiDTGV(dtgvHoaDonCanHo, new List<string> { "Delete"});
            MyGUI.dinhDangCotAllCellsDTGV(dtgvHoaDonCanHo, new List<string> { "HoaDonID" });
        }

        void XoaHoaDon(int hoaDonID)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa hóa đơn này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            bool kq = HoaDonDAO.Instance.XoaHoaDon(hoaDonID);

            if (kq)
            {
                MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (cbbLocHoaDon.SelectedItem.ToString() == "Hóa đơn chưa thanh toán")
                {
                    LoadDtgvHoaDonChuaThanhToan();
                }
                else
                {
                    LoadDtgvTatCaHoaDon();
                }
            }
            else
            {
                MessageBox.Show("Xóa hóa đơn thất bại. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbbLocHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbbLocHoaDon
            //Hóa đơn chưa thanh toán
            //Tất cả hóa đơn

            string selectedItem = cbbLocHoaDon.SelectedItem?.ToString();

            if (selectedItem == "Hóa đơn chưa thanh toán")
            {
                LoadDtgvHoaDonChuaThanhToan();
            }
            else if (selectedItem == "Tất cả hóa đơn")
            {
                LoadDtgvTatCaHoaDon();
            }
        }

        private void dtgvHoaDonCanHo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý xóa, xem chi tiết
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dtgvHoaDonCanHo.Columns["Delete"].Index)
                {
                    int hoaDonID = Convert.ToInt32(dtgvHoaDonCanHo.Rows[e.RowIndex].Cells["HoaDonID"].Value);
                    XoaHoaDon(hoaDonID);
                }
            }
        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            formThemHoaDon f = new formThemHoaDon("Hóa đơn Điện-Nước-Thuê nhà-Phí dịch vụ");
            f.ShowDialog();
        }
    }
}
