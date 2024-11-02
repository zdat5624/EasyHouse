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
	TrangThai NVARCHAR(50) DEFAULT N'Hiệu lực' -- "Hiệu lực" - "Kết thúc"
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

CREATE PROCEDURE sp_ThemHopDong
    @MaCanHo NVARCHAR(50),
    @NgayBatDau DATE,
    @NgayKetThuc DATE,
    @TienThue FLOAT,
    @DieuKhoan NVARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO HopDongThue (MaCanHo, NgayBatDau, NgayKetThuc, TienThue, DieuKhoan)
    VALUES (@MaCanHo, @NgayBatDau, @NgayKetThuc, @TienThue, @DieuKhoan);

	SELECT SCOPE_IDENTITY() AS NewHopDongID;

	-- Cập nhật trạng thái căn hộ
	UPDATE CanHo SET TrangThai = N'Đang thuê' WHERE MaCanHo = @MaCanHo; 
END

GO

CREATE PROCEDURE XoaHopDongThue
    @HopDongID INT
AS
BEGIN
    -- Kiểm tra xem hợp đồng có tồn tại không
    IF EXISTS (SELECT 1 FROM HopDongThue WHERE HopDongID = @HopDongID)
    BEGIN
        -- Xóa các bản ghi trong bảng ThueCanHo liên quan đến hợp đồng
        DELETE FROM ThueCanHo WHERE HopDongID = @HopDongID;

        -- Xóa hợp đồng khỏi bảng HopDongThue
        DELETE FROM HopDongThue WHERE HopDongID = @HopDongID;
    END
END
GO

CREATE PROCEDURE sp_UpdateNgayKetThuc
    @HopDongID INT,
    @NgayKetThuc DATE
AS
BEGIN
    -- Cập nhật ngày kết thúc
    UPDATE HopDongThue SET HopDongThue.NgayKetThuc = @NgayKetThuc WHERE HopDongThue.HopDongID = @HopDongID;

    -- Cập nhật trạng thái hợp đồng nếu ngày kết thúc nhỏ hơn hoặc bằng ngày hiện tại
    UPDATE HopDongThue
    SET TrangThai = N'Kết thúc'
    WHERE HopDongID = @HopDongID AND @NgayKetThuc <= GETDATE();
END;
GO

CREATE PROCEDURE sp_CapNhatHopDongThue
    @HopDongID INT,
    @MaCanHo NVARCHAR(50),
    @NgayBatDau DATE,
    @NgayKetThuc DATE,
    @TienThue FLOAT,
    @DieuKhoan NVARCHAR(MAX)
AS
BEGIN
    -- Cập nhật thông tin hợp đồng
    UPDATE HopDongThue
    SET MaCanHo = @MaCanHo,
        NgayBatDau = @NgayBatDau,
        NgayKetThuc = @NgayKetThuc,
        TienThue = @TienThue,
        DieuKhoan = @DieuKhoan,
        TrangThai = CASE 
            WHEN @NgayKetThuc <= GETDATE() THEN N'Kết thúc'
            ELSE N'Hiệu lực'
        END
    WHERE HopDongID = @HopDongID;
END;
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
GO

INSERT INTO CanHo (MaCanHo, ViTri, DienTich, SoPhongNgu, SoPhongTam, TrangThai) VALUES
('CH001', N'Tầng 1, Block A', 50.0, 1, 1, N'Trống'),
('CH002', N'Tầng 2, Block A', 75.0, 2, 1, N'Trống'),
('CH003', N'Tầng 3, Block B', 100.0, 3, 2, N'Trống'),
('CH004', N'Tầng 4, Block B', 60.0, 2, 1, N'Trống'),
('CH005', N'Tầng 5, Block C', 90.0, 2, 2, N'Trống'),
('CH006', N'Tầng 6, Block C', 120.0, 4, 2, N'Trống'),
('CH007', N'Tầng 1, Block D', 55.0, 1, 1, N'Trống'),
('CH008', N'Tầng 2, Block D', 80.0, 3, 2, N'Trống'),
('CH009', N'Tầng 3, Block E', 85.0, 2, 2, N'Trống'),
('CH010', N'Tầng 4, Block E', 110.0, 3, 2, N'Trống'),
('CH011', N'Tầng 1, Block F', 65.0, 2, 1, N'Trống'),
('CH012', N'Tầng 2, Block F', 95.0, 2, 2, N'Trống'),
('CH013', N'Tầng 3, Block G', 115.0, 3, 2, N'Trống'),
('CH014', N'Tầng 4, Block G', 130.0, 4, 3, N'Trống'),
('CH015', N'Tầng 5, Block H', 140.0, 5, 3, N'Trống');
GO

