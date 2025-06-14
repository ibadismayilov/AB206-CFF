using MakanBLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace Makan.PL.Controllers
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
            var products = _productService.GetAllProdcut();
            return View(products);
        }
    }
}
