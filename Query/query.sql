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
(1, 1, '������', 1),
(2, 2, '�����', 1),
(3, 3, '������', 1),
(4, 4, '������', 2),
(5, 5, '��������', 1),
(6, 5, '��������', 2),
(7, 6, '��������', 2),
(8, 7, '������', 2),
(9, 8, '�����', 2),
(10, 9, '������', 3),
(11, 10, '���', 3),
(12, 11, '������', 3),
(13, 11, '������', 5),
(14, 12, '���� �������', 4),
(15, 13, '������ �������', 4),
(16, 14, '���� �������', NULL),
(17, 15, '�������', 5)

INSERT INTO #categories VALUES 
(1, '������'),
(2, '�����'),
(3, '��������� ��������'),
(4, '����'),
(5, '��������')

SELECT p.ProductName, ISNULL(c.CategoryName, '��� ���������') FROM #products AS p
LEFT JOIN #categories AS c
ON p.CategoryIds = c.Id

DROP TABLE #products, #categories