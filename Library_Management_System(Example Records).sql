INSERT INTO dbo.Books (Name, Date, OLB, Publisher, ISBN, AuthorName, Category, Location, Amount, Price)
VALUES 
('The Great Gatsby', '1925-04-10', 'Fiction', 'Charles Scribner''s Sons', '9780743273565', 'F. Scott Fitzgerald', 'Fiction', 'A1', 10, 12.99),
('To Kill a Mockingbird', '1960-07-11', 'Fiction', 'J.B. Lippincott & Co.', '9780061120084', 'Harper Lee', 'Fiction', 'A2', 8, 9.99),
('1984', '1949-06-08', 'Fiction', 'Secker & Warburg', '9780451524935', 'George Orwell', 'Fiction', 'A3', 12, 8.99),
('Pride and Prejudice', '1813-01-28', 'Fiction', 'T. Egerton, Whitehall', '9780141439518', 'Jane Austen', 'Fiction', 'A4', 15, 7.99),
('The Catcher in the Rye', '1951-07-16', 'Fiction', 'Little, Brown and Company', '9780316769488', 'J.D. Salinger', 'Fiction', 'A5', 7, 10.99);

INSERT INTO dbo.Borrow (MemberId, BorrowDate, DueDate, BookId)
VALUES 
(1, '2023-10-01 10:00:00', '2023-10-15 10:00:00', 1),
(2, '2023-10-02 11:00:00', '2023-10-16 11:00:00', 2),
(3, '2023-10-03 12:00:00', '2023-10-17 12:00:00', 3),
(4, '2023-10-04 13:00:00', '2023-10-18 13:00:00', 4),
(5, '2023-10-05 14:00:00', '2023-10-19 14:00:00', 5);

INSERT INTO dbo.Buy (BookId, CustomerName, CustomerContact, PurchaseDate, TotalPrice)
VALUES 
(1, 'John Doe', '123-456-7890', '2023-10-01 10:00:00', 12.99),
(2, 'Jane Smith', '234-567-8901', '2023-10-02 11:00:00', 9.99),
(3, 'Alice Johnson', '345-678-9012', '2023-10-03 12:00:00', 8.99),
(4, 'Bob Brown', '456-789-0123', '2023-10-04 13:00:00', 7.99),
(5, 'Charlie Davis', '567-890-1234', '2023-10-05 14:00:00', 10.99);

INSERT INTO dbo.Fines (MemberId, FineAmount, FineType, ReturnDate, BookId, ReturnId)
VALUES 
(1, 5.00, 'Late', '2023-10-16 10:00:00', 1, 1),
(2, 3.00, 'Damage', '2023-10-17 11:00:00', 2, 2),
(3, 2.00, 'Late', '2023-10-18 12:00:00', 3, 3),
(4, 4.00, 'Lost', '2023-10-19 13:00:00', 4, 4),
(5, 1.00, 'Late', '2023-10-20 14:00:00', 5, 5);

INSERT INTO dbo.Members (Name, SSN, Address, Phone1, Phone2, Email, BirthDate, MembershipStatus, BorrowState)
VALUES 
('John Doe', '123-45-6789', '123 Elm St', '123-456-7890', NULL, 'john.doe@example.com', '1980-01-01', 1, 0),
('Jane Smith', '234-56-7890', '456 Oak St', '234-567-8901', NULL, 'jane.smith@example.com', '1985-02-02', 1, 0),
('Alice Johnson', '345-67-8901', '789 Pine St', '345-678-9012', NULL, 'alice.johnson@example.com', '1990-03-03', 1, 0),
('Bob Brown', '456-78-9012', '101 Maple St', '456-789-0123', NULL, 'bob.brown@example.com', '1975-04-04', 1, 0),
('Charlie Davis', '567-89-0123', '202 Birch St', '567-890-1234', NULL, 'charlie.davis@example.com', '1988-05-05', 1, 0);

INSERT INTO dbo.Returning (StaffId, MemberId, ReturnDate, BookId, BorrowId)
VALUES 
(1, 1, '2023-10-16 10:00:00', 1, 1),
(2, 2, '2023-10-17 11:00:00', 2, 2),
(3, 3, '2023-10-18 12:00:00', 3, 3),
(4, 4, '2023-10-19 13:00:00', 4, 4),
(5, 5, '2023-10-20 14:00:00', 5, 5);

INSERT INTO dbo.Staff (Name, SSN, Address, Phone1, Phone2, BirthDate, WorkType, HireDate, Email)
VALUES 
('Alice Johnson', '111-22-3333', '123 Elm St', '111-222-3333', NULL, '1980-01-01', 'Librarian', '2010-01-01', 'alice.johnson@example.com'),
('Bob Brown', '222-33-4444', '456 Oak St', '222-333-4444', NULL, '1985-02-02', 'Assistant', '2015-02-02', 'bob.brown@example.com'),
('Charlie Davis', '333-44-5555', '789 Pine St', '333-444-5555', NULL, '1990-03-03', 'Manager', '2020-03-03', 'charlie.davis@example.com'),
('Diana Evans', '444-55-6666', '101 Maple St', '444-555-6666', NULL, '1975-04-04', 'Librarian', '2005-04-04', 'diana.evans@example.com'),
('Eve Franklin', '555-66-7777', '202 Birch St', '555-666-7777', NULL, '1988-05-05', 'Assistant', '2018-05-05', 'eve.franklin@example.com');

INSERT INTO dbo.User_Pass (Username, Password)
VALUES 
('john', 'password1'),
('jane', 'password2'),
('alice', 'password3'),
('bob', 'password4'),
('charlie', 'password5');