using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventory;

class Electronics : Product
{
    public int WarrantyYears { get; set; }
    public Electronics(string name, double price, int stockCount, int warrantyYears) : base(name, price, stockCount)
    {
        WarrantyYears = warrantyYears;
    }

    public override void ShowInfo()
    {
        //Console.WriteLine($"Name: {Name}\nPrice: {Price}\nStock Count: {StockCount}");
        Console.WriteLine($"WarrantyYears: {WarrantyYears}");
    }
}
