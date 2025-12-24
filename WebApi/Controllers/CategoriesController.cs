using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Context;
using WebApi.Entities;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController(AppDbContext appDbContext) : ControllerBase
{
    [HttpGet]
    public IActionResult GetAllCategory()
    {
        var categories = appDbContext.Categories.ToList();
        return Ok(categories);
    }



    [HttpPost]
    public IActionResult CreateCategory(Category category)
    {
        appDbContext.Categories.Add(category);
        appDbContext.SaveChanges();
        return Ok("Category added");
    }

    [HttpDelete]
    public IActionResult DeleteCategory(int id)
    {
        var value = appDbContext.Categories.Find(id);
        appDbContext.Categories.Remove(value);
        appDbContext.SaveChanges();
        return Ok("Category deleted");
    }

    [HttpGet("GetCategory")]
    public IActionResult GetCategory(int id)
    {
        var value = appDbContext.Categories.Find(id);
        return Ok(value);
    }

    [HttpPut]
    public IActionResult UpdateCategory(Category category)
    {
        appDbContext.Categories.Update(category);
        appDbContext.SaveChanges();
        return Ok("Category updated");
    }
}
