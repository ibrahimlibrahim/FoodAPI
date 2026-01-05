using Microsoft.AspNetCore.Mvc;

namespace MVC.ViewCompanents;

public class _NavbarDefaultComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
