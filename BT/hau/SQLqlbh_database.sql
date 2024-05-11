create database QuanLyBanHang
go

use QuanLyBanHang
go

create table NhomNguoiDung(
	MaNhomNguoiDung int identity(1,1) primary key,
	TenNhomNguoiDung nvarchar(255) unique not null,
	IsDelete bit not null default(0)
)
go
create table NguoiDung(
	MaNguoiDung int identity(1,1) primary key,
	TenNguoiDung nvarchar(255) unique,
	TaiKhoan varchar(50) not null unique,
	MatKhau varbinary(MAX),
	DiaChi nvarchar(255),
	DienThoai varchar(20),
	Zalo varchar(20),
	Facebook varchar(255),
	Email varchar(50),
	IsDelete bit not null default(0),
	Constraint fk_NguoiDung_NhomNguoiDung foreign key (MaNguoiDung) references NhomNguoiDung(MaNhomNguoiDung)
)
go
create table ChucNang(
	MaChucNang int identity(1,1) primary key,
	TenChucNang nvarchar(255) not null unique,
	KiHieu varchar(255) not null unique,
	IsDelete bit not null default(0)
)
go
create table PhanQuyen(
	MaChucNang int not null,
	MaNhomNguoiDung int not null,
	TongQuyen int not null default(0),
	constraint pk_PhanQuyen primary key(MaChucNang,MaNhomNguoiDung),
	constraint fk_PhanQuyen_ChucNang foreign key (MaChucNang) references ChucNang(MaChucNang),
	constraint fk_PhanQuyen_NhomNguoiDung foreign key (MaNhomNguoiDung) references NhomNguoiDung(MaNhomNguoiDung),
)
go
Create table Nhacungcap(
	MaNCC int identity(1,1) primary key,
	TenNCC nvarchar(255) not null,
	ModifiedDate date null,
	CreateDate date not null default(getdate()),	
	Createby nvarchar(50)null,
	GhiChu nvarchar(255) null,
	IsDelete bit not null default(0)
)
go
create table LoaiSanPham(
	MaLoaiSanPham int identity(1,1) not null primary key,
	TenLoaiSanPham nvarchar(255) not null,
	IsDelete bit not null default(0)
)
go
create table DonViTinh(
	MaDonViTinh int identity(1,1) primary key,
	TenDonViTinh nvarchar(50) not null,
	GhiChu nvarchar(255) null,
	IsDelete bit not null default(0)
)
go
create table SanPham(
	MaSanPham int identity(1,1) primary key,
	TenSanPham nvarchar(255) not null,
	MaLoaiSP int not null,
	MaDVT int not null,
	MaNCC int not null,
	Color nvarchar(20),
	Size float,
	MaVach varchar(20) unique,
	constraint fk_SanPham_DonViTinh foreign key (MaDVT)
	references DonViTinh (MaDonViTinh),
	constraint fk_SanPham_LoaiSanPhan foreign key (MaLoaiSP)
	references LoaiSanPham(MaLoaiSanPham),
	constraint fk_SanPham_NhaCungCap foreign key (MaNCC)
	references NhaCungCap (MaNCC),
)
go
Create table PhieuNhap(
	MaPhieuNhap char(11) primary key,--20240321001 NgayNhap DateTime not null default(getdate()),
	NguoiNhap int not null,
	MoTa nvarchar(255),
	Constraint fk_PhieuNhap_NguoiDung foreign key(NguoiNhap)
	references NguoiDung (MaNguoiDung)
)
go
create table ChiTietPhieuNhap(
	MaPhieuNhap char(11) not null,
	MaSanPham int not null,
	SoLuongNhap int not null default(0),
	SoLuongNhapTon int not null default(0),
	DonGiaNhap int not null default(0),
	ThanhTienNhap as SoLuongNhap*DonGiaNhap
	Constraint pk_ChiTietPhieuNhap primary key (MaPhieuNhap,MaSanPham),
	constraint fk_ChiTietPhieuNhap_PhieuNhap foreign key (MaPhieuNhap) references PhieuNhap(MaPhieuNhap),
	constraint fk_ChiTietPhieuNhap_SanPham foreign key (MaSanPham) references SanPham(MaSanPham),
	constraint chk_SoluongNhapTon check (SoLuongNhapTon <= SoLuongNhap)
)


--Chu?n b? c c th? t?c (Store procedure) cho ch?c n?ng t?o m  phi?u
--// Function Pfc_SinhMaTuDong ?? sinh m  t? ??ng, c  th? d ng sinh m  phi?u nh?p, m  h a ??n.

