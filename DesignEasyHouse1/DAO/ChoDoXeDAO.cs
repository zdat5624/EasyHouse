using DesignEasyHouse1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignEasyHouse1.DAO
{
    public class ChoDoXeDAO
    {
        private static ChoDoXeDAO instance;

        public static ChoDoXeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChoDoXeDAO();
                return instance;
            }
            private set => instance = value;
        }

        private ChoDoXeDAO() { }

        public DataTable LayTatCaChoDoXe()
        {
            string query = "SELECT ChoDoXeID, ViTri, TrangThai FROM ChoDoXe";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool ThemChoDoXe(ChoDoXe choDoXe)
        {
            string query = "INSERT INTO ChoDoXe (ViTri, TrangThai) VALUES (@viTri , @trangThai)";
            object[] para = new object[] { choDoXe.ViTri, choDoXe.TrangThai };

            int result = DataProvider.Instance.ExecuteNonQuery(query, para);

            return result > 0;
        }

        public ChoDoXe LayChoDoXeTheoID(int choDoXeID)
        {
            string query = "SELECT * FROM ChoDoXe WHERE ChoDoXeID = @choDoXeID";
            object[] parameters = new object[] { choDoXeID };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                return new ChoDoXe(row);
            }

            return null;
        }

        public bool XoaChoDoXe(int choDoXeID)
        {
            string query = "DELETE FROM ChoDoXe WHERE ChoDoXeID = @choDoXeID";
            object[] parameters = new object[] { choDoXeID };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);

            return result > 0;
        }

        public bool CapNhatChoDoXe(ChoDoXe choDoXe)
        {
            string query = "UPDATE ChoDoXe SET ViTri = @viTri, TrangThai = @trangThai WHERE ChoDoXeID = @choDoXeID";
            object[] para = new object[]
            {
                choDoXe.ViTri,
                choDoXe.TrangThai,
                choDoXe.ChoDoXeID
            };

            int result = DataProvider.Instance.ExecuteNonQuery(query, para);

            return result > 0;
        }

        public List<ChoDoXe> LayDanhSachChoDoXe()
        {
            string query = "SELECT * FROM ChoDoXe";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<ChoDoXe> choDoXeList = new List<ChoDoXe>();

            foreach (DataRow row in data.Rows)
            {
                ChoDoXe choDoXe = new ChoDoXe(row);
                choDoXeList.Add(choDoXe);
            }

            return choDoXeList;
        }
    }
}
