-- 1. Question
SELECT * FROM film WHERE title LIKE '%n' ORDER BY length DESC LIMIT 5;

-- 2. Question
SELECT * FROM film WHERE title LIKE '%n' 
	ORDER BY length ASC 
	OFFSET 5 
	LIMIT 5;

-- 3. Question
SELECT first_name, last_name FROM customer WHERE store_id = 1
	ORDER BY last_name DESC
	LIMIT 4	