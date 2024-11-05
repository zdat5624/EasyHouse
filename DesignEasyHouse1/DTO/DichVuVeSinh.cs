using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignEasyHouse1.DTO
{
    public class DichVuVeSinh
    {
        private int dichVuVeSinhID;
        private string khuVucVeSinh;
        private string loaiVeSinh;
        private string kieuVeSinh;
        private string khuVucCuThe;
        private DateTime thoiGianVeSinh;
        private int cuDanID;

        public int DichVuVeSinhID { get => dichVuVeSinhID; set => dichVuVeSinhID = value; }
        public string KhuVucVeSinh { get => khuVucVeSinh; set => khuVucVeSinh = value; }
        public string LoaiVeSinh { get => loaiVeSinh; set => loaiVeSinh = value; }
        public string KieuVeSinh { get => kieuVeSinh; set => kieuVeSinh = value; }
        public string KhuVucCuThe { get => khuVucCuThe; set => khuVucCuThe = value; }
        public DateTime ThoiGianVeSinh { get => thoiGianVeSinh; set => thoiGianVeSinh = value; }
        public int CuDanID { get => cuDanID; set => cuDanID = value; }

        // Constructor không tham số
        public DichVuVeSinh() { }

        // Constructor với tham số
        public DichVuVeSinh(int dichVuVeSinhID, string khuVucVeSinh, string loaiVeSinh, string kieuVeSinh, string khuVucCuThe, DateTime thoiGianVeSinh, int cuDanID)
        {
            DichVuVeSinhID = dichVuVeSinhID;
            KhuVucVeSinh = khuVucVeSinh;
            LoaiVeSinh = loaiVeSinh;
            KieuVeSinh = kieuVeSinh;
            KhuVucCuThe = khuVucCuThe;
            ThoiGianVeSinh = thoiGianVeSinh;
            CuDanID = cuDanID;
        }

        // Constructor từ DataRow
        public DichVuVeSinh(DataRow row)
        {
            DichVuVeSinhID = (int)row["DichVuVeSinhID"];
            KhuVucVeSinh = row["KhuVucVeSinh"].ToString();
            LoaiVeSinh = row["LoaiVeSinh"].ToString();
            KieuVeSinh = row["KieuVeSinh"].ToString();
            KhuVucCuThe = row["KhuVucCuThe"].ToString();
            ThoiGianVeSinh = Convert.ToDateTime(row["ThoiGianVeSinh"]);
            CuDanID = (int)row["CuDanID"];
        }

        // Phương thức ToString
        public override string ToString()
        {
            return $"DichVuVeSinhID: {DichVuVeSinhID}, KhuVucVeSinh: {KhuVucVeSinh}, LoaiVeSinh: {LoaiVeSinh}, " +
                   $"KieuVeSinh: {KieuVeSinh}, KhuVucCuThe: {KhuVucCuThe}, ThoiGianVeSinh: {ThoiGianVeSinh}, CuDanID: {CuDanID}";
        }
    }
}
