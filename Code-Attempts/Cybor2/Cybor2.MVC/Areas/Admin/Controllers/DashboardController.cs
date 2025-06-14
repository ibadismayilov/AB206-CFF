using Microsoft.AspNetCore.Mvc;

namespace Cybor2.MVC.Areas.Admin.Controllers;

[Area("Admin")]
public class DashboardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
