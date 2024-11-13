﻿CREATE DATABASE EasyHouseDB;
GO

USE EasyHouseDB;
GO

--Bảng user lưu thông tin đăng nhập của toàn bộ người dùng 
CREATE TABLE users (
    id INT IDENTITY PRIMARY KEY,
    TenDangNhap VARCHAR(255) NOT NULL,
    MatKhau VARCHAR(255) NOT NULL
);
--INSERT INTO users (TenDangNhap, MatKhau)
--VALUES ('vana@example.com', '123')
--,('thib@example.com', '123');
GO



-- Bảng thông tin cư dân
CREATE TABLE CuDan (
    CuDanID INT IDENTITY(1000,1) PRIMARY KEY,
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
	HinhAnh Image,
	UserId INT  
);
GO


CREATE TABLE NhanVien (
    id INT PRIMARY KEY IDENTITY(100,1),  -- Khóa chính, tự tăng
    Ten NVARCHAR(100) NOT NULL,        -- Tên nhân viên
    ChucVu NVARCHAR(50) NOT NULL,      -- Chức vụ
    NgaySinh DATE,                     -- Ngày sinh
    DiaChi NVARCHAR(255),              -- Địa chỉ
    DienThoai NVARCHAR(15),            -- Số điện thoại
    Email NVARCHAR(100),                -- Email
    NgayTuyenDung DATE,                -- Ngày tuyển dụng
    Luong DECIMAL(18, 2),              -- Lương
    PhongBan NVARCHAR(50),             -- Phòng ban
    UserId INT                         -- ID người dùng, có thể là khóa ngoại tham chiếu đến bảng users
);

--Thêm nhân viên
INSERT INTO nhanvien (Ten, ChucVu, NgaySinh, DiaChi, DienThoai, Email, NgayTuyenDung, Luong, PhongBan)
VALUES 
    ('Nguyen Van A', 'Quản lý', '1985-05-10', 'Hà Nội', '1', '1', '2020-01-01', 10000000, N'Vệ Sinh');

INSERT INTO nhanvien (Ten, ChucVu, NgaySinh, DiaChi, DienThoai, Email, NgayTuyenDung, Luong, PhongBan)
VALUES 
    ('Nguyen Van B', 'Quản lý', '1985-05-10', 'Hà Nội', 'qlcudan', 'qlcudan', '2020-01-01', 10000000, N'Quản lý cư dân');


INSERT INTO nhanvien (Ten, ChucVu, NgaySinh, DiaChi, DienThoai, Email, NgayTuyenDung, Luong, PhongBan)
VALUES 
    ('Nguyen Van c', 'Quản lý', '1985-05-10', 'Hà Nội', 'thicong', 'thicong', '2020-01-01', 10000000, N'Quản lý dự án thi công');

INSERT INTO nhanvien (Ten, ChucVu, NgaySinh, DiaChi, DienThoai, Email, NgayTuyenDung, Luong, PhongBan)
VALUES 
    ('Nguyen Van c', 'Quản lý', '1985-05-10', 'Hà Nội', 'vesinh', 'vesinh', '2020-01-01', 10000000, N'Vệ sinh');


CREATE TABLE ThongBao (
    id INT PRIMARY KEY IDENTITY,
    TieuDe NVARCHAR(255) NOT NULL,
    NoiDung NVARCHAR(MAX),
	LoaiThongBao NVARCHAR(255),
    ThoiGian DATETIME DEFAULT GETDATE(),
    UsersId INT,
	YeuCauId INT
);



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
--CREATE TABLE ThongBao (
  --  ThongBaoID INT IDENTITY PRIMARY KEY,
    --TieuDe NVARCHAR(255),
    --NoiDung NVARCHAR(MAX),
    --NgayGui DATETIME DEFAULT GETDATE(),
    --LoaiThongBao NVARCHAR(50) -- 'Chung' hoặc 'Riêng'
--);
--GO

-- Bảng lưu thông báo riêng đến các cư dân
CREATE TABLE ThongBaoCuDan (
    ThongBaoCuDanID INT IDENTITY PRIMARY KEY,
    ThongBaoID INT,
    CuDanID INT,
);
GO


