# Library Management System

## Overview

The **Library Management System** is a desktop application developed using **C#** and **Windows Forms** for the graphical user interface (GUI). It uses **ADO.NET** for database connectivity to manage library operations such as adding books, borrowing and returning books, managing members, and handling fines. The system is designed to streamline library operations and provide an efficient way to manage books, members, and staff.

This project was developed as part of my **Database Final Project** for the **Computer Science** program at **Alexandria University**. My name is **Makrious Ayman**.

---

## Features

- **Book Management**: Add, update, and delete books.
- **Member Management**: Add, update, and delete members.
- **Staff Management**: Add, update, and delete staff members.
- **Borrowing and Returning Books**: Track book borrowings and returns.
- **Fines Management**: Record fines for overdue books.
- **Authentication**: Secure login system for staff and administrators.

---

## Database Design

The database for the Library Management System is designed using **SQL Server**. Below is a detailed description of the database schema, including tables, relationships, and constraints.

### Relational Schema

![Relational Schema](Relational_Schema.png)

---

### Tables and Relationships

#### 1. **Books**
   - **Description**: Stores information about books in the library.
   - **Attributes**:
     - `id` (Primary Key, INT): Unique identifier for each book.
     - `Name` (VARCHAR): Title of the book.
     - `Date` (DATE): Publication date.
     - `OLB` (VARCHAR): Old library barcode.
     - `Publisher` (VARCHAR): Publisher of the book.
     - `ISBN` (VARCHAR): International Standard Book Number.
     - `AuthorName` (VARCHAR): Author of the book.
     - `Category` (VARCHAR): Genre or category of the book.
     - `Location` (VARCHAR): Physical location of the book in the library.
     - `Amount` (INT): Number of copies available.
     - `Price` (FLOAT): Price of the book.
   - **Constraints**:
     - `ISBN` must be unique.
     - `Amount` must be a non-negative integer.

#### 2. **Members**
   - **Description**: Stores information about library members.
   - **Attributes**:
     - `id` (Primary Key, INT): Unique identifier for each member.
     - `Name` (VARCHAR): Full name of the member.
     - `SSN` (VARCHAR): Social Security Number (unique identifier).
     - `Address` (VARCHAR): Address of the member.
     - `Phone1` (VARCHAR): Primary phone number.
     - `Phone2` (VARCHAR): Secondary phone number.
     - `Email` (VARCHAR): Email address of the member.
     - `BirthDate` (DATE): Date of birth.
     - `MembershipStatus` (BIT): Indicates if the membership is active (1) or inactive (0).
     - `BorrowState` (BIT): Indicates if the member is allowed to borrow books (1) or not (0).
   - **Constraints**:
     - `SSN` must be unique.
     - `Email` must be unique.

#### 3. **Borrow**
   - **Description**: Tracks book borrowings by members.
   - **Attributes**:
     - `BorrowId` (Primary Key, INT): Unique identifier for each borrowing record.
     - `MemberId` (Foreign Key, INT): References `Members(id)`.
     - `BookId` (Foreign Key, INT): References `Books(id)`.
     - `BorrowDate` (DATETIME): Date the book was borrowed.
     - `DueDate` (DATETIME): Due date for returning the book.
   - **Constraints**:
     - A member cannot borrow more books than the allowed limit (enforced by application logic).
     - A book cannot be borrowed if `Amount` in the `Books` table is 0.

#### 4. **Buy**
   - **Description**: Records book purchases by customers.
   - **Attributes**:
     - `Purchaseld` (Primary Key, INT): Unique identifier for each purchase record.
     - `BookId` (Foreign Key, INT): References `Books(id)`.
     - `CustomerName` (VARCHAR): Name of the customer.
     - `CustomerContact` (VARCHAR): Contact information of the customer.
     - `PurchaseDate` (DATETIME): Date of purchase.
     - `TotalPrice` (FLOAT): Total price of the purchase.
   - **Constraints**:
     - `BookId` must reference an existing book.

#### 5. **Fines**
   - **Description**: Records fines for overdue books.
   - **Attributes**:
     - `FineId` (Primary Key, INT): Unique identifier for each fine record.
     - `MemberId` (Foreign Key, INT): References `Members(id)`.
     - `FineAmount` (FLOAT): Amount of the fine.
     - `FineType` (VARCHAR): Type of fine (e.g., overdue, lost).
     - `ReturnDate` (DATETIME): Date the book was returned.
     - `BookId` (Foreign Key, INT): References `Books(id)`.
     - `ReturnId` (Foreign Key, INT): References `Returning(ReturnId)`.
   - **Constraints**:
     - `FineAmount` must be a non-negative value.

