CREATE DATABASE LibraryDB;

USE [LibraryDB];

CREATE TABLE BookCopies (
    CopyID INT PRIMARY KEY,
    BookID INT NOT NULL,
    IsAvailable BIT NOT NULL,
    ReservedBy NVARCHAR(100) NULL,
    Status NVARCHAR(20) NOT NULL DEFAULT 'Available', -- For compatibility with your code
    FOREIGN KEY (BookID) REFERENCES Books(Id)
);
CREATE TABLE Users (
    UserNumber NVARCHAR(20) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Sex NVARCHAR(10) NOT NULL,
    NIC NVARCHAR(20) NOT NULL,
    Address NVARCHAR(200) NOT NULL
);

CREATE TABLE Books (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Classification NVARCHAR(5) NOT NULL,
    Number INT NOT NULL,
    Title NVARCHAR(200) NOT NULL,
    Publisher NVARCHAR(100) NOT NULL,
    IsReference BIT NOT NULL,
    Copies INT NOT NULL
);



CREATE TABLE BookLoans (
    LoanID INT IDENTITY(1,1) PRIMARY KEY,
    UserNumber NVARCHAR(20) NOT NULL,
    CopyID INT NOT NULL,
    LoanDate DATE NOT NULL,
    ReturnDate DATE NULL,
    FOREIGN KEY (CopyID) REFERENCES BookCopies(CopyID)
);



CREATE TABLE Reservations (
    ReservationID INT IDENTITY(1,1) PRIMARY KEY,
    AccessionNo INT NOT NULL,
    BorrowerID NVARCHAR(20) NOT NULL,
    ReservationDate DATETIME NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (AccessionNo) REFERENCES Books(Id)
);


INSERT INTO Books (Classification, Number, Title, Publisher, IsReference, Copies)
VALUES ('A', 101, 'C# Programming', 'TechPress', 0, 3);

INSERT INTO BookCopies (CopyID, BookID, IsAvailable, ReservedBy, Status)
VALUES 
(1, 1, 1, NULL, 'Available'),
(2, 1, 1, NULL, 'Available'),
(3, 1, 1, NULL, 'Available');

select * from Users;

select * from Books;

select * from BookLoans;

select * from BookCopies;

select * from Reservations;