using API.Models;
using Client.Utils;

namespace Client.Services;

public class ProductService
{
    private readonly ApiClient _client;

        public ProductService(ApiClient client)
        {
            _client = client;
        }

        public async Task GetProductsByCategoryAsync()
        {
            Console.WriteLine("Enter Category ID:");
            int categoryId = int.Parse(Console.ReadLine());

            try
            {
                var products = await _client.GetAsync<List<Product>>($"/product/category/{categoryId}");

                Console.WriteLine($"\nProducts in Category {categoryId}:");
                if (products.Count == 0)
                {
                    Console.WriteLine("No products found.");
                }
                else
                {
                    foreach (var product in products)
                    {
                        Console.WriteLine($"- {product.Name} (ID: {product.Id})");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public async Task AddProductAsync()
        {
            Console.WriteLine("Enter Product Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Product Price:");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter Category ID for the product:");
            int categoryId = int.Parse(Console.ReadLine());

            var newProduct = new Product
            {
                Name = name,
                CategoryId = categoryId
            };

            try
            {
                var response = await _client.PostAsync("/product", newProduct);
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Product added successfully!");
                }
                else
                {
                    Console.WriteLine("Failed to add product.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
}