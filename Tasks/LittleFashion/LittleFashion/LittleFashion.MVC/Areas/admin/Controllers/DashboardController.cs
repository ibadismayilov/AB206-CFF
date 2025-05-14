using LittleFashion.BL.Models;
using LittleFashion.BL.Services;
using Microsoft.AspNetCore.Mvc;

namespace LittleFashion.MVC.Areas.admin.Controllers
{
    [Area("Admin")]

    public class DashboardController : Controller
    {

        private readonly ProductrModelService _productrModelService;

        public DashboardController()
        {
            _productrModelService = new ProductrModelService();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
