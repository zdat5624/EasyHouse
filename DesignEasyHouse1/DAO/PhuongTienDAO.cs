using DesignEasyHouse1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignEasyHouse1.DAO
{
    public class PhuongTienDAO
    {
        private static PhuongTienDAO instance;

        public static PhuongTienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhuongTienDAO();
                return instance;
            }
            private set => instance = value;
        }

        public DataTable LayThongTinPhuongTien()
        {
            string query = "SELECT PhuongTienID, BienSoXe, CuDanID, LoaiXe, ThoiGianGui, CavetXe, CCCD_CMND FROM PhuongTien";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool ThemPhuongTien(PhuongTien phuongTien)
        {

            // Tạo tham số đầu vào cho thủ tục
            string query = " INSERT INTO PhuongTien (BienSoXe, CuDanID, LoaiXe, ThoiGianGui, CavetXe, CCCD_CMND) " +
                           "VALUES ( @BienSoXe ,  @CuDanID , @LoaiXe , @ThoiGianGui , @CavetXe , @CCCD_CMND ) ";

            object[] parameters = new object[]
            {
                phuongTien.BienSoXe,
                phuongTien.CuDanID,
                phuongTien.LoaiXe,
                phuongTien.ThoiGianGui.HasValue ? (object)phuongTien.ThoiGianGui.Value : DBNull.Value,
                phuongTien.CavetXe,
                phuongTien.CCCD_CMND
            };

            // Gọi phương thức ExecuteNonQuery từ DataProvider để thực thi thủ tục
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);

            // Trả về true nếu thêm thành công (kết quả > 0)
            return result > 0;
        }
    }
}
