using API.Models;

namespace API.Repositories;

public class CategoryRepository
{
    private static CategoryRepository? _instance = new CategoryRepository();
    
    private static List<Category> _categories = new List<Category>
    {
        new Category { Id = 1, Name = "Electronics", Description = "Electronic devices"},
        new Category { Id = 2, Name = "Clothing", Description = "Clothes for everyone" },
        new Category { Id = 3, Name = "Books", Description = "Books for everyone" },
    };

    public static CategoryRepository GetInstance()
    {
        return _instance;
    }
    
    public List<Category> GetAllCategories() => _categories;

    public Category? GetCategoryById(int id) => _categories.FirstOrDefault(c => c.Id == id);

    public void AddCategory(Category category)
    {
        category.Id = _categories.Max(c => c.Id) + 1;
        _categories.Add(category);
    }

    public void UpdateCategory(int id, string newName)
    {
        var category = _categories.FirstOrDefault(c => c.Id == id);
        if (category != null)
        {
            category.Name = newName;
        }
    }

    public void DeleteCategory(int id)
    {
        var category = _categories.FirstOrDefault(c => c.Id == id);
        if (category != null)
        {
            _categories.Remove(category);
        }
    }
}