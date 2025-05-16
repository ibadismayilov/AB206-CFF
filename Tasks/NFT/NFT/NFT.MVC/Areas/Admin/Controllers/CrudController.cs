using Microsoft.AspNetCore.Mvc;
using NFT.BL.Services;
using NFT.DAL.Models;

namespace NFT.MVC.Areas.Admin.Controllers;

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
        List<ProductModel> getALllProduct = _productService.GetAllProduct();
        return View(getALllProduct);
    }

    #region Create
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(ProductModel productModel)
    {
        _productService.CreateProduct(productModel);
        return RedirectToAction(nameof(Index));
    }
    #endregion

    #region Update
    [HttpGet]
    public IActionResult Update()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Update(ProductModel productModel)
    {
        _productService.UpdateProduct(productModel);
        return RedirectToAction(nameof(Index));
    }
    #endregion

    #region Read
    [HttpGet]
    public IActionResult Info(int id)
    {
        ProductModel findProduct = _productService.GetProductById(id);
        return View(findProduct);
    }
    #endregion

    #region Delete
    [HttpPost]
    public IActionResult Delete(int id)
    {
        _productService.DeleteProduct(id);
        return RedirectToAction(nameof(Index));
    }
    #endregion
}
