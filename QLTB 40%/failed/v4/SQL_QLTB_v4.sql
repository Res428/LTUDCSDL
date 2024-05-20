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
    MaNV int identity(1,1) Primary Key NOT NULL,
    HoTenNV NVARCHAR(50),
	Email NVARCHAR(50),
	TaiKhoan NVARCHAR(20),
	MatKhau NVARCHAR(50),
	SoDT NVARCHAR(11)
)


--Tạo bảng KhachHang ng mượn tb
drop table KhachHang
CREATE TABLE KhachHang (
    MaKH INT identity(1,1) PRIMARY KEY NOT NULL,
    HoKH NVARCHAR(50) NOT NULL,
    TenKH NVARCHAR(50) NOT NULL,
	Email NVARCHAR(50),
	SoDT NVARCHAR(11) NOT NULL
)

-- Tạo bảng thiết bị
drop table ChiTietTBi
Create TABLE ChiTietTBi (
    MaTB int identity(1,1) Primary Key NOT NULL,
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
    MaMuon INT IDENTITY(1,1) NOT NULL,
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


insert [dbo].[NhanVien] ([HoTenNV], [Email], [TaiKhoan], [MatKhau], [SoDT]) values (N'Truong Đinh Tien Anh', N'anhtruong.09102003@gmail.com', N'admin', '123456', '0961558011')
insert [dbo].[NhanVien] ([HoTenNV], [Email], [TaiKhoan], [MatKhau], [SoDT]) values (N'Nguyen Thi Kieu Anh', N'kieuk635@gmail.com', N'ka', '12345', '0763012341')
insert [dbo].[NhanVien] ([HoTenNV], [Email], [TaiKhoan], [MatKhau], [SoDT]) values (N'Nguyen Co Trung Hau', N'haut020789@gmail.com', N'th', '12345', '0234556789')

		select * from [dbo].[NhanVien]
--KHACH HANG

INSERT [dbo].[KhachHang] ([HoKH], [TenKH], [Email], [SoDT]) VALUES (N'Nguyen', N'A', N'nva@gmail.com', '0123456789')
INSERT [dbo].[KhachHang] ([HoKH], [TenKH], [Email], [SoDT]) VALUES (N'Nguyen', N'B', N'nvb@gmail.com', '0234567890')
INSERT [dbo].[KhachHang] ([HoKH], [TenKH], [Email], [SoDT]) VALUES (N'Nguyen', N'C', N'nvc@gmail.com', '0345678901')
INSERT [dbo].[KhachHang] ([HoKH], [TenKH], [Email], [SoDT]) VALUES (N'Nguyen', N'D', N'nvd@gmail.com', '0456789012')

		select * from KhachHang	
--THIET BI

Insert [dbo].[ChiTietTBi] ([TenTB], [LoaiTB], [Sl], [TinhTrang]) values (N'RoboGo', N'Xe Robot', 1, N'Có sẵn')
Insert [dbo].[ChiTietTBi] ([TenTB], [LoaiTB], [Sl], [TinhTrang]) values (N'AlphaMini', N'Robot', 1, N'Có sẵn')
Insert [dbo].[ChiTietTBi] ([TenTB], [LoaiTB], [Sl], [TinhTrang]) values (N'Asus Rog Strix 15', N'Laptop', 1, N'Có sẵn')
Insert [dbo].[ChiTietTBi] ([TenTB], [LoaiTB], [Sl], [TinhTrang]) values (N'Lenovo Legion 5 Pro', N'Laptop', 1, N'Có sẵn')

		select * from ChiTietTBi
--===PARAMETERS

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


-- THIẾT BỊ
drop Proc HSP_ThietBi_Select
Create proc HSP_ThietBi_Select
@MaTB int =0
as
Select MaTB, TenTB, LoaiTB, Sl, TinhTrang, CurrentUser
from ChiTietTBi
where @MaTB=Case @MaTB when 0 then @MaTB else MaTB end

Go
Exec HSP_ThietBi_Select


drop Proc HSP_ThietBi_InsertAndUpdate
create proc HSP_ThietBi_InsertAndUpdate
@MaTB int, @TenTB nvarchar(100), @LoaiTB nvarchar(50), @Sl int,@TinhTrang nvarchar(50), @CurrentUser nvarchar(100)
as
if exists (select 1 from ChiTietTBi where MaTB=@MaTB)
begin
	update ChiTietTBi
	set TenTB=@TenTB, LoaiTB = @LoaiTB, Sl = @Sl, TinhTrang = @TinhTrang, CurrentUser = @CurrentUser
	where MaTB = @MaTB
end
else
begin
	insert into ChiTietTBi(TenTB, LoaiTB, Sl, TinhTrang, CurrentUser)
	values(@TenTB, @LoaiTB, @Sl, @TinhTrang, @CurrentUser)
end



drop proc HSP_ThietBi_Delete
@MaTB int
as
delete ChiTietTBi
--set TenTB = NULL, LoaiTB = null, Sl = null, TinhTrang = null, CurrentUser = null
where MaTB = @MaTB
	


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


drop PROC HSP_ThietBi_LayMaThietBi
AS
SELECT ISNULL([dbo].[Hfc_SinhMaTuDong](MAX(maTB),1,1,'0','0'),'1') MaTBMax
FROM dbo.ChiTietTBi


create proc HSP_ThietBi_LayMaxID
as
select isnull([dbo].[Hfc_SinhMaTuDong](max(MaTB),1,1,'0','0'),'1') MaxID
from ChiTietTBi


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
Create proc HSP_KhachHang_Select
@MaKH int =0
as
Select MaKH, HoKH, TenKH, SoDT
from KhachHang
where @MaKH=Case @MaKH when 0 then @MaKH else MaKH end

Go
Exec HSP_KhachHang_Select


Create proc HSP_KhachHang_InsertAndUpdate
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
	insert into KhachHang(HoKH, TenKH, SoDT)
	values(@HoKH, @TenKH, @SoDT)
end


Create proc HSP_KhachHang_Delete
@MaKH int
as
Delete KhachHang
where MaKH = @MaKH


alter PROC HSP_KhachHang_LayMaKH
AS
SELECT ISNULL([dbo].[Hfc_SinhMaTuDong](MAX(maKH),1,1,'0','0'),'1') MaKHMax
FROM dbo.KhachHang