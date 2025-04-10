using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreTask.Models;

class Product
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

    public static int _price;
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
            }
        }
    }

    enum Type
    {
        Baker,
        Drink,
        Meat,
        Diary
    }
}
