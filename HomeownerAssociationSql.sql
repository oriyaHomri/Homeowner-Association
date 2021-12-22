
CREATE DATABASE HomeownerAssociation
GO
USE HomeownerAssociation
GO
CREATE TABLE Tenants(
	ID VARCHAR(10) not null  PRIMARY KEY,
	FirstName VARCHAR(20) not null,
	LastName VARCHAR(20) not null,
	Apartment INT not null,
	FloorNum INT,
	ParkingNum INT,
	Phone VARCHAR(15) not null,
	AdditionalPhone VARCHAR(15),
	Email VARCHAR(30),
	MonthlyBill FLOAT,
	HouseCommitteeMember TINYINT ,
	Rent TINYINT
);
GO
CREATE TABLE Landlord(
	ID VARCHAR(10) not null  PRIMARY KEY,
	FirstName VARCHAR(20) not null,
	LastName VARCHAR(20) not null,
	Phone VARCHAR(15) not null,
	AdditionalPhone VARCHAR(15),
	Email VARCHAR(30)
);
GO
CREATE TABLE Expenses(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	Category VARCHAR(20) not null,
	Professional VARCHAR(20) not null,
	SumExpenses INT not null,
	DataExpenses DATETIME default current_timestamp,
	PaymentMethods VARCHAR(20)
);
GO
CREATE TABLE CommitteePayments(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	Apartment INT not null,
	PaymentFor VARCHAR(20),
	SumPayment INT not null,
	NumberOfPayments INT
);
GO
CREATE TABLE BulletinBoard(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	Massage text not null,
	Note text,
	DataMassage DATETIME default current_timestamp
);
GO
CREATE TABLE Malfunction(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	Category VARCHAR(20) not null,
	Urgency VARCHAR(20) 
);
GO
CREATE TABLE Malfunctions(
	ID  SMALLINT  not null,
	NameMalfunctions VARCHAR(20) not null
);	
GO
CREATE TABLE PaymentMethods(
	ID  SMALLINT  not null,
	NamePaymentMethods VARCHAR(20) not null
);	