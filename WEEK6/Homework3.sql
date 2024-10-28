-- 1. Question
SELECT * FROM country WHERE country LIKE 'A%a';

-- 2. Question
SELECT country FROM country WHERE 
	LENGTH(country) >= 6 
	AND
	country LIKE '%n';

-- 3. Question
SELECT title FROM film WHERE 
	LENGTH(title) >= 4
	AND
	title ILIKE '%T%';

-- 4. Question
SELECT * FROM film WHERE 
	title LIKE 'C%'
	AND
	length > 90
	AND
	rental_rate = 2.99;






