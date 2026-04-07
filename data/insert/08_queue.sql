/*
CMPT 291 X01L-Team 1
Assignment 4: 08_queue.sql
Inserts customer queue test data into the movie rental database
Includes:
- QueueUp rows

Notes:
- assumes Customer and Movie rows already exist
- Queue positions are unique per customer
*/

USE RentalDB;

-- McArthur, Lena
INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'mcarthurl@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'The Godfather'),
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

-- Roucci, Jorges
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

-- Smith, John
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

-- Trundel, Tina
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

-- Bowling, Will
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

-- Leterrier, Jacques
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

-- Herro, Will
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

-- Hunt, Linda
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

-- Lewis, Bonnie
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

-- Lewis, George
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
		(SELECT MovieID FROM Movie WHERE MovieName = 'Fast and Furious'),
		4
	);

INSERT INTO QueueUp (CustomerID, MovieID, QueuePosition)
	VALUES(
		(SELECT CustomerID FROM Customer WHERE Email = 'GLewis@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Forrest Gump'),
		5
	);