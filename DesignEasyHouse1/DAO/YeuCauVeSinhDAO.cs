using DesignEasyHouse1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignEasyHouse1.DAO
{

    public class YeuCauVeSinhDAO
    {
        private static YeuCauVeSinhDAO instance;

        public static YeuCauVeSinhDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new YeuCauVeSinhDAO();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetDanhSachVeSinh(int CuDanID)
        {
            string query = "SELECT y.YeuCauID AS MaYeuCau,    y.TrangThai,  d.KhuVucVeSinh,    d.ThoiGianVeSinh FROM    YeuCau y JOIN     DichVuVeSinh d ON y.DichvuId = d.DichVuVeSinhID  WHERE y.CuDanID = @CuDanID  AND d.KieuVeSinh = N'Thường'";
            object[] parameters = new object[] { CuDanID };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
        public DataTable GetDanhSachVeSinhThang(int CuDanID)
        {
            string query = "SELECT y.YeuCauID AS MaYeuCau,    y.TrangThai,  d.KhuVucVeSinh,    d.ThoiGianVeSinh FROM    YeuCau y JOIN     DichVuVeSinh d ON y.DichvuId = d.DichVuVeSinhID  WHERE y.CuDanID = @CuDanID AND d.KieuVeSinh = N'Định kỳ theo tháng'";
            object[] parameters = new object[] { CuDanID };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
        public DataTable GetDanhSachVeSinhTuan(int CuDanID)
        {
            string query = "SELECT y.YeuCauID AS MaYeuCau,    y.TrangThai,  d.KhuVucVeSinh,    d.ThoiGianVeSinh FROM    YeuCau y JOIN     DichVuVeSinh d ON y.DichvuId = d.DichVuVeSinhID  WHERE y.CuDanID = @CuDanID AND d.KieuVeSinh = N'Định kỳ theo tuần'";
            object[] parameters = new object[] { CuDanID };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
        public bool DeleteYeuCauVeSinh(int YeuCauId)
        {
           return YeuCauDAO.Instance.DeleteYeuCau(YeuCauId);
        }
    }
}
