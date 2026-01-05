using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Context;
using WebApi.Entities;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController(AppDbContext appDbContext) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllService()
        {
            var services = appDbContext.Services.ToList();
            return Ok(services);
        }



        [HttpPost]
        public IActionResult CreateService(Service Service)
        {
            appDbContext.Services.Add(Service);
            appDbContext.SaveChanges();
            return Ok("Service added");
        }

        [HttpDelete]
        public IActionResult DeleteService(int id)
        {
            var value = appDbContext.Services.Find(id);
            appDbContext.Services.Remove(value);
            appDbContext.SaveChanges();
            return Ok("Service deleted");
        }

        [HttpGet("GetService")]
        public IActionResult GetService(int id)
        {
            var value = appDbContext.Services.Find(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateService(Service Service)
        {
            appDbContext.Services.Update(Service);
            appDbContext.SaveChanges();
            return Ok("Service updated");
        }
    }
}
