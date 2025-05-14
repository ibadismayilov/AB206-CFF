using LittleFashion.BL.Models;
using LittleFashion.BL.Services;
using Microsoft.AspNetCore.Mvc;

namespace LittleFashion.MVC.Areas.admin.Controllers;

[Area("Admin")]
public class CrudController : Controller
{
    private readonly ProductrModelService _productrModelService;

    public CrudController()
    {
        _productrModelService = new ProductrModelService();
    }

    public IActionResult Index()
    {
        List<ProductModel> getAllProd = _productrModelService.GetAllProd();

        return View(getAllProd);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(ProductModel product)
    {
        _productrModelService.CreateProd(product);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public IActionResult Delete(int id)
    {
        _productrModelService.DeleteProd(id);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Info(int id)
    {
        ProductModel productModel = _productrModelService.GetProductById(id);
        return View(productModel);
    }
}
