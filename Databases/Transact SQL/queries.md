1.Create a database with two tables: Persons(Id(PK), FirstName, LastName, SSN) and Accounts(Id(PK), PersonId(FK), Balance).
Insert few records for testing.
Write a stored procedure that selects the full names of all persons.

```sql

USE master
GO

CREATE DATABASE Users
GO

USE Users
GO

CREATE TABLE Persons(
 Id INT PRIMARY KEY IDENTITY,
 FirstName NVARCHAR(45) NOT NULL,
 LastName NVARCHAR(45) NOT NULL,
 SSN NVARCHAR(10) NOT NULL
)
GO

CREATE TABLE Accounts(
 Id INT PRIMARY KEY IDENTITY,
 Balance MONEY NOT NULL,
 PersonId INT,
 FOREIGN KEY (PersonId) REFERENCES Persons(Id)
)
GO

INSERT INTO Persons
VALUES('Jhon', 'Doe', '1234567891')
GO

INSERT INTO Persons
VALUES('Doncho', 'Minkov', '1233331891')
GO

INSERT INTO Persons
VALUES('Ivaylo', 'Kenov', '6543217891')
GO

INSERT INTO Persons
VALUES('Niki', 'Kostov', '0987654321')
GO

INSERT INTO Persons
VALUES('Evlogi', 'Hristov', '1111111111')
GO

INSERT INTO Accounts
VALUES(25000, 1)
GO

INSERT INTO Accounts
VALUES(20000, 2)
GO

INSERT INTO Accounts
VALUES(21000, 3)
GO

INSERT INTO Accounts
VALUES(23000, 4)
GO

INSERT INTO Accounts
VALUES(2500, 5)
GO

CREATE PROC usp_GetPersonsFullNames
AS
	SELECT FirstName + ' ' + LastName AS [Full Name] FROM Persons
GO

```

2.Create a stored procedure that accepts a number as a parameter and returns all persons who have more money in their accounts than the supplied number.

```sql

USE Users
GO

CREATE PROC usp_GetPersonsByBalance(@amountMoney MONEY)
AS
BEGIN
SELECT a.Id, a.Balance, a.PersonId, p.Id, p.FirstName, p.LastName, p.SSN FROM Users.dbo.Accounts a 
		INNER JOIN Users.dbo.Persons p
		ON (a.PersonId = p.Id)
		WHERE a.Balance > @amountMoney;
END
GO

EXEC usp_GetPersonsByBalance 10000

```

3.Create a function that accepts as parameters – sum, yearly interest rate and number of months.
It should calculate and return the new sum.
Write a SELECT to test whether the function works as expected.

```sql

USE Users
GO

CREATE FUNCTION ufn_CalculateAccountBalance(@oldSum MONEY, @interestRate MONEY, @monthsCount INT)
  RETURNS MONEY
AS
  BEGIN
  DECLARE @newSum MONEY
  SET @newSum = @oldSum + (((@interestRate / 100) / 12) * @monthsCount)
  RETURN @newSum
  END
GO

--Test--
PRINT Users.dbo.ufn_CalculateAccountBalance(3456, 6, 8)
GO

```

4.Create a stored procedure that uses the function from the previous example to give an interest to a person's account for one month.
It should take the AccountId and the interest rate as parameters.

```sql

USE Users
GO

CREATE PROC usp_CalculateMonthPersonBalance(@accountID INT,@interestRate MONEY)
AS
 DECLARE @balance MONEY
 SELECT @balance = Balance FROM Users.dbo.Accounts WHERE Id = @accountID
 SELECT Users.dbo.ufn_CalculateAccountBalance(@balance, @interestRate, 1) as MonthBalance
GO


EXEC Users.dbo.usp_CalculateMonthPersonBalance 1, 6

```

5.Create a stored procedure that uses the function from the previous example to give an interest to a person's account for one month.
It should take the AccountId and the interest rate as parameters.

