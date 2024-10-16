using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DesignEasyHouse1.DTO
{
    public class YeuCau
    {
        private int yeuCauID;
        private int cuDanID;
        private int loaiYeuCauID;
        private string tieuDe;
        private string noiDung;
        private DateTime ngayGui;
        private string trangThai;

        public int YeuCauID { get => yeuCauID; set => yeuCauID = value; }
        public int CuDanID { get => cuDanID; set => cuDanID = value; }
        public int LoaiYeuCauID { get => loaiYeuCauID; set => loaiYeuCauID = value; }
        public string TieuDe { get => tieuDe; set => tieuDe = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public DateTime NgayGui { get => ngayGui; set => ngayGui = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }

        public YeuCau(DataRow row)
        {
            yeuCauID = (int)row["YeuCauID"];
            cuDanID = (int)row["CuDanID"];
            loaiYeuCauID = (int)row["LoaiYeuCauID"];
            tieuDe = row["TieuDe"].ToString();
            noiDung = row["NoiDung"].ToString();
            ngayGui = row["NgayGui"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(row["NgayGui"]);
            trangThai = row["TrangThai"].ToString();
        }
    }
}
