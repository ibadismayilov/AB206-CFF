using FiorellaMvc.Contexts;
using FiorellaMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace FiorellaMvc.Services;

public class ProductService
{
    private readonly AppDbContext _context;

    public ProductService()
    {
        _context = new AppDbContext();
    }

    public void CreateProduct(Product product)
    {
        _context.Products.Add(product);
        _context.SaveChanges();
    }

    public List<Product> GetAllProducts()
    {
        return _context.Products.ToList();
    }

    public Product GetProductById(int id)
    {
        Product? findProd = _context.Products.Find(id);

        if (findProd is null)
        {
            throw new Exception($"{id} bu Id - ə sahib product yoxdur");
        }

        return findProd;
    }

    public void Delete(int id)
    {
        var findProd = GetProductById(id);

        _context.Products.Remove(findProd);
        _context.SaveChanges();
    }

    public void Update(int id, Product updateProduct)
    {
        var existingProduct = GetProductById(id);

        //existingProduct.ImgUrl = updateProduct.ImgUrl;
        existingProduct.Title = updateProduct.Title;
        existingProduct.Price = updateProduct.Price;

        _context.SaveChanges();
    }

}
