using DesignEasyHouse1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DesignEasyHouse1.DAO
{
    public class ChiTietHopDongThueCanHoDAO
    {
        private static ChiTietHopDongThueCanHoDAO instance;

        public static ChiTietHopDongThueCanHoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietHopDongThueCanHoDAO();
                return instance;
            }
            private set => instance = value;
        }

        private ChiTietHopDongThueCanHoDAO() { }

        public List<ChiTietHopDongThueCanHo> GetDanhSachChiTietHopDongThueCanHo()
        {
            List <ChiTietHopDongThueCanHo> lst = new List<ChiTietHopDongThueCanHo>();

            string query1 = "SELECT * FROM HopDongThue";
            DataTable data1 = DataProvider.Instance.ExecuteQuery(query1);

            foreach (DataRow row in data1.Rows)
            {
                ChiTietHopDongThueCanHo ct = new ChiTietHopDongThueCanHo(row);
                lst.Add(ct);
            }

            string query2 = "SELECT ThueCanHo.*, CuDan.HoTen FROM ThueCanHo, CuDan WHERE ThueCanHo.CuDanID = CuDan.CuDanID";
            DataTable data2 = DataProvider.Instance.ExecuteQuery(query2);

            foreach (DataRow row in data2.Rows)
            {
                ThueCanHo tch = new ThueCanHo(row);
                foreach (ChiTietHopDongThueCanHo item in lst)
                {
                    if (row["HopDongID"].Equals(item.HopDongID))
                    {
                        item.AddThueCanHo(tch);
                    }
                }
            }

            return lst;
        }

        public DataTable GetDtTbChiTietHopDongThueCanHo()
        {

            string query1 = "SELECT * FROM HopDongThue";
            DataTable data = DataProvider.Instance.ExecuteQuery(query1);

            return data;
        }

        public DataTable GetDanhSachCuDanID()
        {
            string query = "SELECT CuDan.CuDanID FROM CuDan";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public DataTable GetDanhSachMaCanHo()
        {
            string query = "SELECT CanHo.MaCanHo FROM CanHo WHERE CanHo.TrangThai = N'Trống'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public DataTable GetDanhSachMaCanHo(string maCanHo)
        {
            string query = "SELECT CanHo.MaCanHo FROM CanHo WHERE CanHo.TrangThai = N'Trống' or CanHo.MaCanHo = @MaCanHo ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {maCanHo});

            return data;
        }

        public int ThemHopDong(string MaCanHo, DateTime NgayBatDau, DateTime NgayKetThuc, double TienThue, string DieuKhoan)
        {
            string query = @"EXEC sp_ThemHopDong @MaCanHo , @NgayBatDau , @NgayKetThuc , @TienThue , @DieuKhoan ";

            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { MaCanHo, NgayBatDau, NgayKetThuc, TienThue, DieuKhoan });

            int newHopDongID = Convert.ToInt32(result);

            return newHopDongID;
        }

        public bool ThemThueCanHo(int cuDanID, int hopDongID, string vaiTro)
        {
            string query = "INSERT INTO ThueCanHo (CuDanID, HopDongID, VaiTro) VALUES ( @CuDanID , @HopDongID , @VaiTro )";
            object[] para = new object[] { cuDanID, hopDongID, vaiTro };
            int result = DataProvider.Instance.ExecuteNonQuery(query, para);
            return result > 0;
        }

        public bool XoaHopDongThue(int hopDongID)
        {
            string query = "EXEC XoaHopDongThue @HopDongID ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { hopDongID });
            return result > 0;
        }

        public bool CapNhatNgayKetThuc(int hopDongID, DateTime ngayKetThuc)
        {
            string query = "EXEC sp_UpdateNgayKetThuc @HopDongID , @NgayKetThuc ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { hopDongID, ngayKetThuc });
            return result > 0;
        }

        public bool CapNhatHopDongThue(int HopDongID, string MaCanHo, DateTime NgayBatDau, DateTime NgayKetThuc, double TienThue, string DieuKhoan)
        {
            string query = @"EXEC sp_CapNhatHopDongThue @HopDongID , @MaCanHo , @NgayBatDau , @NgayKetThuc , @TienThue , @DieuKhoan ";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {HopDongID, MaCanHo, NgayBatDau, NgayKetThuc, TienThue, DieuKhoan });

            return result> 0;
        }

        public bool XoaThueCanHoByHopDongID(int hopDongID)
        {
            string query = "DELETE FROM ThueCanHo WHERE ThueCanHo.HopDongID = @HopDongID ";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { hopDongID });

            return result > 0;
        }

    }
}
