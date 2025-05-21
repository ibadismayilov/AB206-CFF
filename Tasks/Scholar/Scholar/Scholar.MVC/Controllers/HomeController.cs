using Microsoft.AspNetCore.Mvc;
using Scholar.BL.Services;
using Scholar.DAL.Models;

namespace Scholar.MVC.Controllers;

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
