-- Write queries to return the following:
-- The following changes are applied to the "dvdstore" database.**

-- 1. Add actors, Hampton Avenue, and Lisa Byway to the actor table.
INSERT actor
(first_name, last_name)
VALUES
('Hampton', 'Avenue'), ('Lisa', 'Byway')

SELECT *
FROM actor

-- 2. Add "Euclidean PI", "The epic story of Euclid as a pizza delivery boy in
-- ancient Greece", to the film table. The movie was released in 2008 in English.
-- Since its an epic, the run length is 3hrs and 18mins. There are no special
-- features, the film speaks for itself, and doesn't need any gimmicks.
INSERT film
(title, description, release_year, language_id, length)
VALUES
('Euclidean PI', 'The epic story of Euclid as a pizza delivery boy in
-- ancient Greece', 2008, 1, 198)

SELECT *
FROM film


-- 3. Hampton Avenue plays Euclid, while Lisa Byway plays his slightly
-- overprotective mother, in the film, "Euclidean PI". Add them to the film.
INSERT film_actor
(film_id, actor_id)
VALUES
( 101, 201), ( 101, 202) 

-- 4. Add Mathmagical to the category table.
INSERT category
(name)
VALUES
('Mathmagical')

SELECT *
FROM category

-- 5. Assign the Mathmagical category to the following films, "Euclidean PI",
-- "EGG IGBY", "KARATE MOON", "RANDOM GO", and "YOUNG LANGUAGE"
UPDATE film_category
SET category_id = 17
WHERE film_id IN (274, 494, 714, 996, 1001)

INSERT film_category
(film_id, category_id)
VALUES
(1001, 17)

SELECT *
FROM film_category

-- 6. Mathmagical films always have a "G" rating, adjust all Mathmagical films
-- accordingly.
-- (5 rows affected)
UPDATE film
SET rating = 'G'
WHERE film_id IN
(SELECT film_id FROM film_category WHERE category_id = (SELECT category_id FROM category WHERE name = 'Mathmagical'))

SELECT *
FROM film_category
WHERE category_id = 17

SELECT *
FROM film
WHERE title = 'Euclidean PI'


-- 7. Add a copy of "Euclidean PI" to all the stores.
INSERT inventory
(film_id, store_id)
VALUES
(1001, 1), (1001, 2)

SELECT *
FROM inventory

-- 8. The Feds have stepped in and have impounded all copies of the pirated film,
-- "Euclidean PI". The film has been seized from all stores, and needs to be
-- deleted from the film table. Delete "Euclidean PI" from the film table.
-- (Did it succeed? Why?)
-- Could not delete because it's a PK of film_category and is dependent of it. "Referential Integrity Constraints"
DELETE FROM film
WHERE film.title = 'Euclidean PI'



-- 9. Delete Mathmagical from the category table.
-- (Did it succeed? Why?)
-- Could not delete because category_id is a pk to category and references Mathmagical. "Referential Integrity Constraints"
DELETE FROM category
WHERE name = 'Mathmagical'

-- 10. Delete all links to Mathmagical in the film_category tale.
-- (Did it succeed? Why?)
-- Yes. film_category held the primary key of mathmagical which is the category_id. The PK is able to be deleted because it is not dependent on other tables.
DELETE FROM film_category
WHERE category_id = 17

-- 11. Retry deleting Mathmagical from the category table, followed by retrying
-- to delete "Euclidean PI".
-- (Did either deletes succeed? Why?)
-- Mathmagical was able to be deleted because the PK from film_category was previously deleted in 10 and reference no longer there. 
--Euclidean PI could not be deleted because it still has a PK connected with film_id.
DELETE FROM category
WHERE name = 'Mathmagical'

DELETE FROM film
WHERE film.title = 'Euclidean PI'

-- 12. Check database metadata to determine all constraints of the film id, and
-- describe any remaining adjustments needed before the film "Euclidean PI" can
-- be removed from the film table.
SELECT * FROM INFORMATION_SCHEMA.TABLES 
SELECT * FROM INFORMATION_SCHEMA. COLUMNS 
SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS 
SELECT * FROM INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE 
SELECT * FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS

SELECT *
FROM film
WHERE title = 'Euclidean PI'

DELETE FROM film
WHERE film.title = 'Euclidean PI'