
CREATE DATABASE Company;

USE Company;

CREATE TABLE Users (
    Id INT,
    Name VARCHAR(50),
    Surname VARCHAR(50),
    Age INT,
    Email VARCHAR(100)
);

INSERT INTO Users (Id,Name, Surname, Age, Email)
VALUES
(1,'Ali', 'Aliyev', 18, 'ali@example.com'),
(2,'Nigar', 'Mammadova', 22, 'nigar@example.com'),
(3,'Rauf', 'Huseynov', 19, 'rauf@example.com'),
(4,'Leyla', 'Karimova', 25, 'leyla@example.com'),
(5,'Kamran', 'Ismayilov', 17, 'kamran@example.com');


SELECT * FROM Users;

SELECT * FROM Users
WHERE Age < 20;