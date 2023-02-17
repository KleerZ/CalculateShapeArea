SELECT p.Name AS ProductName, c.Name AS CategoryName
FROM Products p
         LEFT JOIN CategoryProduct cp on p.Id = cp.ProductsId
         LEFT JOIN Categories c on c.Id = cp.CategoriesId