create database WINFORM
use WINFORM

-- Công Việc
create table JOB(
	JobID varchar(100) primary key,											-- 1 = sửa, 2 = rửa, 3 = trông coi xe
	Description varchar(1000)
)
INSERT INTO JOB VALUES('QL', 'Quản Lý')
INSERT INTO JOB VALUES('NV', 'Nhân Viên')
INSERT INTO JOB VALUES('KH', 'Khách Hàng')

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
	IdentityCardNumber varchar(100),
	JobID varchar(100) references JOB(JobID),
	--ShiftID int references WORKSHIFT(ShiftID)						--Cái này tao nghĩ không cần
)
INSERT INTO EMPLOYEE VALUES('QL01', 'Nguyễn Văn A', 'Nam', '123456789', '079201006666', 'QL') 

-- Quản lý
create table MANAGER(
	ManagerID varchar(100) primary key,
	ShiftID int references WORKSHIFT(ShiftID)						--quản lý ca nào, có bao nhiêu nhân viên trong ca đấy bị này quản lý
)
---------------------------------------------------------------------------------------------------------------------------------------------

create table POSITION(
	PositionID varchar(100) primary key,							-- 1 là quản lý, 2 là nhân viên, 3 là khách hàng
	Description text
)

INSERT INTO POSITION VALUES ('1', 'QuanLy') 
INSERT INTO POSITION VALUES ('2', 'NhanVien') 
INSERT INTO POSITION VALUES ('3', 'KhachHang') 

-- Tài khoản, mật khẩu người dùng || Quy định mỗi nhân viên chỉ được có 1 tài khoản
create table ACCOUNT(
	Username varchar(100),											--Khoá chính 
	Password varchar(100),
	EmpID varchar(100) references EMPLOYEE(EmpID),
	PositionID varchar(100) references POSITION(PositionID)					
)

-- Tài khoản admin
insert into ACCOUNT values ('admin', 'admin', 'QL01', '1')	--TK quản lý

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
	Purpose varchar(100),											--Mục đích (thuê, ....)
	Description text
)
