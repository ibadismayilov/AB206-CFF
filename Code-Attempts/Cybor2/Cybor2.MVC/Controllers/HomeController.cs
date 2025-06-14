using Microsoft.AspNetCore.Mvc;

namespace Cybor2.MVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
