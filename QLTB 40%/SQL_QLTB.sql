--IF EXISTS (SELECT * FROM sys.databases WHERE name = N'QLTB_HK6')
--BEGIN
--    -- Nếu database tồn tại, thì xóa nó
--    DROP DATABASE QLTB_HK6;
--END

IF EXISTS (SELECT * FROM sys.databases WHERE name = N'deadlinengapdau_QLTB')
BEGIN
    -- Nếu database tồn tại, thì xóa nó
    DROP DATABASE deadlinengapdau_QLTB;
END

-- Tạo database mới
CREATE DATABASE deadlinengapdau_QLTB; --QLTB_HK6;
GO

-- Sử dụng database vừa tạo
USE deadlinengapdau_QLTB;
GO

--Tạo bảng Admin
drop table NhanVien
CREATE TABLE NhanVien (
    MaNV int Primary Key NOT NULL,
    HoTenNV NVARCHAR(50),
	Email NVARCHAR(50),
	TaiKhoan NVARCHAR(20),
	MatKhau NVARCHAR(50),
	SoDT NVARCHAR(11)
)


--Tạo bảng KhachHang ng mượn tb
drop table KhachHang
CREATE TABLE KhachHang (
    MaKH INT PRIMARY KEY NOT NULL,
    HoKH NVARCHAR(50) NOT NULL,
    TenKH NVARCHAR(50) NOT NULL,
	Email NVARCHAR(50),
	SoDT NVARCHAR(11) NOT NULL
)

-- Tạo bảng thiết bị
drop table ChiTietTBi
Create TABLE ChiTietTBi (
    MaTB int Primary Key NOT NULL,
    TenTB NVARCHAR(100) NOT NULL,
    LoaiTB NVARCHAR(50) NOT NULL,
	Sl int,
    TinhTrang nvarchar(50) NOT NULL,
	--TinhTrang VARCHAR(50) CHECK (TinhTrang IN (N'Có sẵn', N'Cho mượn')) DEFAULT N'Có sẵn',
	CurrentUser NVARCHAR(100)
)




--Tạo bảng cho mượn tb
drop table PhieuMuon

CREATE TABLE PhieuMuon (
    MaMuon INT NOT NULL,
    MaTB int NOT NULL,
    MaNV varchar(20) NOT NULL,
	MaKH INT,
    NgayMuon DATE,
    NgayTra DATE,
    FOREIGN KEY (MaTB) REFERENCES ChiTietTBi(MaTB),
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
) 
		





---==INSERT
--NHAN VIEN
Update NhanVien
Set TaiKhoan ='admin', MatKhau=PWDENCRYPT('123456')
Where MaNV=1

Update NhanVien
Set TaiKhoan ='ka', MatKhau=PWDENCRYPT('12345')
Where MaNV=2

Update NhanVien
Set TaiKhoan ='th', MatKhau=PWDENCRYPT('12345')
Where MaNV=3


insert [dbo].[NhanVien] ([MaNV], [HoTenNV], [Email], [TaiKhoan], [MatKhau], [SoDT]) values (1, N'Truong Đinh Tien Anh', N'anhtruong.09102003@gmail.com', N'admin', '123456', '0961558011')
insert [dbo].[NhanVien] ([MaNV], [HoTenNV], [Email], [TaiKhoan], [MatKhau], [SoDT]) values (2, N'Nguyen Thi Kieu Anh', N'kieuk635@gmail.com', N'ka', '12345', '0763012341')
insert [dbo].[NhanVien] ([MaNV], [HoTenNV], [Email], [TaiKhoan], [MatKhau], [SoDT]) values (3, N'Nguyen Co Trung Hau', N'haut020789@gmail.com', N'th', '12345', '0234556789')

		select * from [dbo].[NhanVien]
--KHACH HANG

INSERT [dbo].[KhachHang] ([MaKH], [HoKH], [TenKH], [Email], [SoDT]) VALUES (1, N'Nguyen', N'A', N'nva@gmail.com', '0123456789')
INSERT [dbo].[KhachHang] ([MaKH], [HoKH], [TenKH], [Email], [SoDT]) VALUES (2, N'Nguyen', N'B', N'nvb@gmail.com', '0234567890')
INSERT [dbo].[KhachHang] ([MaKH], [HoKH], [TenKH], [Email], [SoDT]) VALUES (3, N'Nguyen', N'C', N'nvc@gmail.com', '0345678901')
INSERT [dbo].[KhachHang] ([MaKH], [HoKH], [TenKH], [Email], [SoDT]) VALUES (4, N'Nguyen', N'D', N'nvd@gmail.com', '0456789012')

		select * from KhachHang	
--THIET BI

