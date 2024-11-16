using System.Data;
using System;

public class YeuCauThiCong
{
    public int Id { get; set; }
    public int CuDanID { get; set; }
    public string LoaiYeuCau { get; set; }
    public string NoiDungYeuCau { get; set; }
    public int? NhanVienID { get; set; }
    public string KetQua { get; set; }
    public string NoiDungPhanHoi { get; set; }
    public string TrangThai { get; set; }
    public DateTime NgayGui { get; set; }
    public DateTime? NgayPhanHoi { get; set; }

    public YeuCauThiCong() { }

    public YeuCauThiCong(DataRow row)
    {
        Id = (int)row["id"];
        CuDanID = (int)row["CuDanID"];
        LoaiYeuCau = row["LoaiYeuCau"].ToString();
        NoiDungYeuCau = row["NoiDungYeuCau"].ToString();
        NhanVienID = row["NhanVienID"] != DBNull.Value ? (int?)row["NhanVienID"] : null;
        KetQua = row["KetQua"].ToString();
        NoiDungPhanHoi = row["NoiDungPhanHoi"].ToString();
        TrangThai = row["TrangThai"].ToString();
        NgayGui = (DateTime)row["NgayGui"];
        NgayPhanHoi = row["NgayPhanHoi"] != DBNull.Value ? (DateTime?)row["NgayPhanHoi"] : null;
    }
}
