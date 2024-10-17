using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignEasyHouse1.DTO
{
    public class LichSuCapNhatCuDan
    {
        private int capNhatID;
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
        private DateTime ngayLuu;

        public int CapNhatID { get => capNhatID; set => capNhatID = value; }
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
        public DateTime NgayLuu { get => ngayLuu; set => ngayLuu = value; }

        public LichSuCapNhatCuDan(int capNhatID, int cuDanID, string hoTen, string soDienThoai, string cCCD, string email,
                     string diaChi, string gioiTinh, DateTime ngaySinh, string trangThai,
                     string thanhToan, DateTime ngayChuyenDen, byte[] hinhAnh, DateTime ngayLuu)
        {
            this.CapNhatID = capNhatID;
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
            this.ngayLuu = ngayLuu;
        }

        public LichSuCapNhatCuDan(DataRow row)
        {
            this.capNhatID = (int)row["CapNhatID"];
            this.cuDanID = (int)row["CuDanID"];
            this.hoTen = row["HoTen"].ToString();
            this.soDienThoai = row["SoDienThoai"].ToString();
            this.cCCD = row["CCCD"].ToString();
            this.email = row["Email"].ToString();
            this.diaChi = row["DiaChi"].ToString();
            this.gioiTinh = row["GioiTinh"].ToString();
            this.ngaySinh = Convert.ToDateTime(row["NgaySinh"]);
            this.trangThai = row["TrangThai"].ToString();
            this.thanhToan = row["ThanhToan"].ToString();
            this.ngayChuyenDen = Convert.ToDateTime(row["NgayChuyenDen"]);
            this.HinhAnh = row["HinhAnh"] == DBNull.Value ? null : (byte[])row["HinhAnh"];
            this.NgayLuu = Convert.ToDateTime(row["NgayLuu"]);
        }
    }
}
