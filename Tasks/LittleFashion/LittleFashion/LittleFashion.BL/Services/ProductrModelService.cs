using LittleFashion.BL.Models;
using LittleFashion.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleFashion.BL.Services;

public class ProductrModelService
{
    private readonly AppDbContext _appDbContext;

    public ProductrModelService()
    {
        _appDbContext = new AppDbContext();
    }

    public List<ProductModel> GetAllProd()
    {
        return _appDbContext.ProductModels.ToList();
    }

    public ProductModel GetProductById(int id)
    {
        var findProd = _appDbContext.ProductModels.Find(id);
        return findProd;
    }

    public void CreateProd(ProductModel product)
    {
        _appDbContext.ProductModels.Add(product);
        _appDbContext.SaveChanges();
    }

    public void DeleteProd(int id)
    {
        var findProd = GetProductById(id);
        _appDbContext.ProductModels.Remove(findProd);
        _appDbContext.SaveChanges();
    }

    public void UpdateProd(int id, ProductModel newProdModel)
    {
        var findProd = _appDbContext.ProductModels.AsNoTracking().FirstOrDefault(item=>item.Id == id);

        if(findProd is null)
        {
            throw new Exception("Something went wrong");
        }

        findProd.Id = id;
        _appDbContext.ProductModels.Update(newProdModel);
        _appDbContext.SaveChanges();
    }

}
