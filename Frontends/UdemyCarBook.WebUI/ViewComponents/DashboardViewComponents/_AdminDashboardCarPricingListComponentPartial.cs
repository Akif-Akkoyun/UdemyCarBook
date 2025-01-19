using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.CarPricingDtos;

namespace UdemyCarBook.WebUI.ViewComponents.DashboardViewComponents
{
    public class _AdminDashboardCarPricingListComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AdminDashboardCarPricingListComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.v1 = "Paketler";
            ViewBag.v2 = "Araç Fiyat Paketleri";
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7219/api/CarPricings/GetCarPricingWithTimePeriodList");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var testimonials = JsonConvert.DeserializeObject<List<ResultCarPricingListWithModelDto>>(jsonData);
                return View(testimonials);
            }
            return View();
        }
    }
}
