using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Context;
using WebApi.DTOs.FeatureDto;
using WebApi.DTOs.MessageDto;
using WebApi.Entities;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MessageController(AppDbContext appDbContext, IMapper mapper) : ControllerBase
{
    [HttpGet]
    public IActionResult MessageList()
    {
        var values = appDbContext.Features.ToList();
        return Ok(mapper.Map<List<ResultMessageDto>>(values));
    }

    [HttpPost]
    public IActionResult MessageFeature(CreateMessageDto createMessageDto)
    {
        var value = mapper.Map<Message>(createMessageDto);
        appDbContext.Messages.Add(value);
        appDbContext.SaveChanges();
        return Ok("Message added");
    }

    [HttpDelete]
    public IActionResult DeleteMessage(int id)
    {
        var value = appDbContext.Messages.Find(id);
        appDbContext.Messages.Remove(value);
        return Ok("Message deleted");
    }

    [HttpGet("GetFeature")]
    public IActionResult GetMessage(int id)
    {
        var value = appDbContext.Messages.Find(id);
        return Ok(mapper.Map<GetByIdMessageDto>(value));
    }

    [HttpPut]
    public IActionResult UpdateMessage(UpdateMessageDto updateMessageDto)
    {
        var value = mapper.Map<Message>(updateMessageDto);
        appDbContext.Messages.Update(value);
        return Ok("Message updated");
    }
}
