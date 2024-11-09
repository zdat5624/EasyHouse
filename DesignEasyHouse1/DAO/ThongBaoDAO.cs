using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignEasyHouse1.DAO
{
    public class ThongBaoDAO
    {
        private static ThongBaoDAO instance;

        public static ThongBaoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThongBaoDAO();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable LayDanhSachThongBao(int userId)
        {
            string query = "SELECT TieuDe, NoiDung,ThoiGian FROM ThongBao WHERE UsersId = @userId";
            object[] parameters = new object[] { userId };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
            
        }
    }
}
