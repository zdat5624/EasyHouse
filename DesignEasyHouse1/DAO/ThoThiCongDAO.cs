using DesignEasyHouse1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DesignEasyHouse1.DAO
{
    public class ThoThiCongDAO
    {
        private static ThoThiCongDAO instance;

        public static ThoThiCongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThoThiCongDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private ThoThiCongDAO() { }

        // Lấy danh sách thợ thi công theo DuAnThiCongID
        public List<ThoThiCong> GetThoThiCongByDuAnID(int duAnThiCongID)
        {
            List<ThoThiCong> list = new List<ThoThiCong>();
            string query = "SELECT * FROM ThoThiCong WHERE DuAnThiCongID = @duAnThiCongID ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { duAnThiCongID });

            foreach (DataRow row in data.Rows)
            {
                ThoThiCong tho = new ThoThiCong(row);
                list.Add(tho);
            }

            return list;
        }

        // Thêm mới một thợ thi công
        public bool ThemThoThiCong(ThoThiCong tho)
        {
            string query = "INSERT INTO ThoThiCong (DuAnThiCongID, HoTen, CCCD, NhiemVu) VALUES ( @duAnThiCongID , @hoTen , @cccd ,  @nhiemVu )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tho.DuAnThiCongID, tho.HoTen, tho.CCCD, tho.NhiemVu });
            return result > 0;
        }

        // Cập nhật thông tin thợ thi công
        public bool CapNhatThoThiCong(ThoThiCong tho)
        {
            string query = "UPDATE ThoThiCong SET HoTen = @hoTen , CCCD = @cccd , NhiemVu = @nhiemVu WHERE ThoThiCongID = @thoThiCongID ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tho.HoTen, tho.CCCD, tho.NhiemVu, tho.ThoThiCongID });
            return result > 0;
        }

        // Xóa thợ thi công theo ID
        public bool XoaThoThiCong(int thoThiCongID)
        {
            string query = "DELETE FROM ThoThiCong WHERE ThoThiCongID = @thoThiCongID ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { thoThiCongID });
            return result > 0;
        }

        public ThoThiCong GetThoThiCongByThoThiCongID(int thoThiCongID)
        {
            string query = "SELECT * FROM ThoThiCong where ThoThiCongID = @thoThiCongID ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { thoThiCongID });
            if (dt.Rows.Count>0)
            {
                ThoThiCong ttc = new ThoThiCong(dt.Rows[0]);
                return ttc;
            }
            return null;
        }
    }
}
