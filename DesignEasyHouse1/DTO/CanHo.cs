using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignEasyHouse1.DTO
{
    public class CanHo
    {
        private string maCanHo;
        private string viTri;
        private double dienTich;
        private int soPhongNgu;
        private int soPhongTam;
        private string trangThai;
        private int cuDanID; // Thêm thuộc tính mới

        public string MaCanHo { get => maCanHo; set => maCanHo = value; }
        public string ViTri { get => viTri; set => viTri = value; }
        public double DienTich { get => dienTich; set => dienTich = value; }
        public int SoPhongNgu { get => soPhongNgu; set => soPhongNgu = value; }
        public int SoPhongTam { get => soPhongTam; set => soPhongTam = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public int CuDanID { get => cuDanID; set => cuDanID = value; } // Getter và Setter cho thuộc tính mới

        public CanHo() { }

        public CanHo(string maCanHo, string viTri, double dienTich, int soPhongNgu, int soPhongTam, string trangThai, int cuDanID)
        {
            MaCanHo = maCanHo;
            ViTri = viTri;
            DienTich = dienTich;
            SoPhongNgu = soPhongNgu;
            SoPhongTam = soPhongTam;
            TrangThai = trangThai;
            CuDanID = cuDanID; // Khởi tạo thuộc tính mới
        }

        public CanHo(DataRow row)
        {
            MaCanHo = row["MaCanHo"].ToString();
            ViTri = row["ViTri"].ToString();
            DienTich = Convert.ToDouble(row["DienTich"]);
            SoPhongNgu = Convert.ToInt32(row["SoPhongNgu"]);
            SoPhongTam = Convert.ToInt32(row["SoPhongTam"]);
            TrangThai = row["TrangThai"].ToString();
            CuDanID = Convert.ToInt32(row["CuDanID"]); // Gán giá trị cho thuộc tính mới từ DataRow
        }
    }
}
