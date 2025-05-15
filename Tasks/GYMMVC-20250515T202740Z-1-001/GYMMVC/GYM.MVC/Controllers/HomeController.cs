using GYM.BL.Services;
using GYM.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace GYM.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductService _productService;

        public HomeController(ProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            List<ProductModel> getAllProd = _productService.GetAllProd();
            return View(getAllProd);
        }
    }
}
