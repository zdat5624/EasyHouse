using DesignEasyHouse1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignEasyHouse1.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAO();
                return instance;
            }
            private set => instance = value;
        }
        public string GetTenNhanVien(int userId)
        {
            string query = "SELECT Ten FROM NhanVien WHERE UserId = @userId";
            object[] parameters = new object[] { userId };
            return (string)DataProvider.Instance.ExecuteScalar(query, parameters);
        }
        public string GetPhongBan(int userId)
        {
            string query = "SELECT PhongBan FROM NhanVien WHERE UserId = @userId";
            object[] parameters = new object[] { userId };
            return (string)DataProvider.Instance.ExecuteScalar(query, parameters);
        }
        public string GetChucVu(int userId)
        {
            string query = "SELECT ChucVu FROM NhanVien WHERE UserId = @userId";
            object[] parameters = new object[] { userId };
            return (string)DataProvider.Instance.ExecuteScalar(query, parameters);
        }
        public int GetNhanVienId(int userId)
        {
            string query = "SELECT id FROM NhanVien WHERE UserId = @userId";
            object[] parameters = new object[] { userId };
            return (int)DataProvider.Instance.ExecuteScalar(query, parameters);
        }

        // Phương thức lấy thông tin nhân viên theo ID
        public NhanVien LayNhanVienBangID(int id)
        {
            string query = "SELECT * FROM NhanVien WHERE id = @id ";
            object[] parameters = new object[] { id };

            // Thực thi truy vấn và lấy kết quả
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                NhanVien nhanVien = new NhanVien(row);
                return nhanVien; 
            }

            return null; 
        }
    }
}
