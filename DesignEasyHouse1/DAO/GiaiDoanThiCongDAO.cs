using System;
using System.Collections.Generic;
using System.Data;
using DesignEasyHouse1.DTO;

namespace DesignEasyHouse1.DAO
{
    public class GiaiDoanThiCongDAO
    {
        private static GiaiDoanThiCongDAO instance;

        public static GiaiDoanThiCongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new GiaiDoanThiCongDAO();
                return instance;
            }
            private set => instance = value;
        }

        private GiaiDoanThiCongDAO() { }

        // Phương thức lấy danh sách giai đoạn theo DuAnThiCongID
        public List<GiaiDoanThiCong> GetGiaiDoanByDuAnID(int duAnThiCongID)
        {
            List<GiaiDoanThiCong> list = new List<GiaiDoanThiCong>();
            string query = "SELECT * FROM GiaiDoanThiCong WHERE DuAnThiCongID = @duAnThiCongID ORDER BY ThuTu ASC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { duAnThiCongID });

            foreach (DataRow row in data.Rows)
            {
                GiaiDoanThiCong giaiDoan = new GiaiDoanThiCong(row);
                list.Add(giaiDoan);
            }

            return list;
        }

        // Phương thức thêm mới một giai đoạn thi công
        public bool ThemGiaiDoanThiCong(int duAnThiCongID, DateTime? ngayKetThuc, string trangThai, string noiDung)
        {
            // Tạo tham số đầu vào cho thủ tục
            string query = "EXEC sp_ThemGiaiDoanThiCong @DuAnThiCongID , @NgayKetThuc , @TrangThai , @NoiDung ";

            object[] parameters = new object[]
            {
                duAnThiCongID,
                ngayKetThuc.HasValue ? (object)ngayKetThuc.Value : DBNull.Value,
                trangThai,
                noiDung
            };

            // Gọi phương thức ExecuteNonQuery từ DataProvider để thực thi thủ tục
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);

            // Trả về true nếu thêm thành công (kết quả > 0)
            return result > 0;
        }

        // Phương thức cập nhật giai đoạn thi công
        public bool CapNhatGiaiDoan(GiaiDoanThiCong giaiDoan)
        {
            string query = "UPDATE GiaiDoanThiCong SET ThuTu = @thuTu , NgayKetThuc = @ngayKetThuc , " +
                           " TrangThai = @trangThai , NoiDung = @noiDung WHERE GiaiDoanID = @giaiDoanID ";
            object[] para = new object[]
            {
                giaiDoan.ThuTu,
                giaiDoan.NgayKetThuc.HasValue ? (object)giaiDoan.NgayKetThuc.Value : DBNull.Value,
                giaiDoan.TrangThai,
                giaiDoan.NoiDung,
                giaiDoan.GiaiDoanID
            };

            int result = DataProvider.Instance.ExecuteNonQuery(query, para);
            return result > 0;
        }

        // Phương thức xóa giai đoạn thi công
        public bool XoaGiaiDoanThiCongByID(int giaiDoanThiCongID)
        {
            string query = "DELETE FROM GiaiDoanThiCong WHERE GiaiDoanID = @GiaiDoanID";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { giaiDoanThiCongID });

            return result > 0;
        }

        public GiaiDoanThiCong GetGiaiDoanByGiaiDoanID(int giaiDoanID)
        {
            string query = "SELECT * FROM GiaiDoanThiCong WHERE GiaiDoanID = @GiaiDoanID";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { giaiDoanID });

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                GiaiDoanThiCong giaiDoan = new GiaiDoanThiCong(
                    Convert.ToInt32(row["GiaiDoanID"]),
                    Convert.ToInt32(row["DuAnThiCongID"]),
                    Convert.ToInt32(row["ThuTu"]),
                    row["NgayKetThuc"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["NgayKetThuc"]),
                    row["TrangThai"].ToString(),
                    row["NoiDung"].ToString()
                );

                return giaiDoan;
            }

            return null;
        }

        public bool KiemTraThuTuTonTai(int duAnThiCongID, int thuTu, int excludeGiaiDoanID)
        {
            string query = "SELECT COUNT(*) FROM GiaiDoanThiCong WHERE DuAnThiCongID = @duAnThiCongID AND ThuTu = @thuTu AND GiaiDoanID != @excludeGiaiDoanID ";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { duAnThiCongID, thuTu, excludeGiaiDoanID });

            return Convert.ToInt32(result) > 0;
        }

    }
}
