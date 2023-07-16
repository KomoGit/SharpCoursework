CREATE DATABASE Homework2

USE Homework2
CREATE TABLE Categories(
id int primary key,
Name nvarchar(50) not null)

CREATE TABLE Songs(
id int primary key,
Name nvarchar(50) not null,
Duration decimal not null,
CategoryId int references Categories(id)
)

CREATE TABLE Users(
id int primary key,
Username nvarchar(250) not null,
Password nvarchar(250) not null,
birthday Date not null,
gender bit not null,
)

CREATE TABLE Playlists(
id int primary key,
Name nvarchar(50) not null,
UserId int references Users(id),
SongId int references Songs(id)
)

