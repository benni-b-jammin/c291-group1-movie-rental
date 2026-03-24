/*
CMPT 291 X01L-Team 1
Assignment 4: Insertion Script
Inserts test values into the created movie rental database	
Notes:
- Round 1 uses the programatic method of recalling the current sequence number to make additions as a proof of concept
- Round 2 uses the safer SELECT method to insert new table entries based on pre-existing information within the tables
*/

USE RentalDB

-- Remove test data
DELETE EmployeePhone;
DELETE CustomerPhone;
DELETE QueueUp;
DELETE AppearedIn;	
DELETE ActorRating;
DELETE MovieRating;
DELETE Rental;
DELETE Actor;
DELETE Movie;
DELETE Customer;
DELETE Employee;

-- ============================================================================================================================================
-- Round 1 - initial insertion uses the current value attributes from sequences to make insertions into the tables (proof of concept - unsafe)
-- ============================================================================================================================================

INSERT INTO Employee (EmployeeID, SSN, LastName, FirstName, Address, City, State, ZipCode, Username, PasswordHash)
	VALUES ( NEXT VALUE FOR EmployeeIDSeq, '122333444', 'Doe', 'Jane', '890 College St', 'Ottawa', 'ON', 'L6T5M2', 'janedoe', HASHBYTES('SHA2_256', 'password'));

INSERT INTO EmployeePhone (EmployeeID, PhoneNum, PhoneType)
	VALUES( 
		TRY_CAST((SELECT current_value FROM sys.sequences WHERE name = 'EmployeeIDSeq') AS INT), '9054848439', 'Home' );


INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, State, Zipcode, Email, AccountNum, CardNum)
	VALUES (NEXT VALUE FOR CustomerIDSeq, 'Smith', 'John', '2143 108st', 'Edmonton', 'AB', 'R4B1G8', 'JohnSmith@gmail.com', 1, '2190058737563355');

INSERT INTO CustomerPhone (CustomerID, PhoneNum)
	VALUES( TRY_CAST((SELECT current_value FROM sys.sequences WHERE name = 'CustomerIDSeq') AS INT), '8268396017');


INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES(NEXT VALUE FOR MovieIDSeq, 'The Lion King (2019)', 'Drama', 1.50, 3, 1);

INSERT INTO Rental (RentalID, CheckoutDate, ReturnDate, EmployeeID, CustomerID, MovieID)
	VALUES(
		NEXT VALUE FOR RentalIDSeq, '2026-03-10 14:00:00', '2026-03-21 11:30:00',
		TRY_CAST((SELECT current_value FROM sys.sequences WHERE name = 'EmployeeIDSeq') AS INT),
		TRY_CAST((SELECT current_value FROM sys.sequences WHERE name = 'CustomerIDSeq') AS INT),
		TRY_CAST((SELECT current_value FROM sys.sequences WHERE name = 'MovieIDSeq') AS INT)
	);

INSERT INTO MovieRating (RentalID, MRate)
	VALUES( 
		TRY_CAST((SELECT current_value FROM sys.sequences WHERE name = 'RentalIDSeq') AS INT), 4);

INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES(NEXT VALUE FOR ActorIDSeq, 'Beyonce', 0, '1981-09-04');

INSERT INTO ActorRating (ActorID, RentalID, ARate)
	VALUES(
		TRY_CAST((SELECT current_value FROM sys.sequences WHERE name = 'ActorIDSeq') AS INT),
		TRY_CAST((SELECT current_value FROM sys.sequences WHERE name = 'RentalIDSeq') AS INT), 5);


INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES( 
		TRY_CAST((SELECT current_value FROM sys.sequences WHERE name = 'CustomerIDSeq') AS INT),
		TRY_CAST((SELECT current_value FROM sys.sequences WHERE name = 'MovieIDSeq') AS INT), 1 );


INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES( 
		TRY_CAST((SELECT current_value FROM sys.sequences WHERE name = 'MovieIDSeq') AS INT),
		TRY_CAST((SELECT current_value FROM sys.sequences WHERE name = 'ActorIDSeq') AS INT));


