using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignEasyHouse1.DTO
{
    public class DoanhThu
    {
        private int DoanhThuId;
        private int YeuCauID;
        private string loaiDv;
        private double SoTien;
        private DateTime thoiGian;


        public int doanhThuId { get => DoanhThuId; set => DoanhThuId = value; }
        public int yeuCauID { get => YeuCauID; set => YeuCauID = value; }
        public string LoaiDv { get => loaiDv; set => loaiDv = value; }
        public double soTien { get => SoTien; set => SoTien = value; }
        public DateTime ThoiGian { get => thoiGian; set => thoiGian = value; }

        public DoanhThu(int doanhThuId, int yeuCauID, string loaiDv, double soTien, DateTime thoiGian)
        {
            DoanhThuId = doanhThuId;
            YeuCauID = yeuCauID;
            this.loaiDv = loaiDv;
            SoTien = soTien;
            this.thoiGian = thoiGian;
        }
        public DoanhThu(DataRow row)
        {
            DoanhThuId = (int)row["DoanhThuId"];
            YeuCauID = (int)row["YeuCauID"];
            thoiGian = Convert.ToDateTime(row["thoiGian"]);
            SoTien = Convert.ToDouble(row["SoTien"]);
            loaiDv = row["loaiDv"].ToString();
            
        }
    }
}
