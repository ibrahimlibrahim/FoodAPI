using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers;

public class DefaultController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
