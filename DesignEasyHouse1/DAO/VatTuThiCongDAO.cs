using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignEasyHouse1.DTO;
using System.Data;

namespace DesignEasyHouse1.DAO
{
    public class VatTuThiCongDAO
    {
        private static VatTuThiCongDAO instance;

        public static VatTuThiCongDAO Instance
        {
            get { if (instance == null) instance = new VatTuThiCongDAO(); return instance; }
            private set { instance = value; }
        }

        private VatTuThiCongDAO() { }

        // Thêm vật tư thi công
        public bool ThemVatTuThiCong(VatTuThiCong vatTu)
        {
            string query = "INSERT INTO VatTuThiCong (DuAnThiCongID, TenVatTu, LoaiVatTu, SoLuong, DonVi, GhiChu) " +
                           "VALUES ( @DuAnThiCongID , @TenVatTu , @LoaiVatTu , @SoLuong , @DonVi , @GhiChu )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                vatTu.DuAnThiCongID,
                vatTu.TenVatTu,
                vatTu.LoaiVatTu,
                vatTu.SoLuong,
                vatTu.DonVi,
                vatTu.GhiChu
            });

            return result > 0;
        }

        // Lấy danh sách vật tư theo dự án
        public DataTable GetVatTuByDuAnID(int duAnThiCongID)
        {
            string query = "SELECT * FROM VatTuThiCong WHERE DuAnThiCongID = @duAnThiCongID ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { duAnThiCongID });
            return data;
        }

        // Xóa vật tư thi công
        public bool XoaVatTuThiCong(int vatTuThiCongID)
        {
            string query = "DELETE FROM VatTuThiCong WHERE VatTuThiCongID = @vatTuThiCongID ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { vatTuThiCongID });

            return result > 0;
        }

        // Lấy chi tiết vật tư thi công theo ID
        public VatTuThiCong GetVatTuByID(int vatTuThiCongID)
        {
            string query = "SELECT * FROM VatTuThiCong WHERE VatTuThiCongID = @vatTuThiCongID";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { vatTuThiCongID });

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                return new VatTuThiCong(
                    Convert.ToInt32(row["VatTuThiCongID"]),
                    Convert.ToInt32(row["DuAnThiCongID"]),
                    row["TenVatTu"].ToString(),
                    row["LoaiVatTu"].ToString(),
                    Convert.ToInt32(row["SoLuong"]),
                    row["DonVi"].ToString(),
                    row["GhiChu"].ToString()
                );
            }

            return null;
        }

        // Cập nhật vật tư thi công
        public bool CapNhatVatTuThiCong(VatTuThiCong vatTu)
        {
            string query = "UPDATE VatTuThiCong SET TenVatTu = @TenVatTu , LoaiVatTu = @LoaiVatTu , SoLuong = @SoLuong , DonVi = @DonVi , GhiChu = @GhiChu " +
                           "WHERE VatTuThiCongID = @VatTuThiCongID ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                vatTu.TenVatTu,
                vatTu.LoaiVatTu,
                vatTu.SoLuong,
                vatTu.DonVi,
                vatTu.GhiChu,
                vatTu.VatTuThiCongID
            });

            return result > 0;
        }


    }
}

