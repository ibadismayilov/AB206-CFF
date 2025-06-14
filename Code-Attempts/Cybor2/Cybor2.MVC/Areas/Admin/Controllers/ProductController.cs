using Cybor2.BL.Services;
using Cybor2.BL.ViewModels;
using Cybor2.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Cybor2.MVC.Areas.Admin.Controllers;

[Area("Admin")]
public class ProductController : Controller
{

    private readonly ProductService _productService;

    public ProductController(ProductService productService)
    {
        _productService = productService;
    }

    public IActionResult Index()
    {
        List<ProductModel> products = _productService.GetAllProduct();
        return View(products);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(ProductVM productVM) 
    {
        ProductModel product = new ProductModel();
        product.Title = productVM.Title;
        product.Desc = productVM.Desc;

        if (!ModelState.IsValid)
        {
            return View(productVM);
        }

        _productService.Create(productVM);
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
        _productService.Delete(id);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        var product = _productService.GetProductById(id);

        if (product == null) return NotFound();

        UpdateVM productVM = new UpdateVM();
        productVM.Title = product.Title;
        productVM.Desc = product.Desc;

        return View(productVM);
    }


    [HttpPost]
    public IActionResult Update(int id, UpdateVM updateVM)
    {

        if (!ModelState.IsValid)
        {
            return View();
        }

        _productService.UpdateProduct(id, updateVM);
        return RedirectToAction(nameof(Index));
    }

}
