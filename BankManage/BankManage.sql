CREATE DATABASE BankManageDM

Create Table Customer (
	STK char(10) PRIMARY KEY,
	Name varchar(255) NOT NULL,
	Address varchar(255),
	DoB date,
	CitizenID char(12) NOT NULL,
	PhoneNum char(10) NOT NULL,
	Money int,
	CreateAt date,
	UpdateAt date
)




INSERT INTO Customer(STK, Name, Address, DoB, CitizenID, PhoneNum, Money)
VALUES ('1234567890', 'Nguyen Van A', 'HCM', '1999-5-15','123456789012','0365471254', 250000)


INSERT INTO Customer(STK, Name, Address, DoB, CitizenID, PhoneNum, Money)
VALUES ('1564567890', 'Nguyen Van B', 'HCM', '1999-5-15','156456789012','0365471254', 250000)

INSERT INTO Customer(STK, Name, Address, DoB, CitizenID, PhoneNum, Money)
VALUES ('1234567891', 'Nguyen Van C', 'HCM', '1999-5-15','123456789012','0365471254', 250000)


CREATE TABLE Trans (
	STK char(10),
	MaGD char(10),
	LoaiGD varchar(255),
	Money int,
	ThoigianGD date,
	ReceivedSTK char(10),
	PRIMARY KEY(STK, MaGD),
	FOREIGN KEY (ReceivedSTK) REFERENCES Customer(STK)
)

ALTER TABLE Trans ADD Note varchar(255)

INSERT INTO Trans(STK, MaGD, LoaiGD, Money, ThoigianGD, ReceivedSTK)
VALUES ('1234567890', '001', 'Chuyen tien', '15000','2022-5-6','1564567890')

INSERT INTO Trans(STK, MaGD, LoaiGD, Money, ThoigianGD, ReceivedSTK)
VALUES ('1234567890', '002', 'Gui tien', '15000','2022-5-6','1564567890')

INSERT INTO Trans(STK, MaGD, LoaiGD, Money, ThoigianGD, ReceivedSTK) 
VALUES ('1234567891', 'GT032', 'Gui tien' , '15000', '2023-03-20 8:24:30 PM' , '1234567891')

CREATE TABLE Saving (
	STK char(10),
	MaSo char(10) PRIMARY KEY,
	Money int,
	KyHan char(255),
	PhuongThucDaoHan char(255),
	NgayGui date,
	NgayDaoHan date,
	FOREIGN KEY (STK) REFERENCES Customer(STK)
)
INSERT INTO Saving(STK, MaSo, Money, KyHan, PhuongThucDaoHan, NgayGui, NgayDaoHan) 
VALUES ('1234567891', '1043', '250000' , '12 thang voi lai suat 8%/ nam', 'Nhan tien lai vao tai khoan, chuyen tien goc sang ky han moi' , '2023-03-22', '2024-03-22')

CREATE TABLE Borrow(
	Money int,
	CitizenID char(12) PRIMARY KEY,
	Salary int,
	MoneyBorrow int,
	KieuTinDung char(255),
	TaiSanTheChap char(255),
	KyHan char(255),
	NgayChoVay date,
	NgayHoanTien date,
)
INSERT INTO Borrow(Money, CitizenID, Salary, MoneyBorrow, KieuTinDung, TaiSanTheChap, KyHan, NgayChoVay, NgayHoanTien) 
VALUES ('250000', '123456789012', '300000' ,'200000' ,'Vay khong the chap', '', '12 thang, lai suat 10%/nam' , '2023-03-22', '2024-03-22')

CREATE TABLE Credit (
	STK char(10),
	MaThe char(10) PRIMARY KEY,
	HanMuc int NOT NULL,
	UsedMoney int,
	Method varchar(255),
	NgayMo Date,
	NgayDaoHan Date,
	FOREIGN KEY (STK) REFERENCES Customer(STK)
)

