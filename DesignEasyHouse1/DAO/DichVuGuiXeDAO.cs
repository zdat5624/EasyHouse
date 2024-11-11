using DesignEasyHouse1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignEasyHouse1.DAO
{
    public class DichVuGuiXeDAO
    {
        private static DichVuGuiXeDAO instance;

        public static DichVuGuiXeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DichVuGuiXeDAO();
                return instance;
            }
            private set => instance = value;
        }

        public DataTable LayThongTinDichVuGuiXe()
        {
            string query = "SELECT D.DichVuGuiXeID, D.NgayDangKy, D.TrangThai, P.BienSoXe, " +
                           "P.LoaiXe, P.CuDanID, P.ThoiGianGui, P.CavetXe, P.CCCD_CMND FROM DichVuGuiXe D " +
                           "JOIN PhuongTien P ON D.PhuongTienID = P.PhuongTienID";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
