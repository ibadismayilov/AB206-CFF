using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProductInventory;

class InputValue
{
    public void Value(Warehouse warehouse)
    {
        Console.Write("Please enter Product Name: ");
        string name = Console.ReadLine();

        Console.Write("Please enter Product Price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        Console.Write("Please enter Product Stock Count: ");
        int stockCount = Convert.ToInt32(Console.ReadLine());

        // Daxil edilmiş məlumatlarla Product obyektini yaradıb birbaşa anbara əlavə edirik
        Product product = new Product(name, price, stockCount);
        warehouse.AddProduct(product);
    }
}
