IF EXISTS (SELECT * FROM sys.databases WHERE name = N'QLTB')
BEGIN
    -- Nếu database tồn tại, thì xóa nó
    DROP DATABASE QLTB;
END

-- Tạo database mới
CREATE DATABASE QLTB;
GO

-- Sử dụng database vừa tạo
USE QLTB;
GO

--Tạo bảng Admin
CREATE TABLE QuanLy (
    MaQL INT PRIMARY KEY,
    HoQL VARCHAR(50),
    TenQL VARCHAR(50),
	Email NVARCHAR(50),
	MatKhau NVARCHAR(50),
	SoDT NVARCHAR(11)
)

--Tạo bảng NhanVien
CREATE TABLE NhanVien (
    MaNV INT PRIMARY KEY,
    HoNV VARCHAR(50),
    TenNV VARCHAR(50),
	Email NVARCHAR(50),
	SoDT NVARCHAR(11)
)

-- Tạo bảng thiết bị
CREATE TABLE Devices (
    MaTB INT PRIMARY KEY,
    TenTB VARCHAR(100) NOT NULL,
    LoaiTB VARCHAR(50),
	Sl int ,
    TinhTrang VARCHAR(50) CHECK (TinhTrang IN (N'Có sãn', N'Cho mượn')) DEFAULT N'Có sãn',
	CurrentUser VARCHAR(100)
)

-- Tạo bảng lịch sử sử dụng thiết bị
CREATE TABLE DeviceHistory (
    MaLS INT PRIMARY KEY,
    MaTB INT,
    Action VARCHAR(100),
    ActionDate DATETIME,
    FOREIGN KEY (MaTB) REFERENCES Devices(MaTB)
)

--Tạo bảng cho mượn tb
CREATE TABLE DeviceLoans (
    MaMuon INT PRIMARY KEY,
    MaTB INT,
    MaNV INT,
    NgayMuon DATE,
    NgayTra DATE,
    FOREIGN KEY (MaTB) REFERENCES Devices(MaTB),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
)






--===TRIGGER
--Cập nhật lại tình trạng Devices
CREATE TRIGGER SetCurrentUserToNull
ON Devices after update
as
begin
	declare @MaTB INT;
	declare @TinhTrang VARCHAR(50);
	declare @CurrentUser VARCHAR(100);

	SELECT @MaTB = inserted.MaTB,
			   @TinhTrang = inserted.TinhTrang,
			   @CurrentUser = inserted.CurrentUser
		FROM inserted;

		IF @TinhTrang = 'Có sẵn'
		BEGIN
			SET @CurrentUser = NULL;
		END
		ELSE
		BEGIN
			SELECT @CurrentUser = NhanVien.MaNV
			FROM NhanVien;
		END

		UPDATE Devices
		SET CurrentUser = @CurrentUser,
			TinhTrang = @TinhTrang
		WHERE MaTB = @MaTB;
end

--Cập nhật thông tin ng mượn
CREATE TRIGGER UpdateBorrowerInfo
ON DeviceLoans AFTER update 
as
begin
	DECLARE @ReturnDate DATE;
    DECLARE @MaTB INT;
    DECLARE @MaMuon INT;
    DECLARE @MaNV VARCHAR(100);
    DECLARE @TinhTrang VARCHAR(50);

    SELECT @MaNV = i.MaNV,
           @ReturnDate = i.ReturnDate,
           @MaTB = i.MaTB,
           @MaMuon = i.MaMuon
    FROM inserted i;

    IF @ReturnDate IS NOT NULL
    BEGIN
        SET @MaTB = NULL;
    END
    ELSE
    BEGIN
        SELECT @MaTB = d.MaTB
        FROM Devices d
        WHERE d.MaTB = @MaTB; -- Nếu sử dụng SELECT vào biến thì cần phải sử dụng WHERE để chỉ định rõ điều kiện
    END;

    UPDATE DeviceLoans
    SET MaTB = @MaTB
    WHERE MaMuon = @MaMuon;

    UPDATE Devices
    SET CurrentUser = @MaNV,
        TinhTrang = @TinhTrang
    WHERE MaTB = @MaTB;
end

