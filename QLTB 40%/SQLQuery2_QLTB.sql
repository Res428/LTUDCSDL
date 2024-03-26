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

--Tạo bảng KhachHang ng mượn tb
CREATE TABLE KhachHang (
    MaKH INT PRIMARY KEY,
    HoKH VARCHAR(50),
    TenKH VARCHAR(50),
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
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
)



--===PARAMETERS
-- THIẾT BỊ
Create proc HSP_ThietBi_Select
@MaTB int =0
as
Select MaTB, TenTB, Sl, LoaiTB, TinhTrang, CurrentUser
from Devices
where @MaTB=Case @MaTB when 0 then @MaTB else MaTB end

Go
Exec HSP_ThietBi_Select


Create proc HSP_ThietBi_InsertAndUpdate
@MaTB int, @TenTB nvarchar(100), @Sl int, @LoaiTB nvarchar(50), @TinhTrang nvarchar(50), @CurrentUser varchar(100)
as
if exists (select 1 from Devices where MaTB=@MaTB)
begin
	update Devices
	set TenTB=@TenTB,  @Sl = Sl, @LoaiTB = LoaiTB, @TinhTrang = TinhTrang, @CurrentUser = CurrentUser
	where MaTB = @MaTB
end
else
begin
	insert into Devices(TenTB, Sl, LoaiTB, TinhTrang, CurrentUser)
	values(@TenTB, @Sl, @LoaiTB, @TinhTrang, @CurrentUser)
end



Create proc HSP_ThietBi_Delete
@MaTB int
as
Delete Devices
where MaTB = @MaTB
	


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
			SELECT @CurrentUser = KhachHang.MaKH
			FROM KhachHang;
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

    SELECT @MaKH = i.MaKH,
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
    SET CurrentUser = @MaKH,
        TinhTrang = @TinhTrang
    WHERE MaTB = @MaTB;
end

