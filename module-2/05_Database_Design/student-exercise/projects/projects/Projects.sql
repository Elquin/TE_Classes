--Switch context to 'master' database
Use master
GO

-- If our DB already exists, drop it. (Only for exercises to refresh database to default state)
DROP DATABASE IF EXISTS Projects

--Create the Projects
CREATE DATABASE Projects
GO

--Use the new database
USE Projects
GO

CREATE TABLE Project (
	ProjectId	int NOT NULL IDENTITY primary key,
	ProjectName		nvarchar(30) NOT NULL,
	StartDate	Datetime NOT NULL,
	NumberOfEmployees int NOT NULL

)

CREATE TABLE Department (
	DepartmentId	int identity primary key, -- (100, 10) is optional. Starts identity at 100 and increments by 10. If single column ID, you can do it this simplified way rather than the above way
	DepartmentName			nvarchar(30) NOT NULL,
	NumberOfEmployees int Default ('0')
)

CREATE TABLE Employee (
	EmployeeId	int identity(100, 1),
	JobTitle	nvarchar(30) NOT NULL,
	LastName	nvarchar(30) NOT NULL,
	FirstName	nvarchar(30) NOT NULL,
	Gender		nvarchar(30) Default ('Unknown'),
	DateOfBirth	Datetime NOT NULL,
	DateOfHire	Datetime NOT NULL,
	DepartmentId int NOT NULL,
	CONSTRAINT pk_EmployeeId_1 PRIMARY KEY (EmployeeId), 
	constraint fk_DepartmentId_1 FOREIGN KEY (DepartmentId) REFERENCES Department(DepartmentId)
)

INSERT INTO PROJECT (ProjectName, StartDate, NumberOfEmployees)
VALUES ('Mobile App', '10-20-2019', 2), ('Video Game', '10-25-2019', 2),
('Database', '11-20-2019', 2), ('Member Rewards Catalogue', '10-25-2019', 2)

INSERT INTO Department(DepartmentName, NumberOfEmployees)
VALUES ('Art Department', 2), ('Dev Ops', 2),
('Database OPs', 2)

INSERT INTO Employee(JobTitle, LastName, FirstName, Gender, DateOfBirth, DateOfHire, DepartmentId)
VALUES ('Dev Ops', 'Smith', 'John', 'Male', '10-13-1986', '08-13-2018', 2),
('Dev Ops', 'Crone', 'Sam', 'Male', '09-17-1976', '08-07-2002', 2),
('Dev Ops', 'Lylwynn', 'Shelly', 'Female', '12-14-1980', '08-10-2013', 2),
('Database Ops', 'Haliwell', 'Sarah', 'Female', '10-13-1990', '06-13-2018', 3),
('Database Ops', 'Samuels', 'Sam', 'Male', '09-17-1979', '08-07-2014', 3),
('Database Ops', 'Locklin', 'Christian', 'Male', '12-20-1983', '08-16-2012', 3),
('Art Department', 'Hackwell', 'Sid', 'Male', '10-23-1988', '08-13-2018', 1),
('Art Department', 'Simmons', 'Kelly', 'Female', '09-17-1992', '08-07-2014', 1),
('Art Department', 'Markson', 'Markus', 'Male', '06-20-1989', '09-18-2017', 1)

SELECT *
FROM Department

SELECT *
FROM Employee

SELECT *
FROM Project