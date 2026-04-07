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

-- =====================================================
-- LOGIN SCREEN
-- =====================================================

SELECT * FROM Employee

-- Check employee credentials exist
SELECT EmployeeID, Username
FROM Employee
WHERE Username IN ('janedoe', 'spaul');

-- =====================================================
-- CUSTOMER SCREEN
-- =====================================================

SELECT * FROM Customer

-- After creating a customer
SELECT *
FROM Customer
WHERE Email = 'spag.hetti@gmail.com';

SELECT *
FROM CustomerPhone
WHERE CustomerID = (
    SELECT CustomerID
    FROM Customer
    WHERE Email = 'spag.hetti@gmail.com'
);

-- After updating a customer
SELECT *
FROM Customer
WHERE Email = 'spag.hetti@gmail.com';

-- After adding/removing phone numbers
SELECT *
FROM CustomerPhone
WHERE CustomerID = (
    SELECT CustomerID
    FROM Customer
    WHERE Email = 'spag.hetti@gmail.com'
);

-- After deleting a customer
SELECT *
FROM Customer
WHERE Email = 'spag.hetti@gmail.com';

SELECT *
FROM CustomerPhone
WHERE CustomerID = (
    SELECT CustomerID
    FROM Customer
    WHERE Email = 'spag.hetti@gmail.com'
);

-- =====================================================
-- MOVIE SCREEN
-- =====================================================

-- After creating movie without actors
SELECT *
FROM Movie
WHERE MovieName = 'Interstellar';

SELECT *
FROM AppearedIn
WHERE MovieID = (
    SELECT MovieID
    FROM Movie
    WHERE MovieName = 'Interstellar'
);

-- After creating movie with actors
SELECT *
FROM Movie
WHERE MovieName = 'The Matrix';

SELECT *
FROM AppearedIn
WHERE MovieID = (
    SELECT MovieID
    FROM Movie
    WHERE MovieName = 'The Matrix'
);

-- After updating a movie
SELECT *
FROM Movie
WHERE MovieName = 'Parasite';

SELECT *
FROM AppearedIn
WHERE MovieID = (
    SELECT MovieID
    FROM Movie
    WHERE MovieName = 'Parasite'
);

-- After deleting a movie
SELECT *
FROM Movie
WHERE MovieName = 'Fast and Furious';

SELECT *
FROM QueueUp
WHERE MovieID = (
    SELECT MovieID
    FROM Movie
    WHERE MovieName = 'Fast and Furious'
);

-- =====================================================
-- RENTAL SCREEN
-- =====================================================

-- Queue before/after dispense for Will Herro
SELECT *
FROM QueueUp
WHERE CustomerID = (
    SELECT CustomerID
    FROM Customer
    WHERE FirstName = 'Will' AND LastName = 'Herro'
)
ORDER BY QueuePosition;

-- Rental created for Will Herro and Casablanca
SELECT *
FROM Rental
WHERE CustomerID = (
    SELECT CustomerID
    FROM Customer
    WHERE FirstName = 'Will' AND LastName = 'Herro'
)
AND MovieID = (
    SELECT MovieID
    FROM Movie
    WHERE MovieName = 'Casablanca'
)
ORDER BY RentalID DESC;

-- Check copies rented changed
SELECT MovieName, NumOfCopies, CopiesRented
FROM Movie
WHERE MovieName = 'Casablanca';

-- =====================================================
-- REPORT SCREEN
-- =====================================================

-- Report 1 – Top Rated Actors / Actresses (Both)
SELECT TOP 5 WITH TIES
    A.ActorID,
    A.ActorName,
    AVG(CAST(AR.ARate AS FLOAT)) AS AvgRating
FROM Actor A
JOIN ActorRating AR ON A.ActorID = AR.ActorID
GROUP BY
    A.ActorID,
    A.ActorName
ORDER BY
    AvgRating DESC;

-- Report 1 – Actors only
SELECT TOP 5 WITH TIES
    A.ActorID,
    A.ActorName,
    AVG(CAST(AR.ARate AS FLOAT)) AS AvgRating
