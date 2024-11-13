using System;
using System.Data;

namespace DesignEasyHouse1.DTO
{
    public class NhanVien
    {
        public int Id { get; set; }             // Khóa chính (ID)
        public string Ten { get; set; }         // Tên nhân viên
        public string ChucVu { get; set; }      // Chức vụ
        public DateTime? NgaySinh { get; set; } // Ngày sinh
        public string DiaChi { get; set; }      // Địa chỉ
        public string DienThoai { get; set; }   // Số điện thoại
        public string Email { get; set; }       // Email
        public DateTime? NgayTuyenDung { get; set; } // Ngày tuyển dụng
        public decimal Luong { get; set; }      // Lương
        public string PhongBan { get; set; }    // Phòng ban
        public int? UserId { get; set; }        // ID người dùng (khóa ngoại, có thể là null)

        // Constructor khởi tạo đối tượng NhanVien với tất cả các tham số
        public NhanVien(int id, string ten, string chucVu, DateTime? ngaySinh, string diaChi,
                        string dienThoai, string email, DateTime? ngayTuyenDung, decimal luong,
                        string phongBan, int? userId)
        {
            Id = id;
            Ten = ten;
            ChucVu = chucVu;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            DienThoai = dienThoai;
            Email = email;
            NgayTuyenDung = ngayTuyenDung;
            Luong = luong;
            PhongBan = phongBan;
            UserId = userId;
        }

        // Constructor không tham số (có thể sử dụng để tạo đối tượng rỗng)
        public NhanVien() { }

        // Constructor nhận DataRow làm tham số để khởi tạo đối tượng NhanVien
        public NhanVien(DataRow row)
        {
            Id = Convert.ToInt32(row["id"]);
            Ten = row["Ten"].ToString();
            ChucVu = row["ChucVu"].ToString();
            NgaySinh = row["NgaySinh"] != DBNull.Value ? Convert.ToDateTime(row["NgaySinh"]) : (DateTime?)null;
            DiaChi = row["DiaChi"].ToString();
            DienThoai = row["DienThoai"].ToString();
            Email = row["Email"].ToString();
            NgayTuyenDung = row["NgayTuyenDung"] != DBNull.Value ? Convert.ToDateTime(row["NgayTuyenDung"]) : (DateTime?)null;
            Luong = Convert.ToDecimal(row["Luong"]);
            PhongBan = row["PhongBan"].ToString();
            UserId = row["UserId"] != DBNull.Value ? Convert.ToInt32(row["UserId"]) : (int?)null;
        }
    }
}
