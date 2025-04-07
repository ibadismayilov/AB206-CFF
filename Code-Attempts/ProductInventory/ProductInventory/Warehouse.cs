using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventory;

class Warehouse
{
    List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void ShowInfo()
    {
        foreach (var item in products)
        {
            item.ShowInfo();
        }
    }
}
