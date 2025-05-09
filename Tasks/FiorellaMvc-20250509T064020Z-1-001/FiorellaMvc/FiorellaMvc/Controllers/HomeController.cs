using FiorellaMvc.Models;
using FiorellaMvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace FiorellaMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductService _productService;
        public HomeController()
        {
            _productService = new ProductService();
        }
        public IActionResult Index()
        {
            List<Product> products = _productService.GetAllProducts();
            return View(products);
        }
    }
}
