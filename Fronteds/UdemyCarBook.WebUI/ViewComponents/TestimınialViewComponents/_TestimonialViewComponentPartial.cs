using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace UdemyCarBook.WebUI.ViewComponents.TestimınialViewComponents
{
    public class _TestimonialViewComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _TestimonialViewComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> Invoke()
        {
            var client = _httpClientFactory.CreateClient();
            var response = client.GetAsync("https://localhost:7219/api//testimonials");
            if (response.IsCompletedSuccessfully)
            {
                var jsonData = await response.Result.Content.ReadAsStringAsync();
                var testimonials = JsonConvert.DeserializeObject<List<Testimonial>>(jsonData);
                return View(testimonials);
            }
            return View();
        }
    }
}
