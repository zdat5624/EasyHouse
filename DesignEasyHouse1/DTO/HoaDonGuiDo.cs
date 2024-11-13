using System;
using System.Data;

namespace DesignEasyHouse1.DTO
{
    public class HoaDonGuiDo
    {
        public int HoaDonGuiDoID { get; set; }
        public string LoaiDo { get; set; }
        public string KichCo { get; set; }
        public string ViTri { get; set; }
        public string GhiChu { get; set; }
        public int CuDanID { get; set; }
        public DateTime NgayTao { get; set; }
        public int NguoiTaoID { get; set; }
        public DateTime? NgayThanhToan { get; set; }
        public DateTime? NgayLayDuKien { get; set; }
        public string TrangThai { get; set; }
        public int? NguoiThanhToanID { get; set; }
        public string LoaiThanhToan { get; set; }
        public double? SoTien { get; set; }

        // Constructor mặc định
        public HoaDonGuiDo() { }

        // Constructor từ DataRow
        public HoaDonGuiDo(DataRow row)
        {
            HoaDonGuiDoID = Convert.ToInt32(row["HoaDonGuiDoID"]);
            LoaiDo = row["LoaiDo"].ToString();
            KichCo = row["KichCo"].ToString();
            ViTri = row["ViTri"].ToString();
            GhiChu = row["GhiChu"].ToString();
            CuDanID = Convert.ToInt32(row["CuDanID"]);
            NgayTao = Convert.ToDateTime(row["NgayTao"]);
            NguoiTaoID = Convert.ToInt32(row["NguoiTaoID"]);
            NgayThanhToan = row["NgayThanhToan"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["NgayThanhToan"]);
            NgayLayDuKien = row["NgayLayDuKien"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["NgayLayDuKien"]);
            TrangThai = row["TrangThai"].ToString();
            NguoiThanhToanID = row["NguoiThanhToanID"] == DBNull.Value ? (int?)null : Convert.ToInt32(row["NguoiThanhToanID"]);
            LoaiThanhToan = row["LoaiThanhToan"].ToString();
            SoTien = row["SoTien"] == DBNull.Value ? (double?)null : Convert.ToDouble(row["SoTien"]);
        }
    }
}
