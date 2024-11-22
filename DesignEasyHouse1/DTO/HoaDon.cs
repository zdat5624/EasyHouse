using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignEasyHouse1.DTO
{
    public class HoaDon
    {
        public int HoaDonID { get; set; }
        public string PhanLoai { get; set; }
        public float TongTien { get; set; }
        public string NoiDung { get; set; }
        public DateTime NgayTao { get; set; }
        public string TrangThai { get; set; }
        public int CuDanID { get; set; }

        public HoaDon () { }

        public HoaDon(int hoaDonID, string phanLoai, float tongTien, string noiDung, DateTime ngayTao, string trangThai, int cuDanID)
        {
            HoaDonID = hoaDonID;
            PhanLoai = phanLoai;
            TongTien = tongTien;
            NoiDung = noiDung;
            NgayTao = ngayTao;
            TrangThai = trangThai;
            CuDanID = cuDanID;
        }

        public HoaDon(DataRow row)
        {
            HoaDonID = Convert.ToInt32(row["HoaDonID"]);
            PhanLoai = row["PhanLoai"].ToString();
            TongTien = Convert.ToSingle(row["TongTien"]);
            NoiDung = row["NoiDung"].ToString();
            NgayTao = Convert.ToDateTime(row["NgayTao"]);
            TrangThai = row["TrangThai"].ToString();
            CuDanID = Convert.ToInt32(row["CuDanID"]);
        }

    }
}

