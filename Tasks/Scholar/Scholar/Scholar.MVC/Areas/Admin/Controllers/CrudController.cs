using Microsoft.AspNetCore.Mvc;
using Scholar.BL.Services;
using Scholar.DAL.Models;
using Scholar.MVC.ViewModels;

namespace Scholar.MVC.Areas.Admin.Controllers;

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
    public IActionResult Create(ProductVM productVM)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }

        _productService.CreateProduct(productVM);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Info(int id)
    {
        ProductModel product = _productService.GetProductById(id);

        if (product is null)
        {
            throw new Exception("Product tapilmadi");
        }

        ProductVM vm = new ProductVM();
        vm.Title = product.Title;
        vm.Desc = product.Desc;
        vm.Category = product.Category;
        vm.Price = product.Price;

        return View(vm);
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
        ProductModel findProduct = _productService.GetProductById(id);

        if (findProduct is null)
        {
            throw new Exception("Product tapilmadi");
        }

        ProductVM vm = new ProductVM();
        vm.Title = findProduct.Title;
        vm.Desc = findProduct.Desc;
        vm.Category = findProduct.Category;
        vm.Price = findProduct.Price;

        return View(vm);
    }

    [HttpPost]
    public IActionResult Update(int id, ProductVM productVM)
    {

        if (!ModelState.IsValid)
        {
            return View();
        }

        _productService.UpdateProduct(id, productVM);
        return RedirectToAction(nameof(Index));
    }
}
