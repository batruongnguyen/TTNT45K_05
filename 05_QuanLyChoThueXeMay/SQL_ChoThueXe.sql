create database choThueXe
use choThueXe


--Tạo bảng
create table XE(MaX varchar(5) not null primary key,
TinhTrang nvarchar(50) not null, 
MoTa nvarchar(100) not null,
Loai nvarchar(50) not null,
DonGiaThue int not null)

create table KHACH(SoDT varchar(15) not null primary key,
Ten nvarchar(100) not null,
DiaChi nvarchar(100) not null)

create table THUE(MaHD int identity (1,1) primary key, SoDT varchar(15) not null ,
MaX varchar(5) not null,
DamBao nvarchar(50) not null,
NgayThue date, GioThue time, NgayTra date, GioTra time,
ThoiGianThue int,
ThanhTien int,
TinhTrang bit)


--Nhập dữ liệu
Insert into XE
values ('D01', N'Sẵn có', N'Màu Vàng', N'Xe Đạp', '500'),
('D02', N'Hỏng', N'Màu Nâu', N'Xe Đạp', '500'),
('D03', N'Sẵn có', N'Màu Đen', N'Xe Đạp', '500'),
('M01', N'Sẵn có', N'Màu Vàng', N'Xe Máy', '1000'),
('M02', N'Sẵn có', N'Màu Vàng', N'Xe Máy', '1000'),
('M03', N'Sẵn có', N'Màu Xanh', N'Xe Máy', '1000'),
('M04', N'Hỏng', N'Màu Vàng', N'Xe Máy', '1000'),
('M05', N'Sẵn có', N'Màu Xanh', N'Xe Máy', '1000'),
('M06', N'Sẵn có', N'Màu Xanh', N'Xe Máy', '1000'),
('M07', N'Hỏng', N'Màu Trắng', N'Xe Máy', '1000'),
('D04', N'Sẵn có', N'Màu Xanh', N'Xe Đạp', '500'),
('D05', N'Sẵn có', N'Màu Vàng', N'Xe Đạp', '500')



Insert into KHACH
values ('0905111', N'Nguyễn Văn Anh', 'P01'),
('0905112', N'Nguyễn Thị Bình', 'P02'),
('0905113', N'Trần Văn Cường', 'P03'),
('0905114', N'Huỳnh Văn Đạt', 'P04'),
('0905115', N'Huỳnh Công Minh', 'P05'),
('0905116', N'Hồ Nhật Thành', 'P06'),
('0905117', N'Hồ Văn Thanh', 'P07'),
('0935118', N'Đàm Văn An', 'P07')


--Tạo liên kết
alter Table THUE
Add constraint FK_XE foreign key (MaX) references XE(MaX)

alter Table THUE
Add constraint FK_KHACH foreign key (SoDT) references KHACH(SoDT)


--Xem bảng
select*from XE
select * from THUE 
select*from KHACH

-- TRIGGER INSERT
CREATE TRIGGER InsertTinhTrangXe on Thue
FOR Insert
AS 
BEGIN
	declare @MaX varchar(5),@TinhTrangThue nvarchar(50)
	select @MaX = ins.MaX, @TinhTrangThue = ins.TinhTrang from inserted ins
	if(@TinhTrangThue = 0)
	BEGIN
		update Xe
		set TinhTrang = N'Đang cho thuê'
		where MaX = @MaX
	END
END

-- TRIGGER UPDATE
CREATE TRIGGER UpdateTinhTrangXe on Thue
FOR UPDATE
AS
BEGIN
	declare @MaX varchar(5),@TinhTrangThue nvarchar(50)
	select @MaX = ins.MaX, @TinhTrangThue = ins.TinhTrang from inserted ins
	if(@TinhTrangThue = 1)
	BEGIN
		update Xe
		set TinhTrang = N'Sẵn có'
		where MaX = @MaX
	END
END 

-- TRIGGER DELETE
CREATE TRIGGER DeleteTinhTrangXe on Thue
FOR Delete
AS 
BEGIN
	declare @MaX varchar(5),@TinhTrangThue nvarchar(50)
	select @MaX = del.MaX, @TinhTrangThue = del.TinhTrang from deleted del
	if(@TinhTrangThue = 1)
	BEGIN
		update Xe
		set TinhTrang = N'Sẵn có'
		where MaX = @MaX
	END
END


--FUNCTION 
create function TimDoanhThu
(@Loai nvarchar(50))
returns INT
AS
BEGIN
	declare @res INT
	select @res = sum(ThanhTien) from thue inner join xe on THUE.MaX=XE.MaX where Loai = @Loai group by Loai
	RETURN @res
END





