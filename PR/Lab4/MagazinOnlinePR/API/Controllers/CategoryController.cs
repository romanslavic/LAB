using API.DTOs;
using API.Models;
using API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController : ControllerBase
{
    private readonly CategoryRepository _repository;

    public CategoryController()
    {
        _repository = CategoryRepository.GetInstance();
    }

    [HttpGet]
    public IActionResult GetCategories()
    {
        var categories = _repository.GetAllCategories();
        var dto = new List<CategoryDTO>();
        foreach (var category in categories)
        {
            dto.Add(new CategoryDTO{CategoryName = category.Name});
        }
        return Ok(dto);
    }

    [HttpGet("{id}")]
    public IActionResult GetCategoryById(int id)
    {
        var category = _repository.GetCategoryById(id);
        if (category == null)
        {
            return NotFound();
        }

        return Ok(category);
    }

    [HttpPost]
    public IActionResult CreateCategory([FromBody] Category? category)
    {
        if (category == null)
        {
            return BadRequest();
        }

        _repository.AddCategory(category);
        return CreatedAtAction(nameof(GetCategoryById), new { id = category.Id }, category);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateCategory(int id, [FromBody] Category? updatedCategory)
    {
        if (updatedCategory == null)
        {
            return BadRequest();
        }

        var existingCategory = _repository.GetCategoryById(id);
        if (existingCategory == null)
        {
            return NotFound();
        }

        _repository.UpdateCategory(id, updatedCategory.Name);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteCategory(int id)
    {
        var category = _repository.GetCategoryById(id);
        if (category == null)
        {
            return NotFound();
        }

        _repository.DeleteCategory(id);
        return NoContent();
    }
}