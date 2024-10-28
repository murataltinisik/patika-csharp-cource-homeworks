-- 1. Question
SELECT rating FROM film GROUP BY rating;

-- 2. Question
SELECT replacement_cost, COUNT(*) FROM film 
GROUP BY replacement_cost
HAVING COUNT(*) > 50;

-- 3. Question
SELECT store_id, COUNT(store_id) FROM customer GROUP BY store_id;

-- 4. Question
SELECT country_id, COUNT(*) FROM city 
	GROUP BY country_id 
	ORDER BY COUNT(*) DESC
	LIMIT 1;




