CREATE DATABASE EasyHouseDB;
GO

USE EasyHouseDB;
GO

-- Bảng thông tin cư dân
CREATE TABLE CuDan (
    CuDanID INT IDENTITY PRIMARY KEY ,
    HoTen NVARCHAR(100),
    SoDienThoai NVARCHAR(15),
	CCCD NVARCHAR(15),
	Email NVARCHAR(255),
    DiaChi NVARCHAR(255),
	GioiTinh NVARCHAR(10), -- N'Nam' hoặc 'Nữ'
	NgaySinh DATE,
	TrangThai NVARCHAR(255) DEFAULT N'Còn ở', --'Còn ở' hoặc 'Chuyển đi'
	ThanhToan NVARCHAR(255) DEFAULT N'Trả đủ', --'Trả đủ' hoặc 'Nợ'
	NgayChuyenDen DATE DEFAULT GETDATE(),
	HinhAnh Image
);
GO

--SoCanHo NVARCHAR(10),
--ThanhToan NVARCHAR(255) DEFAULT N'Trả đủ', --'Trả đủ' hoặc 'Nợ'

-- Bảng thông tin cư dân
CREATE TABLE LichSuCapNhatCuDan (
	CapNhatID INT IDENTITY PRIMARY KEY,
    CuDanID INT,
    HoTen NVARCHAR(100),
    SoDienThoai NVARCHAR(15),
	CCCD NVARCHAR(15),
	Email NVARCHAR(255),
    DiaChi NVARCHAR(255),
	GioiTinh NVARCHAR(10), -- N'Nam' hoặc 'Nữ'
	NgaySinh DATE,
	TrangThai NVARCHAR(255), --'Còn ở' hoặc 'Chuyển đi'
	ThanhToan NVARCHAR(255),
	NgayChuyenDen DATE,
	HinhAnh Image,
    NgayLuu DATETIME DEFAULT GETDATE()
);
GO


CREATE TABLE CanHo (
    MaCanHo NVARCHAR(50) PRIMARY KEY,    -- Mã căn hộ
    ViTri NVARCHAR(255) NOT NULL,    -- Địa chỉ căn hộ
    DienTich FLOAT,                   -- Diện tích căn hộ
    SoPhongNgu INT,                   -- Số phòng ngủ
    SoPhongTam INT,                   -- Số phòng tắm
    TrangThai NVARCHAR(50) DEFAULT N'Trống'            -- Trạng thái căn hộ (Trống, Đang thuê, ...)
)
GO

CREATE TABLE HopDongThue (
    HopDongID INT IDENTITY PRIMARY KEY,
    CanHoID INT NOT NULL,             -- Khóa ngoại tới bảng CanHo
    NgayBatDau DATE NOT NULL,         -- Ngày bắt đầu hợp đồng
    NgayKetThuc DATE,                 -- Ngày kết thúc hợp đồng
    TienThue FLOAT,                   -- Số tiền thuê
    DieuKhoan NVARCHAR(MAX),          -- Điều khoản hợp đồng
	NgayKetThucSom DATE,
)
GO

CREATE TABLE ThueCanHo (
    ThueCanHoID INT IDENTITY PRIMARY KEY,
    CuDanID INT NOT NULL,             -- Khóa ngoại tới bảng CuDan
    HopDongID INT NOT NULL,           -- Khóa ngoại tới bảng HopDongThue
    VaiTro NVARCHAR(50),              -- Vai trò của cư dân (Người thuê, Người ở ghép,...)
)
GO

-- Bảng quản lý thông báo
CREATE TABLE ThongBao (
    ThongBaoID INT IDENTITY PRIMARY KEY,
    TieuDe NVARCHAR(255),
    NoiDung NVARCHAR(MAX),
    NgayGui DATETIME DEFAULT GETDATE(),
    LoaiThongBao NVARCHAR(50) -- 'Chung' hoặc 'Riêng'
);
GO

