using Microsoft.AspNetCore.Mvc;

namespace MVC.ViewCompanents;

public class _FeatureDefaultComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