Insert [dbo].[ChiTietTBi] ([MaTB], [TenTB], [LoaiTB], [Sl], [TinhTrang]) values (1, N'RoboGo', N'Xe Robot', 1, N'Có sẵn')
Insert [dbo].[ChiTietTBi] ([MaTB], [TenTB], [LoaiTB], [Sl], [TinhTrang]) values (2, N'AlphaMini', N'Robot', 1, N'Có sẵn')
Insert [dbo].[ChiTietTBi] ([MaTB], [TenTB], [LoaiTB], [Sl], [TinhTrang]) values (3, N'Asus Rog Strix 15', N'Laptop', 1, N'Có sẵn')
Insert [dbo].[ChiTietTBi] ([MaTB], [TenTB], [LoaiTB], [Sl], [TinhTrang]) values (4, N'Lenovo Legion 5 Pro', N'Laptop', 1, N'Có sẵn')

		select * from ChiTietTBi

--===PROCEDURE

--Viết thủ tục kiểm tra đăng nhập
drop Proc HSP_NhanVien_KiemTraDangNhap
Create Proc HSP_NhanVien_KiemTraDangNhap
@TaiKhoan varchar(20),
@MatKhau varchar(50)
as
if exists (select 1 from NhanVien where TaiKhoan= @TaiKhoan and PWDCOMPARE(@MatKhau,MatKhau)=1)
begin 
	select 1 as Code,MaNV,HoTenNV, TaiKhoan
	from NhanVien
	where TaiKhoan=@TaiKhoan and PWDCOMPARE(@MatKhau,MatKhau)=1
end
else
begin 
	select 0 as Code,'' as MaNV,N'' as HoTenNV, '' as TaiKhoan,  0 as GroupID
End
Go
--Test
Exec HSP_NhanVien_KiemTraDangNhap 'admin','123456'


--NHÂN VIÊN
-----==Select
--drop Proc HSP_NhanVien_Select

Create proc HSP_NhanVien_Select
@MaNV int =0
as
Select [MaNV], [HoTenNV], [Email], [SoDT]
from NhanVien
where @MaNV=Case @MaNV when 0 then @MaNV else MaNV end

Go
Exec HSP_NhanVien_Select



-----==Insert & Update
--drop Proc HSP_NhanVien_InsertAndUpdate

create proc HSP_NhanVien_InsertAndUpdate
	@MaNV int,
	@HoTenNV NVARCHAR(50),
	@Email NVARCHAR(50),
	@SoDT NVARCHAR(11)
as
if exists (select 1 from NhanVien where MaNV=@MaNV)
BEGIN
    UPDATE NhanVien
    SET HoTenNV = @HoTenNV,
        Email = @Email,
        SoDT = @SoDT
    WHERE MaNV = @MaNV
END;
else
BEGIN
    INSERT INTO NhanVien([MaNV], [HoTenNV], [Email], [SoDT])
    VALUES (@MaNV, @HoTenNV, @Email, @SoDT)
END;



-----==Delete
--drop proc HSP_NhanVien_Delete

create proc HSP_NhanVien_Delete
@MaNV int
as
begin
	delete from NhanVien
	where MaNV = @MaNV
end


--drop PROC HSP_NhanVien_LayMaNV

Create PROC HSP_NhanVien_LayMaNV
AS
SELECT ISNULL([dbo].[Hfc_SinhMaTuDong](MAX(maNV),1,1,'0','0'),'1') MaNVMax
FROM dbo.NhanVien



-- THIẾT BỊ
-----==Select
drop Proc HSP_ThietBi_Select
Create proc HSP_ThietBi_Select
@MaTB int =0
as
Select MaTB, TenTB, LoaiTB, Sl, TinhTrang, CurrentUser
from ChiTietTBi
where @MaTB=Case @MaTB when 0 then @MaTB else MaTB end

Go
Exec HSP_ThietBi_Select


-----==Insert & Update
drop Proc HSP_ThietBi_InsertAndUpdate

create proc HSP_ThietBi_InsertAndUpdate
@MaTB int, @TenTB nvarchar(100), @LoaiTB nvarchar(50), @Sl int,@TinhTrang nvarchar(50), @CurrentUser nvarchar(100)
as
if exists (select 1 from ChiTietTBi where MaTB=@MaTB)
BEGIN
    UPDATE ChiTietTBi
    SET TenTB = @TenTB,
        LoaiTB = @LoaiTB,
        Sl = @Sl,
        TinhTrang = @TinhTrang,
        CurrentUser = @CurrentUser
    WHERE MaTB = @MaTB
END;
else
BEGIN
	--SELECT @MaTB = COUNT(*) + 1 FROM ChiTietTBi;
    INSERT INTO ChiTietTBi([MaTB], [TenTB], [LoaiTB], [Sl], [TinhTrang], [CurrentUser])
    VALUES (@MaTB, @TenTB, @LoaiTB, @Sl, @TinhTrang, @CurrentUser)
END;



-----==Delete
create proc HSP_ThietBi_Delete
@MaTB int
as
begin
	delete from ChiTietTBi
	where MaTB = @MaTB
end