-- ============================================================================================================================================
-- Round 2 - insertions are made using the SELECT procedure as in the provided example insert document - safer solution
-- ============================================================================================================================================
-- Employees (4)
INSERT INTO Employee (EmployeeID, SSN, LastName, FirstName, Address, City, State, ZipCode, StartDate, Username, PasswordHash)
	VALUES (NEXT VALUE FOR EmployeeIDSeq, '789541235', 'Paulson', 'Sam', '10311 106 Avenue', 'Toronto', 'ON', 'M6V9P1', '2026-02-20', 'spaul', HASHBYTES('SHA2_256','super'));

INSERT INTO EmployeePhone (EmployeeID, PhoneNum, PhoneType)
	VALUES(
		(SELECT EmployeeID FROM Employee WHERE SSN = '789541235'),
		'9428521462', 'Home'
	);

INSERT INTO Employee (EmployeeID, SSN, LastName, FirstName, Address, City, State, ZipCode, StartDate, Username, PasswordHash)
	VALUES (NEXT VALUE FOR EmployeeIDSeq, '787858018', 'Mayo', 'Angela', '5858 21 Avenue', 'Montreal', 'QC', 'J7J5G5', '2026-03-18', 'amayo', HASHBYTES('SHA2_256','leopard'));

INSERT INTO EmployeePhone (EmployeeID, PhoneNum, PhoneType)
	VALUES(
		(SELECT EmployeeID FROM Employee WHERE SSN = '787858018'),
		'4139250909', 'Home'
	);

INSERT INTO Employee (EmployeeID, SSN, LastName, FirstName, Address, City, State, ZipCode, StartDate, Username, PasswordHash)
	VALUES (NEXT VALUE FOR EmployeeIDSeq, '135798642', 'Bower', 'Hugh', '757 31 Street', 'Vancouver', 'BC', 'T7H1D4', '2026-01-20', 'hbower', HASHBYTES('SHA2_256','wizard'));

INSERT INTO EmployeePhone (EmployeeID, PhoneNum, PhoneType)
	VALUES(
		(SELECT EmployeeID FROM Employee WHERE SSN = '135798642'),
		'5207099191', 'Home'
	);

-- Customers (10)
INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, State, ZipCode, Email, AccountNum, CardNum)
	VALUES (NEXT VALUE FOR CustomerIDSeq, 'McArthur', 'Lena', '123 Lux Lane', 'Vancouver', 'BC', 'V6R8H8', 'mcarthurl@gmail.com', 2, '7814523584152369');

INSERT INTO CustomerPhone (CustomerID, PhoneNum)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'mcarthurl@gmail.com'),
		'5207851744'
	);

INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, State, ZipCode, Email, AccountNum, CardNum)
	VALUES (NEXT VALUE FOR CustomerIDSeq, 'Roucci', 'Jorges', '954 Long Way', 'Calgary', 'AB', 'P0L8H1', 'RJorges@gmail.com', 3, '4191908976765707');

INSERT INTO CustomerPhone (CustomerID, PhoneNum)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'RJorges@gmail.com'),
		'8109598080'
	);

INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, State, ZipCode, Email, AccountNum, CardNum)
	VALUES (NEXT VALUE FOR CustomerIDSeq, 'Trundel', 'Tina', '1010 Fish Street', 'Halifax', 'NS', 'H1P7T6', 'TinaT@gmail.com', 4, '1010210250608765');

INSERT INTO CustomerPhone (CustomerID, PhoneNum)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'TinaT@gmail.com'),
		'8809196655'
	);

INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, State, ZipCode, Email, AccountNum, CardNum)
	VALUES (NEXT VALUE FOR CustomerIDSeq, 'Bowling', 'Will', '7071 66 Street', 'Regina', 'SK', 'Y7A4R5', 'WiBowling@gmail.com', 5, '7565809071355050');

INSERT INTO CustomerPhone (CustomerID, PhoneNum)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'WiBowling@gmail.com'),
		'7514098154'
	);

INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, State, ZipCode, Email, AccountNum, CardNum)
	VALUES (NEXT VALUE FOR CustomerIDSeq, 'Leterrier', 'Jacques', '21 French Boulevard', 'Montreal', 'QC', 'T8M9L9', 'Jacques@gmail.com', 6, '1362656570708191');

INSERT INTO CustomerPhone (CustomerID, PhoneNum)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'Jacques@gmail.com'),
		'4037678080'
	);

INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, State, ZipCode, Email, AccountNum, CardNum)
	VALUES (NEXT VALUE FOR CustomerIDSeq, 'Herro', 'Will', '601 Wide Street', 'Winnipeg', 'MB', 'H9L0P0', 'GHerro@gmail.com', 7, '6564717180809000');

INSERT INTO CustomerPhone (CustomerID, PhoneNum)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'GHerro@gmail.com'),
		'6208187007'
	);

INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, State, ZipCode, Email, AccountNum, CardNum)
	VALUES (NEXT VALUE FOR CustomerIDSeq, 'Hunt', 'Linda', '400 48 Street', 'Ottawa', 'ON', 'M7B6G5', 'Lin@gmail.com', 8, '7897891076765090');

INSERT INTO CustomerPhone (CustomerID, PhoneNum)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'Lin@gmail.com'),
		'5900908878'
	);

INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, State, ZipCode, Email, AccountNum, CardNum)
	VALUES (NEXT VALUE FOR CustomerIDSeq, 'Lewis', 'Bonnie', '34 New Street', 'Kelowna', 'BC', 'K9L9B8', 'BonBon@gmail.com', 9, '8080808090909090');

INSERT INTO CustomerPhone (CustomerID, PhoneNum)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'BonBon@gmail.com'),
		'7609188757'
	);

INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, State, ZipCode, Email, AccountNum, CardNum)
	VALUES (NEXT VALUE FOR CustomerIDSeq, 'Lewis', 'George', '9898 51 Street', 'Edmonton', 'AB', 'T6B9L8', 'GLewis@gmail.com', 10, '5145611208986867');

INSERT INTO CustomerPhone (CustomerID, PhoneNum)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'GLewis@gmail.com'),
		'8256156545'
	);

-- Movies
INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES(NEXT VALUE FOR MovieIDSeq, 'Oldboy', 'Foreign', 2.50, 3, 1);

INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES(NEXT VALUE FOR MovieIDSeq, 'The Shawshank Redemption', 'Drama', 1.50, 4, 2);

INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES(NEXT VALUE FOR MovieIDSeq, 'The Godfather', 'Drama', 2.60, 5,0);

INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES(NEXT VALUE FOR MovieIDSeq, 'The Dark Knight', 'Action', 1.0, 1, 0);

INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES(NEXT VALUE FOR MovieIDSeq, 'Schindlers List', 'Drama', 3.0, 6, 3);

INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES(NEXT VALUE FOR MovieIDSeq, 'Pulp Fiction', 'Comedy', 1.40, 4, 1);

INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES(NEXT VALUE FOR MovieIDSeq, 'Lord of the Rings', 'Action', 4.44, 9, 1);

INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES(NEXT VALUE FOR MovieIDSeq, '12 Angry Men', 'Drama', 1.33, 7, 4);

INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES(NEXT VALUE FOR MovieIDSeq, 'Parasite', 'Foreign', 2.60, 3, 2);

INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES(NEXT VALUE FOR MovieIDSeq,'Spirited Away', 'Foreign', 3.33, 3, 0);

INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES(NEXT VALUE FOR MovieIDSeq,'Inception', 'Drama', 2.78, 8, 2);

INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES(NEXT VALUE FOR MovieIDSeq,'Seven Samurai', 'Foreign', 3.45, 2, 0);

INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES(NEXT VALUE FOR MovieIDSeq,'Casablanca','Drama', 1.09, 10, 1);

INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES(NEXT VALUE FOR MovieIDSeq,'Star Wars','Action',9.99,10,4);

INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES(NEXT VALUE FOR MovieIDSeq,'Scooby Doo', 'Comedy', 5.30, 5, 3);

INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES(NEXT VALUE FOR MovieIDSeq,'Zootopia', 'Comedy', 8.3, 2, 0);

-- Rental (does not include CheckoutDate or ReturnDate for default checking)
INSERT INTO Rental (RentalID, EmployeeID, CustomerID, MovieID)
	VALUES(
		NEXT VALUE FOR RentalIDSeq,
		(SELECT EmployeeID FROM Employee WHERE SSN = '789541235'),
		(SELECT CustomerID FROM Customer WHERE Email = 'mcarthurl@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Oldboy')
	);

