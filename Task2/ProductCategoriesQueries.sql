CREATE TABLE Products(Id INT PRIMARY KEY IDENTITY(1, 1), Name NVARCHAR(300) UNIQUE NOT NULL)
CREATE TABLE Categories(Id INT PRIMARY KEY IDENTITY(1, 1), Name NVARCHAR(100) UNIQUE NOT NULL)
CREATE TABLE ProductCategories(ProductId INT FOREIGN KEY REFERENCES Products(Id), CategoryId INT FOREIGN KEY REFERENCES Categories(Id), PRIMARY KEY (ProductId, CategoryId))
GO

INSERT INTO Products VALUES ('Product 1'), ('Product 2'), ('Product 3'), ('Product 4'), ('Product 5')
INSERT INTO Categories VALUES ('Category 1'), ('Category 2'), ('Category 3'), ('Category 4')
INSERT INTO ProductCategories VALUES (1, 1), (1, 3), (2, 1), (2, 2), (3, 1), (4, 3)
GO

SELECT Products.Name AS 'ProductName', Categories.Name AS 'CategoryName'
FROM Products
LEFT JOIN ProductCategories ON ProductCategories.ProductId = Products.Id
LEFT JOIN Categories ON ProductCategories.CategoryId = Categories.Id