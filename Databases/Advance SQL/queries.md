1.Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company.
 -Use a nested SELECT statement.

```sql

SELECT FirstName + ' ' + LastName as [Full Name],
       Salary as [Min Slary]
FROM TelerikAcademy.dbo.Employees
WHERE Salary = 
	(SELECT MIN(Salary) FROM TelerikAcademy.dbo.Employees)

```
2.Write a SQL query to find the names and salaries of the employees that have a salary that is up to 10% higher than the minimal salary for the company.

```sql

SELECT FirstName + ' ' + LastName as [Full Name],
		Salary
FROM TelerikAcademy.dbo.Employees
WHERE Salary = 
	((SELECT MIN(Salary) FROM TelerikAcademy.dbo.Employees) + 
	(SELECT MIN(Salary) FROM TelerikAcademy.dbo.Employees) * 0.1)

```
3.Write a SQL query to find the full name, salary and department of the employees that take the minimal salary in their department.
Use a nested SELECT statement.

```sql

SELECT e.FirstName + ' ' + e.LastName as [FullName], e.Salary as [MinSalary], d.Name as [DepartmentName] 
FROM TelerikAcademy.dbo.Employees e
INNER JOIN TelerikAcademy.dbo.Departments d
ON e.DepartmentID = d.DepartmentID
WHERE e.Salary = 
    (SELECT MIN(m.Salary) FROM TelerikAcademy.dbo.Employees m
	INNER JOIN TelerikAcademy.dbo.Departments p
	ON m.DepartmentID = p.DepartmentID
	WHERE p.Name = d.Name)

```
4.Write a SQL query to find the average salary in the department #1.

```sql

SELECT AVG(e.Salary) as 'AverageSalary in department #1'
FROM TelerikAcademy.dbo.Employees e
INNER JOIN TelerikAcademy.dbo.Departments d
ON e.DepartmentID = d.DepartmentID
WHERE d.DepartmentID = 1 

```
5.Write a SQL query to find the average salary in the "Sales" department.

```sql

SELECT AVG(e.Salary) as 'AverageSalary in "Sales" department'
FROM TelerikAcademy.dbo.Employees e
INNER JOIN TelerikAcademy.dbo.Departments d
ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

```
6.Write a SQL query to find the number of employees in the "Sales" department.

```sql

SELECT COUNT(*) as 'Number enployees in "Sales" department'
FROM TelerikAcademy.dbo.Employees e
INNER JOIN TelerikAcademy.dbo.Departments d
ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

```
7.Write a SQL query to find the number of all employees that have manager.

```sql

SELECT COUNT(*) as 'Employees that have manager'
FROM TelerikAcademy.dbo.Employees e
INNER JOIN TelerikAcademy.dbo.Employees m
ON e.ManagerID = m.EmployeeID
WHERE NOT(m.ManagerID IS NULL) 

```
8.Write a SQL query to find the number of all employees that have no manager.

```sql

SELECT COUNT(*) as 'Employees without manager'
FROM TelerikAcademy.dbo.Employees e
INNER JOIN TelerikAcademy.dbo.Employees m
ON e.ManagerID = m.EmployeeID
WHERE (m.ManagerID IS NULL) 

```
9.Write a SQL query to find all departments and the average salary for each of them.

```sql

SELECT d.Name as [Department Name], AVG(e.Salary) as 'Average salary'
FROM TelerikAcademy.dbo.Employees e
INNER JOIN TelerikAcademy.dbo.Departments d
ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name

```
10.Write a SQL query to find the count of all employees in each department and for each town.

```sql

SELECT t.Name as [Town], d.Name as [DepartmentName], COUNT(*) as [EmployeesCount]
FROM TelerikAcademy.dbo.Employees e
  INNER JOIN TelerikAcademy.dbo.Departments d
	ON e.DepartmentID = d.DepartmentID
  INNER JOIN TelerikAcademy.dbo.Addresses a
	ON e.AddressID = a.AddressID
  INNER JOIN TelerikAcademy.dbo.Towns t
	ON a.TownID = t.TownID
GROUP BY t.Name, d.Name

```
11.Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.

