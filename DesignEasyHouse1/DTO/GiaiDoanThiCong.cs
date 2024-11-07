using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignEasyHouse1.DTO
{
    public class GiaiDoanThiCong
    {
        public int GiaiDoanID { get; set; }
        public int DuAnThiCongID { get; set; }
        public int ThuTu { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public string TrangThai { get; set; }
        public string NoiDung { get; set; }

        // Constructor mặc định
        public GiaiDoanThiCong() { }

        public GiaiDoanThiCong(int giaiDoanID, int duAnThiCongID, int thuTu, DateTime? ngayKetThuc, string trangThai, string noiDung)
        {
            GiaiDoanID = giaiDoanID;
            DuAnThiCongID = duAnThiCongID;
            ThuTu = thuTu;
            NgayKetThuc = ngayKetThuc;
            TrangThai = trangThai;
            NoiDung = noiDung;
        }

        // Constructor với DataRow
        public GiaiDoanThiCong(DataRow row)
        {
            GiaiDoanID = (int)row["GiaiDoanID"];
            DuAnThiCongID = (int)row["DuAnThiCongID"];
            ThuTu = (int)row["ThuTu"];
            NgayKetThuc = row["NgayKetThuc"] != DBNull.Value ? (DateTime?)row["NgayKetThuc"] : null;
            TrangThai = row["TrangThai"].ToString();
            NoiDung = row["NoiDung"].ToString();
        }
    }
}

