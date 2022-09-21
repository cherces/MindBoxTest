CREATE TABLE #products
(
	Id INT PRIMARY KEY,
	ProductId INT,
	ProductName nvarchar(50) NOT NULL,
	CategoryIds nvarchar
)

CREATE TABLE #categories
(
	Id INT PRIMARY KEY,
	CategoryName nvarchar(50) UNIQUE NOT NULL
)

INSERT INTO #products VALUES 
(1, 1, 'Яблоко', 1),
(2, 2, 'Банан', 1),
(3, 3, 'Ананас', 1),
(4, 4, 'Огурец', 2),
(5, 5, 'Помидоры', 1),
(6, 5, 'Помидоры', 2),
(7, 6, 'Картошка', 2),
(8, 7, 'Свекла', 2),
(9, 8, 'Горох', 2),
(10, 9, 'Молоко', 3),
(11, 10, 'Сыр', 3),
(12, 11, 'Творог', 3),
(13, 11, 'Творог', 5),
(14, 12, 'Филе куриная', 4),
(15, 13, 'Грудка куриная', 4),
(16, 14, 'Фарш говяжий', NULL),
(17, 15, 'Шоколад', 5)

INSERT INTO #categories VALUES 
(1, 'Фрукты'),
(2, 'Овощи'),
(3, 'Молочнные продукты'),
(4, 'Мясо'),
(5, 'Сладости')

SELECT p.ProductName, ISNULL(c.CategoryName, 'Без категории') FROM #products AS p
LEFT JOIN #categories AS c
ON p.CategoryIds = c.Id

DROP TABLE #products, #categories