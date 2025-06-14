using Cybor2.BL.ViewModels;
using Cybor2.DAL.Contexts;
using Cybor2.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cybor2.BL.Services;
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
        ProductModel? findProd = _appDbContext.ProductModels.Find(id);

        if (findProd == null)
        {
            throw new Exception("Bu product tapilmadi");
        }

        return findProd;
    }

    public void Create(ProductVM productVM)
    {
        ProductModel product = new ProductModel();
        product.Title = productVM.Title;
        product.Desc = productVM.Desc;

        string filename = Path.GetFileNameWithoutExtension(productVM.ImgFile.FileName);
        string extension = Path.GetExtension(productVM.ImgFile.FileName);

        string result = filename + Guid.NewGuid().ToString() + extension;

        string uploadedImage = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "assets", "uploadedImage");

        using FileStream stream = new FileStream(Path.Combine(uploadedImage, result), FileMode.Create);

        productVM.ImgFile.CopyTo(stream);

        product.ImgPath = result;

        _appDbContext.ProductModels.Add(product);
        _appDbContext.SaveChanges();
    }

    public ProductModel? Delete(int id)
    {
        ProductModel? findProd = _appDbContext.ProductModels.Find(id);

        if (findProd == null)
            return null;

        _appDbContext.ProductModels.Remove(findProd);
        _appDbContext.SaveChanges();

        return findProd;
    }

    public void UpdateProduct(int id, UpdateVM updateVM)
    {
        var existingProduct = GetProductById(id);

        if (existingProduct is null)
        {
            throw new Exception($"ID-si {id} olan məhsul tapılmadı.");
        }

        existingProduct.Title = updateVM.Title;
        existingProduct.Desc = updateVM.Desc;

        if (updateVM.ImgFile is not null)
        {
            string fileName = Path.GetFileNameWithoutExtension(updateVM.ImgFile.FileName);
            string extension = Path.GetExtension(updateVM.ImgFile.FileName);
            string result = fileName + Guid.NewGuid().ToString() + extension;

            string uploadedImages = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "assets", "uploadedImage");

            if (!Directory.Exists(uploadedImages))
            {
                Directory.CreateDirectory(uploadedImages);
            }

            using FileStream stream = new FileStream(Path.Combine(uploadedImages, result), FileMode.Create);
            updateVM.ImgFile.CopyTo(stream);

            existingProduct.ImgPath = result;
        }

        _appDbContext.SaveChanges();
    }

}