CREATE TABLE YeuCau (
    YeuCauID INT IDENTITY PRIMARY KEY,
    CuDanID INT,
	DichvuId INT,
    TieuDe NVARCHAR(255),
    NoiDung NVARCHAR(MAX),
    NgayGui DATETIME DEFAULT GETDATE(),
    TrangThai NVARCHAR(50) DEFAULT N'Đang chờ xử lý', --'Đang xử lý' hoặc 'Hoàn thành',
	ThanhToan NVARCHAR(50) DEFAULT N'chưa thanh toán'
);
GO


CREATE TABLE DichVuVeSinh (
    DichVuVeSinhID INT PRIMARY KEY IDENTITY(1,1),  -- ID tự tăng
    KhuVucVeSinh NVARCHAR(100),                     -- Khu vực vệ sinh chung
    LoaiVeSinh NVARCHAR(50), 
	KieuVeSinh NVARCHAR(50),                       -- Loại vệ sinh (Vệ sinh hàng ngày, vệ sinh định kỳ...)
    KhuVucCuThe NVARCHAR(255),                      -- Khu vực cụ thể cần vệ sinh
    ThoiGianVeSinh DATETIME,                        -- Thời gian vệ sinh
    CuDanID INT                                      -- ID của cư dân
);

CREATE TABLE DanhGia (
    id INT PRIMARY KEY ,
    YeuCauId INT NOT NULL,
    ThaiDoPhucVu VARCHAR(255),
    PhanHoiChiTiet TEXT,
    ThoiGianHoanThanh DATETIME
    --FOREIGN KEY (YeuCauId) REFERENCES YeuCau(id)
);

CREATE TABLE PhanCong (
    id INT PRIMARY KEY ,
    YeuCauId INT NOT NULL,
    NhanVienId INT NOT NULL,
	ThoiGianPhanCong DATETIME
);





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






INSERT INTO PhanHoiYeuCau (YeuCauID, NguoiPhanHoiID, NoiDung)
VALUES 
(1, 201, N'Chúng tôi đã tiếp nhận yêu cầu và sẽ xử lý trong thời gian sớm nhất.'),
(1, 202, N'Yêu cầu đã được chuyển đến bộ phận vệ sinh để xử lý.'),
(3, 201, N'Chúng tôi đã hoàn thành sửa chữa hệ thống nước tại phòng 302.'),
(1, null, N'Chúng tôi đã tiếp nhận yêu cầu và sẽ xử lý trong thời gian sớm nhất.'),
(1, null, N'Yêu cầu đã được chuyển đến bộ phận vệ sinh để xử lý.'),
(1, null, N'Chúng tôi đã hoàn thành sửa chữa hệ thống nước tại phòng 302.');

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



---trigger thêm yêu cầu- dịch vụ vệ sinh 
CREATE TRIGGER trg_AfterInsertDichVuVeSinh
ON DichVuVeSinh
AFTER INSERT
AS
BEGIN
    INSERT INTO YeuCau (CuDanID, DichvuId, TieuDe, NoiDung, NgayGui)
    SELECT 
        CuDanID,
        DichVuVeSinhID,  -- Giả sử DichVuVeSinhID là ID của dịch vụ vệ sinh tương ứng
        N'Yêu cầu vệ sinh',
        KhuVucCuThe + N' cần được vệ sinh vào ' + CONVERT(NVARCHAR(20), ThoiGianVeSinh, 120),
        GETDATE()
    FROM 
        inserted;  -- Bảng ảo chứa các bản ghi mới được thêm vào
END;

