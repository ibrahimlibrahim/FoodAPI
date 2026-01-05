using Microsoft.AspNetCore.Mvc;
using MVC.DTOs.CategoryDto;
using Newtonsoft.Json;

namespace MVC.ViewComponents.DefaultMenuViewComponents;

public class _DefaultMenuCategoryComponentPartial(IHttpClientFactory httpClientFactory) : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("http://localhost:5027/api/Categories");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);
            return View(values);
        }
        return View();
    }
}