```sql

SELECT COUNT(*) as [EmployeesNumber], m.FirstName + ' ' + m.LastName as [ManagersFullName]
FROM TelerikAcademy.dbo.Employees e
  INNER JOIN TelerikAcademy.dbo.Employees m
  ON e.ManagerID = m.EmployeeID
 GROUP BY m.EmployeeID, m.FirstName + ' ' + m.LastName
 HAVING COUNT(*) = 5

```
12.Write a SQL query to find all employees along with their managers. For employees that do not have manager display the value "(no manager)".

```sql

SELECT e.FirstName + ' ' + e.LastName as [EmployeeName], 
		COALESCE(m.FirstName+ ' ' + m.LastName, '(no menager)') as [ManagerName]
FROM TelerikAcademy.dbo.Employees e
  LEFT JOIN TelerikAcademy.dbo.Employees m
  ON e.ManagerID = m.EmployeeID

```
13.Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. Use the built-in LEN(str) function.

```sql

SELECT FirstName + ' ' + LastName as [EmployeeName]
FROM TelerikAcademy.dbo.Employees
WHERE LEN(LastName) = 5

```
14.Write a SQL query to display the current date and time in the following format "day.month.year hour:minutes:seconds:milliseconds".
Search in Google to find how to format dates in SQL Server.

```sql

SELECT CONVERT(VARCHAR(25), GETDATE(), 104) + ':' + SUBSTRING(CONVERT(VARCHAR(25), GETDATE(), 113), 13, 12) as [Date]

```
15.Write a SQL statement to create a table Users. Users should have username, password, full name and last login time.
Choose appropriate data types for the table fields. Define a primary key column with a primary key constraint.
Define the primary key column as identity to facilitate inserting records.
Define unique constraint to avoid repeating usernames.
Define a check constraint to ensure the password is at least 5 characters long.

```sql

USE TelerikAcademy
CREATE TABLE Users(
   UserID INT PRIMARY KEY IDENTITY,
   [Username] NVARCHAR(50) NOT NULL UNIQUE,
   [Password] NVARCHAR(50) NOT NULL CHECK (LEN([Password]) >= 5),
   [FullName] NVARCHAR(50) NOT NULL,
   [LastLogin] DATETIME
)
GO

```
16.Write a SQL statement to create a view that displays the users from the Users table that have been in the system today.
 -Test if the view works correctly.

```sql

CREATE VIEW [Today users list] AS
SELECT * FROM TelerikAcademy.dbo.Users
WHERE DAY(LastLogin) = DAY(GETDATE()) 
      AND MONTH(LastLogin) = MONTH(GETDATE())
	  AND YEAR(LastLogin) = YEAR(GETDATE())
GO
INSERT INTO TelerikAcademy.dbo.Users
VALUES('JhonDoe', 'BATMAN', 'Doncho Minkov', GETDATE())
GO
SELECT * FROM [Today users list]
GO

```
17.Write a SQL statement to create a table Groups. Groups should have unique name (use unique constraint).
Define primary key and identity column.

```sql

USE TelerikAcademy
CREATE TABLE Groups(
  GroupId INT PRIMARY KEY IDENTITY,
  Name NVARCHAR(50) NOT NULL UNIQUE
)
GO

```
18.Write a SQL statement to add a column GroupID to the table Users.
Fill some data in this new column and as well in the `Groups table.
Write a SQL statement to add a foreign key constraint between tables Users and Groups tables.

```sql

USE TelerikAcademy
GO

ALTER TABLE Users ADD GroupId int
GO

ALTER TABLE Users
ADD CONSTRAINT FK_Users_Groups
	FOREIGN KEY (GroupId)
	REFERENCES Groups(GroupId)
GO

```
19.Write SQL statements to insert several records in the Users and Groups tables.

```sql

USE TelerikAcademy
GO

INSERT INTO Groups
VALUES('CSharpGroup')
GO

INSERT INTO Groups
VALUES('JavaScriptGroup')
GO

INSERT INTO Groups
VALUES('SQLGroup')
GO

INSERT INTO Users
VALUES('Niki', 'CSharpMaster', 'Nikolai Kostov', GETDATE(), 1)
GO

