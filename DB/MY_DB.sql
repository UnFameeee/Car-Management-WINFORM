create database WINFORM
use WINFORM

--Tài khoản, mật khẩu người dùng
create table ACCOUNT(
	Username varchar(100), --Khoá chính
	Password varchar(100),
	Gmail varchar(100)
)

--Tài khoản admin
insert into ACCOUNT values ('admin', 'admin', 'plong8338@gmail.com')





-- tạm thời để yên chưa đụng
create table Xe(	
	LoaiXe varchar(30),
	BienSoXe varchar(50),
	)

create table CongViec(
	ViecLam varchar(50) primary key,
	Thoigian int
	)

create table Tho(
	IDTho varchar(50) primary key,
	Ten varchar(100),
	ViecLam varchar(50) references CongViec(ViecLam),
	Luong int
	)

create table ChuyenMon(
	
	)

create table HopDong(
	
	)

