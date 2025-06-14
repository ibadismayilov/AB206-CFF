using Microsoft.AspNetCore.Mvc;

namespace Cyborg.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
