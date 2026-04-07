/*
CMPT 291 X01L-Team 1
Assignment 4: 02_customer.sql
Inserts customer test data into the movie rental database
Includes:
- Customer rows
- CustomerPhone rows

Notes:
- assumes the Customer and CustomerPhone tables already exist
- assumes CustomerIDSeq already exists
- CustomerPhone rows are inserted immediately after their corresponding Customer rows
*/

USE RentalDB;

INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, State, ZipCode, Email, AccountNum, CardNum)
	VALUES (NEXT VALUE FOR CustomerIDSeq, 'Smith', 'John', '2143 108st', 'Edmonton', 'AB', 'R4B1G8', 'JohnSmith@gmail.com', 1, '2190058737563355');

INSERT INTO CustomerPhone (CustomerID, PhoneNum)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'JohnSmith@gmail.com'),
		'8268396017'
	);

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

-- TO DELETE
INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, State, ZipCode, Email, AccountNum, CardNum)
	VALUES (NEXT VALUE FOR CustomerIDSeq, 'Patel', 'Asha', '4412 River Road', 'Calgary', 'AB', 'T2P4K7', 'apatel@gmail.com', 11, '6012345678901234');

INSERT INTO CustomerPhone (CustomerID, PhoneNum)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'apatel@gmail.com'),
		'4035557812'
	);

INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, State, ZipCode, Email, AccountNum, CardNum)
	VALUES (NEXT VALUE FOR CustomerIDSeq, 'Chen', 'Marcus', '7821 Pine Avenue', 'Vancouver', 'BC', 'V5K2M4', 'mchen@gmail.com', 12, '4532987612345678');

INSERT INTO CustomerPhone (CustomerID, PhoneNum)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'mchen@gmail.com'),
		'6045553491'
	);