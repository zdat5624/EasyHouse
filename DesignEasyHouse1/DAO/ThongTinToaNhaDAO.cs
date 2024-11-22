using DesignEasyHouse1.DAO;
using System.Data;

public class ThongTinToaNhaDAO
{
    private static ThongTinToaNhaDAO instance;

    public static ThongTinToaNhaDAO Instance
    {
        get
        {
            if (instance == null)
                instance = new ThongTinToaNhaDAO();
            return instance;
        }
        private set => instance = value;
    }

    private ThongTinToaNhaDAO() { }

    public ThongTinToaNha GetThongTinToaNha()
    {
        string query = "SELECT TOP 1 * FROM ThongTinToaNha ";
        DataTable data = DataProvider.Instance.ExecuteQuery(query);

        if (data.Rows.Count > 0)
        {
            return new ThongTinToaNha(data.Rows[0]);
        }
        return null;
    }

    public bool CapNhatThongTinToaNha(ThongTinToaNha thongTinToaNha)
    {
        string query = "UPDATE ThongTinToaNha " +
                       "SET TenToaNha = @TenToaNha , MoTa = @MoTa , ChuDauTu = @ChuDauTu , " +
                       "DonViQuanLi = @DonViQuanLi , ThongTinThanhToan = @ThongTinThanhToan , ThongTinLienHeVoiCuDan = @ThongTinLienHeVoiCuDan ";

        int result = DataProvider.Instance.ExecuteNonQuery(query, new object[]
        {
        thongTinToaNha.TenToaNha,
        thongTinToaNha.MoTa,
        thongTinToaNha.ChuDauTu,
        thongTinToaNha.DonViQuanLi,
        thongTinToaNha.ThongTinThanhToan,
        thongTinToaNha.ThongTinLienHeVoiCuDan
        });

        return result > 0;
    }


    public bool ThemThongTinToaNha(ThongTinToaNha thongTinToaNha)
    {
        string query = "INSERT INTO ThongTinToaNha (TenToaNha, MoTa, ChuDauTu, DonViQuanLi, ThongTinThanhToan, ThongTinLienHeVoiCuDan) " +
                       "VALUES ( @TenToaNha , @MoTa , @ChuDauTu , @DonViQuanLi , @ThongTinThanhToan , @ThongTinLienHeVoiCuDan )";

        int result = DataProvider.Instance.ExecuteNonQuery(query, new object[]
        {
        thongTinToaNha.TenToaNha,
        thongTinToaNha.MoTa,
        thongTinToaNha.ChuDauTu,
        thongTinToaNha.DonViQuanLi,
        thongTinToaNha.ThongTinThanhToan,
        thongTinToaNha.ThongTinLienHeVoiCuDan
        });

        return result > 0;
    }

}
