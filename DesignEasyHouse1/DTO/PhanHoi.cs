using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DesignEasyHouse1.DTO
{
    public class PhanHoi
    {
        private int phanHoiID;
        private int yeuCauID;
        private int nguoiPhanHoiID;
        private string noiDung;
        private DateTime ngayPhanHoi;

        public int PhanHoiID { get => phanHoiID; set => phanHoiID = value; }
        public int YeuCauID { get => yeuCauID; set => yeuCauID = value; }
        public int NguoiPhanHoiID { get => nguoiPhanHoiID; set => nguoiPhanHoiID = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public DateTime NgayPhanHoi { get => ngayPhanHoi; set => ngayPhanHoi = value; }

        public PhanHoi(DataRow row)
        {
            phanHoiID = (int)row["PhanHoiID"];
            yeuCauID = (int)row["YeuCauID"];
            nguoiPhanHoiID = (int)row["NguoiPhanHoiID"];
            noiDung = row["NoiDung"].ToString();
            ngayPhanHoi = row["NgayPhanHoi"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(row["NgayPhanHoi"]);
        }
    }
}
