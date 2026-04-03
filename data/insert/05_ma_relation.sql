/*
CMPT 291 X01L-Team 1
Assignment 4: 05_ma_relation.sql
Inserts movie-actor relationship data into the movie rental database
Includes:
- AppearedIn rows

Notes:
- assumes Movie and Actor rows have already been inserted
- Actor names used here are expected to be unique in the Actor table
- "Batman Begins" is included to create actor overlap across multiple movies
*/

USE RentalDB;

-- The Lion King (2019)
INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'The Lion King (2019)'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Beyonce')
	);

INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'The Lion King (2019)'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Donald Glover')
	);

-- Oldboy
INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'Oldboy'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Choi Min-sik')
	);

INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'Oldboy'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Yoo Ji-tae')
	);

-- The Shawshank Redemption
INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'The Shawshank Redemption'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Tim Robbins')
	);

INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'The Shawshank Redemption'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Morgan Freeman')
	);

-- The Godfather
INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'The Godfather'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Marlon Brando')
	);

INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'The Godfather'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Al Pacino')
	);

-- The Dark Knight
INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'The Dark Knight'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Christian Bale')
	);

INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'The Dark Knight'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Heath Ledger')
	);

-- Schindlers List
INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'Schindlers List'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Liam Neeson')
	);

INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'Schindlers List'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Ben Kingsley')
	);

-- Pulp Fiction
INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'Pulp Fiction'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'John Travolta')
	);

INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'Pulp Fiction'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Samuel L. Jackson')
	);

-- Lord of the Rings
INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'Lord of the Rings'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Elijah Wood')
	);

INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'Lord of the Rings'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Ian McKellen')
	);

-- 12 Angry Men
INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = '12 Angry Men'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Henry Fonda')
	);

INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = '12 Angry Men'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Lee J. Cobb')
	);

-- Parasite
INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'Parasite'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Song Kang-ho')
	);

INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'Parasite'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Lee Sun-kyun')
	);

-- Spirited Away
INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'Spirited Away'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Daveigh Chase')
	);

INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'Spirited Away'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Suzanne Pleshette')
	);

-- Inception
INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'Inception'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Leonardo DiCaprio')
	);

INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'Inception'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Joseph Gordon-Levitt')
	);

-- Seven Samurai
INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'Seven Samurai'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Toshiro Mifune')
	);

INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'Seven Samurai'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Takashi Shimura')
	);

-- Casablanca
INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'Casablanca'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Humphrey Bogart')
	);

INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'Casablanca'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Ingrid Bergman')
	);

-- Star Wars
INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'Star Wars'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Mark Hamill')
	);

INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'Star Wars'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Harrison Ford')
	);

-- Scooby Doo
INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'Scooby Doo'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Freddie Prinze Jr.')
	);

INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'Scooby Doo'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Sarah Michelle Gellar')
	);

-- Zootopia
INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'Zootopia'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Ginnifer Goodwin')
	);

INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'Zootopia'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Jason Bateman')
	);

-- Batman Begins
INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'Batman Begins'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Christian Bale')
	);

INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'Batman Begins'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Liam Neeson')
	);

INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES(
		(SELECT MovieID FROM Movie WHERE MovieName = 'Batman Begins'),
		(SELECT ActorID FROM Actor WHERE ActorName = 'Morgan Freeman')
	);