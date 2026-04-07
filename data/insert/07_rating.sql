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

USE RentalDB;

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
    -- =====================================================
    -- Song Kang-ho (14 ratings) - top actor
    -- =====================================================
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Song Kang-ho'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'mcarthurl@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Parasite')
           AND CheckoutDate = '2025-01-08 11:00:00'),
        5
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Song Kang-ho'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'JohnSmith@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Parasite')
           AND CheckoutDate = '2025-03-03 09:00:00'),
        4
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Song Kang-ho'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'JohnSmith@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Parasite')
           AND CheckoutDate = '2025-05-04 11:00:00'),
        5
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Song Kang-ho'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'JohnSmith@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Parasite')
           AND CheckoutDate = '2025-07-02 11:30:00'),
        5
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Song Kang-ho'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'JohnSmith@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Parasite')
           AND CheckoutDate = '2025-09-05 13:00:00'),
        4
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Song Kang-ho'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'JohnSmith@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Parasite')
           AND CheckoutDate = '2025-10-03 10:00:00'),
        5
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Song Kang-ho'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'mcarthurl@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Parasite')
           AND CheckoutDate = '2025-10-05 11:00:00'),
        5
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Song Kang-ho'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'RJorges@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Parasite')
           AND CheckoutDate = '2025-10-07 12:00:00'),
        5
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Song Kang-ho'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'TinaT@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Parasite')
           AND CheckoutDate = '2025-10-10 13:00:00'),
        4
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Song Kang-ho'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'WiBowling@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Parasite')
           AND CheckoutDate = '2025-10-12 14:00:00'),
        5
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Song Kang-ho'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'Jacques@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Parasite')
           AND CheckoutDate = '2025-10-15 09:30:00'),
        5
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Song Kang-ho'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'GHerro@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Parasite')
           AND CheckoutDate = '2025-10-18 10:30:00'),
        5
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Song Kang-ho'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'Jacques@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Parasite')
           AND CheckoutDate = '2025-01-05 10:00:00'),
        4
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Song Kang-ho'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'GHerro@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Parasite')
           AND CheckoutDate = '2025-01-09 11:00:00'),
        5
    ),

    -- =====================================================
    -- Daveigh Chase (12 ratings) - top actress
    -- =====================================================
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Daveigh Chase'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'RJorges@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Spirited Away')
           AND CheckoutDate = '2025-01-12 13:00:00'),
        4
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
        (SELECT ActorID FROM Actor WHERE ActorName = 'Daveigh Chase'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'mcarthurl@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Spirited Away')
           AND CheckoutDate = '2025-05-10 09:30:00'),
        5
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Daveigh Chase'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'mcarthurl@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Spirited Away')
           AND CheckoutDate = '2025-07-09 10:00:00'),
        5
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Daveigh Chase'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'mcarthurl@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Spirited Away')
           AND CheckoutDate = '2025-09-11 11:15:00'),
        4
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Daveigh Chase'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'JohnSmith@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Spirited Away')
           AND CheckoutDate = '2025-11-02 10:00:00'),
        5
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Daveigh Chase'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'mcarthurl@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Spirited Away')
           AND CheckoutDate = '2025-11-04 11:00:00'),
        5
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Daveigh Chase'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'RJorges@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Spirited Away')
           AND CheckoutDate = '2025-11-07 12:00:00'),
        5
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Daveigh Chase'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'TinaT@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Spirited Away')
           AND CheckoutDate = '2025-11-10 13:00:00'),
        4
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Daveigh Chase'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'WiBowling@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Spirited Away')
           AND CheckoutDate = '2025-11-13 14:00:00'),
        5
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Daveigh Chase'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'Jacques@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Spirited Away')
           AND CheckoutDate = '2025-11-16 09:00:00'),
        5
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Daveigh Chase'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'GHerro@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Spirited Away')
           AND CheckoutDate = '2025-11-19 10:00:00'),
        5
    ),

    -- =====================================================
    -- Pulp Fiction
    -- =====================================================
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'John Travolta'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'TinaT@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Pulp Fiction')
           AND CheckoutDate = '2025-01-18 09:30:00'),
        3
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
        (SELECT ActorID FROM Actor WHERE ActorName = 'John Travolta'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'RJorges@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Pulp Fiction')
           AND CheckoutDate = '2025-05-16 13:45:00'),
        4
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'John Travolta'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'RJorges@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Pulp Fiction')
           AND CheckoutDate = '2025-07-15 13:30:00'),
        5
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
        (SELECT ActorID FROM Actor WHERE ActorName = 'Samuel L. Jackson'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'RJorges@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Pulp Fiction')
           AND CheckoutDate = '2025-05-16 13:45:00'),
        4
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Samuel L. Jackson'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'RJorges@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Pulp Fiction')
           AND CheckoutDate = '2025-07-15 13:30:00'),
        5
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Samuel L. Jackson'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'JohnSmith@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Pulp Fiction')
           AND CheckoutDate = '2026-03-03 10:00:00'),
        4
    ),

    -- =====================================================
    -- The Dark Knight
    -- =====================================================
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Christian Bale'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'Jacques@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'The Dark Knight')
           AND CheckoutDate = '2025-02-02 10:15:00'),
        5
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
        (SELECT ActorID FROM Actor WHERE ActorName = 'Christian Bale'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'Jacques@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'The Dark Knight')
           AND CheckoutDate = '2025-06-03 11:15:00'),
        5
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Christian Bale'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'Jacques@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'The Dark Knight')
           AND CheckoutDate = '2025-08-04 12:00:00'),
        4
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Heath Ledger'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'Jacques@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'The Dark Knight')
           AND CheckoutDate = '2025-02-02 10:15:00'),
        5
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
        (SELECT ActorID FROM Actor WHERE ActorName = 'Heath Ledger'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'Jacques@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'The Dark Knight')
           AND CheckoutDate = '2025-06-03 11:15:00'),
        4
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Heath Ledger'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'Jacques@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'The Dark Knight')
           AND CheckoutDate = '2025-08-04 12:00:00'),
        5
    ),

    -- =====================================================
    -- Star Wars
    -- =====================================================
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Harrison Ford'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'GHerro@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Star Wars')
           AND CheckoutDate = '2025-02-06 11:45:00'),
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
        (SELECT ActorID FROM Actor WHERE ActorName = 'Harrison Ford'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'GHerro@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Star Wars')
           AND CheckoutDate = '2025-06-08 12:45:00'),
        4
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Harrison Ford'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'GHerro@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Star Wars')
           AND CheckoutDate = '2025-08-10 11:00:00'),
        5
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Mark Hamill'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'GHerro@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Star Wars')
           AND CheckoutDate = '2025-02-06 11:45:00'),
        4
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Mark Hamill'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'GHerro@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Star Wars')
           AND CheckoutDate = '2025-04-09 14:15:00'),
        4
    ),

    -- =====================================================
    -- Inception
    -- =====================================================
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Leonardo DiCaprio'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'Lin@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Inception')
           AND CheckoutDate = '2025-02-11 12:30:00'),
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
        (SELECT ActorID FROM Actor WHERE ActorName = 'Leonardo DiCaprio'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'Lin@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Inception')
           AND CheckoutDate = '2025-06-13 10:30:00'),
        5
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Joseph Gordon-Levitt'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'Lin@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Inception')
           AND CheckoutDate = '2025-02-11 12:30:00'),
        4
    ),

    -- =====================================================
    -- Lord of the Rings
    -- =====================================================
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Ian McKellen'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'BonBon@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Lord of the Rings')
           AND CheckoutDate = '2025-02-17 10:00:00'),
        5
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
        (SELECT ActorID FROM Actor WHERE ActorName = 'Ian McKellen'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'BonBon@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Lord of the Rings')
           AND CheckoutDate = '2025-06-19 15:00:00'),
        4
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Elijah Wood'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'BonBon@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Lord of the Rings')
           AND CheckoutDate = '2025-02-17 10:00:00'),
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
        (SELECT ActorID FROM Actor WHERE ActorName = 'Elijah Wood'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'BonBon@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Lord of the Rings')
           AND CheckoutDate = '2025-06-19 15:00:00'),
        5
    ),

    -- =====================================================
    -- Zootopia
    -- =====================================================
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Ginnifer Goodwin'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'WiBowling@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Zootopia')
           AND CheckoutDate = '2025-01-24 14:00:00'),
        4
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Ginnifer Goodwin'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'TinaT@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Zootopia')
           AND CheckoutDate = '2025-03-18 13:15:00'),
        5
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Ginnifer Goodwin'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'TinaT@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Zootopia')
           AND CheckoutDate = '2025-05-22 10:00:00'),
        4
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Jason Bateman'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'WiBowling@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Zootopia')
           AND CheckoutDate = '2025-01-24 14:00:00'),
        4
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
        (SELECT ActorID FROM Actor WHERE ActorName = 'Jason Bateman'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'TinaT@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Zootopia')
           AND CheckoutDate = '2025-05-22 10:00:00'),
        4
    ),

    -- =====================================================
    -- Batman Begins
    -- =====================================================
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Morgan Freeman'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'GLewis@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Batman Begins')
           AND CheckoutDate = '2025-02-23 15:00:00'),
        4
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Morgan Freeman'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'BonBon@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Batman Begins')
           AND CheckoutDate = '2026-01-24 13:45:00'),
        5
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Morgan Freeman'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'GLewis@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'The Shawshank Redemption')
           AND CheckoutDate = '2025-06-25 09:15:00'),
        4
    ),

    -- =====================================================
    -- Oldboy
    -- =====================================================
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Choi Min-sik'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'GLewis@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Oldboy')
           AND CheckoutDate = '2025-04-27 15:30:00'),
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
        (SELECT ActorID FROM Actor WHERE ActorName = 'Yoo Ji-tae'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'GHerro@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Oldboy')
           AND CheckoutDate = '2026-01-12 12:30:00'),
        4
    ),

    -- =====================================================
    -- Casablanca
    -- =====================================================
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Humphrey Bogart'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'WiBowling@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Casablanca')
           AND CheckoutDate = '2025-03-25 10:45:00'),
        4
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Ingrid Bergman'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'GLewis@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Casablanca')
           AND CheckoutDate = '2025-08-29 10:15:00'),
        4
    ),

    -- =====================================================
    -- The Godfather
    -- =====================================================
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Al Pacino'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'Lin@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'The Godfather')
           AND CheckoutDate = '2026-01-18 11:00:00'),
        4
    ),
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Marlon Brando'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'WiBowling@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'The Godfather')
           AND CheckoutDate = '2025-07-28 14:15:00'),
        5
    ),

    -- =====================================================
    -- The Shawshank Redemption
    -- =====================================================
    (
        (SELECT ActorID FROM Actor WHERE ActorName = 'Tim Robbins'),
        (SELECT RentalID FROM Rental
         WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'Jacques@gmail.com')
           AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'The Shawshank Redemption')
           AND CheckoutDate = '2026-01-05 10:00:00'),
        4
    );

