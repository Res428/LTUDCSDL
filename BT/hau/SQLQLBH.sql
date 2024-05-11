--KHACH HANG
Create proc HSP_240305_KhachHang_Select
@MaKH int =0
as
Select MaKH, HoKH, TenKh, DcKH, DtKH
from [dbo].[KhachHang]
where @MaKH=Case @MaKH when 0 then @MaKH else MaKH end

Go
Exec HSP_240305_KhachHang_Select


Create proc HSP_240305_KhachHang_InsertAndUpdate
@MaKH int, @HoKH nvarchar(100), @TenKh nvarchar(50), @DcKH nvarchar(200), @DtKH varchar(20)
as
if exists (select 1 from KhachHang where MaKH=@MaKH)
begin
	update KhachHang
	set HoKH=@HoKH, TenKh=@TenKh,DcKH=@DcKH,DtKH=@DcKH
	where MaKH=@MaKH
end
else
begin
	insert into KhachHang(HoKH, TenKh, DcKH, DtKH)
	values( @HoKH, @TenKh, @DcKH, @DtKH)
end



Create proc HSP_240305_KhachHang_Delete
@MaKH int
as
Delete KhachHang
where MaKH=@MaKH


--NHAN VIEN
Update NhanVien
Set TaiKhoan ='Admin', MatKhau=PWDENCRYPT('123456')
Where MaNV=1

--Viết thủ tục kiểm tra đăng nhập
Create Proc HSP_NhanVien_KiemTraDangNhap
@TaiKhoan varchar(50),
@MatKhau varchar(50)
as
if exists (select 1 from NhanVien where TaiKhoan= @TaiKhoan and PWDCOMPARE(@MatKhau,MatKhau)=1)
begin 
	select 1 as Code,MaNV,HoTenNV, TaiKhoan, GroupID
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





---Mat khau
create proc HSP_NhanVien_SelectToCboTaiKhoan
as
select TaiKhoan, HoTenNV + '{ '+ CONVERT(varchar, MaNV) +'}'
	as HoTenNV
from NhanVien
where TaiKhoan is not null


go
create proc HSP_NhanVien_DoiMatKhau
@TaiKhoan varchar(20), @MatKhau varchar(20)
as
Update NhanVien
Set MatKhau=PWDENCRYPT(@MatKhau)
Where TaiKhoan = @TaiKhoan
--Chỉnh sửa thủ tục kiểm tra đăng nhập để lấy thêm thông tin taikhoan và groupID khi đăng nhập
ALTER Proc [dbo].[PSP_201103_NhanVien_KiemTraDangNhap]
@TaiKhoan varchar(50),
@MatKhau varchar(50)
as
if exists (select 1 from NhanVien where TaiKhoan=@TaiKhoan and PWDCOMPARE(@MatKhau,MatKhau)=1)
begin 
	select 1 as Code,MaNV,HoTenNV,TaiKhoan,GroupID
	from NhanVien
	where TaiKhoan=@TaiKhoan and PWDCOMPARE(@MatKhau,MatKhau)=1
end
else
begin 
	select 0 as Code,'' as MaNV,N'' as HoTenNV,' ' as TaiKhoan,0 as GroupID
end




--LOAI HANG
Create proc HSP_240306_LoaiHang_Select
@MaLH int =0
as
Select MaLH, TenLH
from [dbo].[LoaiHang]
where @MaLH=Case @MaLH when 0 then @MaLH else MaLH end

Go
Exec HSP_240306_LoaiHang_Select


Create proc HSP_240306_LoaiHang_InsertAndUpdate
@MaLH int, @TenLH nvarchar(50)
as
if exists (select 1 from LoaiHang where MaLH=@MaLH)
begin
	update LoaiHang
	set TenLH=@TenLH
	where MaLH=@MaLH
end
else
begin
	insert into LoaiHang(TenLH)
	values(@TenLH)
end



Create proc HSP_240306_LoaiHang_Delete
@MaLH int
as
Delete LoaiHang
where MaLH=@MaLH





create table GroupUser(
	GroupID int identity(1,1) primary key,
	GroupName nvarchar(50) not null,
	IsDelete bit default(0),
)
go
insert into GroupUser(GroupName)
values(N'Admin'),(N'User')
go
Create table Functions(
	FuncID int identity(1,1) primary key,
	FuncName nvarchar(100) not null,
	Alias varchar(100),
	IsDelete bit default(0)
)
go
insert into Functions(FuncName,Alias)
values(N'Quản lý người dùng','frm_QuanLyNguoiDung_Main'),(N'Quản lý Khách Hàng','frm_QuanLyKhachHang_Main')

