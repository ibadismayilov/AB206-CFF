using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesProject;

class SalesComponents
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public bool IsStock { get; set; }
        public double _price { get; set; }

        private double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Wrong value");
                }
                else
                {
                    _price = value;
                }
            }
        }

        public Product(string name, string description, int count, double price)
        {
            Name = name;
            Description = description;
            Count = count;
            Price = price;
        }

        public void Sale()
        {
            if (Count <= 0)
            {
                Console.WriteLine("No stock");
            }
            else
            {
                Console.WriteLine("Stock");
            }
        }
    }

    public class Notebook : Product
    {
        int Storage { get; set; }
        private byte _ram;
        byte RAM
        {
            get
            {
                return _ram;
            }
            set
            {
                _ram = value;
            }
        }

        public Notebook(string name, string description, int count, double price, int storage, byte ram) : base(name, description, count, price)
        {
            if (name.Length == 0 || count <= 0 || price <= 0 || ram <= 0)
            {
                Console.WriteLine("noooooooooo");
            } else
            {
                Storage = storage;
                RAM = ram;
            }
        }

        public void ShowFullData()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("Count: " + Count);
            Console.WriteLine("Storage: " + Storage + "GB");
            Console.WriteLine("RAM: " + RAM + "GB");
        }
    }
}
