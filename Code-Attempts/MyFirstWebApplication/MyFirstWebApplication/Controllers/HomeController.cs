using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
