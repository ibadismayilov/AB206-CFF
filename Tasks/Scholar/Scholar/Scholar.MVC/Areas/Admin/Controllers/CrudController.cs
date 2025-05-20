using Microsoft.AspNetCore.Mvc;
using Villa.BL.Services;
using Villa.DAL.Models;

namespace Villa.MVC.Areas.Admin.Controllers;

[Area("Admin")]
public class CrudController : Controller
{

    private readonly ProductService _productService;

    public CrudController(ProductService productService)
    {
        _productService = productService;
    }
    public IActionResult Index()
    {
        var getAllProduct = _productService.GetAllProduct();
        return View(getAllProduct);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(ProductModel product)
    {
        //if (!ModelState.IsValid)
        //{
        //    return View();
        //}

        _productService.CreateProduct(product);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Info(int id)
    {
        ProductModel product = _productService.GetProductById(id);
        return View(product);
    }

    [HttpPost]
    public IActionResult Delete(int id)
    {
        _productService.DeleteProduct(id);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        return View();
    }

    [HttpPost]
    public IActionResult Update(ProductModel product)
    {
        _productService.UpdateProduct(product);
        return RedirectToAction(nameof(Index));
    }
}