FROM Actor A
JOIN ActorRating AR ON A.ActorID = AR.ActorID
WHERE A.Gender = 1
GROUP BY
    A.ActorID,
    A.ActorName
ORDER BY
    AvgRating DESC;

-- Report 1 – Actresses only
SELECT TOP 5 WITH TIES
    A.ActorID,
    A.ActorName,
    AVG(CAST(AR.ARate AS FLOAT)) AS AvgRating
FROM Actor A
JOIN ActorRating AR ON A.ActorID = AR.ActorID
WHERE A.Gender = 0
GROUP BY
    A.ActorID,
    A.ActorName
ORDER BY
    AvgRating DESC;

-- Report 2 – Sales Report for 2025
SELECT
    DATENAME(MONTH, R.CheckoutDate) AS SalesMonth,
    YEAR(R.CheckoutDate) AS SalesYear,
    SUM(M.DistFee) AS TotalRevenue
FROM Rental R
JOIN Movie M ON R.MovieID = M.MovieID
WHERE YEAR(R.CheckoutDate) = 2025
GROUP BY
    MONTH(R.CheckoutDate),
    DATENAME(MONTH, R.CheckoutDate),
    YEAR(R.CheckoutDate)
ORDER BY
    MONTH(R.CheckoutDate);

-- Report 3 – Top Employees for October 2025
SELECT TOP 3 WITH TIES
    E.EmployeeID,
    E.FirstName,
    E.LastName,
    COUNT(R.RentalID) AS TotalOrders
FROM Employee E
JOIN Rental R ON E.EmployeeID = R.EmployeeID
WHERE MONTH(R.CheckoutDate) = 10
  AND YEAR(R.CheckoutDate) = 2025
GROUP BY
    E.EmployeeID,
    E.FirstName,
    E.LastName
ORDER BY
    TotalOrders DESC;

-- Report 4 – Top Movies for November 2025
SELECT TOP 5 WITH TIES
    M.MovieID,
    M.MovieName,
    COUNT(R.RentalID) AS TimesRented
FROM Movie M
JOIN Rental R ON M.MovieID = R.MovieID
WHERE MONTH(R.CheckoutDate) = 11
  AND YEAR(R.CheckoutDate) = 2025
GROUP BY
    M.MovieID,
    M.MovieName
ORDER BY
    TimesRented DESC;

-- Report 5 – Movie Recommender for John Smith
WITH CustomerInfo AS (
    SELECT CustomerID, City
    FROM Customer
    WHERE FirstName = 'John' AND LastName = 'Smith'
),
FavouriteGenre AS (
    SELECT TOP 1
        M.MovieType
    FROM Rental R
    JOIN Movie M ON R.MovieID = M.MovieID
    WHERE R.CustomerID = (SELECT CustomerID FROM CustomerInfo)
    GROUP BY M.MovieType
    ORDER BY COUNT(*) DESC
),
TopAreaMovies AS (
    SELECT TOP 2
        M.MovieID,
        M.MovieName,
        COUNT(*) AS RentalCount,
        'Popular in Area' AS Category
    FROM Rental R
    JOIN Customer C ON R.CustomerID = C.CustomerID
    JOIN Movie M ON R.MovieID = M.MovieID
    WHERE C.City = (SELECT City FROM CustomerInfo)
    GROUP BY M.MovieID, M.MovieName
    ORDER BY COUNT(*) DESC
),
TopGenreMovies AS (
    SELECT TOP 3
        M.MovieID,
        M.MovieName,
        COUNT(*) AS RentalCount,
        'Favourite Genre' AS Category
    FROM Rental R
    JOIN Movie M ON R.MovieID = M.MovieID
    WHERE M.MovieType IN (SELECT MovieType FROM FavouriteGenre)
    GROUP BY M.MovieID, M.MovieName
    ORDER BY COUNT(*) DESC
)
SELECT * FROM TopAreaMovies
UNION ALL
SELECT * FROM TopGenreMovies;