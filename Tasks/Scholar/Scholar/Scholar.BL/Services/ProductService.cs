using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scholar.DAL.Contexts;
using Scholar.DAL.Models;
using Scholar.MVC.ViewModels;

namespace Scholar.BL.Services;

public class ProductService
{
    private readonly AppDbContext _appDbContext;

    public ProductService(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public List<ProductModel> GetAllProduct()
    {
        return _appDbContext.ProductModels.ToList();
    }

    public ProductModel GetProductById(int id)
    {
        ProductModel? findProduct = _appDbContext.ProductModels.Find(id);
        return findProduct;
    }

    public void CreateProduct(ProductVM productVM)
    {
        ProductModel product = new ProductModel();
        product.Category = productVM.Category;
        product.Desc = productVM.Desc;
        product.Title = productVM.Title;
        product.Price = productVM.Price;

        string filname = Path.GetFileNameWithoutExtension(productVM.ImgFile.FileName);
        string extension = Path.GetExtension(productVM.ImgFile.FileName);

        string result = filname + Guid.NewGuid().ToString() + extension;

        string uploadedImages = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "assets", "uploadedImages");

        if (!Directory.Exists(uploadedImages))
        {
            Directory.CreateDirectory(uploadedImages);
        }

        using FileStream stream = new FileStream(Path.Combine(uploadedImages, result), FileMode.Create);
        productVM.ImgFile.CopyTo(stream);

        product.ImgPath = result;

        _appDbContext.ProductModels.Add(product);
        _appDbContext.SaveChanges();
    }

    public ProductModel DeleteProduct(int id)
    {
        var findProduct = GetProductById(id);
        _appDbContext.ProductModels.Remove(findProduct);
        _appDbContext.SaveChanges();

        return findProduct;
    }

    public void UpdateProduct(int id, ProductVM productVM)
    {
        var existingProduct = GetProductById(id);

        if (existingProduct is null)
        {
            throw new Exception($"ID-si {id} olan məhsul tapılmadı.");
        }

        existingProduct.Title = productVM.Title;
        existingProduct.Desc = productVM.Desc;
        existingProduct.Category = productVM.Category;
        existingProduct.Price = productVM.Price;

        if (productVM.ImgFile is not null)
        {
            string fileName = Path.GetFileNameWithoutExtension(productVM.ImgFile.FileName);
            string extension = Path.GetExtension(productVM.ImgFile.FileName);
            string result = fileName + Guid.NewGuid().ToString() + extension;

            string uploadedImages = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "assets", "uploadedImages");

            if (!Directory.Exists(uploadedImages))
            {
                Directory.CreateDirectory(uploadedImages);
            }

            using FileStream stream = new FileStream(Path.Combine(uploadedImages, result), FileMode.Create);
            productVM.ImgFile.CopyTo(stream);

            existingProduct.ImgPath = result;
        }

        _appDbContext.SaveChanges();
    }

}
