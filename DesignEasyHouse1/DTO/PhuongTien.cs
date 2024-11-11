using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DesignEasyHouse1.DTO
{
    public class PhuongTien
    {
        private int phuongTienID;
        private string bienSoXe;
        private int cuDanID;
        private string loaiXe;
        private DateTime? thoiGianGui;
        private byte[] cavetXe;
        private byte[] cccd_cmnd;

        public int PhuongTienID { get => phuongTienID; set => phuongTienID = value; }
        public string BienSoXe { get => bienSoXe; set => bienSoXe = value; }
        public int CuDanID { get => cuDanID; set => cuDanID = value; }
        public string LoaiXe { get => loaiXe; set => loaiXe = value; }
        public DateTime? ThoiGianGui { get => thoiGianGui; set => thoiGianGui = value; }
        public byte[] CavetXe { get => cavetXe; set => cavetXe = value; }
        public byte[] CCCD_CMND { get => cccd_cmnd; set => cccd_cmnd = value; }

        public PhuongTien() { }
        public PhuongTien(int phuongTienID, string bienSoXe, int cuDanID, string loaiXe, DateTime? thoiGianGui,
                          byte[] cavetXe, byte[] cccd_cmnd)
        {
            this.phuongTienID = phuongTienID;
            this.bienSoXe = bienSoXe;
            this.cuDanID = cuDanID;
            this.loaiXe = loaiXe;
            this.thoiGianGui = thoiGianGui;
            this.cavetXe = cavetXe;
            this.cccd_cmnd = cccd_cmnd;
        }

        public PhuongTien(DataRow row)
        {
            phuongTienID = (int)row["PhuongTienID"];
            bienSoXe = row["BienSoXe"].ToString();
            cuDanID = (int)row["CuDanID"];
            loaiXe = row["LoaiXe"].ToString();
            thoiGianGui = Convert.ToDateTime(row["ThoiGianGui"]);
            cavetXe = row["CavetXe"] == DBNull.Value ? null : (byte[])row["CavetXe"];
            cccd_cmnd = row["CCCD_CMND"] == DBNull.Value ? null : (byte[])row["CCCD_CMND"];
        }
    }
}
