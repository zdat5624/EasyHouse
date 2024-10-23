using DesignEasyHouse1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignEasyHouse1.DAO
{
    public class ChiTietHopDongTheCanHoDAO
    {
        private static ChiTietHopDongTheCanHoDAO instance;

        public static ChiTietHopDongTheCanHoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietHopDongTheCanHoDAO();
                return instance;
            }
            private set => instance = value;
        }

        private ChiTietHopDongTheCanHoDAO() { }

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

            string query2 = "SELECT * FROM ThueCanHo";
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
