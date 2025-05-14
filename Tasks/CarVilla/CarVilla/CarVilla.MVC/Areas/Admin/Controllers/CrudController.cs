using CarVilla.BL.Services;
using CarVilla.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarVilla.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CrudController : Controller
    {
        private readonly CarService _carService;

        public CrudController()
        {
            _carService = new CarService();
        }

        [HttpGet]
        public IActionResult Index()
        {
            var allCars = _carService.GetAllCar();
            return View(allCars); 
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Car car)
        {
            _carService.CreateCar(car); 
            return RedirectToAction(nameof(Create));
        }

        [HttpGet]
        public IActionResult Info(int id)
        {
            var findCar = _carService.GetCarById(id);
            return View(findCar);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _carService.DeleteCar(id);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update(int id, Car updatedCar)
        {
            _carService.UpdateCar(id, updatedCar);
            return RedirectToAction(nameof(Index));
        }
    }
}