#### 6. **Returning**
   - **Description**: Tracks book returns.
   - **Attributes**:
     - `ReturnId` (Primary Key, INT): Unique identifier for each return record.
     - `StaffId` (Foreign Key, INT): References `Staff(id)`.
     - `MemberId` (Foreign Key, INT): References `Members(id)`.
     - `BookId` (Foreign Key, INT): References `Books(id)`.
     - `ReturnDate` (DATETIME): Date the book was returned.
     - `BorrowId` (Foreign Key, INT): References `Borrow(BorrowId)`.
   - **Constraints**:
     - `ReturnDate` must be greater than or equal to `BorrowDate`.

#### 7. **Staff**
   - **Description**: Stores information about library staff.
   - **Attributes**:
     - `id` (Primary Key, INT): Unique identifier for each staff member.
     - `Name` (VARCHAR): Full name of the staff member.
     - `SSN` (VARCHAR): Social Security Number (unique identifier).
     - `Address` (VARCHAR): Address of the staff member.
     - `Phone1` (VARCHAR): Primary phone number.
     - `Phone2` (VARCHAR): Secondary phone number.
     - `BirthDate` (DATE): Date of birth.
     - `WorkType` (VARCHAR): Type of work (e.g., librarian, admin).
     - `HireDate` (DATE): Date the staff member was hired.
     - `Email` (VARCHAR): Email address of the staff member.
   - **Constraints**:
     - `SSN` must be unique.
     - `Email` must be unique.

#### 8. **User_Pass**
   - **Description**: Stores login credentials for staff and administrators.
   - **Attributes**:
     - `id` (Primary Key, INT): Unique identifier for each user.
     - `Username` (VARCHAR): Username for login.
     - `Password` (VARCHAR): Password for login.
   - **Constraints**:
     - `Username` must be unique.

---

### Relationships and Cardinalities

1. **Books** and **Borrow**:
   - Relationship: A book can be borrowed multiple times.
   - Cardinality: One-to-Many (1 book can be borrowed by many members).

2. **Members** and **Borrow**:
   - Relationship: A member can borrow multiple books.
   - Cardinality: One-to-Many (1 member can borrow many books).

3. **Borrow** and **Returning**:
   - Relationship: A borrowing record corresponds to one return record.
   - Cardinality: One-to-One (1 borrowing record corresponds to 1 return record).

4. **Staff** and **Returning**:
   - Relationship: A staff member can handle multiple returns.
   - Cardinality: One-to-Many (1 staff member can handle many returns).

5. **Books** and **Buy**:
   - Relationship: A book can be purchased multiple times.
   - Cardinality: One-to-Many (1 book can be purchased by many customers).

6. **Members** and **Fines**:
   - Relationship: A member can have multiple fines.
   - Cardinality: One-to-Many (1 member can have many fines).

---

### Constraints

1. **Adding a Book**:
   - The `ISBN` must be unique.
   - The `Amount` of copies must be a non-negative integer.

2. **Borrowing a Book**:
   - A member cannot borrow a book if their `BorrowState` is 0 (not allowed to borrow).
   - A book cannot be borrowed if the `Amount` in the `Books` table is 0 (no copies available).

3. **Returning a Book**:
   - The `ReturnDate` must be greater than or equal to the `BorrowDate`.
   - If the book is returned late, a fine is automatically calculated and recorded in the `Fines` table.

---

## Stored Procedures

The database includes several stored procedures to automate common tasks:

1. **SP_addStaff**: Adds a new staff member.
2. **SP_authenticate**: Authenticates users during login.
3. **SP_addMember**: Adds a new member.
4. **SP_editStaff**: Updates staff information.
5. **SP_editMember**: Updates member information.
6. **SP_searchStaff**: Searches for a staff member by ID.
7. **SP_searchMember**: Searches for a member by ID.
8. **SP_delStaff**: Deletes a staff member.
9. **SP_delMember**: Deletes a member.

---

## How to Use

### Set Up the Database:
1. Run the SQL scripts provided in the `Library_Management_System(Creating Tables SQL).sql` file to create the database and tables.
2. Execute the stored procedures from `Library_Management_System(Some Stored Procedures).sql`.

### Run the Application:
1. Open the project in Visual Studio.
2. Build and run the application.

---

## Contributors

- **Makrious Ayman**

---

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
