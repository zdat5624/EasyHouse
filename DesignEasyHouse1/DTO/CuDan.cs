using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignEasyHouse1.DTO
{
    public class CuDan
    {
        public int CuDanID { get; set; }
        public string HoTen { get; set; }
        public string SoDienThoai { get; set; }
        public string CCCD { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string TrangThai { get; set; }
        public string ThanhToan { get; set; }
        public DateTime NgayChuyenDen { get; set; }
        public byte[] HinhAnh { get; set; }
    }
}
