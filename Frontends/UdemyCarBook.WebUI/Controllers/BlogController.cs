using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.BlogDtos;
using UdemyCarBook.Dto.CarPricingDtos;

namespace UdemyCarBook.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BlogController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.v1 = "Bloglarımız";
            ViewBag.v2 = "Yazarlarımızın Blogları";
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7219/api/Blogs/GetAllBlogsWithAuthorList");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var testimonials = JsonConvert.DeserializeObject<List<ResultAllBlogsWithAuthorDto>>(jsonData);
                return View(testimonials);
            }
            return View();
        }
        public async Task<IActionResult> BlogDetail(int id)
        {
            var client = _httpClientFactory.CreateClient();
            ViewBag.v1 = "Bloglar";
            ViewBag.v2 = "Blog Detayı Ve Yorumlar";
            ViewBag.blogid = id;

            var response = await client.GetAsync($"https://localhost:7219/api/Comments/CommentCountByBlog?id="+id);

            var jsonData = await response.Content.ReadAsStringAsync();
            ViewBag.CommentCount = jsonData;

            return View();
        }
    }
}