-- Bảng lưu thông báo riêng đến các cư dân
CREATE TABLE ThongBaoCuDan (
    ThongBaoCuDanID INT IDENTITY PRIMARY KEY,
    ThongBaoID INT,
    CuDanID INT,
);
GO

-- Bảng yêu cầu cư dân
CREATE TABLE LoaiYeuCau (
    LoaiYeuCauID INT IDENTITY PRIMARY KEY,
    TenLoaiYeuCau NVARCHAR(100),
    MoTa NVARCHAR(255)
);
GO

CREATE TABLE YeuCau (
    YeuCauID INT IDENTITY PRIMARY KEY,
    CuDanID INT,
	LoaiYeuCauID INT,
    TieuDe NVARCHAR(255),
    NoiDung NVARCHAR(MAX),
    NgayGui DATETIME DEFAULT GETDATE(),
    TrangThai NVARCHAR(50) DEFAULT N'Đang chờ xử lý', --'Đang xử lý' hoặc 'Hoàn thành'
);
GO

CREATE TABLE PhanHoiYeuCau (
    PhanHoiID INT IDENTITY PRIMARY KEY,
    YeuCauID INT,
    NguoiPhanHoiID INT DEFAULT NULL, -- Nếu người phản hồi là cư dân thì NguoiPhanHoiID = null
    NoiDung NVARCHAR(MAX),
    NgayPhanHoi DATETIME DEFAULT GETDATE()
);

-- Bảng đánh giá dịch vụ
CREATE TABLE LoaiDanhGia (
    LoaiDanhGiaID INT IDENTITY PRIMARY KEY,
    TenLoaiDanhGia NVARCHAR(100),
    MoTa NVARCHAR(255)
);
GO

CREATE TABLE DanhGiaDichVuCuDan (
    DanhGiaID INT IDENTITY PRIMARY KEY,
    CuDanID INT,
	LoaiDanhGiaID INT,
    DiemDanhGia INT, -- Từ 1 đến 5
    NoiDungDanhGia NVARCHAR(MAX),
    NgayDanhGia DATETIME DEFAULT GETDATE(),
);
GO


INSERT INTO YeuCau (CuDanID, LoaiYeuCauID, TieuDe, NoiDung)
VALUES 
(1, 101, N'Yêu cầu sửa chữa', N'Xin vui lòng sửa chữa hệ thống điện ở tầng 2.'),
(2, 102, N'Yêu cầu vệ sinh', N'Vui lòng dọn vệ sinh khu vực công cộng tầng 1.'),
(3, 101, N'Yêu cầu sửa chữa', N'Hệ thống nước bị rò rỉ ở phòng 302.');

INSERT INTO PhanHoiYeuCau (YeuCauID, NguoiPhanHoiID, NoiDung)
VALUES 
(1, 201, N'Chúng tôi đã tiếp nhận yêu cầu và sẽ xử lý trong thời gian sớm nhất.'),
(1, 202, N'Yêu cầu đã được chuyển đến bộ phận vệ sinh để xử lý.'),
(3, 201, N'Chúng tôi đã hoàn thành sửa chữa hệ thống nước tại phòng 302.'),
(1, null, N'Chúng tôi đã tiếp nhận yêu cầu và sẽ xử lý trong thời gian sớm nhất.'),
(1, null, N'Yêu cầu đã được chuyển đến bộ phận vệ sinh để xử lý.'),
(1, null, N'Chúng tôi đã hoàn thành sửa chữa hệ thống nước tại phòng 302.');

GO

INSERT INTO CanHo (MaCanHo, ViTri, DienTich, SoPhongNgu, SoPhongTam, TrangThai)
VALUES 
('CH101', 'Tòa nhà A', 85.5, 2, 2, N'Trống'),
('CH102', 'Tòa nhà B', 90.0, 3, 2, N'Trống'),
('CH103', 'Tòa nhà C', 75.0, 2, 1, N'Trống'),
('CH104', 'Tòa nhà D', 60.0, 1, 1, N'Trống'),
('CH105', 'Tòa nhà E', 120.0, 4, 3, N'Trống');


select * from CanHo