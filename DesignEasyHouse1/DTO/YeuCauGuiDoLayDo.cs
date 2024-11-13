using System.Data;
using System;

public class YeuCauGuiDoLayDo
{
    public int Id { get; set; }
    public int CuDanID { get; set; }
    public string LoaiYeuCau { get; set; }
    public string NoiDungYeuCau { get; set; }
    public int? NhanVienID { get; set; } // Có thể null nếu chưa phản hồi
    public string KetQua { get; set; }
    public string NoiDungPhanHoi { get; set; }
    public string TrangThai { get; set; }
    public DateTime NgayGui { get; set; } // Ngày gửi yêu cầu
    public DateTime? NgayPhanHoi { get; set; } // Ngày phản hồi (có thể null nếu chưa phản hồi)

    // Constructor không tham số
    public YeuCauGuiDoLayDo() { }

    // Constructor từ DataRow
    public YeuCauGuiDoLayDo(DataRow row)
    {
        Id = Convert.ToInt32(row["id"]);
        CuDanID = Convert.ToInt32(row["CuDanID"]);
        LoaiYeuCau = row["LoaiYeuCau"].ToString();
        NoiDungYeuCau = row["NoiDungYeuCau"].ToString();
        NhanVienID = row["NhanVienID"] != DBNull.Value ? Convert.ToInt32(row["NhanVienID"]) : (int?)null;
        KetQua = row["KetQua"]?.ToString();
        NoiDungPhanHoi = row["NoiDungPhanHoi"]?.ToString();
        TrangThai = row["TrangThai"].ToString();
        NgayGui = Convert.ToDateTime(row["NgayGui"]);
        NgayPhanHoi = row["NgayPhanHoi"] != DBNull.Value ? Convert.ToDateTime(row["NgayPhanHoi"]) : (DateTime?)null;
    }
}
