using DesignEasyHouse1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignEasyHouse1.DAO
{
    public class ChiPhiVeSinhDAO
    {
        private static ChiPhiVeSinhDAO instance;
        public static ChiPhiVeSinhDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiPhiVeSinhDAO();
                return instance;
            }
            private set => instance = value;
        }

        public List<ChiPhi> GetDanhSachChiPhiVeSinh(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            List<ChiPhi> lst = new List<ChiPhi>();

            string query1 = "select * from ChiPhi where PhanLoai = N'Vật tư vệ sinh' and ThoiGian between  @ngayBatDau AND @ngayKetThuc";
            object[] parameters = { ngayBatDau, ngayKetThuc };
            DataTable data1 = DataProvider.Instance.ExecuteQuery(query1, parameters);

            foreach (DataRow row in data1.Rows)
            {
                ChiPhi dt = new ChiPhi(row);
                lst.Add(dt);
            }


            return lst;
        }
        public DataTable ConvertToDataTable(List<ChiPhi> lst)
        {
            DataTable table = new DataTable();

            // Define columns with English names (needed for data binding)
            table.Columns.Add("TenVatTu", typeof(string));
            table.Columns.Add("PhanLoai", typeof(string));
            table.Columns.Add("ChiPhiDuKien", typeof(double));
            table.Columns.Add("ChiPhiThucTe", typeof(double));
            table.Columns.Add("MoTa", typeof(string));
            table.Columns.Add("ThoiGian", typeof(DateTime));

            // Populate DataTable rows
            foreach (var item in lst)
            {
                table.Rows.Add(item.tenVatTu, item.phanLoai, item.chiPhiDuKien, item.chiPhiThucTe, item.mota, item.thoiGian);
            }

            // Rename columns to Vietnamese
            table.Columns["TenVatTu"].ColumnName = "Tên vật tư";
            table.Columns["PhanLoai"].ColumnName = "Phân Loại";
            table.Columns["ChiPhiDuKien"].ColumnName = "Chi phí dự kiến";
            table.Columns["ChiPhiThucTe"].ColumnName = "Chi phí thực tế";
            table.Columns["MoTa"].ColumnName = "Mô tả";
            table.Columns["ThoiGian"].ColumnName = "Thời Gian";

            return table;
        }

        public double GetTotalChiPhi(List<ChiPhi> lst)
        {
            double total = 0;
            foreach (var item in lst)
            {
                total += item.chiPhiThucTe;
            }
            return total;
        }
        public double GetChiPhiDuKien(List<ChiPhi> lst)
        {
            double total = 0;
            foreach (var item in lst)
            {
                total += item.chiPhiDuKien;
            }
            return total;
        }

    }
}
