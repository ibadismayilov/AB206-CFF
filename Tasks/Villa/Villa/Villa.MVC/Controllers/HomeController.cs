using Microsoft.AspNetCore.Mvc;
using Villa.BL.Services;
using Villa.DAL.Models;

namespace Villa.MVC.Controllers
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
            List<ProductModel> getAllProduct = _productService.GetAllProduct();
            return View(getAllProduct);
        }
    }
}
