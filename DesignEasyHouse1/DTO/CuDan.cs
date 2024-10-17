using System;
using System.Collections.Generic;
using System.Data;
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
        private byte[] hinhAnh;

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
        public byte[] HinhAnh { get => hinhAnh; set => hinhAnh = value; }

        public CuDan(int cuDanID, string hoTen, string soDienThoai, string cCCD, string email,
                     string diaChi, string gioiTinh, DateTime ngaySinh, string trangThai,
                     string thanhToan, DateTime ngayChuyenDen, byte[] hinhAnh)
        {
            this.cuDanID = cuDanID;
            this.hoTen = hoTen;
            this.soDienThoai = soDienThoai;
            this.cCCD = cCCD;
            this.email = email;
            this.diaChi = diaChi;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.trangThai = trangThai;
            this.thanhToan = thanhToan;
            this.ngayChuyenDen = ngayChuyenDen;
            this.hinhAnh = hinhAnh;
        }

        public CuDan(DataRow row)
        {
            cuDanID = (int)row["CuDanID"];
            hoTen = row["HoTen"].ToString();
            soDienThoai = row["SoDienThoai"].ToString();
            cCCD = row["CCCD"].ToString();
            email = row["Email"].ToString();
            diaChi = row["DiaChi"].ToString();
            gioiTinh = row["GioiTinh"].ToString();
            ngaySinh = Convert.ToDateTime(row["NgaySinh"]);
            trangThai = row["TrangThai"].ToString();
            thanhToan = row["ThanhToan"].ToString();
            ngayChuyenDen = Convert.ToDateTime(row["NgayChuyenDen"]);
            HinhAnh = row["HinhAnh"] == DBNull.Value ? null : (byte[])row["HinhAnh"];
        }
    }
}
