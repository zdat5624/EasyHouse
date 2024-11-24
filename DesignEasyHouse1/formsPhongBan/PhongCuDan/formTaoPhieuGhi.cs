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
using OfficeOpenXml;
using System.IO;

namespace DesignEasyHouse1.formsPhongBan.PhongCuDan
{
    public partial class formTaoPhieuGhi : Form
    {
        public formTaoPhieuGhi()
        {
            InitializeComponent();
        }

        void TaoPhieuGhiThang()
        {
            // Lấy danh sách căn hộ
            List<CanHo> danhSachCanHo = CanHoDAO.Instance.LayDanhSachCanHo();

            // Tạo danh sách phiếu ghi
            List<object> danhSachPhieuGhi = new List<object>();

            // Các thông số từ giao diện
            float donGiaDien = (float)nudDonGiaDien.Value;
            float donGiaNuoc = (float)nudDonGiaNuoc.Value;
            float phiDichVu = (float)nudPhiDichVu.Value;

            // Duyệt qua danh sách căn hộ
            foreach (CanHo canHo in danhSachCanHo)
            {
                string maCanHo = canHo.MaCanHo;
                int chiSoDienCu = 0;
                int chiSoDienMoi = 0;
                int chiSoNuocCu = 0;
                int chiSoNuocMoi = 0;

                float tienThueCanHo = 0;
                int cuDanID = -1;

                // Kiểm tra trạng thái căn hộ
                if (canHo.TrangThai == "Đã bán")
                {
                    cuDanID = canHo.CuDanID;
                }
                else if (canHo.TrangThai == "Đang thuê")
                {
                    tienThueCanHo = ChiTietHopDongThueCanHoDAO.Instance.LayTienThueTheoCanHo(maCanHo);

                    cuDanID = ChiTietHopDongThueCanHoDAO.Instance.LayCuDanIDTheoVaiTro(maCanHo, "Người thanh toán");

    
                    if (cuDanID == 0)
                    {
                        cuDanID = ChiTietHopDongThueCanHoDAO.Instance.LayCuDanIDTheoVaiTro(maCanHo, "Người ở");
                    }
                }

                danhSachPhieuGhi.Add(new
                {
                    MaCanHo = maCanHo,
                    ChiSoDienCu = chiSoDienCu,
                    ChiSoDienMoi = chiSoDienMoi,
                    DonGiaDien = donGiaDien,
                    ChiSoNuocCu = chiSoNuocCu,
                    ChiSoNuocMoi = chiSoNuocMoi,
                    DonGiaNuoc = donGiaNuoc,
                    TienThueCanHo = tienThueCanHo,
                    PhiDichVu = phiDichVu,
                    CuDanID = cuDanID
                });
            }

            XuatDanhSachPhieuGhiRaExcel(danhSachPhieuGhi);
        }

        void XuatDanhSachPhieuGhiRaExcel(List<object> danhSachPhieuGhi)
        {
            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                using (var package = new ExcelPackage())
                {
                    // Thêm worksheet
                    var worksheet = package.Workbook.Worksheets.Add("Phiếu Ghi");

                    // Tạo tiêu đề
                    worksheet.Cells[1, 1].Value = "Mã Căn Hộ";
                    worksheet.Cells[1, 2].Value = "Chỉ Số Điện Cũ";
                    worksheet.Cells[1, 3].Value = "Chỉ Số Điện Mới";
                    worksheet.Cells[1, 4].Value = "Đơn Giá Điện";
                    worksheet.Cells[1, 5].Value = "Chỉ Số Nước Cũ";
                    worksheet.Cells[1, 6].Value = "Chỉ Số Nước Mới";
                    worksheet.Cells[1, 7].Value = "Đơn Giá Nước";
                    worksheet.Cells[1, 8].Value = "Tiền Thuê Căn Hộ";
                    worksheet.Cells[1, 9].Value = "Phí Dịch Vụ";
                    worksheet.Cells[1, 10].Value = "ID Cư Dân Trả";
                    worksheet.Cells[1, 11].Value = "Tên Người Trả";

                    using (var range = worksheet.Cells[1, 1, 1, 11])
                    {
                        range.Style.Font.Bold = true;
                        range.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        range.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                    }

                    int row = 2;
                    foreach (var phieu in danhSachPhieuGhi)
                    {
                        worksheet.Cells[row, 1].Value = phieu.GetType().GetProperty("MaCanHo").GetValue(phieu, null);
                        worksheet.Cells[row, 2].Value = phieu.GetType().GetProperty("ChiSoDienCu").GetValue(phieu, null);
                        worksheet.Cells[row, 3].Value = phieu.GetType().GetProperty("ChiSoDienMoi").GetValue(phieu, null);
                        worksheet.Cells[row, 4].Value = phieu.GetType().GetProperty("DonGiaDien").GetValue(phieu, null);
                        worksheet.Cells[row, 5].Value = phieu.GetType().GetProperty("ChiSoNuocCu").GetValue(phieu, null);
                        worksheet.Cells[row, 6].Value = phieu.GetType().GetProperty("ChiSoNuocMoi").GetValue(phieu, null);
                        worksheet.Cells[row, 7].Value = phieu.GetType().GetProperty("DonGiaNuoc").GetValue(phieu, null);
                        worksheet.Cells[row, 8].Value = phieu.GetType().GetProperty("TienThueCanHo").GetValue(phieu, null);
                        worksheet.Cells[row, 9].Value = phieu.GetType().GetProperty("PhiDichVu").GetValue(phieu, null);
                        worksheet.Cells[row, 10].Value = phieu.GetType().GetProperty("CuDanID").GetValue(phieu, null);

                        var cuDanID = phieu.GetType().GetProperty("CuDanID").GetValue(phieu, null);
                        CuDan cd = CuDanDAO.Instance.GetCuDanByCuDanID(Convert.ToInt32(cuDanID));
                        if (cd != null)
                        {
                            worksheet.Cells[row, 11].Value = cd.HoTen;
                        }
                        
                        row++;
                    }

                    worksheet.Cells.AutoFitColumns();

                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                        saveFileDialog.FileName = $"Phieu-ghi-tao-ngay-{DateTime.Now:dd-MM-yyyy_HH-mm-ss}.xlsx";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            package.SaveAs(new FileInfo(saveFileDialog.FileName));
                            MessageBox.Show("Xuất file Excel thành công!", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Bạn đã hủy thao tác lưu file.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi xuất file Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            TaoPhieuGhiThang();
        }
    }
}