GO
--khi thêm nhân viên vào thì tự động cũng sẽ có account đăng nhập, tên đăng nhập là email , mật khẩu là số điện thoại  
CREATE TRIGGER trg_AfterInsertNhanVien
ON NhanVien
AFTER INSERT
AS
BEGIN
    -- Tạo bảng tạm để lưu ID vừa được tạo từ bảng Users
    DECLARE @InsertedUsers TABLE (UserId INT);

    -- Thêm dữ liệu vào bảng Users và lưu ID vào bảng tạm
    INSERT INTO Users (TenDangNhap, MatKhau)
    OUTPUT INSERTED.Id INTO @InsertedUsers(UserId)
    SELECT i.Email, i.DienThoai
    FROM inserted i
    WHERE i.Email IS NOT NULL AND i.DienThoai IS NOT NULL;

    -- Cập nhật UserId trong bảng NhanVien bằng giá trị từ bảng tạm
    UPDATE NhanVien
    SET UserId = (SELECT UserId FROM @InsertedUsers)
    FROM inserted i
    WHERE NhanVien.id = i.id;
END;
GO

CREATE TRIGGER trg_AfterInsertCuDan
ON CuDan
AFTER INSERT
AS
BEGIN
    -- Tạo bảng tạm để lưu ID vừa được tạo từ bảng Users
    DECLARE @InsertedUsers TABLE (UserId INT);

    -- Thêm dữ liệu vào bảng Users và lưu ID vào bảng tạm
    INSERT INTO Users (TenDangNhap, MatKhau)
    OUTPUT INSERTED.Id INTO @InsertedUsers(UserId)
    SELECT i.Email, i.SoDienThoai
    FROM inserted i
    WHERE i.Email IS NOT NULL AND i.SoDienThoai IS NOT NULL;

    -- Cập nhật UserId trong bảng CuDan bằng giá trị từ bảng tạm
    UPDATE CuDan
    SET UserId = (SELECT UserId FROM @InsertedUsers)
    FROM inserted i
    WHERE CuDan.CuDanID = i.CuDanID;
END;



--triggers tự động phân việc cho nhân viên khi trạng thái yêu cầu thay đổi thành "Nhân viên vệ sinh sẽ xử lý đúng lịch đã đăng ký"
CREATE TRIGGER trg_UpdateYeuCauTrangThai
ON YeuCau
AFTER UPDATE
AS
BEGIN
    -- Only proceed if the TrangThai is updated to 'Đang chờ  xử lý'
    IF UPDATE(TrangThai)
    BEGIN
        DECLARE @YeuCauID INT, @NhanVienID INT, @ThoiGianPhanCong DATETIME;
        
        -- Get the YeuCauID and the ThoiGianVeSinh from DichVuVeSinh
        SELECT 
            @YeuCauID = YeuCauID,
            @ThoiGianPhanCong = dv.ThoiGianVeSinh
        FROM INSERTED i
        JOIN DichVuVeSinh dv ON i.DichvuId = dv.DichVuVeSinhID
        WHERE i.TrangThai = N'Nhân viên vệ sinh sẽ xử lý đúng lịch đã đăng ký';
        
        -- Assuming the employee is the one responsible for cleaning service
        SELECT @NhanVienID = id  -- Use 'id' instead of 'NhanVienId'
        FROM NhanVien
        WHERE ChucVu = N'Nhân viên' AND PhongBan = N'Vệ Sinh';  -- Adjust this condition depending on how employees are assigned
        
        -- Check if the employee is already assigned to a task on the same day and time
        IF NOT EXISTS (
            SELECT 1
            FROM PhanCong
            WHERE NhanVienId = @NhanVienID
            AND ThoiGianPhanCong = @ThoiGianPhanCong
        )
        BEGIN
            -- Insert the new record into PhanCong table
            INSERT INTO PhanCong (YeuCauId, NhanVienId, ThoiGianPhanCong)
            VALUES (@YeuCauID, @NhanVienID, @ThoiGianPhanCong);
        END
    END
END;







