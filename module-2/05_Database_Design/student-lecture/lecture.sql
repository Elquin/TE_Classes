--Switch context to 'master' database
Use master
GO

-- If our DB already exists, drop it. (Only for exercises to refresh database to default state)
DROP DATABASE IF EXISTS ArtGallery

--Create the ArtGallery
CREATE DATABASE ArtGallery
GO

--Use the new database
USE ArtGallery
GO

CREATE TABLE Person (
	PersonID	int NOT NULL IDENTITY,
	FirstName	nvarchar(30) NOT NULL,
	LastName	nvarchar(30) NOT NULL,
	Address		nvarchar(100) NULL,
	PhoneNumber	varchar(15) NULL,
	constraint	PK_Person PRIMARY KEY (PersonID)
);

CREATE TABLE Art (
	ArtID	int identity(100, 10) primary key, -- (100, 10) is optional. Starts identity at 100 and increments by 10. If single column ID, you can do it this simplified way rather than the above way
	Title	nvarchar(50) NOT NULL Default('Untitled'),
	ArtistID int NOT NULL,
	InStock	bit NOT NULL DEFAULT(1),
	constraint FK_Art_Person FOREIGN KEY (ArtistID) REFERENCES Person(PersonID) --conventional naming with FK_(current table)_(foreign referenced table)
)

CREATE TABLE Purchase (
	PurchaseID	int identity primary key,
	PurchaseDate datetime,
	Price	money,
	CustomerID	int NOT NULL,
	ArtID	int NOT NULL,
	constraint FK_Purchase_Person FOREIGN KEY (CustomerId) REFERENCES Person(PersonID),
	constraint FK_Purchase_Art FOREIGN KEY (ArtId) REFERENCES Art(ArtId)
)