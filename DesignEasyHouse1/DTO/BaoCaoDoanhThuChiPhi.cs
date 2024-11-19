using System;
using System.Data;

namespace DesignEasyHouse1.DTO
{
    public class BaoCaoDoanhThuChiPhi
    {
        public int BaoCaoID { get; set; }
        public string PhanLoai { get; set; }
        public DateTime ThangNam { get; set; }
        public double DoanhThu { get; set; }
        public double ChiPhi { get; set; }
        public DateTime NgayTao { get; set; }
        public byte[] FilePDF { get; set; }

        public BaoCaoDoanhThuChiPhi() { }

        public BaoCaoDoanhThuChiPhi(DataRow row)
        {
            BaoCaoID = (int)row["BaoCaoID"];
            PhanLoai = row["PhanLoai"].ToString();
            ThangNam = (DateTime)row["ThangNam"];
            DoanhThu = (double)row["DoanhThu"];
            ChiPhi = (double)row["ChiPhi"];
            NgayTao = (DateTime)row["NgayTao"];
            FilePDF = row["FilePDF"] != DBNull.Value ? (byte[])row["FilePDF"] : null;
        }
    }
}
