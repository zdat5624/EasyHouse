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

        public bool XoaDichVuGuiXe(int dichVuGuiXeID)
        {
            // Câu lệnh SQL để xóa dịch vụ gửi xe theo ID
            string query = "DELETE FROM DichVuGuiXe WHERE DichVuGuiXeID = @dichVuGuiXeID ";

            // Truyền tham số ID vào truy vấn
            object[] parameters = new object[] { dichVuGuiXeID };

            // Thực thi câu lệnh xóa
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);

            // Trả về true nếu xóa thành công (result > 0), ngược lại false
            return result > 0;
        }

        public bool GuiThongBaoDangKyLai(int dichVuGuiXeID, int cuDanID, string noiDung)
        {
            if (XoaDichVuGuiXe(dichVuGuiXeID))
            {
                // Tạo tham số đầu vào cho thủ tục
                string query = " INSERT INTO ThongBao (TieuDe, NoiDung, ThoiGian, UsersId, YeuCauId) " +
                               "VALUES ( N'Đăng ký gửi xe lại', @noiDung , GETDATE() , @cuDanID , @dichVuGuiXeID ) ";

                object[] parameters = new object[]
                {
                    noiDung,
                    cuDanID,
                    dichVuGuiXeID
                };

                // Gọi phương thức ExecuteNonQuery từ DataProvider để thực thi thủ tục
                int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);

                // Trả về true nếu thêm thành công (kết quả > 0)
                return result > 0;
            }
            else { return false; }
        }

        public bool CapNhatTrangThaiHoanThanh(int dichVuGuiXeID)
        {
            // Cập nhật trạng thái cho dịch vụ gửi xe thành "Đã xác nhận"
            string query = "UPDATE DichVuGuiXe SET TrangThai = N'Đã xác nhận' WHERE DichVuGuiXeID = @DichVuGuiXeID";

            // Truyền dichVuGuiXeID vào danh sách tham số
            object[] parameters = new object[] { dichVuGuiXeID };

            // Thực thi câu truy vấn
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0; // Trả về true nếu cập nhật thành công
        }
    }
}
