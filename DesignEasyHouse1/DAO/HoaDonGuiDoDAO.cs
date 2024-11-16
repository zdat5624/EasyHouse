using DesignEasyHouse1.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace DesignEasyHouse1.DAO
{
    public class HoaDonGuiDoDAO
    {
        private static HoaDonGuiDoDAO instance;

        public static HoaDonGuiDoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonGuiDoDAO();
                return instance;
            }
            private set => instance = value;
        }

        private HoaDonGuiDoDAO() { }

        public DataTable LayDanhSachHoaDon()
        {
            List<HoaDonGuiDo> danhSach = new List<HoaDonGuiDo>();
            string query = "SELECT * FROM HoaDonGuiDo";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
            
        }

        public DataTable LayDanhSachHoaDonChuaThanhToan()
        {
            List<HoaDonGuiDo> danhSach = new List<HoaDonGuiDo>();
            string query = "SELECT * FROM HoaDonGuiDo WHERE TrangThai = N'Chưa thanh toán' ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public bool ThemHoaDon(HoaDonGuiDo hoaDon)
        {
            string query = "INSERT INTO HoaDonGuiDo (LoaiDo, KichCo, ViTri, GhiChu, CuDanID, NguoiTaoID, NgayLayDuKien, TrangThai) " +
                           "VALUES ( @LoaiDo , @KichCo , @ViTri , @GhiChu , @CuDanID , @NguoiTaoID , @NgayLayDuKien , @TrangThai )";

            object[] parameters = new object[]
            {
                hoaDon.LoaiDo, hoaDon.KichCo, hoaDon.ViTri, hoaDon.GhiChu, hoaDon.CuDanID,
                hoaDon.NguoiTaoID, hoaDon.NgayLayDuKien.HasValue ? hoaDon.NgayLayDuKien.Value : (object)DBNull.Value,
                hoaDon.TrangThai
            };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }


        public bool XoaHoaDonBangID(int hoaDonID)
        {
            string query = "DELETE FROM HoaDonGuiDo WHERE HoaDonGuiDoID = @HoaDonGuiDoID ";
            int ketQua = DataProvider.Instance.ExecuteNonQuery(query, new object[] { hoaDonID });
            return ketQua > 0;
        }

        public HoaDonGuiDo LayHoaDonBangID(int hoaDonID)
        {
            string query = "SELECT * FROM HoaDonGuiDo WHERE HoaDonGuiDoID = @HoaDonGuiDoID ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { hoaDonID });

            if (data.Rows.Count > 0)
            {
                return new HoaDonGuiDo(data.Rows[0]);
            }
            return null;
        }

        public bool ThanhToanHoaDon(HoaDonGuiDo hoaDon)
        {
            string query = "UPDATE HoaDonGuiDo " +
                           "SET NgayThanhToan = @NgayThanhToan , " +
                           "TrangThai = @TrangThai , " +
                           "NguoiThanhToanID = @NguoiThanhToanID , " +
                           "LoaiThanhToan = @LoaiThanhToan , " +
                           "SoTien = @SoTien " +
                           "WHERE HoaDonGuiDoID = @HoaDonGuiDoID ";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {
                hoaDon.NgayThanhToan.HasValue ? hoaDon.NgayThanhToan.Value : (object)DBNull.Value,
                hoaDon.TrangThai,
                hoaDon.NguoiThanhToanID.HasValue ? hoaDon.NguoiThanhToanID.Value : (object)DBNull.Value,
                hoaDon.LoaiThanhToan,
                hoaDon.SoTien,
                hoaDon.HoaDonGuiDoID
            });

            return result > 0;
        }

        public List<string> LayDanhSachLoaiDo()
        {
            List<string> dsLoaiDo = new List<string>();
            string query = "SELECT DISTINCT LoaiDo FROM HoaDonGuiDo WHERE LoaiDo != ''";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                string loaiDo = row["LoaiDo"].ToString();
                if (!string.IsNullOrEmpty(loaiDo))
                {
                    dsLoaiDo.Add(loaiDo);
                }
            }

            return dsLoaiDo;
        }

        public bool CapNhatGhiChu(int hoaDonGuiDoID, string ghiChu)
        {
            string query = "UPDATE HoaDonGuiDo SET GhiChu = @GhiChu WHERE HoaDonGuiDoID = @HoaDonGuiDoID ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ghiChu, hoaDonGuiDoID });
            return result > 0;
        }

    }
}
