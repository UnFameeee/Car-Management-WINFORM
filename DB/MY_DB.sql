create database WINFORM
GO
use WINFORM
go
---------------------------------------------------------------------------------------------------------------------------------------------

create table POSITION(
	PositionID nvarchar(100) primary key,									-- 1 là quản lý, 2 là nhân viên, 3 là nhân viên văn phòng
	Description text,
	Coefficient int
)

INSERT INTO POSITION VALUES ('1', 'Manager', 25000) 
INSERT INTO POSITION VALUES ('2', 'Employee', 15000) 
INSERT INTO POSITION VALUES ('3', 'Officer', 20000) 
GO


-- Tài khoản, mật khẩu người dùng || Quy định mỗi nhân viên chỉ được có 1 tài khoản
create table ACCOUNT(									
	Username nvarchar(100) Primary key,										--Khoá chính					 
	Password nvarchar(100),
	PositionID nvarchar(100) references POSITION(PositionID)					
)
-- Tài khoản admin
insert into ACCOUNT values ('admin', 'admin', '1')			--TK quản lý
insert into ACCOUNT values ('emp', 'emp', '2')				--TK nhân viên
insert into ACCOUNT values ('office', 'office', '3')		--TK nhân viên văn phòng
insert into ACCOUNT values ('emp2', 'emp2', '2')				--TK nhân viên
insert into ACCOUNT values ('emp3', 'emp3', '2')				--TK nhân viên
insert into ACCOUNT values ('emp4', 'emp4', '2')				--TK nhân viên
GO
---------------------------------------------------------------------------------------------------------------------------------------------
-- Ca Làm
create table WORKSHIFT(
	ShiftID int primary key,										-- suy nghĩ chia ca
	TimeBegin time,
	TimeEnd time
)
INSERT INTO WORKSHIFT VALUES(1, '00:00:00', '08:00:00')
INSERT INTO WORKSHIFT VALUES(2, '08:00:00', '16:00:00')
INSERT INTO WORKSHIFT VALUES(3, '16:00:00', '00:00:00')
GO

-- Nhân viên
create table EMPLOYEE(
	EmpID nvarchar(100) primary key,									-- mã nhân viên
	FullName nvarchar(100),
	Gender nvarchar(100),
	Birthday Date,
	PhoneNumber nvarchar(100),
	IdentityNumber nvarchar(100),
	Email nvarchar(100),
	JobID nvarchar(100) references POSITION(PositionID),
	Appearance image,
	AccUsername nvarchar(100) references ACCOUNT(Username)		
)
INSERT INTO EMPLOYEE VALUES('NV1', 'Fernando Torres', 'Male', '2-2-2000', '0123456789', '079201006666', 'email@gmail.com', '1', null, 'admin') 
INSERT INTO EMPLOYEE VALUES('NV2', 'Nguyen hai du', 'Male', '2-2-1999', '9876543210', '079201006667', 'email@gmail.com', '3', null, 'office') 
INSERT INTO EMPLOYEE VALUES('NV3', 'Nguyen pham quoc thang', 'Male', '2-2-1998', '8876543210', '089201006667', 'email@gmail.com', '2', null, 'emp') 
INSERT INTO EMPLOYEE VALUES('NV4', 'Dang nhat tien', 'Female', '2-2-1998', '8876543210', '089201006667', 'email@gmail.com', '2', null, 'emp2') 
INSERT INTO EMPLOYEE VALUES('NV5', 'Thach duong duy', 'Female', '2-2-1998', '8876543210', '089201006667', 'email@gmail.com', '2', null, 'emp3') 
INSERT INTO EMPLOYEE VALUES('NV6', 'Nguyen minh dang', 'Male', '2-2-1998', '8876543210', '089201006667', 'email@gmail.com', '2', null, 'emp4') 
GO

CREATE TABLE TIMEKEEPING
(
	EmpID NVARCHAR(100),																--ID nhân viên
	CheckIn DATETIME,																	--Thời gian check in
	CheckOut DATETIME																	--Thời gian check out
	FOREIGN KEY (EmpID) REFERENCES dbo.EMPLOYEE(EmpID)
	PRIMARY KEY (EmpID, CheckIn)
)

--Tạo bảng lương nhân viên
CREATE TABLE SALARY
(
	EmpID NVARCHAR(100),																--ID nhân viên
	MonthWork INT,																		--Tháng của lương
	YearWork INT,																		--Năm của lương																--Thưởng																	--Phạt
	NumberofHourWork REAL,																--Số tiếng đã làm
	SalaryEmployee REAL DEFAULT 0,														--Lương nhân viên
	FOREIGN KEY (EmpID) REFERENCES dbo.EMPLOYEE(EmpID),
	PRIMARY KEY (EmpID, MonthWork, YearWork)
)
GO
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
INSERT INTO INVOICE VALUES('null', null)
GO

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
GO

--Thông tin của chỗ đỗ xe
create table PARKING(
	IDParkcard int PRIMARY KEY,
	CusID nvarchar(100) references CUSTOMER(CusID),
	VehID nvarchar(100) references VEHICLE(VehID),
	DateRegister datetime,
	TimeValue int,
	InvoiceID nvarchar(100) references INVOICE(InvoiceID),
	Service nvarchar(100)
	--PRIMARY KEY(CusID, VehID)
)
GO

-- Hợp Đồng
create table CONTRACT(
	ContID nvarchar(100) primary key,
	Purpose nvarchar(100),											--Mục đích (thuê, ....)
	EmpID nvarchar(100) references EMPLOYEE(EmpID),	
	CusID nvarchar(100) references CUSTOMER(CusID),
	VehID nvarchar(100) references VEHICLE(VehID),
	DateStart date,
	TimeValue int,													--thời gian mà khách chọn
	TimeFormat nvarchar(100),										--ngày, tháng năm
	Price int,
	FeeFactor int
)
GO

--Tạo bảng doanh thu
CREATE TABLE PROFIT
(
	Today datetime,
	MoneyFromParking int,
	MoneyFromContract int,
	MoneyTotal int
)
GO

