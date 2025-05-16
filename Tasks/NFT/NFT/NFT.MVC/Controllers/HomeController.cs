using Microsoft.AspNetCore.Mvc;
using NFT.BL.Services;
using NFT.DAL.Models;

namespace NFT.MVC.Controllers;

public class HomeController : Controller
{
    private readonly ProductService _productService;

    public HomeController(ProductService productService)
    {
        _productService = productService;
    }

    public IActionResult Index()
    {
        List<ProductModel> getALllProduct = _productService.GetAllProduct();
        return View(getALllProduct);
    }
}
