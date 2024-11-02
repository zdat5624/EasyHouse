using DesignEasyHouse1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignEasyHouse1.DAO
{
    public class DichVuVeSinhDAO
    {
        private static DichVuVeSinhDAO instance;
        public static DichVuVeSinhDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DichVuVeSinhDAO();
                return instance;
            }
            private set => instance = value;
        }
        public bool ThemYeuCau(string KhuVucVeSinh,string LoaiVeSinh, string KieuVeSinh, string KhuVucCuThe, DateTime ThoiGianVeSinh, int CuDanID)
        {

            string query = "INSERT INTO DichVuVeSinh  (KhuVucVeSinh, LoaiVeSinh ,KieuVeSinh, KhuVucCuThe, ThoiGianVeSinh, CuDanID)" +
                " VALUES ( @KhuVucVeSinh ,  @LoaiVeSinh , @KieuVeSinh , @KhuVucCuThe , @ThoiGianVeSinh , @CuDanID )";
            object[] parameters = new object[] { KhuVucVeSinh, LoaiVeSinh, KieuVeSinh,  KhuVucCuThe, ThoiGianVeSinh, CuDanID };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            
            
            return result > 0;
        }
    }
}
