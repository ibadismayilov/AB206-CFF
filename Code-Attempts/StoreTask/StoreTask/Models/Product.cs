using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreTask.Models;

public class Product
{
    public static int _id = 1;
    public int ID
    {
        get
        {
            return _id;
        }
        set
        {
            ID = _id++;
        }
    }

    public string Name { get; set; }

    public double _price;
    public double Price
    {
        get
        {
            return _price;
        }
        set
        {
            if (_price < 0)
            {
                Console.WriteLine("Please enter correct price");
            } else
            {
                _price = value;
            }
        }
    }

    public ProductType Type { get; set; }

    public enum ProductType
    {
        Baker,
        Drink,
        Meat,
        Diary
    }
}