-- Movie Rating
INSERT INTO MovieRating (RentalID, MRate)
	VALUES(
		(SELECT RentalID
		 FROM Rental
		 WHERE EmployeeID = (SELECT EmployeeID FROM Employee WHERE SSN = '789541235')
		   AND CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'mcarthurl@gmail.com')
		   AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Oldboy')),
		5
	);

-- Actor
INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES(NEXT VALUE FOR ActorIDSeq, 'Choi Min-sik', 1, '1962-05-30');

-- Actor Rating
INSERT INTO ActorRating (ActorID, RentalID, ARate)
	VALUES(
		(SELECT ActorID FROM Actor WHERE ActorName = 'Choi Min-sik'),
		(SELECT RentalID
		 FROM Rental
		 WHERE EmployeeID = (SELECT EmployeeID FROM Employee WHERE SSN = '789541235')
		   AND CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'mcarthurl@gmail.com')
		   AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Oldboy')),
		5
	);

-- QueueUp
INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'mcarthurl@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Oldboy'),
		1
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'mcarthurl@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Inception'),
		2
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'mcarthurl@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Zootopia'),
		3
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'mcarthurl@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Parasite'),
		4
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'RJorges@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Inception'),
		1
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'RJorges@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'The Dark Knight'),
		2
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'RJorges@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'The Godfather'),
		3
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'RJorges@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Oldboy'),
		4
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'RJorges@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Casablanca'),
		5
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'JohnSmith@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = '12 Angry Men'),
		1
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'JohnSmith@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Lord of the Rings'),
		2
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'JohnSmith@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Spirited Away'),
		3
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'JohnSmith@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Schindlers List'),
		4
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'JohnSmith@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Star Wars'),
		5
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'JohnSmith@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Parasite'),
		6
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'TinaT@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Pulp Fiction'),
		1
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'TinaT@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'The Shawshank Redemption'),
		2
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'TinaT@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Scooby Doo'),
		3
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'TinaT@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Seven Samurai'),
		4
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'WiBowling@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Seven Samurai'),
		1
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'WiBowling@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Pulp Fiction'),
		2
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'WiBowling@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Star Wars'),
		3
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'WiBowling@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Lord of the Rings'),
		4
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'WiBowling@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Oldboy'),
		5
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'Jacques@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Schindlers List'),
		1
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'Jacques@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'The Godfather'),
		2
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'Jacques@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = '12 Angry Men'),
		3
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'Jacques@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'The Dark Knight'),
		4
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'Jacques@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'The Shawshank Redemption'),
		5
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'Jacques@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Spirited Away'),
		6
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'GHerro@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Zootopia'),
		1
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'GHerro@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Spirited Away'),
		2
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'GHerro@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Casablanca'),
		3
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'GHerro@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = '12 Angry Men'),
		4
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'GHerro@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Star Wars'),
		5
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'Lin@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Pulp Fiction'),
		1
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'Lin@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Star Wars'),
		2
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'Lin@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'The Dark Knight'),
		3
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'Lin@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Parasite'),
		4
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'Lin@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Seven Samurai'),
		5
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'BonBon@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Scooby Doo'),
		1
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'BonBon@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Inception'),
		2
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'BonBon@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'The Shawshank Redemption'),
		3
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'BonBon@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = '12 Angry Men'),
		4
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'BonBon@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Star Wars'),
		5
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'GLewis@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'The Dark Knight'),
		1
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'GLewis@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Seven Samurai'),
		2
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'GLewis@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Lord of the Rings'),
		3
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'GLewis@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Star Wars'),
		4
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'GLewis@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Oldboy'),
		5
	);


-- AppearedIn
INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'Oldboy'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Choi Min-sik')
	);

-- Tests

SELECT * FROM Employee;
SELECT * FROM EmployeePhone;
SELECT * FROM Customer;
SELECT * FROM CustomerPhone;
SELECT * FROM Movie;
SELECT * FROM Rental;
SELECT * FROM Actor;
SELECT * FROM MovieRating;
SELECT * FROM ActorRating;
SELECT * FROM QueueUp;
SELECT * FROM AppearedIn;