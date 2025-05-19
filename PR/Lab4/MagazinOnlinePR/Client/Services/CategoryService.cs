using API.DTOs;
using API.Models;
using Client.Utils;

namespace Client.Services;

public class CategoryService
{
    private readonly ApiClient _client;

        public CategoryService(ApiClient client)
        {
            _client = client;
        }

        public async Task GetCategoriesAsync()
        {
            try
            {
                var categories = await _client.GetAsync<List<CategoryDTO>>("/category");
                Console.WriteLine("\nCategories:");
                foreach (var category in categories)
                {
                    Console.WriteLine($"- {category.CategoryName}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public async Task GetCategoryDetailsAsync()
        {
            Console.WriteLine("Enter Category ID to get details:");
            int categoryId = int.Parse(Console.ReadLine());

            try
            {
                var category = await _client.GetAsync<Category>($"/category/{categoryId}");

                if (category != null)
                {
                    Console.WriteLine($"\nCategory Details:");
                    Console.WriteLine($"Category ID: {category.Id}");
                    Console.WriteLine($"Category Name: {category.Name}");
                    Console.WriteLine($"Category Description: {category.Description}");
                }
                else
                {
                    Console.WriteLine("Category not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public async Task AddCategoryAsync()
        {
            Console.WriteLine("Enter Category Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Category Description:");
            string description = Console.ReadLine();

            var newCategory = new Category
            {
                Name = name,
                Description = description
            };

            try
            {
                var response = await _client.PostAsync("/category", newCategory);
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Category added successfully!");
                }
                else
                {
                    Console.WriteLine("Failed to add category.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public async Task EditCategoryAsync()
        {
            Console.WriteLine("Enter Category ID to edit:");
            int categoryId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter new Category Name:");
            string newName = Console.ReadLine();

            Console.WriteLine("Enter new Category Description:");
            string newDescription = Console.ReadLine();

            var updatedCategory = new Category
            {
                Id = categoryId,
                Name = newName,
                Description = newDescription
            };

            try
            {
                var response = await _client.PutAsync($"/category/{categoryId}", updatedCategory);
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Category updated successfully!");
                }
                else
                {
                    Console.WriteLine("Failed to update category.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public async Task DeleteCategoryAsync()
        {
            Console.WriteLine("Enter Category ID to delete:");
            int categoryId = int.Parse(Console.ReadLine());

            try
            {
                var response = await _client.DeleteAsync($"/category/{categoryId}");
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Category deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to delete category.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
}