--Them người dùng là cư dân 
CREATE TRIGGER trg_AfterInsertCuDan
ON CuDan
AFTER INSERT
AS
BEGIN
    -- Tạo bảng tạm để lưu ID vừa được tạo từ bảng Users
    DECLARE @InsertedUsers TABLE (UserId INT);

    -- Thêm dữ liệu vào bảng Users và lưu ID vào bảng tạm
    INSERT INTO Users (TenDangNhap, MatKhau)
    OUTPUT INSERTED.Id INTO @InsertedUsers(UserId)
    SELECT i.Email, i.SoDienThoai
    FROM inserted i
    WHERE i.Email IS NOT NULL AND i.SoDienThoai IS NOT NULL;

    -- Cập nhật UserId trong bảng CuDan bằng giá trị từ bảng tạm
    UPDATE CuDan
    SET UserId = (SELECT UserId FROM @InsertedUsers)
    FROM inserted i
    WHERE CuDan.UserId = i.UserId;
END;

-- trigger thêm thông báo khi có yêu cầu đc thêm , từ  phía cư dân , show ở thông báo cư dân 
CREATE TRIGGER trg_ThongBaoYeuCauMoi
ON YeuCau
AFTER INSERT
AS
BEGIN
    -- Thêm thông báo cho mỗi yêu cầu mới được thêm vào
    INSERT INTO ThongBao (TieuDe, NoiDung, ThoiGian, UsersId, YeuCauId)
    SELECT 
        inserted.TieuDe, 
        inserted.NoiDung, 
        GETDATE(), 
        u.id, 
        inserted.YeuCauID
    FROM 
        inserted
	JOIN 
        CuDan c ON c.CuDanId = inserted.CuDanID
    JOIN 
        users u ON u.id = c.UserId; -- Giả sử CuDanID trong bảng YeuCau tham chiếu đến ID trong bảng users
END;
GO


--trigger thông báo cho cư dân khi hoàn thành yêu cầu 
CREATE TRIGGER trg_YeuCau_HoanThanh_ThongBao
ON YeuCau
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Thêm thông báo cho các yêu cầu có trạng thái cập nhật thành "Hoàn thành"
    INSERT INTO ThongBao (TieuDe, NoiDung, ThoiGian, UsersId, YeuCauId)
    SELECT 
		CONCAT(N'Hoàn thành yêu cầu có mã :',i.YeuCauID ),                               -- Tiêu đề thông báo
        N'vui lòng thanh toán phi dịch vụ : 100.000 đồng', -- Nội dung thông báo
        GETDATE(),                                           -- Thời gian hiện tại
        c.UserId,                                           -- User ID của cư dân từ bảng CuDan
        i.YeuCauID                                           -- ID của yêu cầu
    FROM 
        Inserted i
    JOIN 
        CuDan c ON c.CuDanID = i.CuDanID                    -- Liên kết với bảng CuDan để lấy UsersId
    WHERE 
        i.TrangThai = N'Hoàn thành'                         -- Kiểm tra trạng thái cập nhật là "Hoàn thành"
        AND (SELECT TrangThai FROM Deleted d WHERE d.YeuCauID = i.YeuCauID) <> N'Hoàn thành';
    -- Chỉ thực hiện khi trạng thái thay đổi từ khác "Hoàn thành" sang "Hoàn thành"
END;
GO

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
GO
-- Dữ liệu mẫu cho bảng CuDan
INSERT INTO CuDan (HoTen, SoDienThoai, CCCD, Email, DiaChi, GioiTinh, NgaySinh, TrangThai, ThanhToan, NgayChuyenDen, HinhAnh)
VALUES 
('Nguyen Van A', '0123456789', '123456789012', 'nguyenvana@example.com', '123 Nguyen Trai, Ha Noi', N'Nam', '1990-01-01', N'Còn ở', N'Trả đủ', GETDATE(), NULL),
('Tran Thi B', '0987654321', '987654321098', 'tranthib@example.com', '456 Le Loi, Da Nang', N'Nữ', '1992-02-02', N'Còn ở', N'Nợ', GETDATE(), NULL),
('Le Van C', '0345678901', '567890123456', 'levanc@example.com', '789 Tran Phu, Ho Chi Minh', N'Nam', '1995-03-03', N'Chuyển đi', N'Trả đủ', '2023-01-01', NULL);
GO
INSERT INTO NhanVien(Ten, ChucVu, NgaySinh, DiaChi, DienThoai, Email, NgayTuyenDung, Luong, PhongBan)
VALUES 
('Nguyen Van A', 'Quản lý', '1985-05-10', 'Hà Nội', '2', '2', '2020-01-01', 10000000, N'Vệ Sinh');

