using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.StatisticsDtos;

namespace UdemyCarBook.WebUI.ViewComponents.DashboardComponents
{
    public class _AdminDashboardStatisticsComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AdminDashboardStatisticsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            Random random = new Random();
            var client = _httpClientFactory.CreateClient();
            #region CarCount
            var responseMessage = await client.GetAsync("https://localhost:7219/api/Statistics/GetCarCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                int carCountRadom = random.Next(1, 101);
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.carCount = values.carCount;
                ViewBag.carCountRadom = carCountRadom;
            }
            #endregion
            #region LocationCount
            var responseMessage2 = await client.GetAsync("https://localhost:7219/api/Statistics/GetLocationCount");
            if (responseMessage2.IsSuccessStatusCode)
            {
                int locationCountRadom = random.Next(1, 101);
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                var values2 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData2);
                ViewBag.locationCount = values2.locationCount;
                ViewBag.locationCountRadom = locationCountRadom;
            }
            #endregion            
            #region BrandCount
            var responseMessage6 = await client.GetAsync("https://localhost:7219/api/Statistics/GetBrandCount");
            if (responseMessage6.IsSuccessStatusCode)
            {
                int brandCountRadom = random.Next(1, 101);
                var jsonData = await responseMessage6.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.brandCount = values.brandCount;
                ViewBag.brandCountRadom = brandCountRadom;
            }
            #endregion
            #region avgPriceDaily
            var responseMessage7 = await client.GetAsync("https://localhost:7219/api/Statistics/GetAvgRentPriceForDayliy");
            if (responseMessage7.IsSuccessStatusCode)
            {
                int avgPriceDailyRadom = random.Next(1, 101);
                var jsonData = await responseMessage7.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.avgPriceDaily = Math.Round(values.avgPriceDaily, 2);
                ViewBag.avgPriceDailyRadom = avgPriceDailyRadom;
            }
            #endregion
            return View();
        }
    }
}