go
Create Table PhanQuyen(
	GroupID int not null,
	FuncID int not null,
	Total int default(0) not null,
	Constraint pk_PhanQuyen primary key(GroupID,FuncID),
	Constraint fk_PhanQuyen_GroupUser foreign key(GroupID) references GroupUser(GroupID),
	Constraint fk_PhanQuyen_Functions foreign key(FuncId) references Functions(FuncId)
)
go
Insert Into PhanQuyen(GroupID,FuncID,Total)
values(1,1,15),(1,2,15),(2,1,3),(2,2,3)



--Thực viết Trigger để tạo dữ liệu tự động cho bảng phân quyền
Create Trigger HSP_GroupUser_ThemPhanQuyen
on [dbo].[GroupUser]
after insert
as
Declare @FuncID int;
declare @GroupID int;
set @GroupID=(select GroupID from inserted)

Declare cursor_name cursor for
select FuncID from [dbo].[Functions] where IsDelete=0;

open cursor_name;
Fetch next from cursor_name
into @FuncID
while @@FETCH_STATUS=0
begin
	insert into PhanQuyen(FuncID,GroupID)
	values(@FuncID,@GroupID)
	Fetch next from cursor_name
into @FuncID
end
close cursor_name
Deallocate cursor_name

go
--Trigger thứ hai trên bảng functions
Create Trigger [dbo].[HSP_ChucNang_ThemPhanQuyen]
on [dbo].[Functions]
after insert
as
Declare @FuncID int;
declare @GroupID int;
set @FuncID=(select FuncID from inserted)

Declare cursor_name cursor for
select GroupID from [dbo].[GroupUser] where IsDelete=0;
-- mở con trỏ
open cursor_name;
Fetch next from cursor_name
into @GroupID
while @@FETCH_STATUS=0
begin
	insert into PhanQuyen(FuncID,GroupID)
	values(@FuncID,@GroupID)
	Fetch next from cursor_name
into @GroupID
end
close cursor_name
Deallocate cursor_name


--Store Procedure để lấy danh sách Group User cho ComboBox trên Form
Create Proc HSP_GroupUser_SelectToCombo
as
Select GroupID, GroupName
from GroupUser
where IsDelete=0
Go
--Test Thủ tục
Exec HSP_GroupUser_SelectToCombo
Go
--Store procedure lấy danh sách quyền theo từng chức năng của Group User 
Create proc HSP_PhanQuyen_SelectToGrid 
@GroupID int =0
as
select ROW_NUMBER() over (order by (select 1)) as STT,a.GroupID, a.FuncID,FuncName,Alias,
case Total&1 when 1 then 1 else 0 end as Xem,
case Total&2 when 2 then 1 else 0 end  as Them, 
case Total&4 when 4 then 1 else 0 end  as Sua, 
case Total&8 when 8 then 1 else 0 end  as Xoa,
Total as Tong
from PhanQuyen a join Functions b on a.FuncID=b.FuncId
where @GroupID=Case @GroupID when 0 then @GroupID else GroupID end
Go
--Test thủ tục
HSP_PhanQuyen_SelectToGrid 2
Go
--Store procedure để cập nhật bảng phân quyền 
Create proc HSP_PhanQuyen_InsertAndUpdate
@FuncID int,
@GroupID int,
@Total int

as
if exists (select 1 from PhanQuyen where FuncID=@FuncID and GroupID=@GroupID)
begin
	update PhanQuyen
	set Total=@Total
	where FuncID=@FuncID and GroupID=@GroupID
end
else
begin 
	Insert into PhanQuyen(GroupID, FuncID, Total)
	values(@GroupID, @FuncID, @Total)
End
GO
--Test thủ tục
Exec HSP_PhanQuyen_InsertAndUpdate 1,1,15
Go
-- Store procedure lấy quyền của nhân viên khi đăng nhập
Create proc HSP_PhanQuyen_Select 
@MaNV int
as
Select MaNV,HoTenNV,TaiKhoan,c.FuncID,Alias, c.GroupID,GroupName,Total
from NhanVien a join GroupUser b on a.GroupID=b.GroupID join PhanQuyen c on c.GroupID=b.GroupID join Functions d on d.FuncID=c.FuncID
where MaNV=@MaNV



--Thủ tục để sao lưu dữ liệu
Create Proc HSP_Backup
	@Path nvarchar(max)
as
begin
	declare @dbname nvarchar(50)
	set @dbname =  DB_NAME()

	BACKUP DATABASE @dbname
	TO  DISK = @Path
	WITH NOFORMAT, NOINIT,  
	SKIP, NOREWIND, NOUNLOAD,  STATS = 10
	select ErrorCode = 1
end
