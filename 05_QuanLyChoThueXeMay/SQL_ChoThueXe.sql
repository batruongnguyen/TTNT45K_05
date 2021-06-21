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

create table THUE(SoDT varchar(15) not null ,
MaX varchar(5) not null,
DamBao nvarchar(50) not null,
NgayThue date, GioThue time, NgayTra date, GioTra time,
ThoiGianThue int,
ThanhTien int)

alter table THUE
add constraint PK_THUE Primary Key (MaX,SoDT);

Alter table THUE drop constraint PK_THUE --Xoa lien ket

alter Table THUE
Add constraint FK_XE foreign key (MaX) references XE(MaX)

Alter table THUE drop constraint FK_XE --Xoa lien ket

alter Table THUE
Add constraint FK_KHACH foreign key (SoDT) references KHACH(SoDT)

Alter table THUE drop constraint FK_KHACH --Xoa lien ket

Insert into XE
values ('D01', 'Đang cho thuê', 'Màu Vàng', 'Xe Đap', '500'),
('D02', 'Hong', 'Màu Nâu', 'Xe Đap', '500'),
('D03', 'San co', 'Màu Đen', 'Xe Đap', '500'),
('M01', 'Đang cho thuê', 'Màu Vàng', 'Xe Máy', '1000'),
('M02', 'San co', 'Màu Vàng', 'Xe Máy', '1000'),
('M03', 'Đang cho thuê', 'Màu Xanh', 'Xe Máy', '1000'),
('M04', 'Hong', 'Màu Vàng', 'Xe Máy', '1000'),
('M05', 'Đang cho thuê', 'Màu Xanh', 'Xe Máy', '1000'),
('M06', 'San co', 'Màu Xanh', 'Xe Máy', '1000'),
('M07', 'Hỏng', 'Màu Trang', 'Xe Máy', '1000'),
('D04', 'Đang cho thuê', 'Màu Xanh', 'Xe Đap', '500'),
('D05', 'Đang cho thuê', 'Màu Vàng', 'Xe Đap', '500')

Insert into THUE (SoDT, MaX, DamBao, NgayThue,GioThue,NgayTra,GioTra)
values ('0905111', 'D01', 'Tien mat','2021-06-19','12:00:00','2021-06-20','11:30:00'),
('0905112', 'M01', 'Tien mat','2021-06-18','10:00:00','2021-06-20','09:30:00'),
('0905113', 'M05', 'Thẻ căn cước','2021-06-17','11:00:00','2021-06-20','11:30:00'),
('0905114', 'M03', 'Tien mat','2021-06-17','10:00:00','2021-06-20','10:30:00'),
('0905115', 'D04', 'Tien mat','2021-06-17','13:00:00','2021-06-20','13:30:00'),
('0905116', 'D05', 'CMT','2021-06-17','14:00:00','2021-06-20','14:30:00')


Insert into KHACH
values ('0905111', 'Nguyen A', 'P01'),
('0905112', 'Nguyen B', 'P02'),
('0905113', 'Nguyen C', 'P03'),
('0905114', 'Nguyen D', 'P04'),
('0905115', 'Nguyen E', 'P05'),
('0905116', 'Nguyen F', 'P06'),
('0905117', 'Nguyen G', 'P07')

drop table KHACH
drop table THUE
drop table XE


select*from XE
select*from THUE
select*from KHACH

Update THUE
Set Thoigianthue = iif(Datediff(day,Ngaythue,Ngaytra)=0,1,
datediff(day, Ngaythue,Ngaytra))

Update THUE
Set ThanhTien=Dongiathue*Thoigianthue
from THUE inner join XE on
THUE.MaX=XE.MaX