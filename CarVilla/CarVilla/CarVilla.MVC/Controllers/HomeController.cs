using CarVilla.BL.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarVilla.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly CarService _carService;

        public HomeController()
        {
            _carService = new CarService();
        }

        public IActionResult Index()
        {
            var carList = _carService.GetAllCar();

            return View(carList);
        }
    }
}
