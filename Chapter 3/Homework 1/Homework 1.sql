--DROP DATABASE TEST
CREATE DATABASE Homework1SQL

USE Homework1SQL
CREATE TABLE distribution_companies
(
id int primary key,
company_name varchar(200)
)
--DROP TABLE unnamed_table
USE Homework1SQL
CREATE TABLE unnamed_table
(
id int primary key,
movie_title nvarchar(200),
imdb_rating FLOAT CHECK(imdb_rating >= 1.0 AND imdb_rating <= 10.0),
year_released int,
budget FLOAT,
box_office FLOAT,
language nvarchar(3)
)


--INSERT INTO distribution_companies
--VALUES(1,'Metro Golden Meier')
INSERT INTO distribution_companies
VALUES(2,'Marvel Studios')
INSERT INTO distribution_companies
VALUES(3,'20th Century Fox')
INSERT INTO distribution_companies
VALUES(4,'Universal Pictures')
INSERT INTO distribution_companies
VALUES(5,'Lionsgate')
INSERT INTO distribution_companies
VALUES(6,'Red Granite')

SELECT * FROM distribution_companies --First exercise

