using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Context;
using WebApi.Entities;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ChefsController(AppDbContext appDbContext) : ControllerBase
{
    [HttpGet]
    public IActionResult GetAllChef()
    {
        var chefs = appDbContext.Chefs.ToList();
        return Ok(chefs);
    }



    [HttpPost]
    public IActionResult CreateChefs(Chef chef)
    {
        appDbContext.Chefs.Add(chef);
        appDbContext.SaveChanges();
        return Ok("Chef added");
    }

    [HttpDelete]
    public IActionResult DeleteChefs(int id)
    {
        var value = appDbContext.Chefs.Find(id);
        appDbContext.Chefs.Remove(value);
        appDbContext.SaveChanges();
        return Ok("Category deleted");
    }

    [HttpGet("GetChef")]
    public IActionResult GetChefs(int id)
    {
        var value = appDbContext.Chefs.Find(id);
        return Ok(value);
    }

    [HttpPut]
    public IActionResult UpdateChefs(Chef chef)
    {
        appDbContext.Chefs.Update(chef);
        appDbContext.SaveChanges();
        return Ok("Chef updated");
    }
}