CREATE FUNCTION Hfc_SinhMaTuDong(
@MaxID VARCHAR(20),
@Start INT,
@Lenght INT,
@Asign VARCHAR(20),
@Format VARCHAR(20)
)
RETURNS VARCHAR(20)
AS
BEGIN
    DECLARE @number INT;
	DECLARE @Result VARCHAR(20);
	SET @number=CONVERT(INT,SUBSTRING(@MaxId,@Start,@lenght))+1
	SET @Result=@Asign+FORMAT(@number,@Format);
	RETURN @Result;
END
Go


create PROC HSP_ThietBi_LayMaThietBi
AS
SELECT ISNULL([dbo].[Hfc_SinhMaTuDong](MAX(maTB),1,1,'0','0'),'1') MaTBMax
FROM dbo.ChiTietTBi

--drop PROC HSP_ThietBi_LayMaxID
--create proc HSP_ThietBi_LayMaxID
--as
--select isnull([dbo].[Hfc_SinhMaTuDong](max(MaTB),1,1,'0','0'),'1') MaxID
--from ChiTietTBi


--===TRIGGER
--Cập nhật lại tình trạng Devices
CREATE TRIGGER SetCurrentUserToNull
ON ChiTietTBi after update
as
begin
	declare @MaTB INT;
	declare @TinhTrang NVARCHAR(50);
	declare @CurrentUser NVARCHAR(100);

	SELECT @MaTB = inserted.MaTB,
			   @TinhTrang = inserted.TinhTrang,
			   @CurrentUser = inserted.CurrentUser
		FROM inserted;

		IF @TinhTrang = 0
		BEGIN
			SET @CurrentUser = NULL;
		END
		ELSE
		BEGIN
			SELECT @CurrentUser = KhachHang.MaKH
			FROM KhachHang;
		END

		UPDATE ChiTietTBi
		SET CurrentUser = @CurrentUser,
			TinhTrang = @TinhTrang
		WHERE MaTB = @MaTB;
end

--Cập nhật thông tin ng mượn
--CREATE TRIGGER UpdateBorrowerInfo
--ON PhieuMuon AFTER update 
--as
--begin
--	DECLARE @ReturnDate DATE;
--    DECLARE @MaTB nvarchar(30);
--	DECLARE @MaKH INT;
--    DECLARE @MaMuon INT;
--    DECLARE @MaNV VARCHAR(100);
--    DECLARE @TinhTrang VARCHAR(50);

--    SELECT @MaKH = i.MaKH,
--           @ReturnDate = i.ReturnDate,
--           @MaTB = i.MaTB,
--           @MaMuon = i.MaMuon
--    FROM inserted i;

--    IF @ReturnDate IS NOT NULL
--    BEGIN
--        SET @MaTB = NULL;
--    END
--    ELSE
--    BEGIN
--        SELECT @MaTB = d.MaTB
--        FROM ChiTietTBi d
--        WHERE d.MaTB = @MaTB; -- Nếu sử dụng SELECT vào biến thì cần phải sử dụng WHERE để chỉ định rõ điều kiện
--    END;

--    UPDATE PhieuMuon
--    SET MaTB = @MaTB
--    WHERE MaMuon = @MaMuon;

--    UPDATE ChiTietTBi
--    SET CurrentUser = @MaKH,
--        TinhTrang = @TinhTrang
--    WHERE MaTB = @MaTB;
--end


-- KHÁCH HÀNG
-----==Select
drop proc HSP_KhachHang_Select

Create proc HSP_KhachHang_Select
@MaKH int =0
as
Select MaKH, HoKH, TenKH, SoDT
from KhachHang
where @MaKH=Case @MaKH when 0 then @MaKH else MaKH end

Go
Exec HSP_KhachHang_Select


-----==Insert & Update
drop proc HSP_KhachHang_InsertAndUpdate

create proc HSP_KhachHang_InsertAndUpdate
@MaKH int, @HoKH NVARCHAR(50), @TenKH NVARCHAR(50), @SoDT NVARCHAR(11) 
as
if exists (select 1 from KhachHang where MaKH=@MaKH)
begin
	update KhachHang
	set HoKH = @HoKH, TenKH = @TenKH, SoDT = @SoDT
	where MaKH = @MaKH
end
else
begin
	--SELECT @MaKH = COUNT(*) + 1 FROM KhachHang;
	insert into KhachHang(MaKH, HoKH, TenKH, SoDT)
	values(@MaKH, @HoKH, @TenKH, @SoDT)
end


-----==Delete
drop proc HSP_KhachHang_Delete

create proc HSP_KhachHang_Delete
@MaKH int
as
begin
	Delete KhachHang
	where MaKH = @MaKH
end

drop PROC HSP_KhachHang_LayMaKH
Create PROC HSP_KhachHang_LayMaKH
AS
SELECT ISNULL([dbo].[Hfc_SinhMaTuDong](MAX(maKH),1,1,'0','0'),'1') MaKHMax
FROM dbo.KhachHang