-- ===================================================
-- Ensure all actors have at least 1 rating
-- ===================================================

    INSERT INTO ActorRating (ActorID, RentalID, ARate)
VALUES (
    (SELECT ActorID FROM Actor WHERE ActorName = 'Ben Kingsley'),
    1062,
    3
);

INSERT INTO ActorRating (ActorID, RentalID, ARate)
VALUES (
    (SELECT ActorID FROM Actor WHERE ActorName = 'Beyonce'),
    1000,
    1
);

INSERT INTO ActorRating (ActorID, RentalID, ARate)
VALUES (
    (SELECT ActorID FROM Actor WHERE ActorName = 'Donald Glover'),
    1000,
    2
);

INSERT INTO ActorRating (ActorID, RentalID, ARate)
VALUES (
    (SELECT ActorID FROM Actor WHERE ActorName = 'Freddie Prinze Jr.'),
    1069,
    3
);

INSERT INTO ActorRating (ActorID, RentalID, ARate)
VALUES (
    (SELECT ActorID FROM Actor WHERE ActorName = 'Henry Fonda'),
    1063,
    2
);

INSERT INTO ActorRating (ActorID, RentalID, ARate)
VALUES (
    (SELECT ActorID FROM Actor WHERE ActorName = 'Lee J. Cobb'),
    1063,
    2
);

INSERT INTO ActorRating (ActorID, RentalID, ARate)
VALUES (
    (SELECT ActorID FROM Actor WHERE ActorName = 'Lee Sun-kyun'),
    1021,
    3
);

INSERT INTO ActorRating (ActorID, RentalID, ARate)
VALUES (
    (SELECT ActorID FROM Actor WHERE ActorName = 'Liam Neeson'),
    1029,
    2
);

INSERT INTO ActorRating (ActorID, RentalID, ARate)
VALUES (
    (SELECT ActorID FROM Actor WHERE ActorName = 'Sarah Michelle Gellar'),
    1069,
    3
);

INSERT INTO ActorRating (ActorID, RentalID, ARate)
VALUES (
    (SELECT ActorID FROM Actor WHERE ActorName = 'Suzanne Pleshette'),
    1022,
    2
);

INSERT INTO ActorRating (ActorID, RentalID, ARate)
VALUES (
    (SELECT ActorID FROM Actor WHERE ActorName = 'Takashi Shimura'),
    1064,
    4
);

INSERT INTO ActorRating (ActorID, RentalID, ARate)
VALUES (
    (SELECT ActorID FROM Actor WHERE ActorName = 'Toshiro Mifune'),
    1064,
    4
);