/*
CMPT 291 X01L-Team 1
Assignment 4: 06_rental.sql
Inserts rental test data into the movie rental database

Notes:
- assumes Employee, Customer, and Movie rows already exist
- assumes RentalIDSeq already exists
- Ongoing rentals are inserted without ReturnDate, so they count toward current copies rented
*/

USE RentalDB;

-- Completed Round 1 rental
INSERT INTO Rental (RentalID, CheckoutDate, ReturnDate, EmployeeID, CustomerID, MovieID)
	VALUES(
		NEXT VALUE FOR RentalIDSeq,
		'2026-03-10 14:00:00',
		'2026-03-21 11:30:00',
		(SELECT EmployeeID FROM Employee WHERE SSN = '122333444'),
		(SELECT CustomerID FROM Customer WHERE Email = 'JohnSmith@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'The Lion King (2019)')
	);

-- Ongoing rentals
INSERT INTO Rental (RentalID, EmployeeID, CustomerID, MovieID)
	VALUES(
		NEXT VALUE FOR RentalIDSeq,
		(SELECT EmployeeID FROM Employee WHERE SSN = '789541235'),
		(SELECT CustomerID FROM Customer WHERE Email = 'mcarthurl@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Spirited Away')
	);

INSERT INTO Rental (RentalID, EmployeeID, CustomerID, MovieID)
	VALUES(
		NEXT VALUE FOR RentalIDSeq,
		(SELECT EmployeeID FROM Employee WHERE SSN = '135798642'),
		(SELECT CustomerID FROM Customer WHERE Email = 'mcarthurl@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Scooby Doo')
	);

INSERT INTO Rental (RentalID, EmployeeID, CustomerID, MovieID)
	VALUES(
		NEXT VALUE FOR RentalIDSeq,
		(SELECT EmployeeID FROM Employee WHERE SSN = '135798642'),
		(SELECT CustomerID FROM Customer WHERE Email = 'RJorges@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Seven Samurai')
	);

INSERT INTO Rental (RentalID, EmployeeID, CustomerID, MovieID)
	VALUES(
		NEXT VALUE FOR RentalIDSeq,
		(SELECT EmployeeID FROM Employee WHERE SSN = '122333444'),
		(SELECT CustomerID FROM Customer WHERE Email = 'RJorges@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Spirited Away')
	);

INSERT INTO Rental (RentalID, EmployeeID, CustomerID, MovieID)
	VALUES(
		NEXT VALUE FOR RentalIDSeq,
		(SELECT EmployeeID FROM Employee WHERE SSN = '787858018'),
		(SELECT CustomerID FROM Customer WHERE Email = 'JohnSmith@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Zootopia')
	);

INSERT INTO Rental (RentalID, EmployeeID, CustomerID, MovieID)
	VALUES(
		NEXT VALUE FOR RentalIDSeq,
		(SELECT EmployeeID FROM Employee WHERE SSN = '787858018'),
		(SELECT CustomerID FROM Customer WHERE Email = 'JohnSmith@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Pulp Fiction')
	);

INSERT INTO Rental (RentalID, EmployeeID, CustomerID, MovieID)
	VALUES(
		NEXT VALUE FOR RentalIDSeq,
		(SELECT EmployeeID FROM Employee WHERE SSN = '135798642'),
		(SELECT CustomerID FROM Customer WHERE Email = 'TinaT@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Star Wars')
	);

INSERT INTO Rental (RentalID, EmployeeID, CustomerID, MovieID)
	VALUES(
		NEXT VALUE FOR RentalIDSeq,
		(SELECT EmployeeID FROM Employee WHERE SSN = '135798642'),
		(SELECT CustomerID FROM Customer WHERE Email = 'WiBowling@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'The Dark Knight')
	);

INSERT INTO Rental (RentalID, EmployeeID, CustomerID, MovieID)
	VALUES(
		NEXT VALUE FOR RentalIDSeq,
		(SELECT EmployeeID FROM Employee WHERE SSN = '135798642'),
		(SELECT CustomerID FROM Customer WHERE Email = 'WiBowling@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Parasite')
	);

INSERT INTO Rental (RentalID, EmployeeID, CustomerID, MovieID)
	VALUES(
		NEXT VALUE FOR RentalIDSeq,
		(SELECT EmployeeID FROM Employee WHERE SSN = '787858018'),
		(SELECT CustomerID FROM Customer WHERE Email = 'Jacques@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Lord of the Rings')
	);

INSERT INTO Rental (RentalID, EmployeeID, CustomerID, MovieID)
	VALUES(
		NEXT VALUE FOR RentalIDSeq,
		(SELECT EmployeeID FROM Employee WHERE SSN = '122333444'),
		(SELECT CustomerID FROM Customer WHERE Email = 'Jacques@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Inception')
	);

INSERT INTO Rental (RentalID, EmployeeID, CustomerID, MovieID)
	VALUES(
		NEXT VALUE FOR RentalIDSeq,
		(SELECT EmployeeID FROM Employee WHERE SSN = '789541235'),
		(SELECT CustomerID FROM Customer WHERE Email = 'GHerro@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Oldboy')
	);

INSERT INTO Rental (RentalID, EmployeeID, CustomerID, MovieID)
	VALUES(
		NEXT VALUE FOR RentalIDSeq,
		(SELECT EmployeeID FROM Employee WHERE SSN = '789541235'),
		(SELECT CustomerID FROM Customer WHERE Email = 'GHerro@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Parasite')
	);

INSERT INTO Rental (RentalID, EmployeeID, CustomerID, MovieID)
	VALUES(
		NEXT VALUE FOR RentalIDSeq,
		(SELECT EmployeeID FROM Employee WHERE SSN = '787858018'),
		(SELECT CustomerID FROM Customer WHERE Email = 'Lin@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Lord of the Rings')
	);

INSERT INTO Rental (RentalID, EmployeeID, CustomerID, MovieID)
	VALUES(
		NEXT VALUE FOR RentalIDSeq,
		(SELECT EmployeeID FROM Employee WHERE SSN = '789541235'),
		(SELECT CustomerID FROM Customer WHERE Email = 'Lin@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Zootopia')
	);

INSERT INTO Rental (RentalID, EmployeeID, CustomerID, MovieID)
	VALUES(
		NEXT VALUE FOR RentalIDSeq,
		(SELECT EmployeeID FROM Employee WHERE SSN = '789541235'),
		(SELECT CustomerID FROM Customer WHERE Email = 'BonBon@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Spirited Away')
	);

INSERT INTO Rental (RentalID, EmployeeID, CustomerID, MovieID)
	VALUES(
		NEXT VALUE FOR RentalIDSeq,
		(SELECT EmployeeID FROM Employee WHERE SSN = '122333444'),
		(SELECT CustomerID FROM Customer WHERE Email = 'BonBon@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Pulp Fiction')
	);

INSERT INTO Rental (RentalID, EmployeeID, CustomerID, MovieID)
	VALUES(
		NEXT VALUE FOR RentalIDSeq,
		(SELECT EmployeeID FROM Employee WHERE SSN = '789541235'),
		(SELECT CustomerID FROM Customer WHERE Email = 'GLewis@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Parasite')
	);

INSERT INTO Rental (RentalID, EmployeeID, CustomerID, MovieID)
	VALUES(
		NEXT VALUE FOR RentalIDSeq,
		(SELECT EmployeeID FROM Employee WHERE SSN = '135798642'),
		(SELECT CustomerID FROM Customer WHERE Email = 'GLewis@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Zootopia')
	);

-- ====================================
-- 50 historical entries for reports
-- ====================================

INSERT INTO Rental (
    RentalID,
    CheckoutDate,
    ReturnDate,
    EmployeeID,
    CustomerID,
    MovieID
)
VALUES
    (NEXT VALUE FOR RentalIDSeq, '2025-01-03 10:00:00', '2025-01-06 16:00:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '122333444'),
        (SELECT CustomerID FROM Customer WHERE Email = 'JohnSmith@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'The Lion King (2019)')),

    (NEXT VALUE FOR RentalIDSeq, '2025-01-08 11:00:00', '2025-01-11 15:00:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '789541235'),
        (SELECT CustomerID FROM Customer WHERE Email = 'mcarthurl@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Parasite')),

    (NEXT VALUE FOR RentalIDSeq, '2025-01-12 13:00:00', '2025-01-15 18:00:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '787858018'),
        (SELECT CustomerID FROM Customer WHERE Email = 'RJorges@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Spirited Away')),

    (NEXT VALUE FOR RentalIDSeq, '2025-01-18 09:30:00', '2025-01-20 12:00:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '135798642'),
        (SELECT CustomerID FROM Customer WHERE Email = 'TinaT@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Pulp Fiction')),

    (NEXT VALUE FOR RentalIDSeq, '2025-01-24 14:00:00', '2025-01-27 10:00:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '246813579'),
        (SELECT CustomerID FROM Customer WHERE Email = 'WiBowling@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Zootopia')),

    (NEXT VALUE FOR RentalIDSeq, '2025-02-02 10:15:00', '2025-02-05 14:30:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '122333444'),
        (SELECT CustomerID FROM Customer WHERE Email = 'Jacques@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'The Dark Knight')),

    (NEXT VALUE FOR RentalIDSeq, '2025-02-06 11:45:00', '2025-02-08 17:00:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '789541235'),
        (SELECT CustomerID FROM Customer WHERE Email = 'GHerro@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Star Wars')),

    (NEXT VALUE FOR RentalIDSeq, '2025-02-11 12:30:00', '2025-02-14 16:15:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '787858018'),
        (SELECT CustomerID FROM Customer WHERE Email = 'Lin@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Inception')),

    (NEXT VALUE FOR RentalIDSeq, '2025-02-17 10:00:00', '2025-02-20 13:45:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '135798642'),
        (SELECT CustomerID FROM Customer WHERE Email = 'BonBon@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Lord of the Rings')),

    (NEXT VALUE FOR RentalIDSeq, '2025-02-23 15:00:00', '2025-02-26 11:00:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '246813579'),
        (SELECT CustomerID FROM Customer WHERE Email = 'GLewis@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Batman Begins')),

    (NEXT VALUE FOR RentalIDSeq, '2025-03-03 09:00:00', '2025-03-06 15:00:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '122333444'),
        (SELECT CustomerID FROM Customer WHERE Email = 'JohnSmith@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Parasite')),

    (NEXT VALUE FOR RentalIDSeq, '2025-03-07 12:00:00', '2025-03-10 17:30:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '789541235'),
        (SELECT CustomerID FROM Customer WHERE Email = 'mcarthurl@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Spirited Away')),

    (NEXT VALUE FOR RentalIDSeq, '2025-03-12 11:30:00', '2025-03-15 16:00:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '787858018'),
        (SELECT CustomerID FROM Customer WHERE Email = 'RJorges@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Pulp Fiction')),

    (NEXT VALUE FOR RentalIDSeq, '2025-03-18 13:15:00', '2025-03-21 18:00:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '135798642'),
        (SELECT CustomerID FROM Customer WHERE Email = 'TinaT@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Zootopia')),

    (NEXT VALUE FOR RentalIDSeq, '2025-03-25 10:45:00', '2025-03-28 14:00:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '246813579'),
        (SELECT CustomerID FROM Customer WHERE Email = 'WiBowling@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Casablanca')),

    (NEXT VALUE FOR RentalIDSeq, '2025-04-02 09:45:00', '2025-04-05 12:45:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '122333444'),
        (SELECT CustomerID FROM Customer WHERE Email = 'Jacques@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'The Dark Knight')),

    (NEXT VALUE FOR RentalIDSeq, '2025-04-09 14:15:00', '2025-04-12 10:30:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '789541235'),
        (SELECT CustomerID FROM Customer WHERE Email = 'GHerro@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Star Wars')),

    (NEXT VALUE FOR RentalIDSeq, '2025-04-14 12:00:00', '2025-04-17 16:45:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '787858018'),
        (SELECT CustomerID FROM Customer WHERE Email = 'Lin@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Inception')),

    (NEXT VALUE FOR RentalIDSeq, '2025-04-21 10:30:00', '2025-04-24 13:30:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '135798642'),
        (SELECT CustomerID FROM Customer WHERE Email = 'BonBon@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Lord of the Rings')),

    (NEXT VALUE FOR RentalIDSeq, '2025-04-27 15:30:00', '2025-04-30 11:15:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '246813579'),
        (SELECT CustomerID FROM Customer WHERE Email = 'GLewis@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Oldboy')),

    (NEXT VALUE FOR RentalIDSeq, '2025-05-04 11:00:00', '2025-05-07 15:30:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '122333444'),
        (SELECT CustomerID FROM Customer WHERE Email = 'JohnSmith@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Parasite')),

    (NEXT VALUE FOR RentalIDSeq, '2025-05-10 09:30:00', '2025-05-13 12:30:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '789541235'),
        (SELECT CustomerID FROM Customer WHERE Email = 'mcarthurl@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Spirited Away')),

    (NEXT VALUE FOR RentalIDSeq, '2025-05-16 13:45:00', '2025-05-19 18:00:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '787858018'),
        (SELECT CustomerID FROM Customer WHERE Email = 'RJorges@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Pulp Fiction')),

    (NEXT VALUE FOR RentalIDSeq, '2025-05-22 10:00:00', '2025-05-25 14:30:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '135798642'),
        (SELECT CustomerID FROM Customer WHERE Email = 'TinaT@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Zootopia')),

    (NEXT VALUE FOR RentalIDSeq, '2025-05-29 14:30:00', '2025-06-01 10:15:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '246813579'),
        (SELECT CustomerID FROM Customer WHERE Email = 'WiBowling@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Batman Begins')),

    (NEXT VALUE FOR RentalIDSeq, '2025-06-03 11:15:00', '2025-06-06 16:00:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '122333444'),
        (SELECT CustomerID FROM Customer WHERE Email = 'Jacques@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'The Dark Knight')),

    (NEXT VALUE FOR RentalIDSeq, '2025-06-08 12:45:00', '2025-06-11 17:15:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '789541235'),
        (SELECT CustomerID FROM Customer WHERE Email = 'GHerro@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Star Wars')),

    (NEXT VALUE FOR RentalIDSeq, '2025-06-13 10:30:00', '2025-06-16 13:45:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '787858018'),
        (SELECT CustomerID FROM Customer WHERE Email = 'Lin@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Inception')),

    (NEXT VALUE FOR RentalIDSeq, '2025-06-19 15:00:00', '2025-06-22 11:30:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '135798642'),
        (SELECT CustomerID FROM Customer WHERE Email = 'BonBon@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Lord of the Rings')),

    (NEXT VALUE FOR RentalIDSeq, '2025-06-25 09:15:00', '2025-06-28 12:00:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '246813579'),
        (SELECT CustomerID FROM Customer WHERE Email = 'GLewis@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'The Shawshank Redemption')),

    (NEXT VALUE FOR RentalIDSeq, '2025-07-02 11:30:00', '2025-07-05 16:30:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '122333444'),
        (SELECT CustomerID FROM Customer WHERE Email = 'JohnSmith@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Parasite')),

    (NEXT VALUE FOR RentalIDSeq, '2025-07-09 10:00:00', '2025-07-12 14:00:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '789541235'),
        (SELECT CustomerID FROM Customer WHERE Email = 'mcarthurl@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Spirited Away')),

    (NEXT VALUE FOR RentalIDSeq, '2025-07-15 13:30:00', '2025-07-18 18:00:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '787858018'),
        (SELECT CustomerID FROM Customer WHERE Email = 'RJorges@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Pulp Fiction')),

    (NEXT VALUE FOR RentalIDSeq, '2025-07-21 09:45:00', '2025-07-24 13:15:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '135798642'),
        (SELECT CustomerID FROM Customer WHERE Email = 'TinaT@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Zootopia')),

    (NEXT VALUE FOR RentalIDSeq, '2025-07-28 14:15:00', '2025-07-31 10:45:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '246813579'),
        (SELECT CustomerID FROM Customer WHERE Email = 'WiBowling@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'The Godfather')),

    (NEXT VALUE FOR RentalIDSeq, '2025-08-04 12:00:00', '2025-08-07 15:00:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '122333444'),
        (SELECT CustomerID FROM Customer WHERE Email = 'Jacques@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'The Dark Knight')),

    (NEXT VALUE FOR RentalIDSeq, '2025-08-10 11:00:00', '2025-08-13 16:00:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '789541235'),
        (SELECT CustomerID FROM Customer WHERE Email = 'GHerro@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Star Wars')),

    (NEXT VALUE FOR RentalIDSeq, '2025-08-16 09:30:00', '2025-08-19 12:30:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '787858018'),
        (SELECT CustomerID FROM Customer WHERE Email = 'Lin@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Inception')),

    (NEXT VALUE FOR RentalIDSeq, '2025-08-23 14:00:00', '2025-08-26 17:00:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '135798642'),
        (SELECT CustomerID FROM Customer WHERE Email = 'BonBon@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Lord of the Rings')),

    (NEXT VALUE FOR RentalIDSeq, '2025-08-29 10:15:00', '2025-09-01 13:00:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '246813579'),
        (SELECT CustomerID FROM Customer WHERE Email = 'GLewis@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Casablanca')),

    (NEXT VALUE FOR RentalIDSeq, '2025-09-05 13:00:00', '2025-09-08 17:00:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '122333444'),
        (SELECT CustomerID FROM Customer WHERE Email = 'JohnSmith@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Parasite')),

    (NEXT VALUE FOR RentalIDSeq, '2025-09-11 11:15:00', '2025-09-14 15:15:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '789541235'),
        (SELECT CustomerID FROM Customer WHERE Email = 'mcarthurl@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Spirited Away')),

    (NEXT VALUE FOR RentalIDSeq, '2025-09-18 10:45:00', '2025-09-21 14:45:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '787858018'),
        (SELECT CustomerID FROM Customer WHERE Email = 'RJorges@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Schindlers List')),

    (NEXT VALUE FOR RentalIDSeq, '2025-09-24 09:30:00', '2025-09-27 12:30:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '135798642'),
        (SELECT CustomerID FROM Customer WHERE Email = 'TinaT@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = '12 Angry Men')),

    (NEXT VALUE FOR RentalIDSeq, '2025-09-29 15:15:00', '2025-10-02 10:15:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '246813579'),
        (SELECT CustomerID FROM Customer WHERE Email = 'WiBowling@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Seven Samurai')),

    (NEXT VALUE FOR RentalIDSeq, '2026-01-05 10:00:00', '2026-01-08 14:00:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '122333444'),
        (SELECT CustomerID FROM Customer WHERE Email = 'Jacques@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'The Shawshank Redemption')),

    (NEXT VALUE FOR RentalIDSeq, '2026-01-12 12:30:00', '2026-01-15 17:00:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '789541235'),
        (SELECT CustomerID FROM Customer WHERE Email = 'GHerro@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Oldboy')),

    (NEXT VALUE FOR RentalIDSeq, '2026-01-18 11:00:00', '2026-01-21 15:00:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '787858018'),
        (SELECT CustomerID FROM Customer WHERE Email = 'Lin@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'The Godfather')),

    (NEXT VALUE FOR RentalIDSeq, '2026-01-24 13:45:00', '2026-01-27 18:00:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '135798642'),
        (SELECT CustomerID FROM Customer WHERE Email = 'BonBon@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Batman Begins')),

    (NEXT VALUE FOR RentalIDSeq, '2026-01-30 09:15:00', '2026-02-02 11:45:00',
        (SELECT EmployeeID FROM Employee WHERE SSN = '246813579'),
        (SELECT CustomerID FROM Customer WHERE Email = 'GLewis@gmail.com'),
        (SELECT MovieID FROM Movie WHERE MovieName = 'Scooby Doo'));