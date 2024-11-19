using System;
using System.Collections.Generic;
using System.Data;
using DesignEasyHouse1.DTO;

namespace DesignEasyHouse1.DAO
{
    public class BaoCaoDoanhThuChiPhiDAO
    {
        private static BaoCaoDoanhThuChiPhiDAO instance;

        public static BaoCaoDoanhThuChiPhiDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BaoCaoDoanhThuChiPhiDAO();
                return instance;
            }
            private set => instance = value;
        }

        private BaoCaoDoanhThuChiPhiDAO() { }

        public DataTable LayTatCaBaoCao()
        {
            string query = "SELECT BaoCaoID, PhanLoai, ThangNam, DoanhThu, ChiPhi, NgayTao FROM BaoCaoDoanhThuChiPhi ORDER BY ThangNam DESC ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable LayBaoCaoTheoPhanLoai(string phanLoai)
        {
            string query = "SELECT BaoCaoID, PhanLoai, ThangNam, DoanhThu, ChiPhi, NgayTao FROM BaoCaoDoanhThuChiPhi " +
                           " WHERE PhanLoai = @phanLoai " +
                           " ORDER BY ThangNam DESC ";

            object[] parameters = new object[] { phanLoai };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);
            return data;
        }



        // Lấy báo cáo theo ID
        public BaoCaoDoanhThuChiPhi LayBaoCaoBangID(int baoCaoID)
        {
            string query = "SELECT * FROM BaoCaoDoanhThuChiPhi WHERE BaoCaoID = @baoCaoID ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { baoCaoID });

            if (data.Rows.Count > 0)
            {
                return new BaoCaoDoanhThuChiPhi(data.Rows[0]);
            }
            return null;
        }

        // Thêm báo cáo
        public bool ThemBaoCao(BaoCaoDoanhThuChiPhi baoCao)
        {
            string query;
            object[] parameters;

            if (baoCao.FilePDF == null)
            {
                query = "INSERT INTO BaoCaoDoanhThuChiPhi ( PhanLoai, ThangNam, DoanhThu, ChiPhi ) " +
                        "VALUES ( @phanLoai , @thangNam , @doanhThu , @chiPhi )";
                parameters = new object[]
                {
                    baoCao.PhanLoai,
                    baoCao.ThangNam,
                    baoCao.DoanhThu,
                    baoCao.ChiPhi
                };
            }
            else
            {
                query = "INSERT INTO BaoCaoDoanhThuChiPhi (PhanLoai, ThangNam, DoanhThu, ChiPhi, FilePDF) " +
                        "VALUES ( @phanLoai , @thangNam , @doanhThu , @chiPhi , @filePDF )";
                parameters = new object[]
                {
                    baoCao.PhanLoai,
                    baoCao.ThangNam,
                    baoCao.DoanhThu,
                    baoCao.ChiPhi,
                    baoCao.FilePDF
                };
            }

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }


        // Xóa báo cáo
        public bool XoaBaoCao(int baoCaoID)
        {
            string query = "DELETE FROM BaoCaoDoanhThuChiPhi WHERE BaoCaoID = @baoCaoID ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { baoCaoID });
            return result > 0;
        }

        public bool KiemTraBaoCaoTheoThangPhanLoai(DateTime thangNam, string phanLoai)
        {
            int month = thangNam.Month;
            int year = thangNam.Year;

            // Sửa câu truy vấn để lọc theo cả tháng năm và phân loại
            string query = "SELECT COUNT(*) FROM BaoCaoDoanhThuChiPhi " +
                           "WHERE MONTH(ThangNam) = @Month " +
                           "AND YEAR(ThangNam) = @Year " +
                           "AND PhanLoai = @PhanLoai ";

            // Truyền cả tháng năm và phân loại vào tham số
            int count = (int)DataProvider.Instance.ExecuteScalar(query, new object[] { month, year, phanLoai });

            return count > 0;
        }


    }
}
