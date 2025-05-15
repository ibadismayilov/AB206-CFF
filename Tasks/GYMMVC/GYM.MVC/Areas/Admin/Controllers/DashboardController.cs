using GYM.BL.Services;
using GYM.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace GYM.MVC.Areas.Admin.Controllers;

[Area("Admin")]
public class DashboardController : Controller
{

    private readonly ProductService _productService;

    public DashboardController(ProductService productService)
    {
        productService = _productService;
    }

    public IActionResult Index()
    {
        List<ProductModel> getAllProd = _productService.GetAllProd();
        return View(getAllProd);
    }
}
