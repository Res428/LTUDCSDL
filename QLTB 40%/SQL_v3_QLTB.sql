IF EXISTS (SELECT * FROM sys.databases WHERE name = N'QLTB_HK6')
BEGIN
    -- Nếu database tồn tại, thì xóa nó
    DROP DATABASE QLTB_HK6;
END

-- Tạo database mới
CREATE DATABASE QLTB_HK6;
GO

-- Sử dụng database vừa tạo
USE QLTB_HK6;
GO

--Tạo bảng Admin
CREATE TABLE NhanVien (
    MaNV varchar(20) NOT NULL,
    HoTenNV VARCHAR(50),
	Email NVARCHAR(50),
	TaiKhoan NVARCHAR(20),
	MatKhau NVARCHAR(50),
	SoDT NVARCHAR(11),

	CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


--Tạo bảng KhachHang ng mượn tb
CREATE TABLE KhachHang (
    MaKH INT PRIMARY KEY NOT NULL,
    HoKH VARCHAR(50) NOT NULL,
    TenKH VARCHAR(50) NOT NULL,
	Email NVARCHAR(50) NOT NULL,
	SoDT NVARCHAR(11) NOT NULL
)

INSERT [dbo].[KhachHang] ([MaKH], [HoKH], [TenKH], [Email], [SoDT]) VALUES (01, N'Nguyen', N'A', N'nva@gmail.com', '0123456789')
INSERT [dbo].[KhachHang] ([MaKH], [HoKH], [TenKH], [Email], [SoDT]) VALUES (02, N'Nguyen', N'B', N'nvb@gmail.com', '0234567890')
INSERT [dbo].[KhachHang] ([MaKH], [HoKH], [TenKH], [Email], [SoDT]) VALUES (03, N'Nguyen', N'C', N'nvc@gmail.com', '0345678901')
INSERT [dbo].[KhachHang] ([MaKH], [HoKH], [TenKH], [Email], [SoDT]) VALUES (04, N'Nguyen', N'D', N'nvd@gmail.com', '0456789012')

-- Tạo bảng thiết bị
Create TABLE ChiTietTBi (
    MaTB nvarchar(30) NOT NULL,
    TenTB VARCHAR(100) NOT NULL,
    LoaiTB VARCHAR(50) NOT NULL,
	Sl int,
    TinhTrang tinyint NOT NULL CONSTRAINT [DF_CTTHIETBI_TINHTRANGTB]  DEFAULT ((0)),
	--TinhTrang VARCHAR(50) CHECK (TinhTrang IN (N'Có sẵn', N'Cho mượn')) DEFAULT N'Có sẵn',
	CurrentUser VARCHAR(100)
	CONSTRAINT [PK_ChiTietTBi] PRIMARY KEY CLUSTERED 
	(
		[MaTB] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

Update ChiTietTBi
Set TinhTrang = DEFAULT, CurrentUser = N'Không'
where MaTB = 0003
Insert [dbo].[ChiTietTBi] ([MaTB], [TenTB], [LoaiTB], [Sl], [TinhTrang], [CurrentUser]) values (0001, N'RoboGo', N'Xe Robot', 1, DEFAULT, N'Không')
Insert [dbo].[ChiTietTBi] ([MaTB], [TenTB], [LoaiTB], [Sl], [TinhTrang], [CurrentUser]) values (0002, N'AlphaMini', N'Robot', 1, DEFAULT, N'Không')
Insert [dbo].[ChiTietTBi] ([MaTB], [TenTB], [LoaiTB], [Sl], [TinhTrang], [CurrentUser]) values (0003, N'Asus Rog Strix 15', N'Laptop', 1, DEFAULT, N'Không')
Insert [dbo].[ChiTietTBi] ([MaTB], [TenTB], [LoaiTB], [Sl], [TinhTrang], [CurrentUser]) values (0004, N'Lenovo Legion 5 Pro', N'Laptop', 1,DEFAULT, N'Không')

Select * from ChiTietTBi

--Tạo bảng cho mượn tb
CREATE TABLE PhieuMuon (
    MaMuon INT IDENTITY(1,1) NOT NULL,
    MaTB nvarchar(30) NOT NULL,
    MaNV varchar(20) NOT NULL,
	MaKH INT,
    NgayMuon DATE,
    NgayTra DATE,
    FOREIGN KEY (MaTB) REFERENCES ChiTietTBi(MaTB),
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),

	CONSTRAINT [PK_PhieuMuon] PRIMARY KEY CLUSTERED
	(
		[MaMuon] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
		





		select * from [dbo].[NhanVien]

--NHAN VIEN
Update NhanVien
Set TaiKhoan ='admin', MatKhau=PWDENCRYPT('123456')
Where MaNV=1

insert [dbo].[NhanVien] ([MaNV], [HoTenNV], [Email], [TaiKhoan], [MatKhau], [SoDT]) values ('001', N'Truong Đinh Tien Anh', N'anhtruong.09102003@gmail.com', N'Admin', '123456', '0961558011')
insert [dbo].[NhanVien] ([MaNV], [HoTenNV], [Email], [TaiKhoan], [MatKhau], [SoDT]) values ('002', N'Nguyen Thi Kieu Anh', N'kieuk635@gmail.com', N'ka', '12345', '0763012341')
insert [dbo].[NhanVien] ([MaNV], [HoTenNV], [Email], [TaiKhoan], [MatKhau], [SoDT]) values ('003', N'Nguyen Co Trung Hau', N'hautkkk@gmail.com', N'th', '12345', '0234556789')





--===PARAMETERS

--Viết thủ tục kiểm tra đăng nhập
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
Create proc HSP_ThietBi_Select
@MaTB int =0
as
Select MaTB, TenTB, LoaiTB, Sl, TinhTrang, CurrentUser
from ChiTietTBi
where @MaTB=Case @MaTB when 0 then @MaTB else MaTB end

Go
Exec HSP_ThietBi_Select


Create proc HSP_ThietBi_InsertAndUpdate
@MaTB int, @TenTB nvarchar(100), @LoaiTB nvarchar(50), @TinhTrang nvarchar(50), @CurrentUser varchar(100)
as
if exists (select 1 from ChiTietTBi where MaTB=@MaTB)
begin
	update ChiTietTBi
	set TenTB=@TenTB, @LoaiTB = LoaiTB, @TinhTrang = TinhTrang, @CurrentUser = CurrentUser
	where MaTB = @MaTB
end
else
begin
	insert into ChiTietTBi(TenTB, LoaiTB, TinhTrang, CurrentUser)
	values(@TenTB, @LoaiTB, @TinhTrang, @CurrentUser)
end



Create proc HSP_ThietBi_Delete
@MaTB int
as
Delete ChiTietTBi
where MaTB = @MaTB
	


--===TRIGGER
--Cập nhật lại tình trạng Devices
CREATE TRIGGER SetCurrentUserToNull
ON ChiTietTBi after update
as
begin
	declare @MaTB INT;
	declare @TinhTrang VARCHAR(50);
	declare @CurrentUser VARCHAR(100);

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
CREATE TRIGGER UpdateBorrowerInfo
ON PhieuMuon AFTER update 
as
begin
	DECLARE @ReturnDate DATE;
    DECLARE @MaTB nvarchar(30);
	DECLARE @MaKH INT;
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
        FROM ChiTietTBi d
        WHERE d.MaTB = @MaTB; -- Nếu sử dụng SELECT vào biến thì cần phải sử dụng WHERE để chỉ định rõ điều kiện
    END;

    UPDATE PhieuMuon
    SET MaTB = @MaTB
    WHERE MaMuon = @MaMuon;

    UPDATE ChiTietTBi
    SET CurrentUser = @MaKH,
        TinhTrang = @TinhTrang
    WHERE MaTB = @MaTB;
end


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
@MaKH int, @HoKH VARCHAR(50), @TenKH VARCHAR(50), @SoDT NVARCHAR(11) 
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