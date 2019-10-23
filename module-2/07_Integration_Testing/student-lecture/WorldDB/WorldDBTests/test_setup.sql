BEGIN Tran

-- Remove all the date from the DB
DELETE FROM contrylanguage;
UPDATE country SET capital = NULL;
DELETE FROM city;
DELETE FROM country;

--insert some test data

--Country
INSERT INTO country ([code]
      ,[name]
      ,[continent]
      ,[region]
      ,[surfacearea]
      ,[population]
      ,[localname]
      ,[governmentform]
      ,[capital]
      ,[code2]) VALUES ('ZZZ', 'Kingdom of Caring', 'Asia', '', 300, 45, 'Home', 'Monarchy', NULL, 'ZZ');

-- City
INSERT INTO city ([name]
      ,[countrycode]
      ,[district]
      ,[population]) VALUES ('Care-a-lot', 'ZZZ', 'Klowds', 25)

DECLARE @newCity int
SELECT @newCity = @@identity

-- Set the capital of care-a-lot
UPDATE country
	SET capital = @newCity

-- Add a language
INSERT INTO countrylanguage ([countrycode]
      ,[language]
      ,[isofficial]
      ,[percentage]) VALUES ('ZZZ', 'Love', 1, 100.0)

-- return the new city id
SELECT @newCity AS NewCity



SELECT * FROM city
SELECT * FROM country
SELECT * FROM countrylanguage

ROLLBACK