using FiorellaMvc.Models;
using FiorellaMvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace FiorellaMvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        ProductService _productService;
        public DashboardController()
        {
            _productService = new ProductService();
        }
        public IActionResult Index()
        {
            List<Product> products = _productService.GetAllProducts();
            return View(products);
        }

        [HttpGet]
        public IActionResult Info(int id)
        {
            Product product = _productService.GetProductById(id);
            return View(product);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            _productService.CreateProduct(product);
            return View();
        }

        [HttpGet]
        public IActionResult DeleteProduct(int id)
        {
            _productService.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var data = _productService.GetProductById(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult UpdateProduct(int id, Product product)
        {
            _productService.Update(id, product);
            return RedirectToAction(nameof(Index));
        }
    }
}
