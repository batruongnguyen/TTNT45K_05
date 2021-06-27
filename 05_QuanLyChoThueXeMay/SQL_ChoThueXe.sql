create database ChoThueXe
use ChoThueXe

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
ThanhTien int)

/*alter table THUE
add constraint PK_THUE Primary Key (MaX,SoDT);
Alter table THUE drop constraint PK_THUE --Xoa lien ket*/

alter Table THUE
Add constraint FK_XE foreign key (MaX) references XE(MaX)

alter Table THUE
Add constraint FK_KHACH foreign key (SoDT) references KHACH(SoDT)


Alter table THUE drop constraint FK_XE --Xoa lien ket
Alter table THUE drop constraint FK_KHACH --Xoa lien ket

Insert into XE
values ('D01', 'Dang cho thue', 'Mau Vang', 'Xe Dap', '500'),
('D02', 'Hong', 'Mau Nau', 'Xe Dap', '500'),
('D03', 'San co', 'Mau Den', 'Xe Dap', '500'),
('M01', 'Dang cho thue', 'Mau Vang', 'Xe May', '1000'),
('M02', 'San co', 'Mau Vang', 'Xe May', '1000'),
('M03', 'Dang cho thue', 'Mau Xanh', 'Xe May', '1000'),
('M04', 'Hong', 'Mau Vang', 'Xe May', '1000'),
('M05', 'Dang cho thue', 'Mau Xanh', 'Xe May', '1000'),
('M06', 'San co', 'Mau Xanh', 'Xe May', '1000'),
('M07', 'Hong', 'Mau Trang', 'Xe May', '1000'),
('D04', 'Dang cho thue', 'Mau Xanh', 'Xe Dap', '500'),
('D05', 'Dang cho thue', 'Mau Vang', 'Xe Dap', '500')

Insert into THUE (SoDT, MaX, DamBao, NgayThue,GioThue,NgayTra,GioTra)
values ('0905111', 'D01', 'Tien mat','2021-06-19','12:00:00','2021-06-20','11:30:00'),
('0905112', 'M01', 'Tien mat','2021-06-18','10:00:00','2021-06-20','09:30:00'),
('0905113', 'M05', 'The can cuoc','2021-06-17','11:00:00','2021-06-20','11:30:00'),
('0905114', 'M03', 'Tien mat','2021-06-17','10:00:00','2021-06-20','10:30:00'),
('0905115', 'D04', 'Tien mat','2021-06-17','13:00:00','2021-06-20','13:30:00'),
('0905116', 'D05', 'CMT','2021-06-17','14:00:00','2021-06-20','14:30:00')


Insert into KHACH
values ('0905111', 'Nguyen Van A', 'P01'),
('0905112', 'Nguyen Thi B', 'P02'),
('0905113', 'Nguyen Tran Van C', 'P03'),
('0905114', 'Huynh Van D', 'P04'),
('0905115', 'Huynh Cong E', 'P05'),
('0905116', 'Ho Nhat F', 'P06'),
('0905117', 'Ho Van G', 'P07'),
('0935118', 'Tran Van F', 'P07')

drop table KHACH
drop table THUE
drop table XE


select*from XE
select * from THUE 
select*from KHACH

Update THUE
Set Thoigianthue = iif(Datediff(day,Ngaythue,Ngaytra)=0,1,
datediff(day, Ngaythue,Ngaytra))

Update THUE
Set ThanhTien=Dongiathue*Thoigianthue
from THUE inner join XE on
THUE.MaX=XE.MaX


/*
insert into Thue values 
(
	'0905113',
	'D04',
	'CMT',
	'2019-10-25',
	'12:00',
	'2019-10-26',
	'12:00',
	NULL,
	NULL
)*/





