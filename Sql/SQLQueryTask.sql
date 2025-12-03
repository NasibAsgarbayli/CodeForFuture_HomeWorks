
CREATE DATABASE MovieDB;


USE MovieDB;



CREATE TABLE Genres (
    Id INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL
);


CREATE TABLE Movies (
    Id INT IDENTITY PRIMARY KEY,
    Title NVARCHAR(150) NOT NULL,
    ReleaseYear INT NOT NULL,
    GenreId INT NOT NULL,
    FOREIGN KEY (GenreId) REFERENCES Genres(Id)
);

CREATE TABLE Actors (
    Id INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Surname NVARCHAR(100) NOT NULL,
    Age INT NOT NULL
);

CREATE TABLE ActorMovies (
    Id INT IDENTITY PRIMARY KEY,
    ActorId INT NOT NULL,
    MovieId INT NOT NULL,
    FOREIGN KEY (ActorId) REFERENCES Actors(Id),
    FOREIGN KEY (MovieId) REFERENCES Movies(Id)
);

INSERT INTO Genres (Name) VALUES
('Action'), 
('Drama'), 
('Comedy'), 
('Sci-Fi'), 
('Horror');


INSERT INTO Movies (Title, ReleaseYear, GenreId) VALUES
('Inception', 2010, 4),
('Titanic', 1997, 2),
('The Mask', 1994, 3),
('Avengers', 2012, 1),
('IT', 2017, 5);


INSERT INTO Actors (Name, Surname, Age) VALUES
('Leonardo', 'DiCaprio', 48),
('Jim', 'Carrey', 61),
('Robert', 'Downey', 59),
('Chris', 'Evans', 42),
('Bill', 'Skarsgard', 33);


INSERT INTO ActorMovies (ActorId, MovieId) VALUES
(1, 1), 
(1, 2), 
(2, 3), 
(3, 4), 
(4, 4),
(5, 5); 


SELECT 
    g.Id,
    g.Name,
    COUNT(m.Id) AS MovieCount
FROM Genres g
LEFT JOIN Movies m ON m.GenreId = g.Id
GROUP BY g.Id, g.Name
ORDER BY MovieCount DESC;


SELECT *
FROM Actors
WHERE Age > (SELECT AVG(Age) FROM Actors);


SELECT 
    a.Name,
    a.Surname,
    a.Age,
    m.Title AS Movie,
    g.Name AS Genre
FROM ActorMovies am
JOIN Actors a ON am.ActorId = a.Id
JOIN Movies m ON am.MovieId = m.Id
JOIN Genres g ON m.GenreId = g.Id
ORDER BY a.Name;
