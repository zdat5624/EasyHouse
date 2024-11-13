using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignEasyHouse1.DTO
{
    public class ChoDoXe
    {
        public int ChoDoXeID { get; set; }
        public string TrangThai { get; set; } 
        public string ViTri { get; set; } 
        public DateTime? ThoiGianVao { get; set; } 
        public DateTime? ThoiGianRa { get; set; } 

        public ChoDoXe() { }

        public ChoDoXe(int choDoXeID, string trangThai, string viTri, DateTime? thoiGianVao, DateTime? thoiGianRa)
        {
            ChoDoXeID = choDoXeID;
            TrangThai = trangThai;
            ViTri = viTri;
            ThoiGianVao = thoiGianVao;
            ThoiGianRa = thoiGianRa;
        }

        public ChoDoXe(DataRow row)
        {
            ChoDoXeID = Convert.ToInt32(row["ChoDoXeID"]);
            ViTri = row["ViTri"].ToString();
            TrangThai = row["TrangThai"].ToString();
            ThoiGianVao = row.IsNull("ThoiGianVao") ? (DateTime?)null : Convert.ToDateTime(row["ThoiGianVao"]);
            ThoiGianRa = row.IsNull("ThoiGianRa") ? (DateTime?)null : Convert.ToDateTime(row["ThoiGianRa"]);
        }
    }
}
