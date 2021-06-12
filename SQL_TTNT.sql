Create database ChoThue_Xe
Use ChoThue_Xe
--
Create table Xe (MaX varchar(5) not null primary key,
TinhTrang Nvarchar(50) not null, MoTa Nvarchar(100) not null,
Loai Nvarchar (50) not null, DonGiaThuc int)
--
Create table Khach_Hang(SoDT varchar(15) not null primary key,
Ten Nvarchar(100) not null, DiaChi Nvarchar(100) not null)
--
Create table Thue_Xe (SoDT varchar(15) not null primary key,
MaX varchar(5) not null, DamBao Nvarchar(50) not null, NgayThue Date,
GioThue Time, NgayTra date, GioTra time, ThanhTien int)
--
alter Table Thue_Xe
Add constraint FK_Xe foreign key(MaX) references Xe(MaX)
--
alter Table Thue_Xe
Add constraint FK_Khach_Hang foreign key (SoDT) references Khach_Hang(SoDT)
