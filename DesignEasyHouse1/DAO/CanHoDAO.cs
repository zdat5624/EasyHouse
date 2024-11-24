using System;
using System.Data;
using System.Collections.Generic;
using DesignEasyHouse1.DTO;

namespace DesignEasyHouse1.DAO
{
    public class CanHoDAO
    {
        private static CanHoDAO instance;

        public static CanHoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CanHoDAO();
                return instance;
            }
            private set => instance = value;
        }

        private CanHoDAO() { }

        public DataTable LayTatCaCanHo()
        {
            string query = "SELECT * FROM CanHo ";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public List<CanHo> LayDanhSachCanHo()
        {
            string query = "SELECT * FROM CanHo";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<CanHo> danhSachCanHo = new List<CanHo>();

            foreach (DataRow row in data.Rows)
            {
                CanHo canHo = new CanHo(row);
                danhSachCanHo.Add(canHo);
            }

            return danhSachCanHo;
        }


        public CanHo LayCanHoTheoMa(string maCanHo)
        {
            string query = "SELECT * FROM CanHo WHERE MaCanHo = @MaCanHo ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maCanHo });

            if (data.Rows.Count > 0)
            {
                return new CanHo(data.Rows[0]);
            }
            return null;
        }

        public bool ThemCanHo(CanHo canHo)
        {
            string query = "INSERT INTO CanHo (MaCanHo, ViTri, DienTich, SoPhongNgu, SoPhongTam, TrangThai, CuDanID) " +
                           "VALUES ( @MaCanHo , @ViTri , @DienTich , @SoPhongNgu , @SoPhongTam , @TrangThai ,   @CuDanID )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                canHo.MaCanHo,
                canHo.ViTri,
                canHo.DienTich,
                canHo.SoPhongNgu,
                canHo.SoPhongTam,
                canHo.TrangThai,
                canHo.CuDanID
            });

            return result > 0;
        }

        public bool CapNhatCanHo(CanHo canHo)
        {
            string query = "UPDATE CanHo SET ViTri = @ViTri , DienTich = @DienTich , SoPhongNgu = @SoPhongNgu , " +
                           "SoPhongTam = @SoPhongTam , TrangThai = @TrangThai , CuDanID = @CuDanID WHERE MaCanHo =  @MaCanHo ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                canHo.ViTri,
                canHo.DienTich,
                canHo.SoPhongNgu,
                canHo.SoPhongTam,
                canHo.TrangThai,
                canHo.CuDanID,
                canHo.MaCanHo
            });

            return result > 0;
        }

        public bool XoaCanHo(string maCanHo)
        {
            string query = "DELETE FROM CanHo WHERE MaCanHo = @MaCanHo ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maCanHo });
            return result > 0;
        }

        // Lấy danh sách căn hộ theo trạng thái
        public DataTable LayCanHoTheoTrangThai(string trangThai)
        {
            string query = "SELECT * FROM CanHo WHERE TrangThai = @TrangThai ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { trangThai });
        }
    }
}
