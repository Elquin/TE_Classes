-- The following queries utilize the "dvdstore" database.

-- 1. All of the films that Nick Stallone has appeared in
-- (30 rows)
SELECT film.title
FROM film
JOIN film_actor ON film.film_id = film_actor.film_id
JOIN actor ON film_actor.actor_id = actor.actor_id
WHERE actor.first_name = 'Nick' AND actor.last_name = 'Stallone'

-- 2. All of the films that Rita Reynolds has appeared in
-- (20 rows)
SELECT film.title
FROM film
JOIN film_actor ON film.film_id = film_actor.film_id
JOIN actor ON film_actor.actor_id = actor.actor_id
WHERE actor.first_name = 'Rita' AND actor.last_name = 'Reynolds'

-- 3. All of the films that Judy Dean or River Dean have appeared in
-- (46 rows)
SELECT film.title
FROM film
JOIN film_actor ON film.film_id = film_actor.film_id
JOIN actor ON film_actor.actor_id = actor.actor_id
WHERE (actor.first_name = 'Judy' AND actor.last_name = 'Dean') OR (actor.first_name = 'River' AND actor.last_name = 'Dean')

-- 4. All of the the ‘Documentary’ films
-- (68 rows)
SELECT film.title
FROM film
JOIN film_category ON film_category.film_id = film.film_id
JOIN category ON category.category_id = film_category.category_id
WHERE category.name = 'Documentary'

-- 5. All of the ‘Comedy’ films
-- (58 rows)
SELECT film.title
FROM film
JOIN film_category ON film_category.film_id = film.film_id
JOIN category ON category.category_id = film_category.category_id
WHERE category.name = 'Comedy'

-- 6. All of the ‘Children’ films that are rated ‘G’
-- (10 rows)
SELECT film.title
FROM film
JOIN film_category ON film_category.film_id = film.film_id
JOIN category ON category.category_id = film_category.category_id
WHERE category.name = 'Children' AND film.rating = 'G'

-- 7. All of the ‘Family’ films that are rated ‘G’ and are less than 2 hours in length
-- (3 rows)
SELECT film.title
FROM film
JOIN film_category ON film_category.film_id = film.film_id
JOIN category ON category.category_id = film_category.category_id
WHERE category.name = 'Family' AND film.rating = 'G' AND film.length < 120

-- 8. All of the films featuring actor Matthew Leigh that are rated ‘G’
-- (9 rows)
SELECT film.title
FROM film
JOIN film_actor ON film.film_id = film_actor.film_id
JOIN actor ON film_actor.actor_id = actor.actor_id
JOIN film_category ON film_category.film_id = film.film_id
JOIN category ON category.category_id = film_category.category_id
WHERE actor.first_name = 'Matthew' AND actor.last_name = 'Leigh' AND film.rating = 'G'

-- 9. All of the ‘Sci-Fi’ films released in 2006
-- (61 rows)
SELECT film.title
FROM film
JOIN film_category ON film_category.film_id = film.film_id
JOIN category ON category.category_id = film_category.category_id
WHERE category.name = 'Sci-Fi' AND film.release_year = '2006'

-- 10. All of the ‘Action’ films starring Nick Stallone
-- (2 rows)
SELECT film.title
FROM film
JOIN film_category ON film_category.film_id = film.film_id
JOIN category ON category.category_id = film_category.category_id
JOIN film_actor ON film.film_id = film_actor.film_id
JOIN actor ON film_actor.actor_id = actor.actor_id
WHERE category.name = 'Action' AND actor.first_name = 'Nick' AND actor.last_name = 'Stallone'




-- 11. The address of all stores, including street address, city, district, and country
-- (2 rows)
SELECT address.address AS 'Address', city.city AS 'City', address.district AS 'District', country.country AS 'Country'
FROM store
JOIN address ON address.address_id = store.address_id
JOIN city ON city.city_id = address.city_id
JOIN country ON country.country_id = city.country_id

-- 12. A list of all stores by ID, the store’s street address, and the name of the store’s manager
-- (2 rows)
SELECT store.store_id, address.address, staff.first_name
FROM staff
JOIN store ON store.manager_staff_id = staff.staff_id
JOIN address ON address.address_id = store.address_id
JOIN city ON city.city_id = address.city_id


