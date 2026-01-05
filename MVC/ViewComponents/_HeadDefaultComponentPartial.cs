using Microsoft.AspNetCore.Mvc;

namespace MVC.ViewCompanents;

public class _HeadDefaultComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
