using DesignEasyHouse1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DesignEasyHouse1.DAO
{
    public class CuDanDAO
    {
        private static CuDanDAO instance;

        public static CuDanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CuDanDAO();
                return instance;
            }
            private set => instance = value;
        }

        private CuDanDAO() { }

        public DataTable GetDanhSachCuDanKhongHoanChinh()
        {
            string query = "SELECT CuDanID, HoTen, SoDienThoai, CCCD, Email, DiaChi, TrangThai, ThanhToan FROM CuDan";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool ThemCuDan(string HoTen, string SoDienThoai, string CCCD, string Email, string DiaChi, string GioiTinh, DateTime NgaySinh, byte[] HinhAnh)
        {
            string query = "INSERT INTO CuDan (HoTen, SoDienThoai, CCCD, Email, DiaChi, GioiTinh, NgaySinh, HinhAnh) VALUES ( @HoTen ,  @SoDienThoai , @CCCD , @Email , @DiaChi , @GioiTinh , @NgaySinh , @HinhAnh )";

            object[] parameters = new object[]{HoTen, SoDienThoai, CCCD, Email, DiaChi, GioiTinh, NgaySinh, HinhAnh};

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public bool XoaCuDanByCuDanID(int CuDanID)
        {
            string query = "DELETE FROM CuDan WHERE CuDanID = @CuDanID";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { CuDanID });
            return result > 0;
        }

        public CuDan GetCuDanByCuDanID(int cuDanID)
        {
            string query = "SELECT * FROM CuDan WHERE CuDanID = @CuDanID";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { cuDanID });
            if (data.Rows.Count > 0)
            {
                return new CuDan(data.Rows[0]);
            }
            return null;
        }

        public bool CapNhatThongTinCuDan(CuDan cd)
        {
        string query = "UPDATE CuDan SET HoTen = @HoTen , SoDienThoai = @SoDienThoai , CCCD = @CCCD , Email = @Email , DiaChi = @DiaChi , GioiTinh = @GioiTinh , NgaySinh = @NgaySinh , TrangThai = @TrangThai , ThanhToan = @ThanhToan , NgayChuyenDen = @NgayChuyenDen , HinhAnh = @HinhAnh WHERE CuDanID = @CuDanID";

            object[] parameters = new object[] { cd.HoTen, cd.SoDienThoai, cd.CCCD, cd.Email, cd.DiaChi, cd.GioiTinh, cd.NgaySinh, cd.TrangThai, cd.ThanhToan, cd.NgayChuyenDen, cd.HinhAnh, cd.CuDanID };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);

            return result > 0;
        }
    }
}