/*
CMPT 291 X01L-Team 1
Assignment 4: 03_movie.sql
Inserts movie test data into the movie rental database

Notes:
- assumes the Movie table already exists
- assumes MovieIDSeq already exists
- CopiesRented values are set to match the current ongoing rentals used in 06_rental.sql
*/

USE RentalDB;

INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES (NEXT VALUE FOR MovieIDSeq, 'The Lion King (2019)', 'Drama', 1.50, 3, 0);

INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES (NEXT VALUE FOR MovieIDSeq, 'Oldboy', 'Foreign', 2.50, 3, 1);

INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES (NEXT VALUE FOR MovieIDSeq, 'The Shawshank Redemption', 'Drama', 1.50, 4, 0);

INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES (NEXT VALUE FOR MovieIDSeq, 'The Godfather', 'Drama', 2.60, 5, 0);

INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES (NEXT VALUE FOR MovieIDSeq, 'The Dark Knight', 'Action', 1.00, 1, 1);

INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES (NEXT VALUE FOR MovieIDSeq, 'Schindlers List', 'Drama', 3.00, 6, 0);

INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES (NEXT VALUE FOR MovieIDSeq, 'Pulp Fiction', 'Comedy', 1.40, 4, 2);

INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES (NEXT VALUE FOR MovieIDSeq, 'Lord of the Rings', 'Action', 4.44, 9, 2);

INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES (NEXT VALUE FOR MovieIDSeq, '12 Angry Men', 'Drama', 1.33, 7, 0);

INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES (NEXT VALUE FOR MovieIDSeq, 'Parasite', 'Foreign', 2.60, 3, 3);

INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES (NEXT VALUE FOR MovieIDSeq, 'Spirited Away', 'Foreign', 3.33, 3, 3);

INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES (NEXT VALUE FOR MovieIDSeq, 'Inception', 'Drama', 2.78, 8, 1);

INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES (NEXT VALUE FOR MovieIDSeq, 'Seven Samurai', 'Foreign', 3.45, 2, 1);

INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES (NEXT VALUE FOR MovieIDSeq, 'Casablanca', 'Drama', 1.09, 10, 0);

INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES (NEXT VALUE FOR MovieIDSeq, 'Star Wars', 'Action', 9.99, 10, 1);

INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES (NEXT VALUE FOR MovieIDSeq, 'Scooby Doo', 'Comedy', 5.30, 5, 1);

INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES (NEXT VALUE FOR MovieIDSeq, 'Zootopia', 'Comedy', 8.30, 3, 3);

INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES (NEXT VALUE FOR MovieIDSeq, 'Batman Begins', 'Action', 2.25, 4, 0);

-- TO DELETE
INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES (NEXT VALUE FOR MovieIDSeq, 'Fast and Furious', 'Action', 5.00, 3, 0);

INSERT INTO Movie (MovieID, MovieName, MovieType, DistFee, NumOfCopies, CopiesRented)
	VALUES (NEXT VALUE FOR MovieIDSeq, 'Forrest Gump', 'Drama', 2.30, 2, 0);