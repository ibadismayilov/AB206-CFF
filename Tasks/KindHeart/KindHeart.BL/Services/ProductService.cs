using KindHeart.DAL.Contexts;
using KindHeart.DAL.Migrations;
using KindHeart.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindHeart.BL.Services;

public class ProductService
{
    private readonly AppDbContext _appDbContext;

    public ProductService()
    {
        _appDbContext = new AppDbContext();
    }


    public List<ProductModel> GetAllProd()
    {
        return _appDbContext.ProductModels.ToList();
    }

    #region Create Product
    public void CreateProd(ProductModel productModel)
    {

        string result =   Guid.NewGuid().ToString() + productModel.ImgPath.FileName;

        string folderPath = $"D:\\KindHeart\\KindHeart.MVC\\wwwroot\\assets\\uploadedImages";

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
        }

        string uploadedPath = Path.Combine(folderPath, result);

        using FileStream fileStream = new FileStream(uploadedPath, FileMode.Create);
        productModel.ImgPath.CopyTo(fileStream);

        productModel.ImgFile = result;

        _appDbContext.ProductModels.Add(productModel);
        _appDbContext.SaveChanges();
    }
    #endregion

    #region Read
    public ProductModel GetProdById(int id)
    {
        ProductModel? findProd = _appDbContext.ProductModels.Find(id);

        if (findProd == null)
        {
            throw new Exception("Id aid product yoxdur");
        }

        return findProd;
    }
    #endregion

    #region Update
    public void UpdateProd(ProductModel updatedModel)
    {
        var existingProduct = _appDbContext.ProductModels.FirstOrDefault(p => p.Id == updatedModel.Id);

        if (existingProduct == null)
        {
            throw new Exception("Id aid product yoxdur");
        }

        existingProduct.Title = updatedModel.Title;
        existingProduct.Desc = updatedModel.Desc;
        existingProduct.Raised = updatedModel.Raised;
        existingProduct.Goal = updatedModel.Goal;

        if (updatedModel.ImgPath != null)
        {
            string result = Guid.NewGuid().ToString() + updatedModel.ImgPath.FileName;

            string folderPath = $"D:\\KindHeart\\KindHeart.MVC\\wwwroot\\assets\\uploadedImages";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string uploadedPath = Path.Combine(folderPath, result);

            using FileStream fileStream = new FileStream(uploadedPath, FileMode.Create);
            updatedModel.ImgPath.CopyTo(fileStream);

            existingProduct.ImgFile = result;
        }

        _appDbContext.SaveChanges();
    }
    #endregion

    #region Delete
    public void DeleteProd(int id)
    {
        ProductModel? findProd = GetProdById(id);
        _appDbContext.ProductModels.Remove(findProd);
        _appDbContext.SaveChanges();
    }
    #endregion
}
