using Microsoft.AspNetCore.Mvc;

namespace MVC.ViewCompanents;

public class _HeadDefaultCompanentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
