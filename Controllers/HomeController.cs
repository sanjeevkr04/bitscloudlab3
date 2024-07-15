using Microsoft.AspNetCore.Mvc;

namespace MyWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Hello World!!!";
            return View();
        }
    }
}
