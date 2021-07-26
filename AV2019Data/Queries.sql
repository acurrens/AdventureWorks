SELECT * FROM Production.Product


select * from Production.ProductSubcategory

select * from Production.ProductCategory


SELECT P.ProductId,
		p.Name,
		p.ProductNumber,
		p.MakeFlag,
		p.ProductSubcategoryID,
		cat.Name 'Category',
		subcat.Name 'SubCategory'
FROM Production.Product P
LEFT JOIN Production.ProductSubcategory subCat ON subCat.ProductSubcategoryID = p.ProductSubcategoryID
LEFT JOIN Production.ProductCategory cat ON cat.ProductCategoryID = subCat.ProductCategoryID
