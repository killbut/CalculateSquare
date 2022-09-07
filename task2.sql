CREATE TABLE Products(
                         id INT NOT NULL PRIMARY KEY,
                         name VARCHAR(64) NOT NULL
);
CREATE TABLE Category(
                         id INT NOT NULL PRIMARY KEY,
                         name VARCHAR(64) NOT NULL
);

CREATE TABLE СategoryProducts(
                                 products_id  INT NOT NULL,
                                 category_id INT NOT NULL
);

INSERT INTO Products
VALUES (1, 'Говядина'),
       (2, 'Молоко'),
       (3, 'Хлеб'),
       (4,'Сыр');

INSERT INTO Category
VALUES (1, 'Мясо'),
       (2, 'Молочные продукты'),
       (3, 'Хлебобулочные изделия');

INSERT INTO СategoryProducts
VALUES (1, 1),
       (2, 2),
       (3, 3),
       (4,2);