INSERT INTO NhanVien(Ten, ChucVu, NgaySinh, DiaChi, DienThoai, Email, NgayTuyenDung, Luong, PhongBan)
VALUES 
('Nguyen Van A', 'Quản lý', '1985-05-10', 'Hà Nội', '1', '1', '2020-01-01', 10000000, N'Quản lý cư dân');

INSERT INTO NhanVien(Ten, ChucVu, NgaySinh, DiaChi, DienThoai, Email, NgayTuyenDung, Luong, PhongBan)
VALUES 
('Nguyen Van A', 'Quản lý', '1985-05-10', 'Hà Nội', '3', '3', '2020-01-01', 10000000, N'Quản lý dự án thi công');

INSERT INTO NhanVien(Ten, ChucVu, NgaySinh, DiaChi, DienThoai, Email, NgayTuyenDung, Luong, PhongBan)
VALUES 
('Nguyen Van A', 'Quản lý', '1985-05-10', 'Hà Nội', '4', '4', '2020-01-01', 10000000, N'Quản lý gửi đồ');


GO

CREATE TABLE DuAnThiCong (
    DuAnThiCongID INT PRIMARY KEY IDENTITY(100,1), -- Bắt đầu từ 100, tăng dần 1 đơn vị
    TenDuAn NVARCHAR(100) NOT NULL,
    TenNhaThau NVARCHAR(100) NOT NULL,
    ChuDuAn NVARCHAR(100) NOT NULL, -- "Tòa nhà hoặc Khách thuê"
    NgayBatDau DATE,
    NgayKetThuc DATE,
    TrangThai NVARCHAR(50) DEFAULT 'Đang thi công', -- Đang thi công, Hoàn thành, Tạm dừng
    FileTaiLieu VARBINARY(MAX) DEFAULT NULL -- Lưu trực tiếp file zip/rar dưới dạng nhị phân
);


GO

CREATE TABLE GiaiDoanThiCong (
    GiaiDoanID INT PRIMARY KEY IDENTITY(1,1),
    DuAnThiCongID INT,
    ThuTu INT, -- Thứ tự 1, 2, 3
    NgayKetThuc DATE DEFAULT NULL,
    TrangThai NVARCHAR(50) DEFAULT 'Chưa thi công', -- Chưa thi công, Đang thi công, Hoàn thành
    NoiDung NVARCHAR(MAX)
);
GO

CREATE TABLE VatTuThiCong (
    VatTuThiCongID INT PRIMARY KEY IDENTITY(1,1),
    DuAnThiCongID INT, -- Tham chiếu không có khóa ngoại
    TenVatTu NVARCHAR(100),
    LoaiVatTu NVARCHAR(100),
    SoLuong INT,
	DonVi NVARCHAR(100)
);
GO

CREATE TABLE ThoThiCong (
    ThoThiCongID INT PRIMARY KEY IDENTITY(1,1),
    DuAnThiCongID INT, -- Tham chiếu không có khóa ngoại
    HoTen NVARCHAR(100),
    CCCD NVARCHAR(100),
    NhiemVu NVARCHAR(100)
);
GO

CREATE TABLE HoaDonGuiDo (
    HoaDonGuiDoID INT PRIMARY KEY IDENTITY(1,1),
    LoaiDo NVARCHAR(100),
	KichCo NVARCHAR(100),
    ViTri NVARCHAR(100),
	GhiChu NVARCHAR(255),
	CuDanID INT, -- Nếu là khách thì CuDanID = 0
	NgayTao DATETIME DEFAULT GETDATE(),
	NguoiTaoID INT, -- NhanVienID của bảng NhanVien
	NgayThanhToan DATETIME DEFAULT NULL,
	NgayLayDuKien DATETIME DEFAULT NULL, -- Ngày cư dân dự kiến lấy đồ đã gửi
	TrangThai NVARCHAR(50) DEFAULT N'Chưa thanh toán', -- 'Chưa thanh toán' hoặc 'Đã thanh toán'
	NguoiThanhToanID INT, -- NhanVienID của bảng NhanVien
	LoaiThanhToan NVARCHAR(255), -- 'Tiền mặt' hoặc 'Chuyển khoản'
	SoTien FLOAT,
);
GO

