using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignEasyHouse1.DTO
{
    public class ChoDoXe
    {
        public int ChoDoXeID { get; set; }
        public string TrangThai { get; set; } // Example values: "Trống", "Đã sử dụng"
        public string ViTri { get; set; } // Example format: "A1", "B2", etc.
        public DateTime? ThoiGianVao { get; set; } // Nullable to account for empty entry times
        public DateTime? ThoiGianRa { get; set; } // Nullable to account for empty exit times

        // Constructor
        public ChoDoXe(int choDoXeID, string trangThai, string viTri, DateTime? thoiGianVao, DateTime? thoiGianRa)
        {
            ChoDoXeID = choDoXeID;
            TrangThai = trangThai;
            ViTri = viTri;
            ThoiGianVao = thoiGianVao;
            ThoiGianRa = thoiGianRa;
        }

        // Default constructor
        public ChoDoXe() { }
    }
}
