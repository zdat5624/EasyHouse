using DesignEasyHouse1.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace DesignEasyHouse1.DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Instance
        {
            get
            {
                if (instance == null) instance = new HoaDonDAO();
                return instance;
            }
            private set => instance = value;
        }

        private HoaDonDAO() { }

        public List<HoaDon> LayTatCaHoaDon()
        {
            List<HoaDon> danhSachHoaDon = new List<HoaDon>();
            string query = "SELECT * FROM HoaDon";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                danhSachHoaDon.Add(new HoaDon(row));
            }

            return danhSachHoaDon;
        }

        public DataTable LayDTHoaDon()
        {
            string query = @"
                            SELECT 
                                HoaDon.HoaDonID, 
                                HoaDon.PhanLoai, 
                                HoaDon.TongTien, 
                                HoaDon.NoiDung, 
                                HoaDon.NgayTao, 
                                HoaDon.TrangThai, 
                                HoaDon.CuDanID, 
                                CuDan.HoTen AS TenCuDan
                            FROM HoaDon
                            LEFT JOIN CuDan ON HoaDon.CuDanID = CuDan.CuDanID
                        ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }


        public DataTable LayDTHoaDonChuaThanhToan()
        {
            string query = @"
                            SELECT 
                                HoaDon.HoaDonID, 
                                HoaDon.PhanLoai, 
                                HoaDon.TongTien, 
                                HoaDon.NoiDung, 
                                HoaDon.NgayTao, 
                                HoaDon.TrangThai, 
                                HoaDon.CuDanID, 
                                CuDan.HoTen AS TenCuDan
                            FROM HoaDon
                            LEFT JOIN CuDan ON HoaDon.CuDanID = CuDan.CuDanID
                            WHERE HoaDon.TrangThai = N'Chưa thanh toán'
                        ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }


        public HoaDon LayHoaDonTheoID(int hoaDonID)
        {
            string query = "SELECT * FROM HoaDon WHERE HoaDonID = @HoaDonID";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { hoaDonID });

            if (data.Rows.Count > 0)
            {
                return new HoaDon(data.Rows[0]);
            }

            return null;
        }

        public bool ThemHoaDon(HoaDon hoaDon)
        {
            string query = "INSERT INTO HoaDon (PhanLoai, TongTien, NoiDung, CuDanID) " +
                           "VALUES ( @PhanLoai , @TongTien , @NoiDung  , @CuDanID )";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                hoaDon.PhanLoai,
                hoaDon.TongTien,
                hoaDon.NoiDung,
                hoaDon.CuDanID
            });

            return result > 0;
        }

        public bool CapNhatHoaDon(HoaDon hoaDon)
        {
            string query = "UPDATE HoaDon " +
                           "SET PhanLoai = @PhanLoai , TongTien = @TongTien , NoiDung = @NoiDung , " +
                           "TrangThai = @TrangThai , CuDanID = @CuDanID " +
                           "WHERE HoaDonID = @HoaDonID ";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                hoaDon.PhanLoai,
                hoaDon.TongTien,
                hoaDon.NoiDung,
                hoaDon.TrangThai,
                hoaDon.CuDanID,
                hoaDon.HoaDonID
            });

            return result > 0;
        }

        public bool XoaHoaDon(int hoaDonID)
        {
            string query = "DELETE FROM HoaDon WHERE HoaDonID = @HoaDonID ";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { hoaDonID });

            return result > 0;
        }
    }
}
