/*
CMPT 291 X01L-Team 1
Assignment 4: 04_actor.sql
Inserts actor test data into the movie rental database

Notes:
- assumes the Actor table already exists
- assumes ActorIDSeq already exists
- Each actor name is inserted once only, so later relationship inserts can safely look up ActorID by ActorName
*/

USE RentalDB;

INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES (NEXT VALUE FOR ActorIDSeq, 'Beyonce', 0, '1981-09-04');

INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES (NEXT VALUE FOR ActorIDSeq, 'Donald Glover', 1, '1983-09-25');

INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES (NEXT VALUE FOR ActorIDSeq, 'Yoo Ji-tae', 1, '1976-04-13');

INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES (NEXT VALUE FOR ActorIDSeq, 'Choi Min-sik', 1, '1962-05-30');

INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES (NEXT VALUE FOR ActorIDSeq, 'Tim Robbins', 1, '1958-10-16');

INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES (NEXT VALUE FOR ActorIDSeq, 'Morgan Freeman', 1, '1937-06-01');

INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES (NEXT VALUE FOR ActorIDSeq, 'Marlon Brando', 1, '1924-04-03');

INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES (NEXT VALUE FOR ActorIDSeq, 'Al Pacino', 1, '1940-04-25');

INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES (NEXT VALUE FOR ActorIDSeq, 'Christian Bale', 1, '1974-01-30');

INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES (NEXT VALUE FOR ActorIDSeq, 'Heath Ledger', 1, '1979-04-04');

INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES (NEXT VALUE FOR ActorIDSeq, 'Liam Neeson', 1, '1952-06-07');

INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES (NEXT VALUE FOR ActorIDSeq, 'Ben Kingsley', 1, '1943-12-31');

INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES (NEXT VALUE FOR ActorIDSeq, 'John Travolta', 1, '1954-02-18');

INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES (NEXT VALUE FOR ActorIDSeq, 'Samuel L. Jackson', 1, '1948-12-21');

INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES (NEXT VALUE FOR ActorIDSeq, 'Elijah Wood', 1, '1981-01-28');

INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES (NEXT VALUE FOR ActorIDSeq, 'Ian McKellen', 1, '1939-05-25');

INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES (NEXT VALUE FOR ActorIDSeq, 'Henry Fonda', 1, '1905-05-16');

INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES (NEXT VALUE FOR ActorIDSeq, 'Lee J. Cobb', 1, '1911-12-08');

INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES (NEXT VALUE FOR ActorIDSeq, 'Song Kang-ho', 1, '1967-01-17');

INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES (NEXT VALUE FOR ActorIDSeq, 'Lee Sun-kyun', 1, '1975-03-02');

INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES (NEXT VALUE FOR ActorIDSeq, 'Daveigh Chase', 0, '1990-07-24');

INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES (NEXT VALUE FOR ActorIDSeq, 'Suzanne Pleshette', 0, '1937-01-31');

INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES (NEXT VALUE FOR ActorIDSeq, 'Leonardo DiCaprio', 1, '1974-11-11');

INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES (NEXT VALUE FOR ActorIDSeq, 'Joseph Gordon-Levitt', 1, '1981-02-17');

INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES (NEXT VALUE FOR ActorIDSeq, 'Toshiro Mifune', 1, '1920-04-01');

INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES (NEXT VALUE FOR ActorIDSeq, 'Takashi Shimura', 1, '1905-03-12');

INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES (NEXT VALUE FOR ActorIDSeq, 'Humphrey Bogart', 1, '1899-12-25');

INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES (NEXT VALUE FOR ActorIDSeq, 'Ingrid Bergman', 0, '1915-08-29');

INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES (NEXT VALUE FOR ActorIDSeq, 'Mark Hamill', 1, '1951-09-25');

INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES (NEXT VALUE FOR ActorIDSeq, 'Harrison Ford', 1, '1942-07-13');

INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES (NEXT VALUE FOR ActorIDSeq, 'Freddie Prinze Jr.', 1, '1976-03-08');

INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES (NEXT VALUE FOR ActorIDSeq, 'Sarah Michelle Gellar', 0, '1977-04-14');

INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES (NEXT VALUE FOR ActorIDSeq, 'Ginnifer Goodwin', 0, '1978-05-22');

INSERT INTO Actor (ActorID, ActorName, Gender, DoB)
	VALUES (NEXT VALUE FOR ActorIDSeq, 'Jason Bateman', 1, '1969-01-14');