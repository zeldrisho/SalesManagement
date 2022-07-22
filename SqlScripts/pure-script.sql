USE master
GO

CREATE DATABASE SalesManagement
GO

USE SalesManagement
GO

CREATE TABLE tblCustomer
(
	Id INT IDENTITY(300, 1) PRIMARY KEY,
	Name NVARCHAR(50) NOT NULL,
	Address NVARCHAR(50) NOT NULL,
	PhoneNumber NVARCHAR(50) NOT NULL,
)
GO

CREATE TABLE tblProduct
(
	Id INT IDENTITY(200, 1) PRIMARY KEY,
	Name NVARCHAR(50) NOT NULL,
	Quantity INT NOT NULL,
	ImportUnitPrice FLOAT NOT NULL,
	UnitPrice FLOAT NOT NULL,
	Image IMAGE NOT NULL,
	Note NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE tblEmployee
(
	Id INT IDENTITY(100, 1) PRIMARY KEY,
	Name NVARCHAR(50) NOT NULL,
	Address NVARCHAR(50) NOT NULL,
	PhoneNumber NVARCHAR(50) NOT NULL,
	Email NVARCHAR(50) NOT NULL,
	Role BIT NOT NULL,
	Status BIT NOT NULL,
	Password NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE tblBill
(
	Id INT IDENTITY(400, 1) PRIMARY KEY,
	EmployeeId INT NOT NULL,
	CustomerId INT NOT NULL,
	DateOfPayment DATETIME DEFAULT SYSDATETIME(),
	TotalPrice FLOAT NOT NULL,
	FOREIGN KEY (EmployeeId) REFERENCES dbo.tblEmployee(Id),
	FOREIGN KEY (CustomerId) REFERENCES dbo.tblCustomer(Id),
)
GO

CREATE TABLE tblBillInfo
(
	ProductId INT NOT NULL PRIMARY KEY,
	Quantity INT NOT NULL,
	Price FLOAT NOT NULL,
	FOREIGN KEY (ProductId) REFERENCES dbo.tblProduct(Id),
)
GO

--Insert default accounts
INSERT INTO dbo.tblEmployee VALUES
(N'Hồ Sỹ Gia Trung', N'Bình Dương', N'0864059257', N'trunghsg2012@gmail.com', 1, 1, N'911211742158029170558324418083233124177'),
(N'Trần Minh Phát', N'Bình Dương', N'0233333333', N'tranminphat@gmail.com', 0, 1, N'101691333513117659127204142106415717392')
GO

--Stored procedures
CREATE PROC ChangePassword
@email NVARCHAR(50), @oldPassword NVARCHAR(50), @newPassword NVARCHAR(50)
AS BEGIN
DECLARE @password NVARCHAR(50), @result bit
SELECT @password = Password FROM dbo.tblEmployee WHERE Email = @email
IF @password = @oldPassword
BEGIN
    UPDATE dbo.tblEmployee SET Password = @newPassword WHERE Email = @email
	SET @result = 1
END
ELSE SET @result = 0
SELECT @result
END
GO

CREATE PROC Login
@email NVARCHAR(50), @password NVARCHAR(50)
AS BEGIN
DECLARE @status BIT
IF EXISTS(SELECT * FROM dbo.tblEmployee WHERE Email = @email AND Password = @password)
	SET @status = 1
ELSE
	SET @status = 0
SELECT @status
END
GO

CREATE PROC ListOfProducts
AS BEGIN
SELECT Id, Name, Quantity, ImportUnitPrice, UnitPrice, Image, Note FROM dbo.tblProduct
END
GO

CREATE PROC ListOfCustomers
AS BEGIN
SELECT Id, Name, Address, PhoneNumber FROM dbo.tblCustomer
END
GO

CREATE PROC ListOfEmployees
AS BEGIN
SELECT Id, Name, Address, PhoneNumber, Email, Role, Status FROM dbo.tblEmployee
END
GO

CREATE PROC ListBillInfo
AS BEGIN
SELECT ProductId, p.Name, b.Quantity, Price FROM dbo.tblBillInfo b, dbo.tblProduct p
WHERE ProductId = p.Id
END
GO

CREATE PROC ListOfBills
AS BEGIN
SELECT b.Id, c.Name, DateOfPayment, TotalPrice FROM dbo.tblBill b, dbo.tblCustomer c
WHERE b.CustomerId = c.Id
END
GO

CREATE PROC DeleteProduct
@id int
AS BEGIN
DECLARE @result BIT = 1
IF EXISTS(SELECT * FROM dbo.tblProduct WHERE Id = @id)
	DELETE dbo.tblProduct WHERE Id = @id
ELSE
	SET @result = 0
SELECT @result
END
GO

CREATE PROC DeleteCustomer
@id INT
AS BEGIN
DECLARE @result BIT = 1
IF EXISTS(SELECT * FROM dbo.tblCustomer WHERE Id = @id)
	DELETE dbo.tblCustomer WHERE Id = @id
ELSE
	SET @result = 0
SELECT @result
END
GO

CREATE PROC DeleteEmployee
@id INT
AS BEGIN
DECLARE @result BIT = 1
IF EXISTS(SELECT * FROM dbo.tblEmployee WHERE Id = @id)
	DELETE dbo.tblEmployee WHERE Id = @id
ELSE
	SET @result = 0
SELECT @result
END
GO

CREATE PROC InsertProduct
@name NVARCHAR(50), @quantity INT, @importUnitPrice FLOAT, @unitPrice FLOAT,
@image IMAGE, @note NVARCHAR(100)
AS BEGIN
INSERT INTO dbo.tblProduct VALUES
(@name, @quantity, @importUnitPrice, @unitPrice, @image, @note)
END
GO

CREATE PROC InsertCustomer
@name NVARCHAR(50), @address NVARCHAR(50), @phoneNumber NVARCHAR(50)
AS BEGIN
INSERT INTO dbo.tblCustomer VALUES
(@name, @address, @phoneNumber)
END
GO

CREATE PROC InsertEmployee
@name NVARCHAR(50), @address NVARCHAR(50), @phoneNumber NVARCHAR(50), 
@email NVARCHAR(50), @role BIT, @status BIT, @password NVARCHAR(50)
AS BEGIN
INSERT INTO dbo.tblEmployee VALUES
(@name, @address, @phoneNumber, @email, @role, @status, @password)
END
GO

CREATE PROC InsertBillInfo
@productId INT, @quantity INT, @unitPrice FLOAT  
AS BEGIN
DECLARE @price FLOAT = @quantity * @unitPrice
INSERT INTO dbo.tblBillInfo VALUES
(@productId, @quantity, @price)
END
GO

CREATE PROC InsertBill
@employeeId INT, @customerId INT, @totalPrice FLOAT
AS BEGIN
ALTER TABLE dbo.tblBill NOCHECK CONSTRAINT ALL
DELETE FROM dbo.tblBillInfo
ALTER TABLE dbo.tblBill CHECK CONSTRAINT ALL

INSERT INTO dbo.tblBill VALUES
(@employeeId, @customerId, DEFAULT, @totalPrice)
END
GO

CREATE PROC GetEmployeeRole
@email NVARCHAR(50)
AS BEGIN
SELECT Role FROM dbo.tblEmployee WHERE Email = @email
END
GO

CREATE PROC IsExistEmail
@email NVARCHAR(50)
AS BEGIN
DECLARE @result BIT
IF EXISTS(SELECT * FROM dbo.tblEmployee WHERE Email = @email)
	SET @result = 1
ELSE
	SET @result = 0
SELECT @result
END
GO

CREATE PROC SearchProduct
@name NVARCHAR(50)
AS BEGIN
SELECT * FROM dbo.tblProduct WHERE Name LIKE '%' + @name + '%'
END
GO

CREATE PROC SearchCustomer
@name NVARCHAR(50)
AS BEGIN
SELECT * FROM dbo.tblCustomer WHERE Name LIKE '%' + @name + '%'
END
GO

CREATE PROC SearchCustomerInBill
@name NVARCHAR(50)
AS BEGIN
SELECT b.Id, c.Name, DateOfPayment, TotalPrice FROM dbo.tblBill b, dbo.tblCustomer c
WHERE b.CustomerId = c.Id AND c.Name LIKE '%' + @name + '%'
END
GO

CREATE PROC SearchEmployee
@name NVARCHAR(50)
AS BEGIN
SELECT Id, Name, Address, PhoneNumber, Email, Role, Status FROM dbo.tblEmployee WHERE Name LIKE '%' + @name + '%'
END
GO

CREATE PROC UpdateProduct
@id INT, @name NVARCHAR(50), @quantity INT, @importUnitPrice FLOAT, 
@unitPrice FLOAT, @image IMAGE, @note NVARCHAR(100)
AS BEGIN
UPDATE dbo.tblProduct
SET Name = @name, Quantity = @quantity, ImportUnitPrice = @importUnitPrice,
UnitPrice = @unitPrice, Image = @image, Note = @note
WHERE Id = @id
END
GO

CREATE PROC UpdateCustomer
@id INT, @name NVARCHAR(50), @address NVARCHAR(50), @phoneNumber NVARCHAR(50)
AS BEGIN
UPDATE dbo.tblCustomer
SET Name = @name, Address = @address, PhoneNumber = @phoneNumber
WHERE Id = @id
END
GO

CREATE PROC UpdateEmployee
@name NVARCHAR(50), @address NVARCHAR(50), @phoneNumber NVARCHAR(50), 
@email NVARCHAR(50), @role BIT, @status BIT
AS BEGIN
UPDATE dbo.tblEmployee
SET Name = @name, Address = @address, PhoneNumber = @phoneNumber,
Role = @role, Status = @status
WHERE @email = Email
END
GO

CREATE PROC UpdatePassword
@email NVARCHAR(50), @password NVARCHAR(50)
AS BEGIN
UPDATE dbo.tblEmployee
SET Password = @password
WHERE Email = @email
END
GO

CREATE PROC ListCustomerIdName
AS BEGIN
SELECT CONVERT(NVARCHAR(50), Id) + ' | ' + Name FROM dbo.tblCustomer
END
GO

CREATE PROC ListProductNameQuantity
AS BEGIN
SELECT Name + ' | ' + CONVERT(NVARCHAR(50), Quantity) FROM dbo.tblProduct
END
GO

CREATE PROC GetUnitPrice
@name NVARCHAR(50)
AS BEGIN
SELECT UnitPrice FROM dbo.tblProduct WHERE Name = @name
END
GO

CREATE PROC GetEmployeeIdName
@email NVARCHAR(50)
AS BEGIN
SELECT CONVERT(NVARCHAR(50), Id) + ' | ' + Name FROM dbo.tblEmployee WHERE Email = @email
END
GO

CREATE PROC GetProductId
@name NVARCHAR(50)
AS BEGIN
SELECT Id FROM dbo.tblProduct WHERE Name = @name
END
GO

CREATE PROC GetTotalPrice
AS BEGIN
SELECT SUM(Price) from dbo.tblBillInfo
END
GO
