using Microsoft.AspNetCore.Mvc;

namespace MVC.ViewCompanents;

public class _NavbarDefaultCompanentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
