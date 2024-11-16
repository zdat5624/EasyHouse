﻿using DesignEasyHouse1.DAO;
using System.Data;

public class YeuCauThiCongDAO
{
    private static YeuCauThiCongDAO instance;

    public static YeuCauThiCongDAO Instance
    {
        get { if (instance == null) instance = new YeuCauThiCongDAO(); return instance; }
        private set { instance = value; }
    }

    private YeuCauThiCongDAO() { }

    // Lấy danh sách yêu cầu chưa phản hồi
    public DataTable LayDanhSachYeuCauChuaPhanHoi()
    {
        string query = "SELECT * FROM YeuCauThiCong WHERE TrangThai = N'Chưa phản hồi' ";
        return DataProvider.Instance.ExecuteQuery(query);
    }

    // Lấy danh sách yêu cầu đã phản hồi
    public DataTable LayDanhSachYeuCauDaPhanHoi()
    {
        string query = "SELECT * FROM YeuCauThiCong WHERE TrangThai = N'Đã phản hồi' ";
        return DataProvider.Instance.ExecuteQuery(query);
    }

    // Lấy danh sách tất cả yêu cầu
    public DataTable LayTatCaYeuCau()
    {
        string query = "SELECT * FROM YeuCauThiCong";
        return DataProvider.Instance.ExecuteQuery(query);
    }

    // Lấy danh sách yêu cầu của một cư dân cụ thể
    public DataTable LayDanhSachYeuCauCuaCuDan(int cuDanID)
    {
        string query = "SELECT * FROM YeuCauThiCong WHERE CuDanID = @cuDanID ";
        return DataProvider.Instance.ExecuteQuery(query, new object[] { cuDanID });
    }

    // Thêm yêu cầu mới
    public bool ThemYeuCau(int cuDanID, string loaiYeuCau, string noiDungYeuCau)
    {
        string query = "INSERT INTO YeuCauThiCong (CuDanID, LoaiYeuCau, NoiDungYeuCau, TrangThai) " +
                       "VALUES ( @cuDanID , @loaiYeuCau , @noiDungYeuCau , N'Chưa phản hồi' )";
        int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { cuDanID, loaiYeuCau, noiDungYeuCau });

        return result > 0;
    }

    // Phản hồi yêu cầu
    public bool PhanHoiYeuCau(int yeuCauID, int nhanVienID, string ketQua, string noiDungPhanHoi)
    {
        string query = "UPDATE YeuCauThiCong " +
                       "SET NhanVienID = @nhanVienID , KetQua = @ketQua , NoiDungPhanHoi = @noiDungPhanHoi , TrangThai = N'Đã phản hồi', NgayPhanHoi = GETDATE() " +
                       " WHERE id = @yeuCauID ";
        int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { nhanVienID, ketQua, noiDungPhanHoi, yeuCauID });

        return result > 0;
    }

    // Lấy yêu cầu theo ID
    public YeuCauThiCong LayYeuCauBangID(int id)
    {
        string query = "SELECT * FROM YeuCauThiCong WHERE id = @id ";
        DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });

        if (data.Rows.Count > 0)
        {
            return new YeuCauThiCong(data.Rows[0]); // Cần tạo constructor trong lớp DTO để nhận DataRow
        }
        return null;
    }
}
