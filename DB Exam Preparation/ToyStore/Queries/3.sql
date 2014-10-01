Use [ToyStore]
Go

SELECT t.Name, t.Price, t.Color
FROM Toys t
INNER JOIN ToysCategories tk
	ON t.Id = tk.ToyId
INNER JOIN Categories c
	ON c.Id = tk.CategoryId
WHERE c.Name = 'BPqFAh'