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
        public bool ThemYeuCau(int cuDanId , string loaiVeSinh, int loaiYeuCauId, string khuVucVeSinh, string khuVucTuyChon, DateTime thoiGianVeSinh)
        {

            //string query = "INSERT INTO YeuCau (CuDanID, LoaiYeuCauID, TieuDe, NoiDung) VALUES ( @CuDanID ,  @LoaiYeuCauID , @TieuDe , @NoiDung )";

            //object[] parameters = new object[] {loaiVeSinh, loaiYeuCauId, khuVucVeSinh, khuVucTuyChon, thoiGianVeSinh };

            //int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            
            
            
            Console.WriteLine("Them yeu cau");
            return 1 > 0;
        }
    }
}
