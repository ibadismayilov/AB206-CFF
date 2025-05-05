using Microsoft.AspNetCore.Mvc;

namespace HotelMvc.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
