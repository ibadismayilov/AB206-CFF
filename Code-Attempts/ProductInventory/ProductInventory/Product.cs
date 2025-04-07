using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventory;

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int StockCount { get; set; }

    public Product(string name, double price, int stockCount)
    {
        Name = name;
        Price = price;
        StockCount = stockCount;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}\nPrice: {Price}\nStock Count: {StockCount}");
    }
}
