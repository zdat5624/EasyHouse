using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignEasyHouse1.DTO
{
    public class VatTuThiCong
    {
        public int VatTuThiCongID { get; set; }
        public int DuAnThiCongID { get; set; }
        public string TenVatTu { get; set; }
        public string LoaiVatTu { get; set; }
        public int SoLuong { get; set; }
        public string DonVi { get; set; }
        public string GhiChu { get; set; }

        // Constructor mặc định
        public VatTuThiCong() { }

        // Constructor với tất cả các tham số
        public VatTuThiCong(int vatTuThiCongID, int duAnThiCongID, string tenVatTu, string loaiVatTu, int soLuong, string donVi, string ghiChu)
        {
            VatTuThiCongID = vatTuThiCongID;
            DuAnThiCongID = duAnThiCongID;
            TenVatTu = tenVatTu;
            LoaiVatTu = loaiVatTu;
            SoLuong = soLuong;
            DonVi = donVi;
            GhiChu = ghiChu;
        }

        // Constructor từ DataRow (dùng khi tạo từ DataTable)
        public VatTuThiCong(DataRow row)
        {
            VatTuThiCongID = Convert.ToInt32(row["VatTuThiCongID"]);
            DuAnThiCongID = Convert.ToInt32(row["DuAnThiCongID"]);
            TenVatTu = row["TenVatTu"].ToString();
            LoaiVatTu = row["LoaiVatTu"].ToString();
            SoLuong = Convert.ToInt32(row["SoLuong"]);
            DonVi = row["DonVi"].ToString();
            GhiChu = row["GhiChu"].ToString();
        }
    }
}

