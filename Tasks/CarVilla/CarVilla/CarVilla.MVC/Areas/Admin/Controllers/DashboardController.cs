using CarVilla.BL.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarVilla.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly CarService _carService;

        public DashboardController()
        {
            _carService = new CarService();
        }

        public IActionResult Index()
        {
            var getAllCar = _carService.GetAllCar();
            return View(getAllCar);
        }
    }
}
