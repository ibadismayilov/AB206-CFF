using Microsoft.AspNetCore.Mvc;

namespace KindHeart.MVC.Areas.Admin.Controllers;

[Area("Admin")]
public class DashboardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
