-- Tạo database
CREATE DATABASE EasyHouseDB;
GO

USE EasyHouseDB;
GO

-- Bảng thông tin cư dân
CREATE TABLE CuDan (
    CuDanID INT PRIMARY KEY IDENTITY,
    HoTen NVARCHAR(100),
    SoDienThoai NVARCHAR(15),
	Email NVARCHAR(255),
    DiaChi NVARCHAR(255),
	TrangThai NVARCHAR(255), --'Còn ở' hoặc 'Chuyển đi'
	NgayChuyenDen DATETIME DEFAULT GETDATE(),
);
GO

--SoCanHo NVARCHAR(10),
--ThanhToan NVARCHAR(255) DEFAULT N'Trả đủ', --'Trả đủ' hoặc 'Nợ'

-- Bảng thông tin cư dân
CREATE TABLE LichSuCapNhatCuDan (
	CapNhatID INT PRIMARY KEY IDENTITY,
    CuDanID INT,
    HoTen NVARCHAR(100),
    SoDienThoai NVARCHAR(15),
	Email NVARCHAR(255),
    DiaChi NVARCHAR(255),
    SoCanHo NVARCHAR(10),
	TrangThai NVARCHAR(255), --'Còn ở' hoặc 'Chuyển đi'
	NgayChuyenDen DATE,
    NgayLuu DATETIME DEFAULT GETDATE()
);
GO

-- Bảng hợp đồng thuê căn hộ
CREATE TABLE HopDongThue (
    HopDongID INT PRIMARY KEY IDENTITY,
    CuDanID INT,
	NoiDungDieuKhoan TEXT,
	TienThueMoiThang FLOAT,
	SoTienCoc FLOAT,
	NgayBatDau DATE,
    NgayHetHan DATE,
);
GO


-- Bảng quản lý thông báo
CREATE TABLE ThongBao (
    ThongBaoID INT PRIMARY KEY IDENTITY,
    TieuDe NVARCHAR(255),
    NoiDung TEXT,
    NgayGui DATETIME DEFAULT GETDATE(),
    LoaiThongBao NVARCHAR(50) -- 'Chung' hoặc 'Riêng'
);
GO

-- Bảng lưu thông báo riêng đến các cư dân
CREATE TABLE ThongBaoCuDan (
    ThongBaoCuDanID INT PRIMARY KEY IDENTITY,
    ThongBaoID INT,
    CuDanID INT,
);
GO

-- Bảng yêu cầu cư dân
CREATE TABLE LoaiYeuCau (
    LoaiYeuCauID INT PRIMARY KEY IDENTITY,
    TenLoaiYeuCau NVARCHAR(100),
    MoTa NVARCHAR(255)
);
GO

CREATE TABLE YeuCau (
    YeuCauID INT PRIMARY KEY IDENTITY,
    CuDanID INT,
	LoaiYeuCauID INT,
    TieuDe NVARCHAR(255),
    NoiDung TEXT,
    NgayGui DATETIME DEFAULT GETDATE(),
    TrangThai NVARCHAR(50) DEFAULT 'Đang chờ xử lý', --'Đang xử lý' hoặc 'Hoàn thành'
);
GO

CREATE TABLE PhanHoiTuCuDan (
    PhanHoiID INT PRIMARY KEY IDENTITY,
    YeuCauID INT,
    CuDanID NVARCHAR(50),
    NoiDung TEXT,
    NgayPhanHoi DATETIME DEFAULT GETDATE()
);
GO

CREATE TABLE PhanHoiTuQuanLy (
    PhanHoiID INT PRIMARY KEY IDENTITY,
    YeuCauID INT,
    NhanVienID INT,
    NoiDung TEXT,
    NgayPhanHoi DATETIME DEFAULT GETDATE()
);

-- Bảng đánh giá dịch vụ
CREATE TABLE LoaiDanhGia (
    LoaiDanhGiaID INT PRIMARY KEY IDENTITY,
    TenLoaiDanhGia NVARCHAR(100),
    MoTa NVARCHAR(255)
);
GO

CREATE TABLE DanhGiaDichVuCuDan (
    DanhGiaID INT PRIMARY KEY IDENTITY,
    CuDanID INT,
	LoaiDanhGiaID INT,
    DiemDanhGia INT, -- Từ 1 đến 5
    NoiDungDanhGia TEXT,
    NgayDanhGia DATETIME DEFAULT GETDATE(),
);
GO
