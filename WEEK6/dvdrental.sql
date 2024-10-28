-- ALL COLUMNS OF FILM
SELECT * FROM film;

-- ALL COLUMNS OF FILM -> length
SELECT * FROM film WHERE length > 60 AND length < 75;

-- ALL COLUMNS OF FILM -> rental_rate, replacement_cost
SELECT * FROM film WHERE 	
	rental_rate = 0.99 
	AND 
	(replacement_cost = 12.99 OR replacement_cost = 28.99);

-- FIRST NAME, LAST NAME COLUMNS OF CUSTOMER
SELECT first_name, last_name FROM customer WHERE first_name =  'Mary';

-- ALL COLUMNS OF FILM -> length, rental_rate
SELECT length, rental_rate FROM film WHERE 
	length <= 50
	AND
	rental_rate != 2.99 
	AND 
	rental_rate != 4.99; 



