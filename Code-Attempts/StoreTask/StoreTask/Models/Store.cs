using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StoreTask.Models.Product;

namespace StoreTask.Models;

public class Store : IMyInterface
{
    Product[] products;

    public Store()
    {
        products = new Product[0];
    }

    public void AddProduct(Product product)
    {
        Array.Resize(ref products, products.Length + 1);
        products[products.Length - 1] = product;
    }

    public Product RemoveProductByNo(int id)
    {
        Product removeItem = GetProduct(id);


        Product[] newArray = new Product[products.Length - 1];

        int index = 0;

        foreach (var item in products)
        {
            if (item.ID != id)
            {
                newArray[index++] = item;
            }
        }

        products = newArray;
        Console.WriteLine("Məhsul silindi.");

        return default;

    }

    public Product GetProduct(int id)
    {
        foreach (var item in products)
        {
            if (item.ID == id)
            {
                Console.WriteLine($"Product: {item.ID} {item.Name} - {item.Price}");
                return item;
            }
        }

        Console.WriteLine("Belə məhsul yoxdur.");
        return default;
    }

    public void FilterProductsByType(ProductType type)
    {
        foreach (var item in products)
        {
            if (item.Type == type)
            {
                Console.WriteLine($"Product: {item.Name} - {item.Price} - {item.Type}");
            }
        }
    }
}
