/*
CMPT 291 X01L-Team 1
Assignment 4: 07_rating.sql
Inserts rating test data into the movie rental database
Includes:
- MovieRating rows
- ActorRating rows

Notes:
- assumes Rental and Actor rows already exist
- all ratings are associated with a specific returned rentals (ReturnDate is not null)
*/

INSERT INTO MovieRating (RentalID, MRate)
	VALUES(
		(SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'JohnSmith@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'The Lion King (2019)')
           AND CheckoutDate = '2025-01-03 10:00:00'),
		4
	);

-- ==============================
-- Historical actor ratings
-- ==============================
INSERT INTO ActorRating (ActorID, RentalID, ARate)
VALUES
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Beyonce'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'JohnSmith@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'The Lion King (2019)')
           AND CheckoutDate = '2025-01-03 10:00:00'),
        4
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Song Kang-ho'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'mcarthurl@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Parasite')
           AND CheckoutDate = '2025-01-08 11:00:00'),
        5
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Daveigh Chase'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'RJorges@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Spirited Away')
           AND CheckoutDate = '2025-01-12 13:00:00'),
        4
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'John Travolta'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'TinaT@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Pulp Fiction')
           AND CheckoutDate = '2025-01-18 09:30:00'),
        3
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Ginnifer Goodwin'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'WiBowling@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Zootopia')
           AND CheckoutDate = '2025-01-24 14:00:00'),
        4
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Christian Bale'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'Jacques@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'The Dark Knight')
           AND CheckoutDate = '2025-02-02 10:15:00'),
        5
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Harrison Ford'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'GHerro@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Star Wars')
           AND CheckoutDate = '2025-02-06 11:45:00'),
        4
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Leonardo DiCaprio'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'Lin@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Inception')
           AND CheckoutDate = '2025-02-11 12:30:00'),
        5
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Ian McKellen'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'BonBon@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Lord of the Rings')
           AND CheckoutDate = '2025-02-17 10:00:00'),
        5
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Lee Sun-kyun'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'JohnSmith@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Parasite')
           AND CheckoutDate = '2025-03-03 09:00:00'),
        4
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Suzanne Pleshette'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'mcarthurl@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Spirited Away')
           AND CheckoutDate = '2025-03-07 12:00:00'),
        4
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Samuel L. Jackson'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'RJorges@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Pulp Fiction')
           AND CheckoutDate = '2025-03-12 11:30:00'),
        5
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Jason Bateman'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'TinaT@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Zootopia')
           AND CheckoutDate = '2025-03-18 13:15:00'),
        5
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Humphrey Bogart'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'WiBowling@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Casablanca')
           AND CheckoutDate = '2025-03-25 10:45:00'),
        4
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Heath Ledger'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'Jacques@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'The Dark Knight')
           AND CheckoutDate = '2025-04-02 09:45:00'),
        5
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Mark Hamill'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'GHerro@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Star Wars')
           AND CheckoutDate = '2025-04-09 14:15:00'),
        4
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Joseph Gordon-Levitt'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'Lin@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Inception')
           AND CheckoutDate = '2025-04-14 12:00:00'),
        4
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Elijah Wood'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'BonBon@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Lord of the Rings')
           AND CheckoutDate = '2025-04-21 10:30:00'),
        4
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Choi Min-sik'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'GLewis@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Oldboy')
           AND CheckoutDate = '2025-04-27 15:30:00'),
        5
    ),
        (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Song Kang-ho'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'JohnSmith@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Parasite')
           AND CheckoutDate = '2025-03-03 09:00:00'),
        5
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Daveigh Chase'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'mcarthurl@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Spirited Away')
           AND CheckoutDate = '2025-03-07 12:00:00'),
        5
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'John Travolta'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'RJorges@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Pulp Fiction')
           AND CheckoutDate = '2025-03-12 11:30:00'),
        4
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Christian Bale'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'Jacques@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'The Dark Knight')
           AND CheckoutDate = '2025-04-02 09:45:00'),
        4
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Harrison Ford'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'GHerro@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Star Wars')
           AND CheckoutDate = '2025-04-09 14:15:00'),
        5
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Leonardo DiCaprio'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'Lin@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Inception')
           AND CheckoutDate = '2025-04-14 12:00:00'),
        4
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Ian McKellen'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'BonBon@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Lord of the Rings')
           AND CheckoutDate = '2025-04-21 10:30:00'),
        5
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Choi Min-sik'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'GHerro@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Oldboy')
           AND CheckoutDate = '2026-01-12 12:30:00'),
        4
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Morgan Freeman'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'GLewis@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Batman Begins')
           AND CheckoutDate = '2025-02-23 15:00:00'),
        5
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Ginnifer Goodwin'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'TinaT@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Zootopia')
           AND CheckoutDate = '2025-03-18 13:15:00'),
        4
    );