using DesignEasyHouse1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignEasyHouse1.DAO
{
    public class YeuCauDAO
    {
        private static YeuCauDAO instance;

        public static YeuCauDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new YeuCauDAO();
                return instance;
            }
            private set => instance = value;
        }

        private YeuCauDAO() { }

        public DataTable GetDanhSachYeuCauKhongHoanChinh()
        {
            string query = "SELECT * FROM YeuCau";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetDanhSachYeuCauDuocPhanCong(int NhanVienID)
        {
            string query = "SELECT yc.YeuCauID, yc.TieuDe, yc.NoiDung, yc.NgayGui, yc.TrangThai, \r\n    pc.ThoiGianPhanCong\r\nFROM YeuCau yc\r\nJOIN PhanCong pc ON yc.YeuCauID = pc.YeuCauId\r\nJOIN NhanVien nv ON pc.NhanVienId = nv.id\r\nWHERE pc.NhanVienId = @NhanVienID";

            object[] parameters = new object[] { NhanVienID };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
        public DataTable GetDanhSachYeuCauDuocPhanCongDaHoanThanh(int NhanVienID)
        {
            string query = "SELECT yc.YeuCauID, yc.TieuDe, yc.NoiDung, yc.NgayGui, yc.TrangThai, \r\n    pc.ThoiGianPhanCong\r\nFROM YeuCau yc\r\nJOIN PhanCong pc ON yc.YeuCauID = pc.YeuCauId\r\nJOIN NhanVien nv ON pc.NhanVienId = nv.id\r\nWHERE yc.TrangThai = N'Hoàn thành' AND pc.NhanVienId = @NhanVienID";

            object[] parameters = new object[] { NhanVienID };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
        public DataTable GetDanhSachYeuCauDuocPhanCongChuaHoanThanh(int NhanVienID)
        {
            string query = "SELECT yc.YeuCauID, yc.TieuDe, yc.NoiDung, yc.NgayGui, yc.TrangThai, \r\n    pc.ThoiGianPhanCong\r\nFROM YeuCau yc\r\nJOIN PhanCong pc ON yc.YeuCauID = pc.YeuCauId\r\nJOIN NhanVien nv ON pc.NhanVienId = nv.id\r\nWHERE yc.TrangThai = N'Nhân viên vệ sinh sẽ xử lý đúng lịch đã đăng ký' AND pc.NhanVienId = @NhanVienID";

            object[] parameters = new object[] { NhanVienID };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }

        public bool ThemYeuCau(int CuDanID, int LoaiYeuCauID, string TieuDe, string NoiDung)
        {
            string query = "INSERT INTO YeuCau (CuDanID, LoaiYeuCauID, TieuDe, NoiDung) VALUES ( @CuDanID ,  @LoaiYeuCauID , @TieuDe , @NoiDung )";

            object[] parameters = new object[] { CuDanID, LoaiYeuCauID, TieuDe, NoiDung };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public bool CapNhatTrangThaiHoanThanh(int YeuCauID)
        {
            string query = "UPDATE YeuCau SET TrangThai = N'Hoàn thành' WHERE YeuCauID = @YeuCauID";

            object[] parameters = new object[] { YeuCauID };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public bool CapNhatTrangThaiDangXuLy(int YeuCauID)
        {
            string query = "UPDATE YeuCau SET TrangThai = N'Đang chờ xử lý' WHERE YeuCauID = @YeuCauID";

            object[] parameters = new object[] { YeuCauID };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        public bool DeleteYeuCau(int yeuCauID)
        {
            string query = "DELETE FROM YeuCau WHERE YeuCauID = @YeuCauID";
            object[] parameters = new object[] { yeuCauID };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);

            return result > 0; // Trả về true nếu xóa thành công
        }
        public bool ChapNhanYeuCauVeSinh(int yeuCauID)
        {
            string query = "UPDATE YeuCau SET TrangThai = N'Nhân viên vệ sinh sẽ xử lý đúng lịch đã đăng ký' WHERE YeuCauID = @YeuCauID ";
            object[] parameters = new object[] { yeuCauID };
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, parameters);

            }
            catch (Exception ex)
            {
            result = 0;
        }

            return result > 0; // Trả về true nếu thay đổi thành công
        }
        public bool TuChoiYeuCauVeSinh(int yeuCauID)
        {
            string query = "UPDATE YeuCau SET TrangThai = N'Yêu cầu bị từ chối' WHERE YeuCauID = @YeuCauID ";
            object[] parameters = new object[] { yeuCauID };

            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, parameters);

            }
            catch(Exception ex)
            {
                result = 0;
            }

            return result > 0; // Trả về true nếu thay đổi thành công
        }
    }
}