CREATE PROCEDURE sp_ThemGiaiDoanThiCong
    @DuAnThiCongID INT,
    @NgayKetThuc DATE = NULL,
    @TrangThai NVARCHAR(50) = 'Chưa thi công',
    @NoiDung NVARCHAR(MAX)
AS
BEGIN
    -- Bắt đầu một giao dịch
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Tìm thứ tự cao nhất hiện có trong bảng cho một DuAnThiCongID cụ thể
        DECLARE @MaxThuTu INT;
        SELECT @MaxThuTu = MAX(ThuTu)
        FROM GiaiDoanThiCong
        WHERE DuAnThiCongID = @DuAnThiCongID;

        -- Nếu không có giai đoạn nào trước đó, thiết lập ThuTu là 1
        IF @MaxThuTu IS NULL
            SET @MaxThuTu = 0;

        -- Thêm giai đoạn mới với ThuTu tăng thêm 1
        INSERT INTO GiaiDoanThiCong (DuAnThiCongID, ThuTu, NgayKetThuc, TrangThai, NoiDung)
        VALUES (@DuAnThiCongID, @MaxThuTu + 1, @NgayKetThuc, @TrangThai, @NoiDung);

        -- Commit giao dịch nếu không có lỗi
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Rollback giao dịch nếu xảy ra lỗi
        ROLLBACK TRANSACTION;

        -- In ra thông báo lỗi
        DECLARE @ErrorMessage NVARCHAR(4000);
        DECLARE @ErrorSeverity INT;
        DECLARE @ErrorState INT;

        SELECT 
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END;

GO
CREATE TRIGGER trg_ThongBao_ThanhToan_ThayDoi
ON YeuCau
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Thêm thông báo cho các yêu cầu khi cột ThanhToan được thay đổi
    INSERT INTO ThongBao (TieuDe, NoiDung, ThoiGian, UsersId, YeuCauId)
    SELECT 
        N'Thông báo thanh toán',                               -- Tiêu đề thông báo
        CONCAT(N'Đang chờ xác nhận thanh toán yêu cầu :',i.YeuCauID,N'từ hệ thống' ), -- Nội dung thông báo
        GETDATE(),                                            -- Thời gian hiện tại
        c.UserId,                                             -- User ID của cư dân từ bảng CuDan
        i.YeuCauID                                            -- ID của yêu cầu
    FROM 
        Inserted i
    JOIN 
        Deleted d ON i.YeuCauID = d.YeuCauID                  -- Liên kết với bảng Deleted để kiểm tra thay đổi
    JOIN 
        CuDan c ON c.CuDanID = i.CuDanID                      -- Liên kết với bảng CuDan để lấy UsersId
    WHERE 
        i.ThanhToan <> d.ThanhToan                            -- Chỉ thực thi khi cột ThanhToan thực sự thay đổi
END;
GO

CREATE TABLE DichVuGuiXe (
    DichVuGuiXeID INT PRIMARY KEY IDENTITY(1,1),
	PhuongTienID INT,
	CuDanID INT,
	ChoDoXeID INT DEFAULT NULL , --Khi quản lý gửi xác nhận thì hệ thống mới set
	NgayDangKy DATETIME DEFAULT GETDATE(), -- Ngày đăng ký gửi xe
    TrangThai nvarchar(20) DEFAULT N'Đang chờ xác nhận' -- 'Đang chờ xác nhận', 'Đã xác nhận'
);
GO