INSERT INTO Users
VALUES('Ivaylo', 'TheBestNinja', 'Ivaylo Kenov', GETDATE(), 3)
GO

INSERT INTO Users
VALUES('Evlogi', 'TheTrainer', 'Evlogi Hristov', GETDATE(), 2)
GO

INSERT INTO Users
VALUES('JhonDoe', 'BATMAN', 'Doncho Minkov', GETDATE(), 2)
GO

```
20.Write SQL statements to update some of the records in the Users and Groups tables.

```sql

USE TelerikAcademy
GO

UPDATE Users SET LastLogin = GETDATE()
GO

UPDATE Groups SET Name = 'CSharp'
WHERE Name = 'CSharpGroup'
GO

UPDATE Groups SET Name = 'JavaScript'
WHERE Name = 'JavaScriptGroup'
GO

UPDATE Groups SET Name = 'SQLGroup'
WHERE Name = 'SQLGroup'
GO

```
21.Write SQL statements to delete some of the records from the Users and Groups tables.

```sql

USE TelerikAcademy
GO

INSERT INTO Users
VALUES('Pesho', 'Gosho', 'PeshoGoshov', GETDATE(), 1)
GO

INSERT INTO Users
VALUES('Gosho', 'Peshov', 'GoshoPeshov', GETDATE(), 1)
GO

```

22.Write SQL statements to insert in the Users table the names of all employees from the Employees table.
Combine the first and last names as a full name.
For username use the first letter of the first name + the last name (in lowercase).
Use the same for the password, and NULL for last login time.

```sql

USE TelerikAcademy
GO

ALTER TABLE Users 
DROP CONSTRAINT CK__Users__Password__76619304;
GO

ALTER TABLE Users
DROP CONSTRAINT UQ__Users__536C85E4BF61EEA1;
GO

INSERT INTO Users ([Username], [Password], [FullName], [LastLogin], [GroupId])
SELECT SUBSTRING(FirstName, 1, 1) + LOWER(LastName),
	   SUBSTRING(FirstName, 1, 1) + LOWER(LastName),
	   Firstname + ' ' + LastName,
	   GETDATE(),
	   NULL
 FROM Employees;
 GO

```
23.Write a SQL statement that changes the password to NULL for all users that have not been in the system since 10.03.2010.

```sql

USE TelerikAcademy
GO

ALTER TABLE Users
ALTER COLUMN Password NVARCHAR(50) NULL
GO

UPDATE Users SET [Password] = NULL
WHERE CAST(CAST(2010 AS varchar) + '-' + CAST(3 AS varchar) + '-' + CAST(10 AS varchar) AS DATETIME)
     < CAST(CAST(YEAR(LastLogin) AS varchar) + '-' + CAST(MONTH(LastLogin) AS varchar) + '-' + CAST( DAY(LastLogin) AS varchar) AS DATETIME)
GO

```
24.Write a SQL statement that deletes all users without passwords (NULL password).

```sql

USE TelerikAcademy
GO

DELETE Users
WHERE Password IS NULL
GO

```
25.Write a SQL query to display the average employee salary by department and job title.

```sql

USE TelerikAcademy
GO

SELECT  d.Name as 'Department Name', e.JobTitle, AVG(e.Salary) as 'Average Salary'
FROM Employees e
INNER JOIN Departments d
ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle
GO

```
26.Write a SQL query to display the minimal employee salary by department and job title along with the name of some of the employees that take it.

```sql

USE TelerikAcademy
GO

SELECT d.Name, e.JobTitle, e.FirstName + ' ' + e.LastName as [Full name], 
ROW_NUMBER() OVER (PARTITION BY e.JobTitle ORDER BY e.FirstName + ' ' + e.LastName) AS RowsCount, 
MIN(Salary) as [Average Salary]
FROM Employees e join Departments d
ON(e.DepartmentID = d.DepartmentID)
GROUP BY d.Name, e.JobTitle, e.FirstName + ' ' + e.LastName
GO

```
27.Write a SQL query to display the town where maximal number of employees work.

```sql

USE TelerikAcademy
GO

