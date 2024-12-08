-- 1. Question
SELECT DISTINCT replacement_cost FROM film;

-- 2. Question
SELECT COUNT(DISTINCT replacement_cost) FROM film;

-- 3. Question
SELECT COUNT(*) FROM film WHERE 
	title LIKE 'T%'
	AND
	rating = 'G';

-- 4. Question
SELECT COUNT(*) FROM country WHERE LENGTH(country) = 5;

-- 5. Question
SELECT * FROM city WHERE city ILIKE '%r';