using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreTask.Models;

class Store
{
    Product[] products = new Product[0];

    public void AddProduct(Product product)
    {
        Array.Resize(ref products, products.Length + 1);
        products[products.Length - 1] = product;
    }

    public Product GetProduct(int id)
    {
        
        foreach (var item in products)
        {
            if(item.ID == id)
            {
                Console.WriteLine($"Product: {products}");
            } else
            {
                Console.WriteLine("Bele mehsul yoxdur");
            }
        }

        return id;
    }

    public void RemoveProductByNo(int id)
    {
        Product removeItem = GetProduct(id);

        Product[] newArray = new Product[products.Length - 1];

        int index = 0;

        foreach (var item in products)
        {
            if (item.ID !=id)
            {
                newArray[index] = item;
            }
        }

        newArray = products;
    }
}
