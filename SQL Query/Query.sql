CREATE DATABASE MindboxDB;

USE MindboxDB;

CREATE TABLE Categories 
(
	Id INT NOT NULL PRIMARY KEY IDENTITY,
	Name VARCHAR(200),
);

INSERT INTO Categories (Name) VALUES ('Clothes'), ('Headphones'), ('Laptop'), ('Smartphone'), ('CPU'), ('Car'), ('Watch');

CREATE TABLE Products 
(
	Id INT NOT NULL PRIMARY KEY IDENTITY,
	Name VARCHAR(200)
);

INSERT INTO Products (Name) VALUES ('Red jacket'), ('Black boots'), ('Apple AirPods'), ('Acer Aspire 505g'), ('Intel Pentium Gold-M'), ('Honor 9X'), ('AMD Ryzen 9999x'), ('Kia Rio'), ('G-Shock 5000'), ('Xiaomi Mijia m365pro'), ('Samsung UltraNano TV');

CREATE TABLE ProductsCategories 
(
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductsCategories (ProductId, CategoryId) VALUES (1, 1), (2, 1), (3, 2), (4, 3), (4, 5), (5, 5), (6, 4), (6, 5), (7, 5), (8, 6), (9, 7);

SELECT P.Name AS Product, C.Name AS Category FROM Products P LEFT JOIN ProductsCategories PC ON P.Id = PC.ProductId LEFT JOIN Categories C ON C.Id = PC.CategoryId;