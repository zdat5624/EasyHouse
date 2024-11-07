using System.Data;

namespace DesignEasyHouse1.DTO
{
    public class ThoThiCong
    {
        public int ThoThiCongID { get; set; }
        public int DuAnThiCongID { get; set; }
        public string HoTen { get; set; }
        public string CCCD { get; set; }
        public string NhiemVu { get; set; }

        // Constructor không tham số
        public ThoThiCong() { }

        // Constructor nhận một DataRow để khởi tạo đối tượng
        public ThoThiCong(DataRow row)
        {
            ThoThiCongID = (int)row["ThoThiCongID"];
            DuAnThiCongID = (int)row["DuAnThiCongID"];
            HoTen = row["HoTen"].ToString();
            CCCD = row["CCCD"].ToString();
            NhiemVu = row["NhiemVu"].ToString();
        }

        // Constructor với tất cả các tham số
        public ThoThiCong(int thoThiCongID, int duAnThiCongID, string hoTen, string cccd, string nhiemVu)
        {
            ThoThiCongID = thoThiCongID;
            DuAnThiCongID = duAnThiCongID;
            HoTen = hoTen;
            CCCD = cccd;
            NhiemVu = nhiemVu;
        }
    }
}
