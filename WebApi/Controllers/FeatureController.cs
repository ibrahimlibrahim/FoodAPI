using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Context;
using WebApi.DTOs.FeatureDto;
using WebApi.Entities;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FeatureController(AppDbContext appDbContext, IMapper mapper) : ControllerBase
{
    [HttpGet]
    public IActionResult FeatureList()
    {
        var values = appDbContext.Features.ToList();
        return Ok(mapper.Map<List<ResultFeatureDto>>(values));
    }

    [HttpPost]
    public IActionResult CreateFeature(CreateFeatureDto createFeatureDto)
    {
        var value = mapper.Map<Feature>(createFeatureDto);
        appDbContext.Features.Add(value);
        appDbContext.SaveChanges();
        return Ok("Feature added");
    }

    [HttpDelete]
    public IActionResult DeleteFeature(int id)
    {
        var value = appDbContext.Features.Find(id);
        appDbContext.Features.Remove(value);
        return Ok("Feature deleted");
    }

    [HttpGet("GetFeature")]
    public IActionResult GetFeature(int id) {
        var value = appDbContext.Features.Find(id);
        return Ok(mapper.Map<GetByIdFeatureDto>(value));
    }

    [HttpPut]
    public IActionResult UpdateFeature(UpdateFeatureDto updateFeatureDto)
    {
        var value = mapper.Map<Feature>(updateFeatureDto);
        appDbContext.Features.Update(value);
        return Ok("Feature updated");
    }
    
}
