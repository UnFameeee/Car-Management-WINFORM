create database WINFORM
use WINFORM


create table POSITION(
	PositionID int primary key,		-- 1 là quản lý, 2 là nhân viên, 3 là khách hàng
	Description text
)

-- Tài khoản, mật khẩu người dùng
create table ACCOUNT(
	Username varchar(100),		--Khoá chính
	Password varchar(100),
	PositionID int references POSITION(PositionID)					
)

-- Tài khoản admin
insert into ACCOUNT values ('admin', 'admin')

---------------------------------------------------------------------------------------------------------------------------------------------
-- Công Việc
create table JOB(
	JobID int primary key,		-- 1 = sửa, 2 = rửa, 3 = trông coi xe
	Description text
)

-- Ca Làm
create table WORKSHIFT(
	ShiftID int primary key,	-- suy nghĩ chia ca
	TimeBegin time,
	TimeEnd time
)


-- Nhân viên
create table EMPLOYEE(
	EmpID varchar(100) primary key,					-- mã nhân viên
	FullName varchar(100),
	PhoneNubmer varchar(100),
	IdentityCardNumber varchar(100),
	JobID int references JOB(JobID),
	ShiftID int references WORKSHIFT(ShiftID)
)

-- Quản lý
create table MANAGER(
	ManagerID varchar(100) primary key,
	ShiftID int references WORKSHIFT(ShiftID)		--quản lý ca nào, có bao nhiêu nhân viên trong ca đấy bị này quản lý
)
---------------------------------------------------------------------------------------------------------------------------------------------

-- Khách Hàng
create table CUSTOMER(
	CusID varchar(100) primary key,
	FullName varchar(100),
	PhoneNumber varchar(100),
	IdentityCardNumber varchar(100)

)



-- Hợp Đồng
create table CONTRACT(
	ContID varchar(100) primary key,
	CusID varchar(100) references CUSTOMER(CusID),
	ManagerID varchar(100) references MANAGER(ManagerID),
	EmpID varchar(100) references EMPLOYEE(EmpID),
	Purpose varchar(100),										--Mục đích (thuê, ....)
	Description text
)
