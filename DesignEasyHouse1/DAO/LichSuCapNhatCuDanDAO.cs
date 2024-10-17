using DesignEasyHouse1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DesignEasyHouse1.DAO
{


    public class LichSuCapNhatCuDanDAO
    {
        private static LichSuCapNhatCuDanDAO instance;

        public static LichSuCapNhatCuDanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new LichSuCapNhatCuDanDAO();
                return instance;
            }
            private set => instance = value;
        }
        private LichSuCapNhatCuDanDAO() { }

        public bool ThemLichSuCapNhatCuDan(CuDan cd)
        {
            string query = @"INSERT INTO LichSuCapNhatCuDan (CuDanID, HoTen, SoDienThoai, CCCD, Email, DiaChi, GioiTinh, NgaySinh, TrangThai, ThanhToan, NgayChuyenDen, HinhAnh) VALUES ( @CuDanID , @HoTen , @SoDienThoai , @CCCD , @Email , @DiaChi ,  @GioiTinh , @NgaySinh , @TrangThai , @ThanhToan ,  @NgayChuyenDen , @HinhAnh )";

            object[] parameters = new object[] { cd.CuDanID, cd.HoTen, cd.SoDienThoai, cd.CCCD, cd.Email, cd.DiaChi, cd.GioiTinh, cd.NgaySinh, cd.TrangThai, cd.ThanhToan, cd.NgayChuyenDen, cd.HinhAnh };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);

            return result > 0;
        }

        //public DataTable GetLichSuCapNhatCuDanKhongHoanChinh(int cuDanID)
        //{
        //    string query = "SELECT CapNhatID, NgayLuu FROM LichSuCapNhatCuDan WHERE CuDanID = @cuDanID ";
        //    object[] parameters = new object[] {cuDanID};

        //    return DataProvider.Instance.ExecuteQuery(query, parameters);
        //}

        public List<LichSuCapNhatCuDan> GetDanhSachLichSuCapNhatCuDan(int cuDanID)
        {
            string query = "SELECT * FROM LichSuCapNhatCuDan WHERE CuDanID = @cuDanID ";
            object[] parameters = new object[] { cuDanID };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            List<LichSuCapNhatCuDan> lst = new List<LichSuCapNhatCuDan>();

            foreach (DataRow row in data.Rows)
            {
                lst.Add(new LichSuCapNhatCuDan(row));
            }

            return lst;
        }

    }
}
