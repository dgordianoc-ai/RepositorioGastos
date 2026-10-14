USE GastosDB;

DELETE FROM dbo.Gastos
WHERE Descripcion IN ('Café', 'Tacos ''al pastor''');

SELECT Id, Descripcion, Monto, Categoria
FROM dbo.Gastos
ORDER BY Id;

SELECT SUM(Monto) AS TotalGastado
FROM dbo.Gastos;