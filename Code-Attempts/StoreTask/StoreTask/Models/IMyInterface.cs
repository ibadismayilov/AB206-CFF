using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StoreTask.Models.Product;

namespace StoreTask.Models;

public interface IMyInterface
{
    void AddProduct(Product product);
    Product RemoveProductByNo(int id); 
    Product GetProduct(int id);
    void FilterProductsByType(ProductType type); 
}
