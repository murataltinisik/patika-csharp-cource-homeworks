-- 1. Question
SELECT country, city FROM city 
LEFT JOIN country
ON city.country_id = country.country_id;

-- 2. Question
SELECT payment_id, first_name, last_name FROM customer
RIGHT JOIN payment
ON customer.customer_id = payment.customer_id;

-- 3. Question
SELECT rental_id, first_name, last_name FROM customer
FULL JOIN rental
ON customer.customer_id = rental.customer_id;