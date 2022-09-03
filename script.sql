CREATE TABLE products (
	id INT PRIMARY KEY,
	name TEXT
);

CREATE TABLE categories (
	id INT PRIMARY KEY,
	name TEXT
);

CREATE TABLE product_categories (
	product_id INT FOREIGN KEY REFERENCES products(id),
	category_id INT FOREIGN KEY REFERENCES categories(id),
	PRIMARY KEY (product_id, category_id)
);

INSERT INTO products
VALUES
	(1, 'MacBook'),
	(2, 'Samsung Galaxy'),
	(3, 'PS5');

INSERT INTO categories
VALUES
	(1, 'Laptop'),
	(2, 'Apple'),
	(3, 'Console');

INSERT INTO product_categories
VALUES
(1, 1),
(1, 2),
(3, 3);

SELECT p.name as "Имя продукта", c.name as "Имя категории" FROM products p
LEFT JOIN product_categories pc ON p.id = pc.product_id
LEFT JOIN categories c ON pc.category_id = c.id;