-- 13. The first and last name of the top ten customers ranked by number of rentals 
-- (#1 should be “ELEANOR HUNT” with 46 rentals, #10 should have 39 rentals)

SELECT TOP 10 customer.first_name, customer.last_name, COUNT(payment.payment_id) AS 'rentals'
FROM customer
JOIN payment ON payment.customer_id = customer.customer_id
GROUP BY customer.first_name, customer.last_name
ORDER BY 3 DESC


-- 14. The first and last name of the top ten customers ranked by dollars spent 
-- (#1 should be “KARL SEAL” with 221.55 spent, #10 should be “ANA BRADLEY” with 174.66 spent)

SELECT TOP 10 customer.first_name, customer.last_name, SUM(payment.amount) AS 'spent'
FROM customer
JOIN payment ON payment.customer_id = customer.customer_id
GROUP BY customer.first_name, customer.last_name
ORDER BY 3 DESC

-- 15. The store ID, street address, total number of rentals, total amount of sales (i.e. payments), and average sale of each store 
-- (Store 1 has 7928 total rentals and Store 2 has 8121 total rentals)

SELECT store.store_id AS 'store', address.address AS 'address',COUNT(payment.payment_id) AS 'rentals', SUM(payment.amount) AS 'totalSales', SUM(payment.amount) / COUNT(payment.payment_id) AS 'averageSales'
FROM store
JOIN address ON address.address_id = store.address_id
JOIN city ON city.city_id = address.city_id
JOIN inventory ON inventory.store_id = store.store_id
JOIN rental ON rental.inventory_id = inventory.inventory_id
JOIN payment ON payment.rental_id = rental.rental_id
GROUP BY store.store_id, address.address
ORDER BY 1 ASC

-- 16. The top ten film titles by number of rentals
-- (#1 should be “BUCKET BROTHERHOOD” with 34 rentals and #10 should have 31 rentals)
SELECT film.title, COUNT(rental.rental_id) AS 'numberRentals'
FROM store
JOIN inventory ON inventory.store_id = store.store_id
JOIN film ON film.film_id = inventory.film_id
JOIN rental ON rental.inventory_id = inventory.inventory_id
GROUP BY film.title
ORDER BY 2 DESC

-- 17. The top five film categories by number of rentals 
-- (#1 should be “Sports” with 1179 rentals and #5 should be “Family” with 1096 rentals)
SELECT category.name, COUNT(rental.rental_id)
FROM film
JOIN film_category ON film_category.film_id = film.film_id
JOIN category ON category.category_id = film_category.category_id
JOIN inventory ON inventory.film_id = film.film_id
JOIN rental ON rental.inventory_id = inventory.inventory_id
GROUP BY category.name
ORDER BY COUNT(rental.rental_id) DESC

-- 18. The top five Action film titles by number of rentals 
-- (#1 should have 30 rentals and #5 should have 28 rentals)
SELECT film.title, COUNT(rental.rental_id) AS 'numberRentals'
FROM film
JOIN film_category ON film_category.film_id = film.film_id
JOIN category ON category.category_id = film_category.category_id
JOIN inventory ON inventory.film_id = film.film_id
JOIN rental ON rental.inventory_id = inventory.inventory_id
WHERE category.name = 'Action'
GROUP BY film.title
ORDER BY COUNT(rental.rental_id) DESC

-- 19. The top 10 actors ranked by number of rentals of films starring that actor 
-- (#1 should be “GINA DEGENERES” with 753 rentals and #10 should be “SEAN GUINESS” with 599 rentals)
SELECT actor.first_name, actor.last_name, COUNT(rental.rental_id) AS 'numberRentals'
FROM film
JOIN film_category ON film_category.film_id = film.film_id
JOIN category ON category.category_id = film_category.category_id
JOIN inventory ON inventory.film_id = film.film_id
JOIN rental ON rental.inventory_id = inventory.inventory_id
JOIN film_actor ON film_actor.film_id = film.film_id
JOIN actor ON actor.actor_id = film_actor.actor_id
GROUP BY film_actor.actor_id, actor.last_name, actor.first_name
ORDER BY COUNT(rental.rental_id) DESC

-- 20. The top 5 “Comedy” actors ranked by number of rentals of films in the “Comedy” category starring that actor 
-- (#1 should have 87 rentals and #5 should have 72 rentals)
SELECT actor.first_name, actor.last_name, COUNT(rental.rental_id) AS 'numberRentals'
FROM film
JOIN film_category ON film_category.film_id = film.film_id
JOIN category ON category.category_id = film_category.category_id
JOIN inventory ON inventory.film_id = film.film_id
JOIN rental ON rental.inventory_id = inventory.inventory_id
JOIN film_actor ON film_actor.film_id = film.film_id
JOIN actor ON actor.actor_id = film_actor.actor_id
WHERE category.name = 'Comedy'
GROUP BY film_actor.actor_id, actor.last_name, actor.first_name
ORDER BY COUNT(rental.rental_id) DESC