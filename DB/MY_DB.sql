create database WINFORM
GO
use WINFORM
go
---------------------------------------------------------------------------------------------------------------------------------------------

create table POSITION(
	PositionID varchar(100) primary key,									-- 1 là quản lý, 2 là nhân viên, 3 là khách hàng
	Description text
)

INSERT INTO POSITION VALUES ('1', 'Manager') 
INSERT INTO POSITION VALUES ('2', 'Staff') 
INSERT INTO POSITION VALUES ('3', 'Customer') 

-- Tài khoản, mật khẩu người dùng || Quy định mỗi nhân viên chỉ được có 1 tài khoản
create table ACCOUNT(									
	Username varchar(100) Primary key,										--Khoá chính					 
	Password varchar(100),
	PositionID varchar(100) references POSITION(PositionID)					
)
----thêm khoá ngoại
--Alter Table EMPLOYEE add constraint accIDwithEM FOREIGN KEY (AccountID) references ACCOUNT(AccountID)

-- Tài khoản admin
insert into ACCOUNT values ('admin', 'admin', '1')	--TK quản lý

---------------------------------------------------------------------------------------------------------------------------------------------
-- Công Việc
create table JOB(
	JobID varchar(100) primary key,									-- 1 = sửa, 2 = rửa, 3 = trông coi xe
	Description varchar(1000)
)
INSERT INTO JOB VALUES('QL', 'Manager')
INSERT INTO JOB VALUES('NV', 'Staff')
INSERT INTO JOB VALUES('KH', 'Customer')

-- Ca Làm
create table WORKSHIFT(
	ShiftID int primary key,										-- suy nghĩ chia ca
	TimeBegin time,
	TimeEnd time
)
INSERT INTO WORKSHIFT VALUES(1, '00:00:00', '08:00:00')
INSERT INTO WORKSHIFT VALUES(2, '08:00:00', '16:00:00')
INSERT INTO WORKSHIFT VALUES(3, '16:00:00', '00:00:00')

-- Nhân viên
create table EMPLOYEE(
	EmpID varchar(100) primary key,									-- mã nhân viên
	FullName varchar(100),
	Gender varchar(100),
	PhoneNumber varchar(100),
	IdentityNumber varchar(100),
	JobID varchar(100) references JOB(JobID),
	Appearance image,
	AccUsername varchar(100) references ACCOUNT(Username)		
)
INSERT INTO EMPLOYEE VALUES('NV01', 'Fernando Torres', 'Male', '0123456789', '079201006666', 'QL', null, 'admin') 

-- Quản lý
create table MANAGER(
	ManagerID varchar(100) primary key,
	ShiftID int references WORKSHIFT(ShiftID)						--quản lý ca nào, có bao nhiêu nhân viên trong ca đấy bị này quản lý
)
---------------------------------------------------------------------------------------------------------------------------------------------------------------
-- Khách Hàng
create table CUSTOMER(
	CusID varchar(100) primary key,
	FullName varchar(100),
	Bdate date,
	PhoneNumber varchar(100),
	Address varchar(100),
	IdentityNumber varchar(100),
	Appearance image
)

--Xe
create table TRANSPORT(
	TransID varchar(100) primary key,
	Type varchar(100),												-- loại xe
	LicensePlate varchar(100),										-- biển số xe
	Picture image,
	CusID varchar(100) references CUSTOMER(CusID)
)

--Xe
create table TRANSPORT(
	TransID varchar(100) primary key,
	Type varchar(100),												-- loại xe
	LicensePlate varchar(100),										-- biển số xe
	Picture image,
	CusID varchar(100) references CUSTOMER(CusID)
)

-- Hợp Đồng
create table CONTRACT(
	ContID varchar(100) primary key,
	CusID varchar(100) references CUSTOMER(CusID),
	ManagerID varchar(100) references MANAGER(ManagerID),
	EmpID varchar(100) references EMPLOYEE(EmpID),
	Purpose varchar(100),											--Mục đích (thuê, ....)
	Description text
)
