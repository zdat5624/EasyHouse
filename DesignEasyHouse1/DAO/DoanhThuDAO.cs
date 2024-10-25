using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignEasyHouse1.DTO;

namespace DesignEasyHouse1.DAO
{
    public class DoanhThuDAO
    {
        private static DoanhThuDAO instance;
        public static DoanhThuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DoanhThuDAO();
                return instance;
            }
            private set => instance = value;
        }

        public List<DoanhThu> GetDanhSachDoanhThuVeSinh(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            List<DoanhThu> lst = new List<DoanhThu>();

            string query1 = "SELECT DoanhThuId,YeuCauID,SoTien,ThoiGian,loaiDv FROM DoanhThu WHERE loaiDv = N'Dịch vụ vệ sinh' AND (ThoiGian BETWEEN @ngayBatDau AND @ngayKetThuc )";
            object[] parameters = { ngayBatDau, ngayKetThuc };
            DataTable data1 = DataProvider.Instance.ExecuteQuery(query1, parameters);

            foreach (DataRow row in data1.Rows)
            {
                DoanhThu dt = new DoanhThu(row);
                lst.Add(dt);
            }


            return lst;
        }
        public DataTable ConvertToDataTable(List<DoanhThu> lst)
        {
            DataTable table = new DataTable();

            // Define columns with English names (needed for data binding)
            table.Columns.Add("YeuCauID", typeof(int));
            table.Columns.Add("SoTien", typeof(double));
            table.Columns.Add("ThoiGian", typeof(DateTime));

            // Populate DataTable rows
            foreach (var item in lst)
            {
                table.Rows.Add( item.yeuCauID,  item.soTien, item.ThoiGian);
            }

            // Rename columns to Vietnamese
            table.Columns["YeuCauID"].ColumnName = "Mã Yêu Cầu";
            table.Columns["SoTien"].ColumnName = "Số Tiền";
            table.Columns["ThoiGian"].ColumnName = "Thời Gian";

            return table;
        }

        public double GetTotalDoanhThu(List<DoanhThu> lst)
        {
            double total = 0;
            foreach (var item in lst)
            {
                total += item.soTien;
            }
            return total;
        }

    }
}
