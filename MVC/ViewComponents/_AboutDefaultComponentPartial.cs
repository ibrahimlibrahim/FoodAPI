using Microsoft.AspNetCore.Mvc;

namespace MVC.ViewCompanents;

public class _AboutDefaultComponentPartial : ViewComponent
{   
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
