using NFT.DAL.Contexts;
using NFT.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFT.BL.Services;

public class ProductService
{
    private readonly AppDbContext _appDbContext;

    public ProductService(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    #region Get All Product
    public List<ProductModel> GetAllProduct()
    {
        return _appDbContext.ProductModels.ToList();
    }
    #endregion

    #region GetProductById
    public ProductModel GetProductById(int id)
    {
        ProductModel? findProduct = _appDbContext.ProductModels.Find(id);

        return findProduct;
    }
    #endregion

    #region Create
    public void CreateProduct(ProductModel productModel)
    {
        string fileName = Path.GetFileNameWithoutExtension(productModel.ImgFile.FileName);
        string extension = Path.GetExtension(productModel.ImgFile.FileName);

        string result = fileName + Guid.NewGuid().ToString() + extension;

        string uploadedImages = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "assets", "uploadedImages");

        if (!Directory.Exists(uploadedImages))
        {
            Directory.CreateDirectory(uploadedImages);
        }

        using FileStream stream = new FileStream(Path.Combine(uploadedImages, result), FileMode.Create);

        productModel.ImgFile.CopyTo(stream);
        productModel.ImgPath = result;

        _appDbContext.ProductModels.Add(productModel);
        _appDbContext.SaveChanges();
    }
    #endregion

    #region Update
    public void UpdateProduct(ProductModel newProductModel)
    {
        var findProduct = _appDbContext.ProductModels.FirstOrDefault(item => item.Id == newProductModel.Id);

        if (findProduct is null)
        {
            throw new Exception($"{findProduct} tapilmadi");
        }

        findProduct.Title = newProductModel.Title;
        findProduct.Category = newProductModel.Category;
        findProduct.MaxCount = newProductModel.MaxCount;
        findProduct.MinCount = newProductModel.MinCount;

        if (findProduct is not null)
        {
            string fileName = Path.GetFileNameWithoutExtension(newProductModel.ImgFile.FileName);
            string extension = Path.GetExtension(newProductModel.ImgFile.FileName);

            string result = fileName + Guid.NewGuid().ToString() + extension;

            string uploadedImages = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "assets", "uploadedImages");

            if (!Directory.Exists(uploadedImages))
            {
                Directory.CreateDirectory(uploadedImages);
            }

            using FileStream stream = new FileStream(Path.Combine(uploadedImages, result), FileMode.Create);

            newProductModel.ImgFile.CopyTo(stream);
            newProductModel.ImgPath = result;

            findProduct.ImgPath = newProductModel.ImgPath;
        }

        _appDbContext.SaveChanges();
    }
    #endregion

    #region Delete
    public void DeleteProduct(int id)
    {
        ProductModel findProduct = GetProductById(id);
        _appDbContext.ProductModels.Remove(findProduct);
        _appDbContext.SaveChanges();
    }
    #endregion
}
