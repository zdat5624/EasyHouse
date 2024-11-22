using System.Data;
using System;

public class ThongTinToaNha
{
    public int ID { get; set; }
    public string TenToaNha { get; set; }
    public string MoTa { get; set; }
    public string ChuDauTu { get; set; }
    public string DonViQuanLi { get; set; }
    public string ThongTinThanhToan { get; set; }
    public string ThongTinLienHeVoiCuDan { get; set; }

    public ThongTinToaNha() { }

    public ThongTinToaNha(DataRow row)
    {
        ID = Convert.ToInt32(row["ID"]);
        TenToaNha = row["TenToaNha"]?.ToString();
        MoTa = row["MoTa"]?.ToString();
        ChuDauTu = row["ChuDauTu"]?.ToString();
        DonViQuanLi = row["DonViQuanLi"]?.ToString();
        ThongTinThanhToan = row["ThongTinThanhToan"]?.ToString();
        ThongTinLienHeVoiCuDan = row["ThongTinLienHeVoiCuDan"]?.ToString();
    }
}
