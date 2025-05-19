using API.DTOs;
using API.Models;
using Client.Services;
using Client.Utils;

class Program
{
    static async Task Main(string[] args)
    {
        var client = new ApiClient("http://localhost:5062");
        var categoryService = new CategoryService(client);
        var productService = new ProductService(client);

        while (true)
        {
            Console.Clear();
            ShowMenu();
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    await categoryService.GetCategoriesAsync();
                    break;
                case "2":
                    await categoryService.GetCategoryDetailsAsync();
                    break;
                case "3":
                    await productService.GetProductsByCategoryAsync();
                    break;
                case "4":
                    await categoryService.AddCategoryAsync();
                    break;
                case "5":
                    await productService.AddProductAsync();
                    break;
                case "6":
                    await categoryService.EditCategoryAsync();
                    break;
                case "7":
                    await categoryService.DeleteCategoryAsync();
                    break;
                case "8":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }

    static void ShowMenu()
    {
        Console.WriteLine("Select an option:");
        Console.WriteLine("1. Get Categories");
        Console.WriteLine("2. Get Category Details");
        Console.WriteLine("3. Get Products by Category");
        Console.WriteLine("4. Add Category");
        Console.WriteLine("5. Add Product");
        Console.WriteLine("6. Edit Category");
        Console.WriteLine("7. Delete Category");
        Console.WriteLine("8. Exit");
    }
}
