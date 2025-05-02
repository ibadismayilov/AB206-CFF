using Microsoft.AspNetCore.Mvc;

namespace HealetMvc.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
