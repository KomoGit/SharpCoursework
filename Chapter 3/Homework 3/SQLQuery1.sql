CREATE DATABASE Homework2

USE Homework2
CREATE TABLE Categories(
id int identity primary key,
Name nvarchar(50) not null
)

CREATE TABLE Singers(
id int identity primary key,
Fullname nvarchar(250) not null,
birthday Date not null CHECK (birthday >= '1960-01-01' AND birthday <= '2100-12-31'),
gender bit not null,
SongsId int references Songs(id)
)

CREATE TABLE Songs(
id int identity primary key,
Name nvarchar(50) not null,
Duration decimal not null,
CategoryId int references Categories(id),
SingerId int references Songs(id)
)

--ALTER TABLE Songs ADD SingerId int references Songs(id)

CREATE TABLE Users(
id int identity primary key,
Username nvarchar(250) not null,
Password nvarchar(250) not null,
birthday Date not null,
gender bit not null,
)

CREATE TABLE Playlists(
id int identity primary key,
Name nvarchar(50) not null,
UserId int references Users(id),
SongId int references Songs(id)
)

USE Homework2
ALTER TABLE Users
ADD CONSTRAINT CHK_birthday
CHECK (birthday >= '1960-01-01' AND birthday <= '2100-12-31');

USE Homework2
ALTER TABLE Singer
ADD CONSTRAINT CHK_birthday
CHECK (birthday >= '1960-01-01' AND birthday <= '2100-12-31');

--ALTER TABLE Users
--ALTER COLUMN id INT PRIMARY KEY IDENTITY(1,1);

INSERT INTO Categories(Name)
VALUES('Video Game OST')
INSERT INTO Categories(Name)
VALUES('Shoegazing')

INSERT INTO Users(Username, Password, birthday, gender)
VALUES
    ('John', 'password1', '1990-05-15', 1),
    ('Jane', 'password2', '1985-09-22', 0),
    ('Mike', 'password3', '1992-02-10', 1),
    ('Emily', 'password4', '1998-11-28', 0),
    ('David', 'password5', '1982-07-03', 1),
    ('Sarah', 'password6', '1995-04-19', 0),
    ('Chris', 'password7', '1991-08-07', 1),
    ('Laura', 'password8', '1987-12-14', 0),
    ('Alex', 'password9', '1993-03-25', 1),
    ('Jessica', 'password10', '1989-06-12', 0),
    ('Mark', 'password11', '1997-09-05', 1),
    ('Rachel', 'password12', '1984-01-31', 0),
    ('Daniel', 'password13', '1996-10-18', 1),
    ('Amy', 'password14', '1994-03-09', 0),
    ('Kevin', 'password15', '1988-07-26', 1),
    ('Olivia', 'password16', '1999-12-02', 0),
    ('Brian', 'password17', '1983-02-16', 1),
    ('Sophia', 'password18', '1997-06-23', 0),
    ('Jason', 'password19', '1992-11-08', 1),
    ('Megan', 'password20', '1986-05-07', 0);

INSERT INTO songs (Name, Duration, CategoryId, SingerId)
VALUES ('Song 1', 3.45, 1),
       ('Song 2', 4.18, 1),
       ('Song 3', 2.57, 2),
       ('Song 4', 3.32, 2),
       ('Song 5', 5.12, 1),
       ('Song 6', 4.02, 2),
       ('Song 7', 3.14, 2),
       ('Song 8', 2.45, 1),
       ('Song 9', 4.58, 2),
       ('Song 10', 3.27, 1),
       ('Song 11', 2.52, 2),
       ('Song 12', 4.33, 2),
       ('Song 13', 3.18, 1),
       ('Song 14', 4.42, 2),
       ('Song 15', 2.55, 1),
       ('Song 16', 3.39, 1),
       ('Song 17', 4.21, 2),
       ('Song 18', 3.02, 1),
       ('Song 19', 4.13, 1),
       ('Song 20', 2.48, 2);

USE Homework2
DROP TABLE Users
DROP TABLE Singers
DROP TABLE Categories
DROP TABLE Playlists
DROP TABLE Songs

EXEC sp_rename 'Singer', 'Singers';

CREATE VIEW Musics AS
SELECT S.Name, S.Duration, C.Name FROM Songs AS S
INNER JOIN Categories AS C
ON S.CategoryId = C.Id

CREATE PROCEDURE Create_Category_Item
    @Parameter1 nvarchar(250)
AS
BEGIN
    INSERT INTO Categories(Name)
    VALUES (@Parameter1)
END
