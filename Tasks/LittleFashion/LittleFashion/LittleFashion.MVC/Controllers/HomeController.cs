using LittleFashion.BL.Models;
using LittleFashion.BL.Services;
using Microsoft.AspNetCore.Mvc;

namespace LittleFashion.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductrModelService _productrModelService;

        public HomeController()
        {
            _productrModelService = new ProductrModelService();
        }

        public IActionResult Index()
        {
            List<ProductModel> getAllProd = _productrModelService.GetAllProd();

            return View(getAllProd);
        }
    }
}