EXEC sp_ThemHopDong 'CH001', '2023-01-01', '2024-01-01', 500, N'Thỏa thuận'
EXEC sp_ThemHopDong 'CH002', '2023-05-01', '2024-05-01', 600, N'Thỏa thuận'
EXEC sp_ThemHopDong 'CH003', '2023-01-01', '2024-01-01', 550, N'Thỏa thuận'
GO

INSERT INTO ThueCanHo (CuDanID, HopDongID, VaiTro) VALUES
(1, 1, N'Người thuê chính'),   -- Giả sử CuDanID 1 là cư dân đầu tiên
(2, 2, N'Người thuê chính'),   -- Giả sử CuDanID 2 là cư dân thứ hai
(3, 3, N'Người thuê chính')   -- Giả sử CuDanID 3 là cư dân thứ ba
GO

--Bảng thuộc module vệ sinh 

--bảng doanh thu 
CREATE TABLE DoanhThu (
    DoanhThuId INT PRIMARY KEY,        -- Khóa chính
    YeuCauID INT,                      -- Khóa ngoại tham chiếu đến bảng Yêu Cầu
    loaiDv NVARCHAR(100),               -- Loại dịch vụ
    SoTien DECIMAL(15, 2),             -- Số tiền doanh thu
    thoiGian DATETIME,                 -- Thời gian phát sinh doanh thu
    --CONSTRAINT FK_YeuCau FOREIGN KEY (YeuCauID) REFERENCES YeuCau(YeuCauID)  -- Khóa ngoại tham chiếu đến bảng YeuCau
);
GO 



--Thêm dữ liệu mẫu vào bảng doanh thu 
INSERT INTO DoanhThu (DoanhThuId, YeuCauID, loaiDv, SoTien, thoiGian)
VALUES 
(1, 101, N'Dịch vụ vệ sinh', 500000, '2024-10-01'),
(2, 102, N'Thi công sửa chữa', 1200000, '2024-10-02'),
(3, 103, N'Gửi xe', 2500000, '2024-10-03 11:00:00'),
(4, 104, N'Dịch vụ vệ sinh', 500000, '2024-10-03');


--Bảng Chi phí 

CREATE TABLE ChiPhi (
    ChiPhiId INT PRIMARY KEY IDENTITY(1,1),
    TenVatTu NVARCHAR(100) NOT NULL,
    PhanLoai NVARCHAR(50),
    ChiPhiDuKien DECIMAL(18, 2),
    ChiPhiThucTe DECIMAL(18, 2),
    Mota NVARCHAR(255),
    ThoiGian DATETIME
);

INSERT INTO ChiPhi VALUES
	(N'Xi măng', N'Vật liệu xây dựng', 500000, 520000, N'Xi măng dùng cho móng nhà', '2024-01-15'),
    (N'Gạch đỏ', N'Vật liệu xây dựng', 300000, 290000, N'Gạch xây tường', '2024-02-10'),
    (N'Sắt thép', N'Vật liệu xây dựng', 800000, 850000, N'Sắt thép cho khung nhà', '2024-03-05'),
	(N'Chổi nhà vệ sinh', N'vật tư vệ sinh', 800000, 850000, N'Chổi cho nhà vệ sinh', '2024-03-05');

SELECT * FROM HopDongThue;

exec sp_UpdateNgayKetThuc 1, '2025-5-5'