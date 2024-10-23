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
    MaCanHo NVARCHAR(50),             -- Khóa ngoại tới bảng CanHo
    NgayBatDau DATE NOT NULL,         -- Ngày bắt đầu hợp đồng
    NgayKetThuc DATE,                 -- Ngày kết thúc hợp đồng
    TienThue FLOAT,                   -- Số tiền thuê
    DieuKhoan NVARCHAR(MAX),          -- Điều khoản hợp đồng
	NgayKetThucSom DATE,
	TrangThai NVARCHAR(50) -- "Hiệu lực" - "Kết thúc"
)
GO

CREATE TABLE ThueCanHo (
    ThueCanHoID INT IDENTITY PRIMARY KEY,
    CuDanID INT NOT NULL,             -- Khóa ngoại tới bảng CuDan
    HopDongID INT NOT NULL,           -- Khóa ngoại tới bảng HopDongThue
    VaiTro NVARCHAR(50),              -- Vai trò của cư dân (Người thuê chính, Người ở ghép,...)
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

-- Dữ liệu mẫu cho bảng CuDan
INSERT INTO CuDan (HoTen, SoDienThoai, CCCD, Email, DiaChi, GioiTinh, NgaySinh, TrangThai, ThanhToan, NgayChuyenDen, HinhAnh)
VALUES 
('Nguyen Van A', '0123456789', '123456789012', 'nguyenvana@example.com', '123 Nguyen Trai, Ha Noi', N'Nam', '1990-01-01', N'Còn ở', N'Trả đủ', GETDATE(), NULL),
('Tran Thi B', '0987654321', '987654321098', 'tranthib@example.com', '456 Le Loi, Da Nang', N'Nữ', '1992-02-02', N'Còn ở', N'Nợ', GETDATE(), NULL),
('Le Van C', '0345678901', '567890123456', 'levanc@example.com', '789 Tran Phu, Ho Chi Minh', N'Nam', '1995-03-03', N'Chuyển đi', N'Trả đủ', '2023-01-01', NULL);

INSERT INTO CanHo (MaCanHo, ViTri, DienTich, SoPhongNgu, SoPhongTam, TrangThai) VALUES
('CH001', N'Tầng 1, Block A', 50.0, 1, 1, N'Trống'),
('CH002', N'Tầng 2, Block A', 75.0, 2, 1, N'Trống'),
('CH003', N'Tầng 3, Block B', 100.0, 3, 2, N'Đang thuê'),
('CH004', N'Tầng 4, Block B', 60.0, 2, 1, N'Trống'),
('CH005', N'Tầng 5, Block C', 90.0, 2, 2, N'Đang thuê'),
('CH006', N'Tầng 6, Block C', 120.0, 4, 2, N'Trống'),
('CH007', N'Tầng 1, Block D', 55.0, 1, 1, N'Đang thuê'),
('CH008', N'Tầng 2, Block D', 80.0, 3, 2, N'Trống'),
('CH009', N'Tầng 3, Block E', 85.0, 2, 2, N'Đang thuê'),
('CH010', N'Tầng 4, Block E', 110.0, 3, 2, N'Trống'),
('CH011', N'Tầng 1, Block F', 65.0, 2, 1, N'Trống'),
('CH012', N'Tầng 2, Block F', 95.0, 2, 2, N'Đang thuê'),
('CH013', N'Tầng 3, Block G', 115.0, 3, 2, N'Trống'),
('CH014', N'Tầng 4, Block G', 130.0, 4, 3, N'Đang thuê'),
('CH015', N'Tầng 5, Block H', 140.0, 5, 3, N'Trống');

INSERT INTO HopDongThue (MaCanHo, NgayBatDau, NgayKetThuc, TienThue, DieuKhoan, NgayKetThucSom, TrangThai) VALUES
('CH001', '2023-01-01', '2024-01-01', 500, N'Thỏa thuận', NULL, N'Hiệu lực'),
('CH002', '2023-05-01', '2024-05-01', 600, N'Thỏa thuận', NULL, N'Hiệu lực'),
('CH003', '2023-01-01', '2024-01-01', 550, N'Thỏa thuận', NULL, N'Hiệu lực'),
('CH004', '2023-03-01', '2024-03-01', 450, N'Thỏa thuận', NULL, N'Hiệu lực'),
('CH005', '2023-05-01', '2024-05-01', 700, N'Thỏa thuận', NULL, N'Hiệu lực'),
('CH006', '2023-06-01', '2024-06-01', 650, N'Thỏa thuận', NULL, N'Hiệu lực'),
('CH007', '2023-07-01', '2024-07-01', 400, N'Thỏa thuận', NULL, N'Hiệu lực'),
('CH008', '2023-04-01', '2024-07-01', 500, N'Thỏa thuận', NULL, N'Hiệu lực'),
('CH009', '2023-01-15', '2024-01-15', 560, N'Thỏa thuận', NULL, N'Hiệu lực'),
('CH010', '2023-02-10', '2024-07-01', 720, N'Thỏa thuận', NULL, N'Hiệu lực'),
('CH011', '2023-05-20', '2024-05-20', 600, N'Thỏa thuận', NULL, N'Hiệu lực'),
('CH012', '2023-03-25', '2024-07-01', 630, N'Thỏa thuận', NULL, N'Hiệu lực'),
('CH013', '2023-01-30', '2024-01-30', 800, N'Thỏa thuận', NULL, N'Hiệu lực'),
('CH014', '2023-06-15', '2024-06-15', 900, N'Thỏa thuận', NULL, N'Hiệu lực'),
('CH015', '2023-07-10', '2024-07-01', 950, N'Thỏa thuận', NULL, N'Hiệu lực');

INSERT INTO ThueCanHo (CuDanID, HopDongID, VaiTro) VALUES
(1, 1, N'Người thuê chính'),   -- Giả sử CuDanID 1 là cư dân đầu tiên
(2, 2, N'Người thuê chính'),   -- Giả sử CuDanID 2 là cư dân thứ hai
(3, 3, N'Người thuê chính'),   -- Giả sử CuDanID 3 là cư dân thứ ba
(4, 4, N'Người ở ghép'),       -- Giả sử CuDanID 4 là cư dân thứ tư
(5, 5, N'Người thuê chính'),   -- Giả sử CuDanID 5 là cư dân thứ năm
(6, 6, N'Người thuê chính'),   -- Giả sử CuDanID 6 là cư dân thứ sáu
(7, 7, N'Người ở ghép'),       -- Giả sử CuDanID 7 là cư dân thứ bảy
(8, 8, N'Người thuê chính'),   -- Giả sử CuDanID 8 là cư dân thứ tám
(9, 9, N'Người ở ghép'),       -- Giả sử CuDanID 9 là cư dân thứ chín
(10, 10, N'Người thuê chính'), -- Giả sử CuDanID 10 là cư dân thứ mười
(11, 11, N'Người ở ghép'),     -- Giả sử CuDanID 11 là cư dân thứ mười một
(12, 12, N'Người thuê chính'), -- Giả sử CuDanID 12 là cư dân thứ mười hai
(13, 13, N'Người thuê chính'), -- Giả sử CuDanID 13 là cư dân thứ mười ba
(14, 14, N'Người ở ghép'),     -- Giả sử CuDanID 14 là cư dân thứ mười bốn
(15, 15, N'Người thuê chính'); -- Giả sử CuDanID 15 là cư dân thứ mười lăm


SELECT * FROM HopDongThue

SELECT * FROM ThueCanHo
