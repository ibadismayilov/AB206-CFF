using LessonRepository.BL.Services.Interfaces;
using LessonRepository.DAL.Entities;
using LessonRepository.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonRepository.BL.Services.Concretes;

public class ProductService : IProductService
{
    private readonly IRepository<Product> _productService;

    public ProductService(IRepository<Product> productService)
    {
        _productService = productService;
    }

    public List<Product> GetAllProducts()
    {
        return _productService.GetAll().ToList();
    }
}
