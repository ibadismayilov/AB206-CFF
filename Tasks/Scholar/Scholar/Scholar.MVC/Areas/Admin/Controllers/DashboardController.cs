using Microsoft.AspNetCore.Mvc;

namespace Villa.MVC.Areas.Admin.Controllers;

[Area("Admin")]
public class DashboardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
