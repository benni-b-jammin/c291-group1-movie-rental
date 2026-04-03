# Movie Rental Application using SQL Server
CMPT 291 X01L-Team 1, W2026

## Overview
This project uses an SQL Server database to run a mock movie rental application using Windows Forms.

## Setup
- Create a database named `RentalDB` in SQL Server.
- The database is built using:
  - `RentalDB_create.sql`
  - the refactored insertion files in `data/insert/`
- For the Windows Forms application, create these credentials for `RentalDB`:
  - username: `superuser`
  - password: `dbaccess`

## Running the SQL scripts
From the project root, you can run everything with:

```powershell
powershell -ExecutionPolicy Bypass -File .\RentalDB_populate.ps1
```

This runs:

- RentalDB_create.sql
- all insertion files in the correct order

If that does not work, run the files manually in this order (to prevent errors due to dependencies):

1. data/RentalDB_create.sql
2. data/insert/00_clear_data.sql
3. data/insert/01_employee.sql
4. data/insert/02_customer.sql
5. data/insert/03_movie.sql
6. data/insert/04_actor.sql
7. data/insert/05_relationships.sql
8. data/insert/06_rental.sql
9. data/insert/07_rating.sql
10. data/insert/08_queue.sql

