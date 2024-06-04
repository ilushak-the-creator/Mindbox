Задание 1.
Состоит из решения с двумя проектами, одно с сервисами и сущностями, второе с тестами

Задание 2.
SELECT
    p.ProductName,
    c.CategoryName
FROM 
    Products p
LEFT JOIN 
    ProductCategories pc ON p.ProductID = pc.ProductID
LEFT JOIN 
    Categories c ON pc.CategoryID = c.CategoryID
ORDER BY 
    p.ProductName, c.CategoryName;
