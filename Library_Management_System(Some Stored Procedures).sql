CREATE PROC SP_addStaff
@name varchar(100),
@ssn varchar(14),
@address varchar(200),
@hire date,
@phone1 varchar(20),
@phone2 varchar(20),
@email varchar(30),
@birth date,
@work varchar(30)
as
INSERT INTO Staff
VALUES(@name, @ssn, @address, @phone1, @phone2, @birth, @work, @hire, @email)


CREATE PROCEDURE SP_authenticate
    @User VARCHAR(20),
    @Pass VARCHAR(20)
AS
BEGIN
    SELECT COUNT(*) 
    FROM dbo.User_Pass 
    WHERE Username = @User AND Password = @Pass;
END

CREATE PROC SP_addMember
@name varchar(100),
@ssn varchar(14),
@address varchar(200),
@phone1 varchar(20),
@phone2 varchar(20),
@email varchar(100),
@birth date,
@qr varchar(50),
@membership bit,
@borrow bit
as
INSERT INTO Members
VALUES(@name, @ssn, @address, @phone1, @phone2, @email, @birth, @qr, @membership, @borrow)


CREATE PROC SP_editStaff
@id int,
@name varchar(100),
@ssn varchar(14),
@address varchar(200),
@hire date,
@phone1 varchar(20),
@phone2 varchar(20),
@email varchar(30),
@birth date,
@work varchar(30)
as
UPDATE Staff SET name = @name, ssn = @ssn, address = @address, HireDate = @hire, phone1 = @phone1, phone2 = @phone2, email = @email, BirthDate = @birth, WorkType = @work
WHERE id = @id


CREATE PROC SP_editMember
@id int,
@name varchar(100),
@ssn varchar(14),
@address varchar(200),
@phone1 varchar(20),
@phone2 varchar(20),
@email varchar(100),
@birth date,
@membership bit,
@borrow bit
as
UPDATE Members SET name = @name, ssn = @ssn, address = @address, phone1 = @phone1, phone2 = @phone2, email = @email, BirthDate = @birth, MembershipStatus = @membership, BorrowState = @borrow
WHERE id = @id


CREATE PROC SP_searchStaff
@id int
as
SELECT * FROM Staff
WHERE id = @id

CREATE PROC SP_searchMember
@id int
as
SELECT * FROM Members
WHERE id = @id


CREATE PROC SP_delStaff
@id int
as
DELETE FROM Staff
WHERE id = @id


CREATE PROC SP_delMember
@id int
as
DELETE FROM Members
WHERE id = @id


CREATE PROC SP_authenticate
@user VARCHAR(20),
@pass VARCHAR(20)
AS
SELECT COUNT(id) FROM User_Pass
WHERE Username = @user AND Password = @pass

EXEC SP_authenticate @User = 'admin', @Pass = 'admin123';