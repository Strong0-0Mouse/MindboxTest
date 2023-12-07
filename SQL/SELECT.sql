SELECT 
  p.Title as ProductName, 
  c.Title as CategoryName 
FROM Mindbox.Product as p 
  LEFT JOIN Mindbox.ProductCategory as pc ON pc.ProductId = p.Id 
  LEFT JOIN Mindbox.Category as c ON c.Id = pc.CategoryId