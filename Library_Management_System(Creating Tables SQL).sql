CREATE DATABASE Library_Management_System;

-- Table: dbo.Books
CREATE TABLE Books (
    id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100),
    Date DATE,
    OLB VARCHAR(50),
    Publisher VARCHAR(100),
    ISBN VARCHAR(20),
    AuthorName VARCHAR(100),
    Category VARCHAR(50),
    Location VARCHAR(50),
    Amount INT,
    Price FLOAT
);

-- Table: dbo.Members
CREATE TABLE Members (
    id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100),
    SSN VARCHAR(14),
    Address VARCHAR(200),
    Phone1 VARCHAR(20),
    Phone2 VARCHAR(20),
    Email VARCHAR(30),
    BirthDate DATE,
    MembershipStatus BIT,
    BorrowState BIT
);

-- Table: dbo.Borrow
CREATE TABLE Borrow (
    BorrowId INT IDENTITY(1,1) PRIMARY KEY,
    MemberId INT,
    BookId INT,
    BorrowDate DATETIME,
    DueDate DATETIME,
    FOREIGN KEY (MemberId) REFERENCES Members(id),
    FOREIGN KEY (BookId) REFERENCES Books(id)
);

-- Table: dbo.Buy
CREATE TABLE Buy (
    Purchaseld INT IDENTITY(1,1) PRIMARY KEY,
    BookId INT,
    CustomerName VARCHAR(100),
    CustomerContact VARCHAR(20),
    PurchaseDate DATETIME,
    TotalPrice FLOAT,
    FOREIGN KEY (BookId) REFERENCES dbo.Books(id)
);

-- Table: dbo.Fines
CREATE TABLE Fines (
    FineId INT IDENTITY(1,1) PRIMARY KEY,
    MemberId INT,
    FineAmount FLOAT,
    FineType VARCHAR(20),
    ReturnDate DATETIME,
    BookId INT,
    ReturnId INT,
    FOREIGN KEY (MemberId) REFERENCES dbo.Members(id),
    FOREIGN KEY (BookId) REFERENCES dbo.Books(id)
);

-- Table: dbo.Returning
CREATE TABLE Returning (
    ReturnId INT IDENTITY(1,1) PRIMARY KEY,
    StaffId INT,
    MemberId INT,
    BookId INT,
    ReturnDate DATETIME,
    BorrowId INT,
    FOREIGN KEY (StaffId) REFERENCES Staff(id),
    FOREIGN KEY (MemberId) REFERENCES Members(id),
    FOREIGN KEY (BookId) REFERENCES Books(id)
);

-- Table: dbo.Staff
CREATE TABLE Staff (
    id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100),
    SSN VARCHAR(14),
    Address VARCHAR(200),
    Phone1 VARCHAR(20),
    Phone2 VARCHAR(20),
    BirthDate DATE,
    WorkType VARCHAR(30),
    HireDate DATE,
    Email VARCHAR(30)
);

-- Table: dbo.User_Pass
CREATE TABLE dbo.User_Pass (
    id INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(20) NOT NULL,
    Password VARCHAR(20) NOT NULL
);