using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignEasyHouse1.DTO
{
    public class ChiPhi
    {
        private int ChiPhiId;
        private string TenVatTu;
        private string PhanLoai;
        private double ChiPhiDuKien;
        private double ChiPhiThucTe;
        private string Mota;
        private DateTime ThoiGian;

        public int chiPhiId { get => ChiPhiId; set => ChiPhiId = value; }
        public string tenVatTu { get => TenVatTu; set => TenVatTu = value; }
        public string phanLoai { get => PhanLoai; set => PhanLoai = value; }
        public double chiPhiDuKien { get => ChiPhiDuKien; set => ChiPhiDuKien = value; }
        public double chiPhiThucTe { get => ChiPhiThucTe; set => ChiPhiThucTe = value; }
        public string mota { get => Mota; set => Mota = value; }
        public DateTime thoiGian { get => ThoiGian; set => ThoiGian = value; }

        public ChiPhi(int chiPhiId, string tenVatTu, string phanLoai, double chiPhiDuKien, double chiPhiThucTe, string mota, DateTime thoiGian)
        {
            ChiPhiId = chiPhiId;
            TenVatTu = tenVatTu;
            PhanLoai = phanLoai;
            ChiPhiDuKien = chiPhiDuKien;
            ChiPhiThucTe = chiPhiThucTe;
            Mota = mota;
            ThoiGian = thoiGian;
        }

        public ChiPhi(DataRow row)
        {
            ChiPhiId = (int)row["ChiPhiId"];
            TenVatTu = row["TenVatTu"].ToString();
            PhanLoai = row["PhanLoai"].ToString();
            ChiPhiDuKien = Convert.ToDouble(row["ChiPhiDuKien"]);
            ChiPhiThucTe = Convert.ToDouble(row["ChiPhiThucTe"]);
            Mota = row["Mota"].ToString();
            ThoiGian = Convert.ToDateTime(row["ThoiGian"]);
        }
    }

}
