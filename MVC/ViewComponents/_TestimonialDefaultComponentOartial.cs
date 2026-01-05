using Microsoft.AspNetCore.Mvc;
using MVC.DTOs.CategoryDto;
using MVC.DTOs.TestimonialDto;
using Newtonsoft.Json;

namespace MVC.ViewComponents;

public class _TestimonialDefaultComponentPartial(IHttpClientFactory httpClientFactory) : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("http://localhost:5027/api/Testimonials");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultTestimonialDto>>(jsonData);
            return View(values);
        }
        return View();
    }
}
