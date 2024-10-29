-- 1. Question
SELECT COUNT(*) FROM film WHERE length > (SELECT AVG(length) FROM film);

-- 2. Question
SELECT COUNT(*) FROM film WHERE 
	rental_rate = (SELECT MAX(rental_rate) FROM film);

-- 3. Question
SELECT * FROM film WHERE 
	rental_rate = (SELECT MIN(rental_rate) FROM film)
	AND
	replacement_cost = (SELECT MIN(replacement_cost) FROM film);

-- 4. Question
SELECT customer_id, COUNT(*) AS numberOfPayment FROM payment
	GROUP BY customer_id
	HAVING COUNT(*) >= ALL (SELECT COUNT(*) FROM payment GROUP BY customer_id)
	ORDER BY numberOfPayment DESC;