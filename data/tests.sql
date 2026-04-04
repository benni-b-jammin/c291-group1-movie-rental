use RentalDB;

--SELECT * FROM Employee;
--SELECT * FROM EmployeePhone;
--SELECT * FROM Customer;
--SELECT * FROM CustomerPhone;
--SELECT * FROM Movie;
--SELECT * FROM Rental;
--SELECT * FROM Actor;
--SELECT * FROM MovieRating;
--SELECT * FROM ActorRating;
--SELECT * FROM QueueUp;
--SELECT * FROM AppearedIn;

--SELECT * FROM Customer
--SELECT * FROM Customer WHERE FirstName = 'Spaghetti';
SELECT MovieID, MovieName
FROM Movie
WHERE MovieName = 'The Lion King (2019)';

SELECT ActorID, ActorName
FROM Actor
WHERE ActorName = 'Donald Glover';