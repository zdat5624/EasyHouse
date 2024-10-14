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
    }
}