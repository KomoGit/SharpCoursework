CREATE DATABASE PRACTICE1SQL

USE PRACTICE1SQL

CREATE TABLE Categories(
Id int primary key identity,
Name nvarchar(200)
)

CREATE TABLE Products(
Id int primary key identity,
Name nvarchar(200),
Price decimal,
CategoryId int references Categories(id)
)

CREATE TABLE Colors(
Id int primary key identity,
Name nvarchar(200),
)

CREATE TABLE ProductToColor(
ProductsId int references Products(id),
ColorsId int references Colors(id)
)

INSERT INTO Products(Name,Price,CategoryId)
VALUES ('SUPEREME',500,'1')

INSERT INTO Products(Name,Price,CategoryId)
VALUES ('Gucci',600,'2')

INSERT INTO Products(Name,Price,CategoryId)
VALUES ('Louis Vouitton',5000,'3')

INSERT INTO ProductToColor(ProductsId,ColorsId)
VALUES (1,1)

INSERT INTO ProductToColor(ProductsId,ColorsId)
VALUES (2,2)

INSERT INTO ProductToColor(ProductsId,ColorsId)
VALUES (3,3)

INSERT INTO Categories(Name)
VALUES ('Shirt')
INSERT INTO Categories(Name)
VALUES ('Jeans')
INSERT INTO Categories(Name)
VALUES ('Jackets')

INSERT INTO Colors(Name)
VALUES ('Green')
INSERT INTO Colors(Name)
VALUES ('Red')
INSERT INTO Colors(Name)
VALUES ('Blue')
--DROP DATABASE PRACTICE1SQL

SELECT p.Name 'Adi',c.Name 'Kateqoria', co.Name 'Rengi'  
FROM Products as p
JOIN Categories as c
ON
c.Id = p.CategoryId
JOIN ProductToColor as ptc
ON 
ptc.ProductsId = p.Id
JOIN Colors as co
ON 
co.Id = ptc.ColorsId
