-- 1. Question
SELECT country, city FROM city INNER JOIN country 
ON city.country_id = country.country_id;

-- 2. Question
SELECT payment_id, first_name, last_name FROM customer
INNER JOIN payment
ON customer.customer_id = payment.customer_id;

-- 3. Question
SELECT rental_id, first_name, last_name FROM customer
INNER JOIN rental
ON customer.customer_id = rental.customer_id;