using System;
using System.Data;

namespace DesignEasyHouse1.DTO
{
    public class DuAnThiCong
    {
        public int DuAnThiCongID { get; set; }
        public string TenDuAn { get; set; }
        public string TenNhaThau { get; set; }
        public string ChuDuAn { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public string TrangThai { get; set; }
        public byte[] FileTaiLieu { get; set; }

        public DuAnThiCong(){}

        // Constructor nhận DataRow để khởi tạo đối tượng từ dữ liệu
        public DuAnThiCong(DataRow row)
        {
            DuAnThiCongID = (int)row["DuAnThiCongID"];
            TenDuAn = row["TenDuAn"].ToString();
            TenNhaThau = row["TenNhaThau"].ToString();
            ChuDuAn = row["ChuDuAn"].ToString();
            NgayBatDau = row["NgayBatDau"] != DBNull.Value ? (DateTime?)row["NgayBatDau"] : null;
            NgayKetThuc = row["NgayKetThuc"] != DBNull.Value ? (DateTime?)row["NgayKetThuc"] : null;
            TrangThai = row["TrangThai"].ToString();
            FileTaiLieu = row["FileTaiLieu"] != DBNull.Value ? (byte[])row["FileTaiLieu"] : null;
        }
    }

}

