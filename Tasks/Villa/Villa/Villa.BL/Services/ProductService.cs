using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa.DAL.Contexts;
using Villa.DAL.Models;

namespace Villa.BL.Services;

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

    public void CreateProduct(ProductModel product)
    {
        string filname = Path.GetFileNameWithoutExtension(product.ImgFile.FileName);
        string extension = Path.GetExtension(product.ImgFile.FileName);

        string result = filname + Guid.NewGuid().ToString() + extension;

        string uploadedImages = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "assets", "uploadedImages");

        if (!Directory.Exists(uploadedImages))
        {
            Directory.CreateDirectory(uploadedImages);
        }

        using FileStream stream = new FileStream(Path.Combine(uploadedImages, result), FileMode.Create);
        product.ImgFile.CopyTo(stream);

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

    public void UpdateProduct(ProductModel product)
    {
        ProductModel? productModel = _appDbContext.ProductModels.FirstOrDefault(item => item.Id == product.Id);

        if (productModel is null)
        {
            throw new Exception($"{productModel} tapilmadi");
        } 

        productModel.Title = product.Title;
        productModel.Category = product.Category;
        productModel.Price = product.Price;
        productModel.BedroomCount = product.BedroomCount;
        productModel.BathroomCount = product.BathroomCount;
        productModel.Area = product.Area;
        productModel.Floor = product.Floor;
        productModel.Parking = product.Parking;

        if (product.ImgFile is not null)
        {

            string filname = Path.GetFileNameWithoutExtension(product.ImgFile.FileName);
            string extension = Path.GetExtension(product.ImgFile.FileName);

            string result = filname + Guid.NewGuid().ToString() + extension;

            string uploadedImages = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "assets", "uploadedImages");

            if (!Directory.Exists(uploadedImages))
            {
                Directory.CreateDirectory(uploadedImages);
            }

            using FileStream stream = new FileStream(Path.Combine(uploadedImages, result), FileMode.Create);
            product.ImgFile.CopyTo(stream);

            productModel.ImgPath = result;
        }

        _appDbContext.SaveChanges();
    }
}