CREATE TABLE PhuongTien (
    PhuongTienID INT PRIMARY KEY IDENTITY(1,1),
	BienSoXe nvarchar(30),
    CuDanID int,
	LoaiXe nvarchar(10), --xe máy, ô tô, xe đạp
	ThoiGianGui DATETIME,
	CavetXe IMAGE, -- Cà vẹt xe
    CCCD_CMND IMAGE, -- CMND hoặc CCCD
);
GO

CREATE TABLE ChoDoXe (
    ChoDoXeID INT PRIMARY KEY IDENTITY(1,1),
	TrangThai nvarchar(20) DEFAULT N'Trống', -- 'Trống' hoặc 'Đã sử dụng'
	ViTri nvarchar(10), --VD: A1, B1, A2, B2,...
	ThoiGianVao DATETIME,
	ThoiGianRa DATETIME
);
GO

-- Bảng theo dõi giao dịch gửi xe
CREATE TABLE GiaoDichGuiXe (
    GiaoDichID INT PRIMARY KEY IDENTITY(1,1),
    PhuongTienID INT,
    DaThanhToan BIT DEFAULT 0, -- 0: Chưa thanh toán, 1: Đã thanh toán
    PhiGuiXe DECIMAL(18, 2) -- Số tiền cho lần gửi xe này
);
GO


CREATE TABLE ThanhToanGuiXe (
    ThanhToanID INT PRIMARY KEY IDENTITY(1,1),
    DichVuGuiXeID INT, 
    SoTien DECIMAL(18, 2), -- Số tiền phải thanh toán
    NgayThanhToan DATETIME DEFAULT GETDATE(), -- Ngày thực hiện thanh toán
    PhuongThucThanhToan NVARCHAR(50), -- Phương thức thanh toán: 'Tiền mặt', 'Chuyển khoản', 'Thẻ'
    LoaiThanhToan NVARCHAR(20) DEFAULT N'Một lần', -- 'Một lần' hoặc 'Theo tháng'
    ThangThanhToan INT, -- Tháng áp dụng thanh toán (chỉ dùng khi LoaiThanhToan là 'Theo tháng')
    NamThanhToan INT -- Năm áp dụng thanh toán (chỉ dùng khi LoaiThanhToan là 'Theo tháng')
);
GO

CREATE TRIGGER trg_InsertDichVuGuiXe
ON PhuongTien
AFTER INSERT
AS
BEGIN
    -- Thêm bản ghi vào bảng DichVuGuiXe khi có phương tiện mới được thêm vào PhuongTien
    INSERT INTO DichVuGuiXe (PhuongTienID, CuDanID, TrangThai)
    SELECT PhuongTienID, CuDanID, N'Đang chờ xác nhận'
    FROM INSERTED
    ORDER BY PhuongTienID;
END;
GO

CREATE TRIGGER trg_AfterInsertDichVuGuiXe
ON DichVuGuiXe
AFTER INSERT
AS
BEGIN
    INSERT INTO YeuCau (CuDanID, DichvuId, TieuDe, NoiDung, NgayGui)
    SELECT 
        PT.CuDanID,  -- Lấy CuDanID từ bảng PhuongTien
        DVGX.DichVuGuiXeID, 
        N'Đăng ký gửi xe',
        N'Bạn đã đăng ký gửi xe ' + 'vào ngày' + CONVERT(NVARCHAR(20), PT.ThoiGianGui, 120),  -- Lấy ThoiGianGui từ PhuongTien
        GETDATE()
    FROM 
        inserted DVGX
    JOIN 
        PhuongTien PT ON DVGX.PhuongTienID = PT.PhuongTienID;  -- Kết nối bảng inserted và PhuongTien bằng PhuongTienID
END;
GO

