/*
CMPT 291 X01L-Team 1
Assignment 4: Creation Script
Creates the tables, keys, constraints, and sequences for the movie rental database
Notes:
- Child tables are dropped before parent tables so the script can be rerun without foreign key dependency errors
- Supporting tables are used for multivalued attributes and relationships, such as phone numbers, queue entries, actor appearances, and ratings
- CHECK constraints are included where needed to enforce valid attribute values, such as movie types, rating ranges, queue positions, copy counts, rental periods, and gender encoding
*/

USE RentalDB;

/* 
   Drop child tables before parent tables to avoid foreign key dependency errors.
   Drop sequences afterward so the script can be rerun cleanly.
*/
DROP TABLE IF EXISTS EmployeePhone;
DROP TABLE IF EXISTS CustomerPhone;
DROP TABLE IF EXISTS QueueUp;
DROP TABLE IF EXISTS AppearedIn;
DROP TABLE IF EXISTS ActorRating;
DROP TABLE IF EXISTS MovieRating;
DROP TABLE IF EXISTS Rental;
DROP TABLE IF EXISTS Employee;
DROP TABLE IF EXISTS Movie;
DROP TABLE IF EXISTS Actor;
DROP TABLE IF EXISTS Customer;

DROP SEQUENCE IF EXISTS MovieIDSeq;
DROP SEQUENCE IF EXISTS EmployeeIDSeq;
DROP SEQUENCE IF EXISTS CustomerIDSeq
DROP SEQUENCE IF EXISTS ActorIDSeq
DROP SEQUENCE IF EXISTS RentalIDSeq;


/* 
   Employee - strong entity table storing employee information.
   EmployeeID is the primary key.
   SSN is unique so no two employees can share the same SSN.
   StartDate defaults to the current date if no value is provided.
*/
CREATE TABLE Employee (
    EmployeeID  INT         NOT NULL,
    SSN         NCHAR(9)    NOT NULL,
    LastName    VARCHAR(40) NOT NULL,
    FirstName   VARCHAR(40) NOT NULL,
    Address     VARCHAR(40) NOT NULL,
    City        VARCHAR(45) NOT NULL,
    State       NCHAR(2)    NOT NULL,
    ZipCode     NCHAR(6)    NOT NULL,
    StartDate   DATE        NOT NULL DEFAULT(getdate()),
    Username       VARCHAR(40)    NOT NULL,
    PasswordHash   VARBINARY(32)  NOT NULL,

    PRIMARY KEY (EmployeeID),
    UNIQUE (SSN, StartDate),
    UNIQUE (Username)
);

/* 
   EmployeePhone - supporting table for multivalued employee phone numbers.
   The composite primary key prevents duplicate phone entries for the same employee.
   EmployeeID is a foreign key referencing Employee.
   PhoneType can describe the number, such as Home, Work, or Cell.
*/
CREATE TABLE EmployeePhone (
    EmployeeID  INT         NOT NULL,
    PhoneNum    NCHAR(10)   NOT NULL,
    PhoneType   VARCHAR(10),

    PRIMARY KEY (EmployeeID, PhoneNum),
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
);

CREATE SEQUENCE EmployeeIDSeq
    START WITH 1000
    INCREMENT BY 1;


/* 
   Customer - strong entity table storing customer information.
   CustomerID is the primary key.
   CreateDate defaults to the current date when the customer record is created.
   AccountNum identifies the customer's account.
   CardNum stores the payment card number associated with the account.
*/
CREATE TABLE Customer (
    CustomerID  INT         NOT NULL,
    LastName    VARCHAR(40) NOT NULL,
    FirstName   VARCHAR(40) NOT NULL,
    Address     VARCHAR(40) NOT NULL,
    City        VARCHAR(40) NOT NULL,
    State       NCHAR(2)    NOT NULL,
    ZipCode     NCHAR(6)    NOT NULL,
    Email       VARCHAR(40) NOT NULL,
    AccountNum  INT         NOT NULL,
    CreateDate  DATE        NOT NULL DEFAULT(getdate()),
    CardNum     NCHAR(16)   NOT NULL,

    PRIMARY KEY (CustomerID)
);

/* 
   CustomerPhone - supporting table for multivalued customer phone numbers.
    (CustomerID, PhoneNum) is the primary key (prevents duplicates).
    CustomerID is a foreign key referencing Customer.
*/
CREATE TABLE CustomerPhone (
    CustomerID  INT       NOT NULL,
    PhoneNum    NCHAR(10) NOT NULL,

    PRIMARY KEY (CustomerID, PhoneNum),
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
);

CREATE SEQUENCE CustomerIDSeq
    START WITH 1000
    INCREMENT BY 1;


