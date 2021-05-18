create database WINFORM
GO
use WINFORM
go
---------------------------------------------------------------------------------------------------------------------------------------------

create table POSITION(
	PositionID nvarchar(100) primary key,									-- 1 là quản lý, 2 là nhân viên, 3 là khách hàng
	Description text
)

INSERT INTO POSITION VALUES ('1', 'Manager') 
INSERT INTO POSITION VALUES ('2', 'Staff') 
INSERT INTO POSITION VALUES ('3', 'Customer') 

-- Tài khoản, mật khẩu người dùng || Quy định mỗi nhân viên chỉ được có 1 tài khoản
create table ACCOUNT(									
	Username nvarchar(100) Primary key,										--Khoá chính					 
	Password nvarchar(100),
	PositionID nvarchar(100) references POSITION(PositionID)					
)
----thêm khoá ngoại
--Alter Table EMPLOYEE add constraint accIDwithEM FOREIGN KEY (AccountID) references ACCOUNT(AccountID)

-- Tài khoản admin
insert into ACCOUNT values ('admin', 'admin', '1')	--TK quản lý

---------------------------------------------------------------------------------------------------------------------------------------------
-- Công Việc
create table JOB(
	JobID nvarchar(100) primary key,									-- 1 = sửa, 2 = rửa, 3 = trông coi xe
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
	EmpID nvarchar(100) primary key,									-- mã nhân viên
	FullName nvarchar(100),
	Gender nvarchar(100),
	PhoneNumber nvarchar(100),
	IdentityNumber nvarchar(100),
	JobID nvarchar(100) references JOB(JobID),
	Appearance image,
	AccUsername nvarchar(100) references ACCOUNT(Username)		
)
INSERT INTO EMPLOYEE VALUES('NV01', 'Fernando Torres', 'Male', '0123456789', '079201006666', 'QL', null, 'admin') 

-- Quản lý
create table MANAGER(
	ManagerID nvarchar(100) primary key,
	ShiftID int references WORKSHIFT(ShiftID)						--quản lý ca nào, có bao nhiêu nhân viên trong ca đấy bị này quản lý
)
---------------------------------------------------------------------------------------------------------------------------------------------------------------
-- Thành Tiền
create table INVOICE(
	InvoiceID nvarchar(100) primary key,
	Description text
)

INSERT INTO INVOICE VALUES('H', 'Hour')								-- theo giờ
INSERT INTO INVOICE VALUES('D', 'Day')								-- theo ngày
INSERT INTO INVOICE VALUES('W', 'Week')								-- theo tuần
INSERT INTO INVOICE VALUES('M', 'Month')							-- theo tháng

-- Khách Hàng
create table CUSTOMER(
	CusID nvarchar(100) primary key,
	FullName nvarchar(100),
	Bdate date,
	PhoneNumber nvarchar(100),
	Address nvarchar(100),
	IdentityNumber nvarchar(100),
	Appearance image
)

--Xe
create table VEHICLE(
	VehID nvarchar(100) primary key,
	VehType nvarchar(100),											-- loại xe
	LicensePlate nvarchar(100),										-- biển số xe
	Picture image,
	CusID nvarchar(100) references CUSTOMER(CusID)
)


--Thông tin của chỗ đỗ xe
create table PARKING(
	CusID nvarchar(100) references CUSTOMER(CusID),
	VehID nvarchar(100) references VEHICLE(VehID),
	DateRegister datetime,
	DateLeave datetime,
	InvoiceID nvarchar(100) references INVOICE(InvoiceID),
	PRIMARY KEY(CusID, VehID)
)

-- Hợp Đồng
create table CONTRACT(
	ContID nvarchar(100) primary key,
	CusID nvarchar(100) references CUSTOMER(CusID),
	ManagerID nvarchar(100) references MANAGER(ManagerID),
	EmpID nvarchar(100) references EMPLOYEE(EmpID),
	Purpose nvarchar(100),											--Mục đích (thuê, ....)
	Description text
)