SELECT t.Name AS [Town Name], COUNT(*) AS [Number of Employees]
FROM Employees e INNER JOIN Addresses a
ON(e.AddressID = a.AddressID)
   INNER JOIN Towns t
ON (a.TownID = t.TownID)
GROUP BY t.Name
GO

```
28.Write a SQL query to display the number of managers from each town.

```sql

USE TelerikAcademy
GO

SELECT t.Name AS [Town Name], COUNT(m.EmployeeID)
  FROM Employees e
  INNER JOIN Employees m
  ON(e.ManagerID = m.EmployeeID)
  INNER JOIN Addresses a
  ON(a.AddressID = m.AddressID)
  INNER JOIN Towns t
  ON(a.TownID = t.TownID)
GROUP BY t.Name, m.EmployeeID

```
29.Write a SQL to create table WorkHours to store work reports for each employee (employee id, date, task, hours, comments).
Don't forget to define identity, primary key and appropriate foreign key.
Issue few SQL statements to insert, update and delete of some data in the table.
Define a table WorkHoursLogs to track all changes in the WorkHours table with triggers.
For each change keep the old record data, the new record data and the command (insert / update / delete).

```sql

USE TelerikAcademy
GO

CREATE TABLE WorkHours(
  WorkHoursId INT PRIMARY KEY IDENTITY,
  [Date] DATETIME NOT NULL,
  Task NVARCHAR(50),
  [HOURS] FLOAT NOT NULL,
  Comments NVARCHAR(1000),
  EmployeeId INT
)
GO

ALTER TABLE Employees ADD WorkHoursId INT
GO

ALTER TABLE Employees
ADD CONSTRAINT FK_Employees_WorkHours
	FOREIGN KEY (WorkHoursId)
	REFERENCES WorkHours(WorkHoursId)
GO

CREATE TABLE WorkHoursLogs(
WorkHoursLogsID INT PRIMARY KEY IDENTITY,
OldData NVARCHAR(1000) ,
NewData NVARCHAR(1000) ,
[Operation] NVARCHAR(50)
)
GO

CREATE TRIGGER InsertLog ON WorkHours
AFTER INSERT
AS
    IF (EXISTS(SELECT * FROM INSERTED))
    BEGIN
	DECLARE @oldData NVARCHAR(1000)
	DECLARE @newData NVARCHAR(1000)
	DECLARE @id INT
	SELECT @oldData =  cast(d.[Date] as nvarchar(30)) + ' ' + d.Task + ' ' + cast(d.[Hours] as nvarchar(2)) + ':hours ' + d.Comments + ' employeeID:' + cast(d.EmployeeId as nvarchar(5)) from DELETED d
	SELECT @newData =  cast(i.[Date] as nvarchar(30)) + ' ' + i.Task + ' ' + cast(i.[Hours] as nvarchar(2))+ ':hours ' + i.Comments + ' employeeID:' + cast(i.EmployeeId as nvarchar(5)) from INSERTED i
	SELECT @id = WorkHoursId from INSERTED
	INSERT INTO WorkHoursLogs(OldData , NewData, [Operation])
	VALUES(@oldData, @newData,'INSERT')
    END
	ELSE
    BEGIN
	  RAISERROR('WorkHoursLogs not contain data.', 16, 1)
      ROLLBACK TRAN
      RETURN
	END

    PRINT 'AFTER INSERT trigger fired.'
GO

CREATE TRIGGER UpdateLog ON WorkHours
AFTER UPDATE
AS
    IF (EXISTS(SELECT * FROM INSERTED))
    BEGIN
	DECLARE @oldData NVARCHAR(1000)
	DECLARE @newData NVARCHAR(1000)
	DECLARE @id INT
	SELECT @oldData =  cast(d.[Date] as nvarchar(30)) + ' ' + d.Task + ' ' + cast(d.[Hours] as nvarchar(2)) + ':hours ' + d.Comments + ' employeeID:' + cast(d.EmployeeId as nvarchar(5)) from DELETED d
	SELECT @newData =  cast(i.[Date] as nvarchar(30)) + ' ' + i.Task + ' ' + cast(i.[Hours] as nvarchar(2))+ ':hours ' + i.Comments + ' employeeID:' + cast(i.EmployeeId as nvarchar(5)) from INSERTED i
	SELECT @id = WorkHoursId from INSERTED
	INSERT INTO WorkHoursLogs(OldData , NewData, [Operation])
	VALUES(@oldData, @newData,'UPDATE')
    END
	ELSE
    BEGIN
	  RAISERROR('WorkHoursLogs not contain data.', 16, 1)
      ROLLBACK TRAN
      RETURN
	END

    PRINT 'AFTER UPDATE trigger fired.'
