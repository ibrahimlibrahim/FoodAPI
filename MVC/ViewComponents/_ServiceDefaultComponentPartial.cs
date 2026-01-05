using Microsoft.AspNetCore.Mvc;
using MVC.DTOs.ServiceDto;
using Newtonsoft.Json;

namespace MVC.ViewCompanents;

public class _ServiceDefaultComponentPartial(IHttpClientFactory httpClientFactory) : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    { 
        var client = httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("http://localhost:5027/api/Services");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsonData);
            return View(values);
        }
        return View(); 
    }
}
