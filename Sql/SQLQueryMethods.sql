CREATE DATABASE Course;

USE Course;


CREATE TABLE Teachers (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(50),
    Surname NVARCHAR(50),
    Email NVARCHAR(100),
    Age INT,
    Salary DECIMAL(10,2)
);

INSERT INTO Teachers (Name, Surname, Email, Age, Salary) VALUES
('Cavid', 'Aliyev', 'cavid@mail.ru', 45, 2500.50),
('Aysel', 'Mammadova', 'aysel@gmail.com', 29, 1200.00),
('Cemil', 'Huseynov', 'cemil@yahoo.com', 38, 3100.00),
('Ramal', 'Karimov', 'ramal@mail.ru', 50, 2800.75),
('Samir', 'Quliyev', 'samir@hotmail.com', 33, 900.00),
('Cahangir', 'Ismayilov', 'cahangir@mail.ru', 41, 1500.00),
('Nigar', 'Sadiqova', 'nigar@mail.ru', 27, 3200.00),
('Cavidan', 'Mahmudov', 'cavidan@gmail.com', 36, 1800.00);

SELECT *
FROM Teachers
WHERE Age > (SELECT AVG(Age) FROM Teachers);

SELECT *
FROM Teachers
WHERE Salary BETWEEN 1000 AND 3000;

SELECT Name, Surname
FROM Teachers
WHERE Email LIKE '%@mail.ru';

SELECT *
FROM Teachers
WHERE Name LIKE 'C%';