CREATE TRIGGER trg_UpdateTrangThaiDichVuGuiXe
ON DichVuGuiXe
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Cập nhật trạng thái và gán vị trí đỗ xe khi dịch vụ được xác nhận
    UPDATE DVGX
    SET 
        DVGX.ChoDoXeID = (SELECT TOP 1 CDX.ChoDoXeID 
                          FROM ChoDoXe CDX
                          WHERE CDX.TrangThai = N'Trống'), -- Chọn một chỗ đỗ xe trống
        DVGX.TrangThai = N'Đã xác nhận'
    FROM 
        DichVuGuiXe DVGX
    JOIN 
        inserted i ON DVGX.DichVuGuiXeID = i.DichVuGuiXeID
    WHERE 
        i.TrangThai = N'Đã xác nhận' 
        AND (SELECT TrangThai FROM deleted d WHERE d.DichVuGuiXeID = i.DichVuGuiXeID) <> N'Đã xác nhận';

    -- Cập nhật trạng thái của chỗ đỗ xe vừa được gán thành "Đã sử dụng"
    UPDATE CDX
    SET CDX.TrangThai = N'Đã sử dụng'
    FROM 
        ChoDoXe CDX
    JOIN 
        DichVuGuiXe DVGX ON CDX.ChoDoXeID = DVGX.ChoDoXeID
    WHERE 
        DVGX.TrangThai = N'Đã xác nhận';

    -- Cập nhật trạng thái yêu cầu trong bảng YeuCau thành "Hoàn thành"
    UPDATE YeuCau
    SET TrangThai = N'Hoàn thành'
    WHERE DichvuId IN (SELECT DichVuGuiXeID FROM inserted WHERE TrangThai = N'Đã xác nhận'); 
END;
GO

CREATE TRIGGER trg_UpdateYeuCauGuiXe
ON YeuCau
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Thêm thông báo khi trạng thái yêu cầu được cập nhật thành "Hoàn thành"
    INSERT INTO ThongBao (TieuDe, NoiDung, ThoiGian, UsersId, YeuCauId)
    SELECT 
        N'Hoàn thành đăng ký gửi xe',
        CONCAT(N'Đăng ký gửi xe đã hoàn thành. Vị trí đỗ xe: ', CDX.ViTri, 
               N'. Ngày đăng ký: ', CONVERT(NVARCHAR(20), DVGX.NgayDangKy, 120)),
        GETDATE(),
        DVGX.CuDanID,
        YQ.YeuCauID
    FROM 
        inserted YQ
    JOIN 
        DichVuGuiXe DVGX ON YQ.DichvuId = DVGX.DichVuGuiXeID
    JOIN 
        ChoDoXe CDX ON DVGX.ChoDoXeID = CDX.ChoDoXeID
    WHERE 
        YQ.TrangThai = N'Hoàn thành';
END;
GO


CREATE TRIGGER trg_DeleteDichVuGuiXe
ON DichVuGuiXe
AFTER DELETE
AS
BEGIN
    -- Lấy PhuongTienID từ các bản ghi bị xóa và xóa phương tiện tương ứng trong bảng PhuongTien
    DELETE FROM PhuongTien
    WHERE PhuongTienID IN (SELECT PhuongTienID FROM deleted);

	DELETE FROM YeuCau
    WHERE YeuCauID IN (SELECT DichVuGuiXeID FROM deleted);
END;
GO

INSERT INTO PhuongTien (BienSoXe, CuDanID, LoaiXe, ThoiGianGui, CavetXe, CCCD_CMND)
VALUES ('SH180', 1, N'Xe máy', '2012-06-18 10:34:09 AM', NULL, NULL),
       ('AB160', 2, N'Xe hơi', '2015-12-30 12:35:19 PM', NULL, NULL),
       ('CD154', 3, N'Xe đạp', '2025-01-05 07:00:00 AM', NULL, NULL);

SELECT * FROM HopDongThue;

exec sp_UpdateNgayKetThuc 1, '2025-5-5'


-- Dữ liệu mẫu cho bảng CuDan
INSERT INTO CuDan (HoTen, SoDienThoai, CCCD, Email, DiaChi, GioiTinh, NgaySinh, TrangThai, ThanhToan, NgayChuyenDen, HinhAnh)
VALUES 
('Nguyen Van A', '99', '123456789012', '99', '123 Nguyen Trai, Ha Noi', N'Nam', '1990-01-01', N'Còn ở', N'Trả đủ', GETDATE(), NULL)
