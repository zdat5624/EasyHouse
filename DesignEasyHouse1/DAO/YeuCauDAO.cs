using DesignEasyHouse1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignEasyHouse1.DAO
{
    public class YeuCauDAO
    {
        private static YeuCauDAO instance;

        public static YeuCauDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new YeuCauDAO();
                return instance;
            }
            private set => instance = value;
        }

        private YeuCauDAO() { }

        public DataTable GetDanhSachYeuCauKhongHoanChinh()
        {
            string query = "SELECT * FROM YeuCau";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool ThemYeuCau(int CuDanID, int LoaiYeuCauID, string TieuDe, string NoiDung)
        {
            string query = "INSERT INTO YeuCau (CuDanID, LoaiYeuCauID, TieuDe, NoiDung) VALUES ( @CuDanID ,  @LoaiYeuCauID , @TieuDe , @NoiDung )";

            object[] parameters = new object[] { CuDanID, LoaiYeuCauID, TieuDe, NoiDung };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public bool CapNhatTrangThaiHoanThanh(int YeuCauID)
        {
            string query = "UPDATE YeuCau SET TrangThai = N'Hoàn thành' WHERE YeuCauID = @YeuCauID";

            object[] parameters = new object[] { YeuCauID };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public bool CapNhatTrangThaiDangXuLy(int YeuCauID)
        {
            string query = "UPDATE YeuCau SET TrangThai = N'Đang chờ xử lý' WHERE YeuCauID = @YeuCauID";

            object[] parameters = new object[] { YeuCauID };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
    }
}
