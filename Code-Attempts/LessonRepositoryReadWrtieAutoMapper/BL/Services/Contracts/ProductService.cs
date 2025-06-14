using AutoMapper;
using BL.DTO;
using BL.Services.Interfaces;
using DAL.Entities;
using DAL.Repositories.Contracts;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services.Contracts;

public class ProductService<T> : IProductService<T> where T : BaseEntity
{
    private readonly IReadRepository<Product> readRepository;
    private readonly IWriteRepository<Product> writeRepository;

    private readonly IMapper mapper;

    public ProductService(IReadRepository<Product> readRepository, IWriteRepository<Product> writeRepository, IMapper mapper)
    {
        this.readRepository = readRepository;
        this.writeRepository = writeRepository;
        this.mapper = mapper;
    }
    public List<ProductDto> GetAllProduct()
    {
        List<Product> products = readRepository.GetAll().ToList();

        var mapped = mapper.Map<List<ProductDto>>(products);

        return mapped;
    }

    public void CreateProduct(ProductDto productDto)
    {
        throw new NotImplementedException();
    }

    public void DeleteProduct()
    {
        throw new NotImplementedException();
    }

    public void SaveProduct()
    {
        throw new NotImplementedException();
    }

    public void UpdateProduct()
    {
        throw new NotImplementedException();
    }
}
