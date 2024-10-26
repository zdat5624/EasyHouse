using DesignEasyHouse1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
    }
}
