using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignEasyHouse1.DTO
{
    public class ChiTietHopDongThueCanHo
    {
        private int hopDongID;
        private string maCanHo;
        private DateTime ngayBatDau;
        private DateTime? ngayKetThuc;
        private double tienThue;
        private string dieuKhoan;
        private DateTime? ngayKetThucSom;
        private string trangThai;
        private List<ThueCanHo> danhSachThueCanHo;

        public int HopDongID { get => hopDongID; set => hopDongID = value; }
        public string MaCanHo { get => maCanHo; set => maCanHo = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime? NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public double TienThue { get => tienThue; set => tienThue = value; }
        public string DieuKhoan { get => dieuKhoan; set => dieuKhoan = value; }
        public DateTime? NgayKetThucSom { get => ngayKetThucSom; set => ngayKetThucSom = value; }
        public List<ThueCanHo> DanhSachThueCanHo { get => danhSachThueCanHo; set => danhSachThueCanHo = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }

        public ChiTietHopDongThueCanHo()
        {
            DanhSachThueCanHo = new List<ThueCanHo>();
        }

        public ChiTietHopDongThueCanHo(int hopDongID, string maCanHo, DateTime ngayBatDau, DateTime? ngayKetThuc, float tienThue,
            string dieuKhoan, DateTime? ngayKetThucSom, string trangThai)
        {
            HopDongID = hopDongID;
            MaCanHo = maCanHo;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            TienThue = tienThue;
            DieuKhoan = dieuKhoan;
            NgayKetThucSom = ngayKetThucSom;
            TrangThai = trangThai;
            DanhSachThueCanHo = new List<ThueCanHo>();
        }

        public ChiTietHopDongThueCanHo(DataRow row)
        {
            HopDongID = (int)row["HopDongID"];
            MaCanHo = row["MaCanHo"].ToString();
            NgayBatDau = Convert.ToDateTime(row["NgayBatDau"]);
            NgayKetThuc = Convert.ToDateTime(row["NgayKetThuc"]);
            TienThue = Convert.ToDouble(row["TienThue"]);
            DieuKhoan = row["DieuKhoan"].ToString();
            NgayKetThucSom = row["NgayKetThucSom"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["NgayKetThucSom"]);
            TrangThai = row["TrangThai"].ToString();
            DanhSachThueCanHo = new List<ThueCanHo>();
        }

        public void AddThueCanHo(ThueCanHo tch)
        {
            this.DanhSachThueCanHo.Add(tch);
        }

        //public ChiTietHopDongThueCanHo(DataTable dataTable)
        //{
        //    DanhSachThueCanHo = new List<ThueCanHo>();

        //    foreach (DataRow row in dataTable.Rows)
        //    {
        //        if (HopDongID == 0)
        //        {
        //            HopDongID = Convert.ToInt32(row["HopDongID"]);
        //            maCanHo = row["CanHoID"].ToString();
        //            NgayBatDau = Convert.ToDateTime(row["NgayBatDau"]);
        //            NgayKetThuc = row["NgayKetThuc"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["NgayKetThuc"]);
        //            TienThue = Convert.ToDouble(row["TienThue"]);
        //            DieuKhoan = row["DieuKhoan"].ToString();
        //            NgayKetThucSom = row["NgayKetThucSom"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["NgayKetThucSom"]);
        //        }

        //        if (row["ThueCanHoID"] != DBNull.Value)
        //        {
        //            var thueCanHo = new ThueCanHo
        //            {
        //                ThueCanHoID = Convert.ToInt32(row["ThueCanHoID"]),
        //                CuDanID = Convert.ToInt32(row["CuDanID"]),
        //                HopDongID = HopDongID,
        //                VaiTro = row["VaiTro"].ToString()
        //            };
        //            DanhSachThueCanHo.Add(thueCanHo);
        //        }
        //    }
        //}

    }

    public class ThueCanHo
    {
        public int ThueCanHoID { get; set; }
        public int CuDanID { get; set; }
        public int HopDongID { get; set; }
        public string VaiTro { get; set; }

        public ThueCanHo() { }

        public ThueCanHo(int thueCanHoID, int cuDanID, int hopDongID, string vaiTro)
        {
            ThueCanHoID = thueCanHoID;
            CuDanID = cuDanID;
            HopDongID = hopDongID;
            VaiTro = vaiTro;
        }
        public ThueCanHo(DataRow row)
        {
            ThueCanHoID = (int)row["ThueCanHoID"];
            CuDanID = (int)row["CuDanID"];
            HopDongID = (int)row["HopDongID"];
            VaiTro = row["vaiTro"].ToString();
        }
    }
}
