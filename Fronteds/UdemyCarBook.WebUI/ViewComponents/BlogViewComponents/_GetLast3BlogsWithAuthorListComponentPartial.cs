﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.BlogDtos;
using UdemyCarBook.Dto.TestimonialDtos;

namespace UdemyCarBook.WebUI.ViewComponents.BlogViewComponents
{
    public class _GetLast3BlogsWithAuthorListComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _GetLast3BlogsWithAuthorListComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7219/api/Blogs/GetLast3BlogsWithAuthorsList");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var testimonials = JsonConvert.DeserializeObject<List<ResultLast3BlogsWithAuthors>>(jsonData);
                return View(testimonials);
            }
            return View();
        }
    }
}
