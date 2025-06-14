using BL.DTO;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services.Interfaces;

public interface IProductService<T> where T : BaseEntity
{
    List<ProductDto> GetAllProduct();
    void CreateProduct(ProductDto productDto);
    void UpdateProduct();
    void DeleteProduct();
    void SaveProduct();
}
