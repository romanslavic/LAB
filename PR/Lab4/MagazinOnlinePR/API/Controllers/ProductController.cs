using API.Models;
using API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly ProductRepository _productRepository;

    public ProductController()
    {
        _productRepository = ProductRepository.GetInstance();
    }
    
    [HttpGet("category/{categoryId}")]
    public IActionResult GetProductsByCategory(int categoryId)
    {
        var products = _productRepository.GetProductsByCategory(categoryId);
        if (!products.Any())
        {
            return NotFound("There are no products in the category");
        }
        
        return Ok(products);
    }
    
    [HttpPost]
    public ActionResult AddProduct(Product product)
    {
        _productRepository.AddProduct(product);
        return CreatedAtAction(nameof(GetProductsByCategory), new { categoryId = product.CategoryId }, product);
    }
}