CREATE DATABASE Student;
USE Student;

CREATE TABLE Students (
    StudentId INT ,
    Name VARCHAR(50),
    Surname VARCHAR(50),
    Age INT,
    Email VARCHAR(100)
);

INSERT INTO Students (StudentId,Name, Surname, Age, Email) VALUES
(1,'Arzu', 'Aliyeva', 20, 'arzu@example.com'),
(2,'Emin', 'Huseynov', 18, 'emin@example.com'),
(3,'Lale', 'Karimova', 22, 'lale@example.com'),
(4,'Murad', 'Hasanov', 19, 'murad@example.com'),
(5,'Aysu', 'Rahimova', 21, 'aysu@example.com');