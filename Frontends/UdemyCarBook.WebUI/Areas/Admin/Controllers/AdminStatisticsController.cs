using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.AuthorDtos;
using UdemyCarBook.Dto.StatisticsDtos;

namespace UdemyCarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminStatistics")]
    public class AdminStatisticsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminStatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [Route("Index")]
        public async Task<IActionResult> Index()
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
            #region AuthorCount
            var responseMessage3 = await client.GetAsync("https://localhost:7219/api/Statistics/GetAuthorCount");
            if (responseMessage3.IsSuccessStatusCode)
            {
                int authorCountRadom = random.Next(1, 101);
                var jsonData = await responseMessage3.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.authorCount = values.authorCount;
                ViewBag.authorCountRadom = authorCountRadom;
            }
            #endregion
            #region BlogCount
            var responseMessage4 = await client.GetAsync("https://localhost:7219/api/Statistics/GetBLogCount");
            if (responseMessage4.IsSuccessStatusCode)
            {
                int blogCountRadom = random.Next(1, 101);
                var jsonData = await responseMessage4.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.blogCount = values.blogCount;
                ViewBag.blogCountRadom = blogCountRadom;
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
            #region avgPriceForWeekly
            var responseMessage8 = await client.GetAsync("https://localhost:7219/api/Statistics/GetAvgRentPriceForWeekly");
            if (responseMessage8.IsSuccessStatusCode)
            {
                int avgPriceForWeeklyRadom = random.Next(1, 101);
                var jsonData = await responseMessage8.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.avgPriceForWeekly = Math.Round(values.avgPriceForWeekly, 2);
                ViewBag.avgPriceForWeeklyRadom = avgPriceForWeeklyRadom;
            }
            #endregion
            #region avgPriceForMontly
            var responseMessage9 = await client.GetAsync("https://localhost:7219/api/Statistics/GetAvgRentPriceForMonthly");
            if (responseMessage9.IsSuccessStatusCode)
            {
                int avgPriceForMontlyRadom = random.Next(1, 101);
                var jsonData = await responseMessage9.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.avgPriceForMontly = values.avgPriceForMontly.ToString("0.00");
                ViewBag.avgPriceForMontlyRadom = avgPriceForMontlyRadom;
            }
            #endregion
            #region carCountByTransmissionIsAuto
            var responseMessage10 = await client.GetAsync("https://localhost:7219/api/Statistics/GetCarCountByTransmissionIsAuto");
            if (responseMessage10.IsSuccessStatusCode)
            {
                int carCountByTransmissionIsAutoRadom = random.Next(1, 101);
                var jsonData = await responseMessage10.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.carCountByTransmissionIsAuto = values.carCountByTransmissionIsAuto;
                ViewBag.carCountByTransmissionIsAutoRadom = carCountByTransmissionIsAutoRadom;
            }
            #endregion
            #region carCountByKmSmallerThan1000
            var responseMessage11 = await client.GetAsync("https://localhost:7219/api/Statistics/GetCarCountByKmSmallerThan1000");
            if (responseMessage11.IsSuccessStatusCode)
            {
                int carCountByKmSmallerThan1000Radom = random.Next(1, 101);
                var jsonData = await responseMessage11.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.carCountByKmSmallerThan1000 = values.carCountByKmSmallerThan1000;
                ViewBag.carCountByKmSmallerThan1000Radom = carCountByKmSmallerThan1000Radom;
            }
            #endregion
            #region carCountByFuelGasOrDiesel
            var responseMessage12 = await client.GetAsync("https://localhost:7219/api/Statistics/GetCarCountByFuelGasOrDiesel");
            if (responseMessage12.IsSuccessStatusCode)
            {
                int carCountByFuelGasOrDieselRadom = random.Next(1, 101);
                var jsonData = await responseMessage12.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.carCountByFuelGasOrDiesel = values.carCountByFuelGasOrDiesel;
                ViewBag.carCountByFuelGasOrDieselRadom = carCountByFuelGasOrDieselRadom;
            }
            #endregion
            #region carCountByFuelElectric
            var responseMessage13 = await client.GetAsync("https://localhost:7219/api/Statistics/GetCarCountByFuelElectric");
            if (responseMessage13.IsSuccessStatusCode)
            {
                int carCountByFuelElectricRadom = random.Next(1, 101);
                var jsonData = await responseMessage13.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.carCountByFuelElectric = values.carCountByFuelElectric;
                ViewBag.carCountByFuelElectricRadom = carCountByFuelElectricRadom;
            }
            #endregion
            #region carBrandAndModelByRendPriceDailyMax
            var responseMessage14 = await client.GetAsync("https://localhost:7219/api/Statistics/GetCarBrandAndModelByRendPriceDailyMax");
            if (responseMessage14.IsSuccessStatusCode)
            {
                int carBrandAndModelByRendPriceDailyMaxRadom = random.Next(1, 101);
                var jsonData = await responseMessage14.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.carBrandAndModelByRendPriceDailyMax = values.carBrandAndModelByRendPriceDailyMax;
                ViewBag.carBrandAndModelByRendPriceDailyMaxRadom = carBrandAndModelByRendPriceDailyMaxRadom;
            }
            #endregion
            #region carBrandAndModelByRendPriceDailyMin
            var responseMessage15 = await client.GetAsync("https://localhost:7219/api/Statistics/GetCarBrandAndModelByRendPriceDailyMin");
            if (responseMessage15.IsSuccessStatusCode)
            {
                int carBrandAndModelByRendPriceDailyMinRadom = random.Next(1, 101);
                var jsonData = await responseMessage15.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.carBrandAndModelByRendPriceDailyMin = values.carBrandAndModelByRendPriceDailyMin;
                ViewBag.carBrandAndModelByRendPriceDailyMinRadom = carBrandAndModelByRendPriceDailyMinRadom;
            }
            #endregion
            #region brandNameByMaxCarCount
            var responseMessage16 = await client.GetAsync("https://localhost:7219/api/Statistics/GetBrandNameByMaxCarCount");
            if (responseMessage16.IsSuccessStatusCode)
            {
                int brandNameByMaxCarCountRadom = random.Next(1, 101);
                var jsonData = await responseMessage16.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.brandNameByMaxCarCount = values.brandNameByMaxCarCount;
                ViewBag.brandNameByMaxCarCountRadom = brandNameByMaxCarCountRadom;
            }
            #endregion
            #region brandNameByMaxCarCount
            var responseMessage17 = await client.GetAsync("https://localhost:7219/api/Statistics/GetBlogTitleByMaxComments");
            if (responseMessage17.IsSuccessStatusCode)
            {
                int blogTitleByMaxCommentsRadom = random.Next(1, 101);
                var jsonData = await responseMessage17.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.blogTitleByMaxComments = values.blogTitleByMaxComments;
                ViewBag.blogTitleByMaxCommentsRadom = blogTitleByMaxCommentsRadom;
            }
            #endregion
            return View();
        }
    }
}
