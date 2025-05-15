using GYM.BL.Services;
using GYM.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace GYM.MVC.Areas.Admin.Controllers;

[Area("Admin")]
public class CRUDController : Controller
{
    private readonly ProductService _productService;

    public CRUDController(ProductService productService)
    {
        _productService = productService;
    }

    public IActionResult Index()
    {
        List<ProductModel> getAllProd =  _productService.GetAllProd();
        return View(getAllProd);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(ProductModel productModel)
    {
        _productService.CreateProd(productModel);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Info(int id)
    {
        ProductModel findProd = _productService.GetProdById(id);
        return View(findProd);
    }

    [HttpPost]
    public IActionResult Delete(int id)
    {
        _productService.DeleteProd(id);
        return RedirectToAction(nameof(Index));
    }
}
