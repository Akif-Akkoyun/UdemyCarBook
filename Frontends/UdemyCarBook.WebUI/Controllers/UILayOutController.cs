using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.WebUI.Controllers
{
    public class UILayOutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
