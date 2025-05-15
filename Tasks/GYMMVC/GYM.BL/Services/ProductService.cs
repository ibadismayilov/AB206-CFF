using GYM.DAL.Contexts;
using GYM.DAL.Models;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.BL.Services;

public class ProductService
{
    private readonly AppDbContext _appDbContext;

    public ProductService(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    #region Get All Product
    public List<ProductModel> GetAllProd()
    {
        return _appDbContext.ProductModels.ToList();
    }

    #endregion

    #region Creat
    public void CreateProd(ProductModel productModel)
    {
        string fileName = Path.GetFileNameWithoutExtension(productModel.ImgFile.FileName);
        string extension = Path.GetExtension(productModel.ImgFile.FileName);

        string result = fileName + Guid.NewGuid().ToString() + extension;

        string uploadedPath = "C:\\Users\\II Novbe\\Desktop\\GYMMVC\\GYM.MVC\\wwwroot\\assets\\uploadedImages\\";

        if (!Directory.Exists(uploadedPath))
        {
            Directory.CreateDirectory(uploadedPath);
        }

        using FileStream stream = new FileStream(Path.Combine(uploadedPath, result), FileMode.Create);

        productModel.ImgFile.CopyTo(stream);

        productModel.ImgPath = result;

        _appDbContext.ProductModels.Add(productModel);
        _appDbContext.SaveChanges();
    }
    #endregion

    #region Read

    public ProductModel GetProdById(int id)
    {
        ProductModel? findProd = _appDbContext.ProductModels.Find(id);
        return findProd;
    }

    #endregion

    #region Update
    public void UpdateProd()
    {

    }
    #endregion

    #region Delete

    public void DeleteProd(int id)
    {
        ProductModel findProd = GetProdById(id);

        if (findProd is null)
        {
            throw new Exception($"{findProd} - li prod yoxdur");
        }

        _appDbContext.ProductModels.Remove(findProd);
        _appDbContext.SaveChanges();
    }

    #endregion
}