CREATE FUNCTION Hfc_SinhMaTuDong(
@MaxID VARCHAR(20),--PN0000001
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
	--PN0000001
	SET @Result=@Asign+FORMAT(@number,@Format);
	RETURN @Result;
END
Go

--C ch d ng: select [dbo].[Pfc_SinhMaTuDong]('PN0000011',3,9,'PN','000000')



-- phương thức lấy mã phiếu nhập max
create proc HSP_PhieuNhap_LayMaxID
as
select isnull([dbo].[Hfc_SinhMaTuDong](max(MaPhieuNhap),3,9,'PN','0000000'),'PN0000001') MaxID
from PhieuNhap
 Ph??ng th?c Insert m  phi?u nh?p v o b?ng phi?u nh?p
Create proc HSP_PhieuNhap_Insert
@MaPhieuNhap char(9),
@MaNV int
as
insert into PhieuNhap(MaPhieuNhap, NgayNhap, MaNV, MoTa)
values(@MaPhieuNhap, GETDATE(), @MaNV, N'')

-- phương thức ktra phiếu nhập chưa hoàn thành theo user
Create PROC PSP_PhieuNhap_KiemTraPhieuTonTaiTheoUser 
@MaNhanVien CHAR(9)
AS
IF EXISTS( SELECT 1 FROM dbo.PhieuNhap WHERE MaNV=@MaNhanVien AND TrangThai=0)
BEGIN
    SELECT DISTINCT MaPhieuNhap FROM dbo.PhieuNhap WHERE MaNV=@MaNhanVien AND TrangThai=0
END
ELSE
BEGIN
    SELECT 'no'  MaPhieuNhap
END

--Viết Store procedure để load dữ liệu lên ComboBox
Go
-- lay dsslsp
Create proc PSP_LoaiSanPham_SelecToComboBox
as
select MaLoaiSanPham, TenLoaiSanPham
from LoaiSanPham
where ISDelete =0
Go

-- lay dsdvt
Create Proc PSP_DonViTinh_SelectToComboBox
as
Select MaDonViTinh, TenDonViTinh
from donviTinh
where isdelete=0

--  lay dssp
go
create proc PSP_SanPham_SelectToComboBox
@MaLoaiSanPham int
as
select MaSanPham, TenSanPham
 + ' { ' +Convert(varchar(20), SoLuongTon)+' ' + TenDonViTinh +' }' as TenSanPham
from SanPham a join DonViTinh b on a.maDonViTinh=b.MaDonViTinh
where a.isdelete=0 and MaLoaiSanPham=@MaLoaiSanPham





--===Trigger cập nhật số tồn trong bảng sản phẩm

CREATE TRIGGER UpdateSoLuongTon_Insert
ON ChiTietPhieuNhap
AFTER INSERT
AS
BEGIN
    UPDATE SanPham
    SET SoLuongTon = SoLuongTon + i.SoLuongNhap
    FROM SanPham sp
    INNER JOIN inserted i ON sp.IDSanPham = i.IDSanPham;
END;
Go

CREATE TRIGGER UpdateSoLuongTon_Update
ON ChiTietPhieuNhap
AFTER UPDATE
AS
BEGIN
    UPDATE [dbo].[SanPham]
    SET SoLuongTon = sp.SoLuongTon + (i.SoLuongNhap - d.SoLuongNhap)
    FROM SanPham sp
    INNER JOIN inserted i ON sp.MaSanPham = i.MaSanPham
    INNER JOIN deleted d ON i.masanpham=d.masanpham and i.maphieunhap=d.maphieunhap;
END;
GO

CREATE TRIGGER UpdateSoLuongTon_Delete
ON ChiTietPhieuNhap
AFTER DELETE
AS
BEGIN
    UPDATE SanPham
    SET SoLuongTon = SoLuongTon - d.SoLuongNhap
    FROM SanPham sp
    INNER JOIN deleted d ON sp.MaSanPham = d.MaSanPham;
END;



--===Phiếu nhập
--Lấy Phiếu Nhập
Create proc HSP_PhieuNhap_Select
@MaPhieuNhap int =0
as
Select MaPhieuNhap, NgayNhap, MaNV, MoTa, TrangThai
from [dbo].[PhieuNhap]
where @MaPhieuNhap =Case @MaPhieuNhap when 0 then @MaPhieuNhap else MaPhieuNhap end

--Hủy phiếu nhập
CREATE PROCEDURE HSP_PhieuNhap_HuyPhieuNhap
    @MaPhieuNhap NVARCHAR(50)
AS
BEGIN
    -- Kiểm tra xem phiếu nhập có tồn tại không
    IF EXISTS (SELECT 1 FROM PhieuNhap WHERE MaPhieuNhap = @MaPhieuNhap)
    BEGIN
        BEGIN TRY
            BEGIN TRANSACTION;

            -- Xóa các sản phẩm liên quan đến phiếu nhập
            DELETE FROM ChiTietPhieuNhap WHERE MaPhieuNhap = @MaPhieuNhap;

            -- Xóa phiếu nhập
            DELETE FROM PhieuNhap WHERE MaPhieuNhap = @MaPhieuNhap;

            COMMIT;
            -- Trả về kết quả thành công
            SELECT 1 AS Result;
        END TRY
        BEGIN CATCH
            ROLLBACK;
            -- Trả về kết quả lỗi
            SELECT 0 AS Result;
        END CATCH
    END
    ELSE
    BEGIN
        -- Trả về kết quả lỗi nếu phiếu nhập không tồn tại
        SELECT 0 AS Result;
    END
END

--Xóa phiếu nhập

Create proc HSP_PhieuNhap_Delete
@MaPhieuNhap int
as
Delete PhieuNhap
where MaPhieuNhap=@MaPhieuNhap



--===proc ChiTietPhieuNhap
Create proc PSP_ChiTietPhieuNhap_Select 
@MaPhieuNhap char(9)
as
SELECT 0 as STT, a.MaSanPham, TenSanPham, a.DonViTinh,TenDonViTinh, SoLuongNhap, DonGiaNhap, SoluongNhap*DongiaNhap as ThanhTien
FROM Chitietphieunhap a join phieunhap b on a.maphieunhap=b.maphieunhap
JOIN sanpham c on a.masanpham=c.masanpham join DonViTinh d on d.madonvitinh=a.donvitinh
where a.MaPhieuNhap=@MaPhieuNhap

