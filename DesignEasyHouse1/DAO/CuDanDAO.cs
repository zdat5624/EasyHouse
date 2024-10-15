using DesignEasyHouse1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public bool ThemCuDan(CuDan cuDan)
        {
            string query = "INSERT INTO CuDan (HoTen, SoDienThoai, CCCD, Email, DiaChi, GioiTinh, NgaySinh, HinhAnh) VALUES ( @HoTen , @SoDienThoai , @CCCD , @Email , @DiaChi , @GioiTinh , @NgaySinh , @HinhAnh )";

            object[] parameters = new object[]
            {
                cuDan.HoTen,
                cuDan.SoDienThoai,
                cuDan.CCCD,
                cuDan.Email,
                cuDan.DiaChi,
                cuDan.GioiTinh,
                cuDan.NgaySinh,
                cuDan.HinhAnh
            };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
    }
}