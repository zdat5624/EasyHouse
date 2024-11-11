using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignEasyHouse1.DTO
{
    public class DichVuGuiXe
    {
        private int dichVuGuiXeID;
        private int phuongTienID;
        private int choDoXeID;
        private DateTime? ngayDangKy;
        private string trangThai;

        public int DichVuGuiXeID { get => dichVuGuiXeID; set => dichVuGuiXeID = value; }
        public int PhuongTienID { get => phuongTienID; set => phuongTienID = value; }
        public int ChoDoXeID { get => choDoXeID; set => choDoXeID = value; }
        public DateTime? NgayDangKy { get => ngayDangKy; set => ngayDangKy = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }

        public DichVuGuiXe(int dichVuGuiXeID, int phuongTienID, int choDoXeID, DateTime? ngayDangKy, string trangThai)
        {
            this.dichVuGuiXeID = dichVuGuiXeID;
            this.phuongTienID = phuongTienID;
            this.choDoXeID = choDoXeID;
            this.ngayDangKy = ngayDangKy;
            this.trangThai = trangThai;
        }

        public DichVuGuiXe(DataRow row)
        {
            dichVuGuiXeID = (int)row["DichVuGuiXeID"];
            phuongTienID = (int)row["PhuongTienID"];
            choDoXeID = (int)row["ChoDoXeID"];
            ngayDangKy = Convert.ToDateTime(row["NgayDangKy"]);
            trangThai = row["TrangThai"].ToString();
        }
    }
}
