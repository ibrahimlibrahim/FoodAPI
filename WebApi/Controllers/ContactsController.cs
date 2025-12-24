using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Context;
using WebApi.DTOs;
using WebApi.Entities;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ContactsController(AppDbContext appDbContext) : ControllerBase
{
    [HttpGet]
    public IActionResult ContactList()
    {
        var contacts = appDbContext.Contacts.ToList();
        return Ok(contacts);
    }

    [HttpPost]
    public IActionResult CreateContact(CreateContactDto createContactDto)
    {
        Contact contact = new Contact();
        contact.Email = createContactDto.Email;
        contact.Address = createContactDto.Address;
        contact.Phone = createContactDto.Phone;
        contact.MapLocation = createContactDto.MapLocation;
        contact.OpenHours = createContactDto.OpenHours;
        appDbContext.Contacts.Add(contact);
        appDbContext.SaveChanges();
        return Ok("Contact added");
    }

    [HttpDelete]
    public IActionResult DeleteContact(int id)
    {
        var value = appDbContext.Contacts.Find(id);
        appDbContext.Contacts.Remove(value);
        appDbContext.SaveChanges();
        return Ok("Contact deleted");
    }

    [HttpGet("GetContact")]
    public IActionResult GetContact(int id)
    {
        var value = appDbContext.Contacts.Find(id);
        return Ok(value);
    }

    [HttpPut]
    public IActionResult UpdateContact(UpdateContactDto updateContactDto)
    {
        Contact contact = new();
        contact.Email = updateContactDto.Email;
        contact.Address = updateContactDto.Address;
        contact.Phone = updateContactDto.Phone;
        contact.MapLocation= updateContactDto.MapLocation;
        contact.OpenHours= updateContactDto.OpenHours;
        appDbContext.Contacts.Update(contact);
        appDbContext.SaveChanges();
        return Ok("Contact updated");
    }
}
