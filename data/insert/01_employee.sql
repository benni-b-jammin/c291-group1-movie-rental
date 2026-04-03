/*
CMPT 291 X01L-Team 1
Assignment 4: 01_employee.sql
Inserts employee test data into the movie rental database
Includes:
- Employee rows
- EmployeePhone rows

Notes:
- assumes the Employee and EmployeePhone tables already exist
- assumes EmployeeIDSeq already exists
- EmployeePhone rows are inserted immediately after their corresponding Employee rows
- Passwords are stored as SHA2-256 hashes using HASHBYTES
*/

USE RentalDB;

-- Employees
INSERT INTO Employee (
    EmployeeID,
    SSN,
    LastName,
    FirstName,
    Address,
    City,
    State,
    ZipCode,
    Username,
    PasswordHash
)
VALUES (
    NEXT VALUE FOR EmployeeIDSeq,
    '122333444',
    'Doe',
    'Jane',
    '890 College St',
    'Ottawa',
    'ON',
    'L6T5M2',
    'janedoe',
    HASHBYTES('SHA2_256', 'password')
);

INSERT INTO EmployeePhone (
    EmployeeID,
    PhoneNum,
    PhoneType
)
VALUES (
    (SELECT EmployeeID FROM Employee WHERE SSN = '122333444'),
    '9054848439',
    'Home'
);

INSERT INTO Employee (
    EmployeeID,
    SSN,
    LastName,
    FirstName,
    Address,
    City,
    State,
    ZipCode,
    StartDate,
    Username,
    PasswordHash
)
VALUES (
    NEXT VALUE FOR EmployeeIDSeq,
    '789541235',
    'Paulson',
    'Sam',
    '10311 106 Avenue',
    'Toronto',
    'ON',
    'M6V9P1',
    '2026-02-20',
    'spaul',
    HASHBYTES('SHA2_256', 'super')
);

INSERT INTO EmployeePhone (
    EmployeeID,
    PhoneNum,
    PhoneType
)
VALUES (
    (SELECT EmployeeID FROM Employee WHERE SSN = '789541235'),
    '9428521462',
    'Home'
);

INSERT INTO Employee (
    EmployeeID,
    SSN,
    LastName,
    FirstName,
    Address,
    City,
    State,
    ZipCode,
    StartDate,
    Username,
    PasswordHash
)
VALUES (
    NEXT VALUE FOR EmployeeIDSeq,
    '787858018',
    'Mayo',
    'Angela',
    '5858 21 Avenue',
    'Montreal',
    'QC',
    'J7J5G5',
    '2026-03-18',
    'amayo',
    HASHBYTES('SHA2_256', 'leopard')
);

INSERT INTO EmployeePhone (
    EmployeeID,
    PhoneNum,
    PhoneType
)
VALUES (
    (SELECT EmployeeID FROM Employee WHERE SSN = '787858018'),
    '4139250909',
    'Home'
);

INSERT INTO Employee (
    EmployeeID,
    SSN,
    LastName,
    FirstName,
    Address,
    City,
    State,
    ZipCode,
    StartDate,
    Username,
    PasswordHash
)
VALUES (
    NEXT VALUE FOR EmployeeIDSeq,
    '135798642',
    'Bower',
    'Hugh',
    '757 31 Street',
    'Vancouver',
    'BC',
    'T7H1D4',
    '2026-01-20',
    'hbower',
    HASHBYTES('SHA2_256', 'wizard')
);

INSERT INTO EmployeePhone (
    EmployeeID,
    PhoneNum,
    PhoneType
)
VALUES (
    (SELECT EmployeeID FROM Employee WHERE SSN = '135798642'),
    '5207099191',
    'Home'
);