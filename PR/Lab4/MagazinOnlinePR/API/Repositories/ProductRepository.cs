using API.Models;

namespace API.Repositories;

public class ProductRepository
{
    private static ProductRepository? _instance = new ProductRepository();
    
    private static List<Product> _products = new List<Product>
    {
        new Product { Id = 1, Name = "Laptop", CategoryId = 1 },
        new Product { Id = 2, Name = "Smartphone", CategoryId = 1 },
        new Product { Id = 3, Name = "T-Shirt", CategoryId = 2 },
        new Product { Id = 4, Name = "Harry Potter Book", CategoryId = 3 }
    };

    public static ProductRepository GetInstance()
    {
        return _instance;
    }

    public List<Product> GetProductsByCategory(int categoryId)
    {
        return _products.Where(p => p.CategoryId == categoryId).ToList();
    }

    public void AddProduct(Product product)
    {
        product.Id = _products.Max(p => p.Id) + 1;
        _products.Add(product);
    }
}