```sql

USE Users
GO

CREATE PROC usp_WithDrawMoney(@accountID INT, @money MONEY)
AS
	BEGIN TRAN
	DECLARE @accountBalance MONEY
	SELECT @accountBalance = Balance FROM Users.dbo.Accounts
						             WHERE Id = @accountID;

    IF(@accountBalance >= @money)
	BEGIN
		UPDATE Users.dbo.Accounts 
		SET Balance = Balance - @money
		WHERE Id = @accountID AND Balance >= @money;

	COMMIT TRAN
	END
	ELSE
	  ROLLBACK TRAN
GO

EXEC Users.dbo.usp_WithDrawMoney 1, 111000
EXEC Users.dbo.usp_WithDrawMoney 2, 1000
EXEC Users.dbo.usp_WithDrawMoney 3, 1000

USE Users
GO

CREATE PROC usp_DepositMoney(@accountID INT, @money MONEY)
AS
    DECLARE @account INT;
	SELECT @account = Id FROM Users.dbo.Accounts
	   WHERE Id = @accountID
	BEGIN TRAN
	IF(NOT(@account IS NULL))
	BEGIN
		UPDATE Users.dbo.Accounts 
		SET Balance = Balance + @money
		WHERE Id = @accountID;
	COMMIT TRAN
	END
	ELSE
	ROLLBACK TRAN
GO

EXEC Users.dbo.usp_DepositMoney 1, 1000
EXEC Users.dbo.usp_DepositMoney 2, 1000
EXEC Users.dbo.usp_DepositMoney 3, 1000

```

6.Create another table – Logs(LogID, AccountID, OldSum, NewSum).
Add a trigger to the Accounts table that enters a new entry into the Logs table every time the sum on an account changes.
USE Users
GO

```sql

CREATE TABLE Logs(
 LogId INT PRIMARY KEY IDENTITY,
 OldSum MONEY NOT NULL,
 NewSum MONEY NOT NULL,
 AccountId INT
 )
 GO

 ALTER TABLE Logs
 ADD CONSTRAINT FK_Logs_Accounts FOREIGN KEY (AccountId) 
    REFERENCES Users.dbo.Accounts (Id) 
GO

USE Users
GO
CREATE TRIGGER tr_AccountsBalanceUpdate ON Accounts AFTER UPDATE
as
     IF (EXISTS(SELECT * FROM inserted WHERE Balance IS NULL) OR
     EXISTS(SELECT * FROM inserted WHERE Balance = 0))
    BEGIN
      RAISERROR('Balance cannot be empty or zero.', 16, 1)
      ROLLBACK TRAN
      RETURN
    END
	ELSE
    BEGIN
	DECLARE @old MONEY
	DECLARE @new MONEY
	DECLARE @id INT	
	 SELECT @new = Balance FROM inserted
	 SELECT @old =  Balance FROM deleted
	 SELECT @id = Id FROM inserted
	 INSERT INTO Logs(OldSum, NewSum, AccountID)
	 VALUES(@old, @new, @id)
	END
GO

EXEC usp_DepositMoney 1, 1000

```

7.Define a function in the database TelerikAcademy that returns all Employee's names (first or middle or last name) and all town's names that are comprised of given set of letters.
Example: 'oistmiahf' will return 'Sofia', 'Smith', … but not 'Rob' and 'Guy'.

```sql

USE TelerikAcademy
GO

CREATE FUNCTION ufn_CountLetters(@anagram NVARCHAR(50),@value NVARCHAR(50))
RETURNS INT
BEGIN
DECLARE @counter INT
DECLARE @position INT
DECLARE @current NVARCHAR(50)
SELECT @position = 0
SELECT @counter = 0

    IF(LEN(@value) < LEN(@anagram))
	BEGIN
	   WHILE(@position < LEN(@anagram))
	    BEGIN
	        IF(CHARINDEX(SUBSTRING(@anagram, @position,1),@value) >= 0)
	           BEGIN
	              SET @counter = @counter + 1
	           END
	        SET @position = @position + 1
	    END
	END
	ELSE
	   BEGIN
	      RETURN 0
	   END
 		  RETURN @counter
END
GO

CREATE FUNCTION ufn_GetEmployeesNames(@pattern nvarchar(50))
RETURNS @EmployeesFullNames TABLE 
(
  MATCH nvarchar(100)
)
AS
BEGIN
  INSERT INTO @EmployeesFullNames
  SELECT Employees.FirstName
  FROM Employees
   INNER JOIN Addresses ON(Employees.AddressID = Addresses.AddressID)
    INNER JOIN Towns ON(Addresses.TownID = Towns.TownID)
    WHERE LEN(Employees.FirstName) <= dbo.ufn_CountLetters(@pattern, Employees.FirstName)
  UNION
  SELECT Employees.LastName
  FROM Employees
    INNER JOIN Addresses ON(Employees.AddressID = Addresses.AddressID)
    INNER JOIN Towns ON(Addresses.TownID = Towns.TownID)
    WHERE LEN(Employees.LastName) <= dbo.ufn_CountLetters(@pattern, Employees.LastName)
  UNION
  SELECT Towns.Name FROM Towns
     WHERE LEN(Towns.Name) <= dbo.ufn_CountLetters(@pattern, Towns.Name)
  RETURN 
END
GO

SELECT * FROM ufn_GetEmployeesNames('oistmiahf')
GO

```

