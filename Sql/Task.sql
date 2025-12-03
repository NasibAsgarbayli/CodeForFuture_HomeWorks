create database Magazine 
use Magazine

CREATE TABLE Countries (
    Id INT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL
);

CREATE TABLE Cities (
    Id INT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    CountryId INT NOT NULL,
    CONSTRAINT FK_Cities_Countries FOREIGN KEY (CountryId) REFERENCES Countries(Id)
);

CREATE TABLE Employees (
    Id INT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Surname VARCHAR(100) NOT NULL,
    Age INT,
    Salary DECIMAL(18,2),
    Position VARCHAR(100),
    CityId INT,
    IsDeleted BIT DEFAULT 0,
    CONSTRAINT FK_Employees_Cities FOREIGN KEY (CityId) REFERENCES Cities(Id)
);


INSERT INTO Countries (Id, Name)
VALUES
(1, 'Azerbaijan'),
(2, 'Turkey'),
(3, 'Germany');

INSERT INTO Cities (Id, Name, CountryId)
VALUES
(1, 'Baku', 1),
(2, 'Ganja', 1),
(3, 'Istanbul', 2),
(4, 'Ankara', 2),
(5, 'Berlin', 3),
(6, 'Munich', 3);

INSERT INTO Employees (Id, Name, Surname, Age, Salary, Position, CityId, IsDeleted)
VALUES
(1, 'Ali', 'Ismayilov', 25, 1500, 'Developer', 1, 0),
(2, 'Nigar', 'Huseynova', 30, 2200, 'Designer', 1, 0),
(3, 'Ruslan', 'Aliyev', 28, 1800, 'Support', 2, 1),
(4, 'Kamran', 'Mammadov', 35, 3500, 'Manager', 3, 0),
(5, 'Aylin', 'Demir', 27, 2500, 'Reseption', 3, 0),
(6, 'Mehmet', 'Kara', 40, 2700, 'Developer', 4, 0),
(7, 'Hans', 'Schmidt', 33, 4200, 'Reseption', 5, 0),
(8, 'Greta', 'Muller', 29, 3900, 'HR', 6, 0),
(9, 'Javid', 'Novruzov', 24, 1200, 'Support', 2, 1),
(10, 'Sevinc', 'Rahimova', 32, 2100, 'Developer', 1, 0);

SELECT
    e.Id,
    e.Name,
    e.Surname,
    e.Age,
    e.Salary,
    e.Position,
    c.Name AS City,
    ctr.Name AS Country,
    e.IsDeleted
FROM Employees e
LEFT JOIN Cities c ON e.CityId = c.Id
LEFT JOIN Countries ctr ON c.CountryId = ctr.Id;

SELECT
    e.Name,
    e.Surname,
    ctr.Name AS Country
FROM Employees e
LEFT JOIN Cities c ON e.CityId = c.Id
LEFT JOIN Countries ctr ON c.CountryId = ctr.Id
WHERE e.Salary > 2000;

SELECT
    c.Name AS City,
    ctr.Name AS Country
FROM Cities c
LEFT JOIN Countries ctr ON c.CountryId = ctr.Id;

SELECT
    e.Name,
    e.Surname,
    e.Age,
    e.Salary,
    e.Position,
    c.Name AS City,
    ctr.Name AS Country,
    e.IsDeleted
FROM Employees e
LEFT JOIN Cities c ON e.CityId = c.Id
LEFT JOIN Countries ctr ON c.CountryId = ctr.Id
WHERE e.Position = 'Reseption';

SELECT
    e.Name,
    e.Surname,
    c.Name AS City,
    ctr.Name AS Country
FROM Employees e
LEFT JOIN Cities c ON e.CityId = c.Id
LEFT JOIN Countries ctr ON c.CountryId = ctr.Id
WHERE e.IsDeleted = 1;


SELECT
    e.Id,
    e.Name,
    e.Surname,
    e.Age,
    e.Salary,
    e.Position,
    c.Name AS City,
    ctr.Name AS Country,
    e.IsDeleted
FROM Employees e
LEFT JOIN Cities c ON e.CityId = c.Id
LEFT JOIN Countries ctr ON c.CountryId = ctr.Id;
SELECT
    e.Name,
    e.Surname,
    ctr.Name AS Country
FROM Employees e
LEFT JOIN Cities c ON e.CityId = c.Id
LEFT JOIN Countries ctr ON c.CountryId = ctr.Id
WHERE e.Salary > 2000;

SELECT
    c.Name AS City,
    ctr.Name AS Country
FROM Cities c
LEFT JOIN Countries ctr ON c.CountryId = ctr.Id;

SELECT
    e.Name,
    e.Surname,
    e.Age,
    e.Salary,
    e.Position,
    c.Name AS City,
    ctr.Name AS Country,
    e.IsDeleted
FROM Employees e
LEFT JOIN Cities c ON e.CityId = c.Id
LEFT JOIN Countries ctr ON c.CountryId = ctr.Id
WHERE e.Position = 'Reseption';

SELECT
    e.Name,
    e.Surname,
    c.Name AS City,
    ctr.Name AS Country
FROM Employees e
LEFT JOIN Cities c ON e.CityId = c.Id
LEFT JOIN Countries ctr ON c.CountryId = ctr.Id
WHERE e.IsDeleted = 1;

