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

create table THUE(SoDT varchar(15) not null,
MaX varchar(5) not null,
DamBao nvarchar(50) not null,
NgayThue date, GioThue time, NgayTra date, GioTra time,
ThanhTien int,

constraint PK_THUE primary key clustered (SoDT ASC, MaX ASC) 
With (PAD_Index=off, statistics_norecompute=off, ignore_dup_key=off,ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]) ON [PRIMARY]

alter Table THUE
Add constraint FK_XE foreign key (MaX) references XE(MaX)

alter Table THUE
Add constraint FK_KHACH foreign key (SoDT) references KHACH(SoDT)
