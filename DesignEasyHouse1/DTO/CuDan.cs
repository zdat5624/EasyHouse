using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignEasyHouse1.DTO
{
    public class CuDan
    {
        private int cuDanID;
        private string hoTen;
        private string soDienThoai;
        private string cCCD;
        private string email;
        private string diaChi;
        private string gioiTinh;
        private DateTime ngaySinh;
        private string trangThai;
        private string thanhToan;
        private DateTime ngayChuyenDen;
        private byte[] HinhAnh;

        public int CuDanID { get => cuDanID; set => cuDanID = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string CCCD { get => cCCD; set => cCCD = value; }
        public string Email { get => email; set => email = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string ThanhToan { get => thanhToan; set => thanhToan = value; }
        public DateTime NgayChuyenDen { get => ngayChuyenDen; set => ngayChuyenDen = value; }
        public byte[] HinhAnh1 { get => HinhAnh; set => HinhAnh = value; }

        public CuDan(string hoTen, string soDienThoai, string cccd, string email, 
            string diaChi, string gioiTinh, DateTime ngaySinh, byte[] hinhAnh)
        {
            HoTen = hoTen;
            SoDienThoai = soDienThoai;
            CCCD = cccd;
            Email = email;
            DiaChi = diaChi;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            HinhAnh1 = hinhAnh;
        }
    }
}
