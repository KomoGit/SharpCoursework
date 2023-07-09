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
--USE Homework1SQL
--EXEC sp_rename 'unnamed_table', 'Movies';

INSERT INTO Movies (id, movie_title, imdb_rating, year_released, budget, box_office, language)
VALUES
    (1, 'The Godfather', 9.2, 1972, 6000000.0, 287000000.0, 'ENG'),
    (2, 'The Godfather: Part II', 9.0, 1974, 13000000.0, 486000000.0, 'ENG'),
    (3, 'The Godfather: Part III', 7.6, 1990, 54000000.0, 136766062.0, 'ENG'),
    (4, 'Pulp Fiction', 8.9, 1994, 8000000.0, 214000000.0, 'ENG'),
    (5, 'The Shawshank Redemption', 9.3, 1994, 25000000.0, 287000000.0, 'ENG'),
    (6, 'Fight Club', 8.8, 1999, 63000000.0, 101200000.0, 'ENG'),
    (7, 'The Dark Knight', 9.0, 2008, 185000000.0, 1005000000.0, 'ENG'),
    (8, 'Inception', 8.8, 2010, 160000000.0, 836000000.0, 'ENG'),
    (9, 'Interstellar', 8.6, 2014, 165000000.0, 677000000.0, 'ENG'),
    (10, 'The Matrix', 8.7, 1999, 63000000.0, 463000000.0, 'ENG'),
    (11, 'Das Boot', 8.4, 1981, 14000000.0, 84500000.0, 'GER'),
    (12, 'Amélie', 8.3, 2001, 10000000.0, 174000000.0, 'FRE'),
    (13, 'Cesur Yürek', 8.7, 1995, 3000000.0, 28100000.0, 'TUR'),
    (14, 'Parasite', 8.6, 2019, 11000000.0, 266000000.0, 'KOR'),
    (15, 'Crouching Tiger, Hidden Dragon', 7.9, 2000, 17000000.0, 213000000.0, 'CHI'),
    (16, 'Life is Beautiful', 8.6, 1997, 20000000.0, 229000000.0, 'ITA'),
    (17, 'City of God', 8.6, 2002, 3300000.0, 30400000.0, 'POR'),
    (18, 'Seven Samurai', 8.6, 1954, 2000000.0, 2710000.0, 'JPN'),
    (19, 'A Separation', 8.3, 2011, 5000000.0, 25700000.0, 'FAR'),
    (20, 'The Lives of Others', 8.4, 2006, 2000000.0, 77500000.0, 'GER');

SELECT movie_title, imdb_rating, year_released
FROM movies
WHERE movie_title LIKE '%Godfather%';

SELECT movie_title, box_office
FROM movies
WHERE box_office > 300000000;

SELECT movie_title, imdb_rating, year_released
FROM movies
WHERE year_released < 2001 AND imdb_rating >= 9;