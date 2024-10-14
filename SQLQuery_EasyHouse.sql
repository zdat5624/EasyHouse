CREATE DATABASE EasyHouseDB;
GO

USE EasyHouseDB;
GO

-- Bảng thông tin cư dân
CREATE TABLE CuDan (
    CuDanID INT IDENTITY PRIMARY KEY ,
    HoTen NVARCHAR(100),
    SoDienThoai NVARCHAR(15),
	CMND NVARCHAR(15),
	Email NVARCHAR(255),
    DiaChi NVARCHAR(255),
	TrangThai NVARCHAR(255), --'Còn ở' hoặc 'Chuyển đi'
	ThanhToan NVARCHAR(255) DEFAULT N'Trả đủ', --'Trả đủ' hoặc 'Nợ'
	NgayChuyenDen DATETIME DEFAULT GETDATE(),
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
    HopDongID INT IDENTITY PRIMARY KEY,
    CuDanID INT,
	NoiDungDieuKhoan NVARCHAR(MAX),
	TienThueMoiThang FLOAT,
	SoTienCoc FLOAT,
	NgayBatDau DATE,
    NgayHetHan DATE,
);
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
    TrangThai NVARCHAR(50) DEFAULT 'Đang chờ xử lý', --'Đang xử lý' hoặc 'Hoàn thành'
);
GO

CREATE TABLE PhanHoiYeuCau (
    PhanHoiID INT IDENTITY PRIMARY KEY,
    YeuCauID INT,
    NguoiPhanHoiID INT, -- Nếu người phản hồi là cư dân thì NguoiPhanHoiID = null
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


insert into CuDan (HoTen,SoDienThoai,Email,DiaChi,TrangThai)
values ('le thanh dat 1','352352352 1','dfaf@gmail.com 1','Q 7 1', N'Còn ở'),
('le thanh dat 2','352352352 2','dfaf@gmail.com 2','Q 7 2', N'Còn ở'),
('le thanh dat 3','352352352 3','dfaf@gmail.com 3','Q 7 3', N'Còn ở'),
('le thanh dat 4','352352352 4','dfaf@gmail.com 4','Q 7 4', N'Còn ở')
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

-- Thêm dữ liệu mẫu vào bảng CuDan
INSERT INTO CuDan (HoTen, SoDienThoai, Email, DiaChi, CMND, TrangThai, ThanhToan, NgayChuyenDen, HinhAnh)
VALUES 
(N'Nguyễn Văn A', '0912345678', 'nguyenvana@example.com', N'123 Đường ABC, Phường 1, Quận 1, TP.HCM', '123456789', N'Còn ở', N'Trả đủ', '2023-05-01', NULL),
(N'Trần Thị B', '0938765432', 'tranthib@example.com', N'456 Đường DEF, Phường 2, Quận 2, TP.HCM', '987654321', N'Còn ở', N'Nợ', '2023-06-10', NULL),
(N'Lê Văn C', '0987654321', 'levanc@example.com', N'789 Đường GHI, Phường 3, Quận 3, TP.HCM', '111222333', N'Chuyển đi', N'Trả đủ', '2023-04-15', NULL),
(N'Phạm Thị D', '0909090909', 'phamthid@example.com', N'12 Đường JKL, Phường 4, Quận 4, TP.HCM', '444555666', N'Còn ở', N'Nợ', '2023-08-01', NULL),
(N'Hoàng Văn E', '0922233344', 'hoangvane@example.com', N'56 Đường MNO, Phường 5, Quận 5, TP.HCM', '777888999', N'Còn ở', N'Trả đủ', '2023-09-05', NULL),
(N'Ngô Thị F', '0945678901', 'ngothif@example.com', N'34 Đường PQR, Phường 6, Quận 6, TP.HCM', '112233445', N'Chuyển đi', N'Nợ', '2022-12-20', NULL),
(N'Võ Văn G', '0911223344', 'vovang@example.com', N'99 Đường STU, Phường 7, Quận 7, TP.HCM', '556677889', N'Còn ở', N'Trả đủ', '2023-01-10', NULL),
(N'Đinh Thị H', '0966677889', 'dinhthih@example.com', N'22 Đường VWX, Phường 8, Quận 8, TP.HCM', '334455667', N'Còn ở', N'Nợ', '2023-03-15', NULL);


GO

SELECT * FROM CuDan