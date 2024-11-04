using DesignEasyHouse1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignEasyHouse1.DAO
{
    public class UsersDAO
    {
        private static UsersDAO instance;

        public static UsersDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new UsersDAO();
                return instance;
            }
            private set => instance = value;
        }
        public int XacThucNguoiDung(string tenDangNhap, string MatKhau)
        {
            string query = "SELECT id FROM users WHERE TenDangNhap = @tenDangNhap AND MatKhau = @MatKhau";
            object[] parameters = new object[] { tenDangNhap, MatKhau };

            int result = (int)DataProvider.Instance.ExecuteScalar(query, parameters);
            return result;
        }
        public int PhanQuyenNguoiDung(int userId)
        {
            return 0;
        }

    }
}