/* 
   Movie - strong entity table storing movies available for rental.
   MovieID is the primary key.
   MovieType is limited to Comedy, Drama, Action, or Foreign.
   DistFee and NumOfCopies must be nonnegative.
   ValidRentedCopies ensures CopiesRented stays between 0 and NumOfCopies.
*/
CREATE TABLE Movie (
    MovieID       INT           NOT NULL,
    MovieName     VARCHAR(40)   NOT NULL,
    MovieType     VARCHAR(10)   NOT NULL
        CHECK (MovieType IN ('Comedy', 'Drama', 'Action', 'Foreign')),
    DistFee       NUMERIC(6, 2) NOT NULL
        CHECK (DistFee >= 0),
    NumOfCopies   INT           NOT NULL
        CHECK (NumOfCopies >= 0),
    CopiesRented  INT           NOT NULL DEFAULT(0),

    PRIMARY KEY (MovieID),

    CONSTRAINT ValidRentedCopies
        CHECK (CopiesRented >= 0 AND CopiesRented <= NumOfCopies)
);

CREATE SEQUENCE MovieIDSeq
    START WITH 1000
    INCREMENT BY 1;


/* 
   Rental - transaction/relationship table connecting an employee, customer, and movie.
   RentalID is the primary key.
   EmployeeID, CustomerID, and MovieID are foreign keys.
   CheckoutDate defaults to the current date and time.
   ReturnDate may be NULL if the rental is still active.
   RentalPeriod ensures the return date, when present, is later than the checkout date.
*/
CREATE TABLE Rental (
    RentalID      INT       NOT NULL,
    CheckoutDate  DATETIME  DEFAULT(getdate()),
    ReturnDate    DATETIME,
    EmployeeID    INT       NOT NULL,
    CustomerID    INT       NOT NULL,
    MovieID       INT       NOT NULL,

    PRIMARY KEY (RentalID),
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID),
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID),
    FOREIGN KEY (MovieID) REFERENCES Movie(MovieID),

    CONSTRAINT RentalPeriod
        CHECK (ReturnDate IS NULL OR CheckoutDate < ReturnDate)
);

CREATE SEQUENCE RentalIDSeq
    START WITH 1000
    INCREMENT BY 1;


/* 
   MovieRating - relationship table storing a customer's movie rating for a rental.
   RentalID is a foreign key referencing Rental.
   MRate is constrained to integer values from 1 to 5.
*/
CREATE TABLE MovieRating (
    RentalID  INT NOT NULL,
    MRate     INT NOT NULL CHECK (MRate BETWEEN 1 AND 5),

    PRIMARY KEY (RentalID),
    FOREIGN KEY (RentalID) REFERENCES Rental(RentalID)
);

/* 
   Actor - strong entity table storing actor information.
   ActorID is the primary key.
   Gender is encoded numerically: 0 = female, 1 = male.
   The CHECK constraint restricts Gender to those two values.
*/
CREATE TABLE Actor (
    ActorID    INT         NOT NULL,
    ActorName  VARCHAR(40) NOT NULL,
    Gender     INT         CHECK (Gender IN (0, 1)),
    DoB        DATE        NOT NULL,

    PRIMARY KEY (ActorID)
);

CREATE SEQUENCE ActorIDSeq
    START WITH 1000
    INCREMENT BY 1;


/* 
   ActorRating - many-to-many relationship table storing a customer's rating of an actor
   in connection with a rental.
   ActorID and RentalID are foreign keys.
   ARate is constrained to integer values from 1 to 5.
*/
CREATE TABLE ActorRating (
    ActorID   INT NOT NULL,
    RentalID  INT NOT NULL,
    ARate     INT NOT NULL CHECK (ARate BETWEEN 1 AND 5),

    PRIMARY KEY (ActorID, RentalID),
    FOREIGN KEY (ActorID) REFERENCES Actor(ActorID),
    FOREIGN KEY (RentalID) REFERENCES Rental(RentalID)
);


/* 
   QueueUp - relationship table representing a customer's queue entry for a movie.
   (CustomerID, MovieID) is the primary key (prevents duplicate queue positions).
   QueuePosition must be greater than 0.
   UniqueCustomerQueue prevents one customer from holding the same queue position
   for multiple movies at the same time.
*/
CREATE TABLE QueueUp (
    CustomerID     INT NOT NULL,
    MovieID        INT NOT NULL,
    QueuePosition  INT NOT NULL
        CHECK (QueuePosition > 0),

    PRIMARY KEY (CustomerID, MovieID),
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID),
    FOREIGN KEY (MovieID) REFERENCES Movie(MovieID),

    CONSTRAINT UniqueCustomerQueue
        UNIQUE (CustomerID, QueuePosition)
);


/* 
   AppearedIn - many-to-many relationship between Movie and Actor.
   The composite primary key prevents the same actor from being entered
   more than once for the same movie.
*/
CREATE TABLE AppearedIn (
    MovieID  INT NOT NULL,
    ActorID  INT NOT NULL,

    PRIMARY KEY (MovieID, ActorID),
    FOREIGN KEY (MovieID) REFERENCES Movie(MovieID),
    FOREIGN KEY (ActorID) REFERENCES Actor(ActorID)
);