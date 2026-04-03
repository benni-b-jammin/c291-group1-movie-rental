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
		(SELECT RentalID
		 FROM Rental
		 WHERE EmployeeID = (SELECT EmployeeID FROM Employee WHERE SSN = '122333444')
		   AND CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'JohnSmith@gmail.com')
		   AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'The Lion King (2019)')
		   AND ReturnDate IS NOT NULL),
		4
	);

-- Actor Rating
INSERT INTO ActorRating (ActorID, RentalID, ARate)
	VALUES(
		(SELECT ActorID FROM Actor WHERE ActorName = 'Beyonce'),
		(SELECT RentalID
		 FROM Rental
		 WHERE EmployeeID = (SELECT EmployeeID FROM Employee WHERE SSN = '122333444')
		   AND CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'JohnSmith@gmail.com')
		   AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'The Lion King (2019)')
		   AND ReturnDate IS NOT NULL),
		5
	);