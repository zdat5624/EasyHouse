﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignEasyHouse1.DTO;

namespace DesignEasyHouse1.DAO
{
    public class DuAnThiCongDAO
    {
        private static DuAnThiCongDAO instance;

        public static DuAnThiCongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DuAnThiCongDAO();
                return instance;
            }
            private set => instance = value;
        }

        private DuAnThiCongDAO() { }

        public DataTable GetAllDuAnThiCong()
        {
            // Cập nhật truy vấn để chọn các cột mới và loại bỏ cột FileTaiLieu nếu không cần thiết
            string query = "SELECT DuAnThiCongID, TenDuAn, TenNhaThau, ChuDuAn, NgayBatDau, NgayKetThuc, TrangThai FROM DuAnThiCong";
            return DataProvider.Instance.ExecuteQuery(query);
        }


        public bool ThemDuAn(DuAnThiCong duAn)
        {
            string query;

            object[] para;
            if (duAn.FileTaiLieu == null)
            {
                query = "INSERT INTO DuAnThiCong (TenDuAn, TenNhaThau, ChuDuAn, NgayBatDau, NgayKetThuc, TrangThai) " +
                           "VALUES ( @tenDuAn , @tenNhaThau , @chuDuAn , @ngayBatDau , @ngayKetThuc , @trangThai  )";
                para = new object[]
                {
                        duAn.TenDuAn,
                        duAn.TenNhaThau,
                        duAn.ChuDuAn,
                        duAn.NgayBatDau.HasValue ? (object)duAn.NgayBatDau.Value : DBNull.Value,
                        duAn.NgayKetThuc.HasValue ? (object)duAn.NgayKetThuc.Value : DBNull.Value,
                        duAn.TrangThai,
                };
            }
            else
            {
                query = "INSERT INTO DuAnThiCong (TenDuAn, TenNhaThau, ChuDuAn, NgayBatDau, NgayKetThuc, TrangThai, FileTaiLieu) " +
                           "VALUES ( @tenDuAn , @tenNhaThau , @chuDuAn , @ngayBatDau , @ngayKetThuc , @trangThai , @fileTaiLieu )";
                para = new object[]
                {
                        duAn.TenDuAn,
                        duAn.TenNhaThau,
                        duAn.ChuDuAn,
                        duAn.NgayBatDau.HasValue ? (object)duAn.NgayBatDau.Value : DBNull.Value,
                        duAn.NgayKetThuc.HasValue ? (object)duAn.NgayKetThuc.Value : DBNull.Value,
                        duAn.TrangThai,
                        duAn.FileTaiLieu
                };
            }

            int result = DataProvider.Instance.ExecuteNonQuery(query, para);

            return result > 0;
        }

        public DuAnThiCong GetDuAnThiCongByDuAnThiCongID(int duAnThiCongID)
        {

            // Câu lệnh SQL để lấy thông tin dự án thi công theo ID
            string query = "SELECT * FROM DuAnThiCong WHERE DuAnThiCongID = @duAnThiCongID ";

            // Truyền tham số ID vào truy vấn
            object[] parameters = new object[] { duAnThiCongID };

            // Lấy dữ liệu từ cơ sở dữ liệu
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            // Kiểm tra nếu có kết quả trả về
            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];

                // Tạo đối tượng DuAnThiCong với các thông tin từ cơ sở dữ liệu
                DuAnThiCong duAn = new DuAnThiCong(row);


                return duAn;
            }

            // Trả về null nếu không tìm thấy dự án với ID đã cho
            return null;
        }

        public bool XoaDuAnThiCong(int duAnThiCongID)
        {
            // Câu lệnh SQL để xóa dự án thi công theo ID
            string query = "DELETE FROM DuAnThiCong WHERE DuAnThiCongID = @duAnThiCongID ";

            // Truyền tham số ID vào truy vấn
            object[] parameters = new object[] { duAnThiCongID };

            // Thực thi câu lệnh xóa
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);

            // Trả về true nếu xóa thành công (result > 0), ngược lại false
            return result > 0;
        }

        public bool CapNhatDuAn(DuAnThiCong duAn)
        {
            // Câu lệnh SQL để cập nhật thông tin dự án thi công theo ID
            string query;

            object[] para;

            if (duAn.FileTaiLieu == null)
            {
                query = "UPDATE DuAnThiCong SET TenDuAn = @tenDuAn , TenNhaThau = @tenNhaThau , ChuDuAn = @chuDuAn , " +
                        "NgayBatDau = @ngayBatDau , NgayKetThuc = @ngayKetThuc , TrangThai = @trangThai " +
                        "WHERE DuAnThiCongID = @duAnThiCongID ";
                para = new object[]
                {
                    duAn.TenDuAn,
                    duAn.TenNhaThau,
                    duAn.ChuDuAn,
                    duAn.NgayBatDau.HasValue ? (object)duAn.NgayBatDau.Value : DBNull.Value,
                    duAn.NgayKetThuc.HasValue ? (object)duAn.NgayKetThuc.Value : DBNull.Value,
                    duAn.TrangThai,
                    duAn.DuAnThiCongID
                };
            }
            else
            {
                query = "UPDATE DuAnThiCong SET TenDuAn = @tenDuAn , TenNhaThau = @tenNhaThau , ChuDuAn = @chuDuAn , " +
                        "NgayBatDau = @ngayBatDau , NgayKetThuc = @ngayKetThuc , TrangThai = @trangThai , FileTaiLieu = @fileTaiLieu " +
                        "WHERE DuAnThiCongID = @duAnThiCongID ";
                para = new object[]
                {
                    duAn.TenDuAn,
                    duAn.TenNhaThau,
                    duAn.ChuDuAn,
                    duAn.NgayBatDau.HasValue ? (object)duAn.NgayBatDau.Value : DBNull.Value,
                    duAn.NgayKetThuc.HasValue ? (object)duAn.NgayKetThuc.Value : DBNull.Value,
                    duAn.TrangThai,
                    duAn.FileTaiLieu,
                    duAn.DuAnThiCongID
                };
            }

            // Thực thi câu lệnh cập nhật
            int result = DataProvider.Instance.ExecuteNonQuery(query, para);

            // Trả về true nếu cập nhật thành công, ngược lại false
            return result > 0;
        }

        public List<DuAnThiCong> GetAllDuAnThiCongList()
        {
            // Câu lệnh SQL để lấy tất cả các dự án thi công
            string query = "SELECT * FROM DuAnThiCong";

            // Lấy dữ liệu từ cơ sở dữ liệu
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            // Danh sách các dự án thi công
            List<DuAnThiCong> duAnList = new List<DuAnThiCong>();

            // Duyệt qua các dòng dữ liệu và tạo đối tượng DuAnThiCong
            foreach (DataRow row in data.Rows)
            {
                DuAnThiCong duAn = new DuAnThiCong(row);
                duAnList.Add(duAn);
            }

            return duAnList;
        }

        // Phương thức lấy dự án thi công theo ID
        public DuAnThiCong GetDuAnThiCongByID(int duAnID)
        {
            // Câu lệnh SQL để tìm dự án thi công theo ID
            string query = "SELECT * FROM DuAnThiCong WHERE DuAnThiCongID = @duAnID";

            // Thực hiện truy vấn và lấy dữ liệu
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { duAnID });

            // Kiểm tra nếu có dữ liệu, trả về đối tượng DuAnThiCong
            if (data.Rows.Count > 0)
            {
                return new DuAnThiCong(data.Rows[0]);
            }

            // Trả về null nếu không tìm thấy dự án
            return null;
        }

        public DataTable GetThongTinDuAnHoanThanhTrongThang(int thang, int nam)
        {
            // Câu truy vấn chỉ lấy tên dự án, tên nhà thầu và ngày kết thúc
            string query = "SELECT TenDuAn, TenNhaThau, NgayKetThuc " +
                           "FROM DuAnThiCong " +
                           "WHERE TrangThai = N'Hoàn thành' " +
                           "AND MONTH(NgayKetThuc) = @Thang " +
                           "AND YEAR(NgayKetThuc) = @Nam ";

            // Tham số tháng và năm
            object[] parameters = new object[] { thang, nam };

            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }



    }
}
