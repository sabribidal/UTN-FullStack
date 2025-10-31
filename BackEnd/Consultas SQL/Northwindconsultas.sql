SELECT CompanyName
FROM Customers
ORDER BY CompanyName ASC;

SELECT *
FROM Customers
WHERE CompanyName LIKE 'S%';

SELECT *
FROM Products
WHERE UnitPrice > 50;

SELECT COUNT(*) AS CantidadDiscontinued
FROM Products
WHERE Discontinued = 1;

SELECT TOP 1 *
FROM Products
ORDER BY UnitPrice DESC;

SELECT ProductName, UnitPrice
FROM Products
WHERE UnitPrice = (
    SELECT MAX(UnitPrice)
    FROM Products
);

SELECT p.ProductName, c.CategoryName
FROM Products p
INNER JOIN Categories c
    ON p.CategoryID = c.CategoryID;

SELECT cu.CustomerID, cu.CompanyName, o.OrderID, o.OrderDate
FROM Customers cu
LEFT JOIN Orders o
    ON cu.CustomerID = o.CustomerID;

SELECT CustomerID, COUNT(*) AS TotalOrders
FROM Orders
GROUP BY CustomerID;

SELECT s.SupplierID, s.CompanyName, COUNT(*) AS TotalProductos
FROM Suppliers s
INNER JOIN Products p
    ON s.SupplierID = p.SupplierID
GROUP BY s.SupplierID, s.CompanyName
HAVING COUNT(*) > 3;


CREATE PROCEDURE GetCustomersByCountry
    @Country NVARCHAR(50)
AS
BEGIN
    SELECT *
    FROM Customers
    WHERE Country = @Country;
END;
GO


EXEC GetCustomersByCountry @Country = 'Argentina';