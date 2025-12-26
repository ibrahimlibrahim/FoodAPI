using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Context;
using WebApi.DTOs.ProductDto;
using WebApi.Entities;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController(AppDbContext appDbContext,
                                IValidator<Product> validator,
                                IMapper mapper) : ControllerBase
{
    [HttpGet]
    public IActionResult ProductList()
    {
        var values = appDbContext.Products.ToList();
        return Ok(values);
    }

    [HttpPost]
    public IActionResult CreateProduct(Product product)
    {
        var validationResult = validator.Validate(product);
        if (!validationResult.IsValid)
        {
            return BadRequest(validationResult.Errors.Select(x => x.ErrorMessage));
        }
        else
        {
            appDbContext.Products.Add(product);
            appDbContext.SaveChanges();
            return Ok("Product Added");
        }
    }

    [HttpDelete]
    public IActionResult DeleteProduct(int id)
    {
        var value = appDbContext.Products.Find(id);
        appDbContext.Products.Remove(value);
        appDbContext.SaveChanges();
        return Ok("Product deleted");
    }


    [HttpGet("GetProduct")]
    public IActionResult GetProduct(int id)
    {
        var value = appDbContext.Products.Find(id);
        return Ok(value);
    }

    [HttpPut]
    public IActionResult UpdateProduct(Product product)
    {
        var validationResult = validator.Validate(product);
        if (!validationResult.IsValid)
        {
            return BadRequest(validationResult.Errors.Select(x => x.ErrorMessage));
        }
        else
        {
            appDbContext.Products.Update(product);
            appDbContext.SaveChanges();
            return Ok("Product Updated");
        }
    }

    [HttpPost("CreateProductWithCategory")]
    public IActionResult CreateProductWithCategory(CreateProductDto createProductDto)
    {
        var value = mapper.Map<Product>(createProductDto);
        appDbContext.Products.Add(value);
        appDbContext.SaveChanges();
        return Ok("Prtoduct added");
    }

    [HttpGet("ProductLisrtWithCategory")]
    public IActionResult ProductListWithCategory()
    {
        var values = appDbContext.Products.Include(x=> x.Category).ToList();
        return Ok(mapper.Map<List<ResultProductWithCategoryDto>>(values));
    }
}