GO

CREATE TRIGGER DeleteLog ON WorkHours
AFTER DELETE
AS
    IF (EXISTS(SELECT * FROM DELETED))
    BEGIN
	DECLARE @oldData NVARCHAR(1000)
	DECLARE @newData NVARCHAR(1000)
	DECLARE @id INT
	SELECT @oldData =  cast(d.[Date] as nvarchar(30)) + ' ' + d.Task + ' ' + cast(d.[Hours] as nvarchar(2)) + ':hours ' + d.Comments + ' employeeID:' + cast(d.EmployeeId as nvarchar(5)) from DELETED d
	SELECT @newData =  cast(i.[Date] as nvarchar(30)) + ' ' + i.Task + ' ' + cast(i.[Hours] as nvarchar(2))+ ':hours ' + i.Comments + ' employeeID:' + cast(i.EmployeeId as nvarchar(5)) from INSERTED i
	SELECT @id = WorkHoursId from INSERTED
	INSERT INTO WorkHoursLogs(OldData , NewData, [Operation])
	VALUES(@oldData, @newData,'DELETE')
    END
	ELSE
    BEGIN
	  RAISERROR('WorkHoursLogs not contain data.', 16, 1)
      ROLLBACK TRAN
      RETURN
	END

    PRINT 'AFTER DELETE trigger fired.'
GO

INSERT INTO WorkHours
VALUES(GETDATE(), 'unit testing', 8, 'driven developing', 77)
GO


INSERT INTO WorkHours
VALUES(GETDATE(), 'unit testing', 8, 'driven developing', 77)
INSERT INTO WorkHours
VALUES(GETDATE(), 'developing JSApp', 8, 'AngularJS and Bootstrap', 159)
GO
INSERT INTO WorkHours
VALUES(GETDATE(), 'developing JSApp', 8, 'AngularJS and Bootstrap', 149)
GO
INSERT INTO WorkHours
VALUES(GETDATE(), 'developing JSApp', 8, 'AngularJS and Bootstrap', 149)
GO
INSERT INTO WorkHours
VALUES(GETDATE(), 'developing JSApp', 8, 'AngularJS and Bootstrap', 149)
GO

UPDATE WorkHours SET Comments = ''
WHERE EmployeeId = 149
GO

DELETE  FROM WorkHours
 WHERE EmployeeId = 149
GO

```
30.Start a database transaction, delete all employees from the 'Sales' department along with all dependent records from the pother tables.
At the end rollback the transaction.

```sql

USE TelerikAcademy
GO

BEGIN TRAN
DELETE Employees
 FROM Employees e
 INNER JOIN Departments d
 ON (e.DepartmentID = d.DepartmentID)
 WHERE d.Name = 'Salaes'
 ROLLBACK TRAN
GO

```
31.Start a database transaction and drop the table EmployeesProjects.
Now how you could restore back the lost table data?
32.Find how to use temporary tables in SQL Server.
Using temporary tables backup all records from EmployeesProjects and restore them back after dropping and re-creating the table.

```sql

USE TelerikAcademy
GO

BEGIN TRAN

--SAVE DATA IN TEMP TABLE #EmployeesProjectsBackup 
SELECT * INTO #EmployeesProjectsBackup FROM TelerikAcademy.dbo.EmployeesProjects
DROP TABLE EmployeesProjects
COMMIT TRAN

--RESTORE DATA FROM TEMP TABLE #EmployeesProjectsBackup
--SELECT * INTO TelerikAcademy.dbo.EmployeesProjects FROM #EmployeesProjectsBackup

```