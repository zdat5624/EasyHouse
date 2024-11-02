using DesignEasyHouse1.DAO;
using System;
using System.Data;

namespace DesignEasyHouse1.DTO
{
    public class YeuCauDichVuVeSinh
    {
        // Các thuộc tính tương ứng với các cột trong yêu cầu
        public int MaYeuCau { get; set; }
        public string TrangThai { get; set; }
        public string KhuVucVeSinh { get; set; }
        public DateTime ThoiGianVeSinh { get; set; }

        // Constructor không tham số
        public YeuCauDichVuVeSinh() { }

        // Constructor với tham số
        public YeuCauDichVuVeSinh(int maYeuCau, string trangThai, string khuVucVeSinh, DateTime thoiGianVeSinh)
        {
            MaYeuCau = maYeuCau;
            TrangThai = trangThai;
            KhuVucVeSinh = khuVucVeSinh;
            ThoiGianVeSinh = thoiGianVeSinh;
        }

        // Constructor từ DataRow
        public YeuCauDichVuVeSinh(DataRow row)
        {
            MaYeuCau = (int)row["YeuCauID"];
            TrangThai = row["TrangThai"].ToString();
            KhuVucVeSinh = row["KhuVucVeSinh"].ToString();
            ThoiGianVeSinh = Convert.ToDateTime(row["ThoiGianVeSinh"]);
        }

        // Phương thức ToString cho lớp này
        public override string ToString()
        {
            return $"MaYeuCau: {MaYeuCau}, TrangThai: {TrangThai}, KhuVucVeSinh: {KhuVucVeSinh}, ThoiGianVeSinh: {ThoiGianVeSinh}";
        }
    }
}
