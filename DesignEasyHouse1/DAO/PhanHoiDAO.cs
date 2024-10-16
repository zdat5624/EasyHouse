using DesignEasyHouse1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignEasyHouse1.DAO
{
    public class PhanHoiDAO
    {
        private static PhanHoiDAO instance;

        public static PhanHoiDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhanHoiDAO();
                return instance;
            }
            private set => instance = value;
        }

        private PhanHoiDAO() { }

        public DataTable GetDanhSachPhanHoiKhongHoanChinh()
        {
            string query = "SELECT * FROM PhanHoiYeuCau";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool ThemPhanHoi(int YeuCauID, int NguoiPhanHoiID, string NoiDung)
        {
            string query;
            if (NguoiPhanHoiID == -1)
            {
                query = "INSERT INTO PhanHoiYeuCau (YeuCauID, NoiDung) VALUES ( @YeuCauID , @NoiDung )";
                object[] parameters = new object[] { YeuCauID,  NoiDung };
                int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
                return result > 0;
            }
            else
            {
                query = "INSERT INTO PhanHoiYeuCau (YeuCauID, NguoiPhanHoiID, NoiDung) VALUES ( @YeuCauID ,  @NguoiPhanHoiID , @NoiDung )";
                object[] parameters = new object[] { YeuCauID, NguoiPhanHoiID, NoiDung };
                int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
                return result > 0;
            }            
            
        }
    }
}