8.Using database cursor write a T-SQL script that scans all employees and their addresses and prints all pairs of employees that live in the same town.

```sql

DECLARE empCursor CURSOR READ_ONLY FOR
  SELECT e.FirstName, e.LastName , t.Name
  FROM TelerikAcademy.dbo.Employees e
  INNER JOIN TelerikAcademy.dbo.Addresses a
  ON e.AddressID = a.AddressID
  INNER JOIN TelerikAcademy.dbo.Towns t
  ON a.TownID = t.TownID

OPEN empCursor
DECLARE @firstName CHAR(50), @lastName CHAR(50), @townName CHAR(50)
FETCH NEXT FROM empCursor INTO @firstName, @lastName, @townName

WHILE @@FETCH_STATUS = 0
  BEGIN
    PRINT @firstName + ' ' + @lastName + ' ' + @townName
    FETCH NEXT FROM empCursor 
    INTO @firstName, @lastName, @townName
  END

CLOSE empCursor
DEALLOCATE empCursor

```

9.*Write a T-SQL script that shows for each town a list of all employees that live in it.
Sample output:	 sql Sofia -> Martin Kulov, George Denchev Ottawa -> Jose Saraiva …

```sql

DECLARE empTownCursor CURSOR READ_ONLY FOR
  SELECT  t.Name, e.FirstName, e.LastName
  FROM TelerikAcademy.dbo.Employees e
  INNER JOIN TelerikAcademy.dbo.Addresses a
  ON e.AddressID = a.AddressID
  INNER JOIN TelerikAcademy.dbo.Towns t
  ON a.TownID = t.TownID
  GROUP BY t.Name, e.FirstName, e.LastName

OPEN empTownCursor
DECLARE @townName CHAR(50), @firstName CHAR(50), @lastName CHAR(50)
FETCH NEXT FROM empTownCursor INTO @townName, @firstName, @lastName

DECLARE @currentTown CHAR(50);
DECLARE @text NVARCHAR(1000);
SELECT @currentTown = @townName;
SELECT @text = @currentTown + '->';
SELECT @text = REPLACE(@text, ' ', '')

WHILE @@FETCH_STATUS = 0
  BEGIN
	IF(NOT(@currentTown = @townName))
	BEGIN
	  SELECT @currentTown = @townName
	  SELECT @text = REPLACE(@text, ' ', '')
	  PRINT @text
	  SELECT @text = @currentTown + '->';
	  SELECT @text = REPLACE(@text, ' ', '')
	END
	ELSE
	BEGIN
	  SELECT @text = CONCAT(@text  , @firstName , ' ' , @lastName , ',')
	END
    FETCH NEXT FROM empTownCursor 
    INTO @townName, @firstName, @lastName
  END

CLOSE empTownCursor
DEALLOCATE empTownCursor

```

10.Define a .NET aggregate function StrConcat that takes as input a sequence of strings and return a single string that consists of the input strings separated by ','.

For example the following SQL statement should return a single string:
sql SELECT StrConcat(FirstName + ' ' + LastName) FROM Employees

```sql

--Turning on CLR functionality
--By default, CLR is disabled in SQL Server so to turn it on
--we need to run this command against our database
EXEC sp_configure 'clr enabled', 1
GO
RECONFIGURE
GO
 
-- Creating the SQL assembly and linking it to the C# library DLL we created
CREATE ASSEMBLY SQLAggregateFunctions
AUTHORIZATION dbo
FROM 'C:\StrConcat.dll'
WITH PERMISSION_SET = SAFE
GO
 
CREATE AGGREGATE dbo.StrConcat (@value nvarchar(MAX)) RETURNS nvarchar(MAX)
EXTERNAL NAME SQLAggregateFunctions.[StrConcat.StrConcat]
--EXTERNAL NAME SQLAssemblyName.[C#NameSpace".C#ClassName].C#MethodName
 
 

--DROP AGGREGATE dbo.CountNulls
--DROP ASSEMBLY SQLAggregateFunctions

```




