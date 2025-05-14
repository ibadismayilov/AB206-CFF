using KindHeart.BL.Services;
using KindHeart.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace KindHeart.MVC.Controllers
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
            List<ProductModel> products = _productService.GetAllProd();
            return View(products);
        }
    }
}
