using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelTask;

class Room
{
    private static int _id = 1;
    public string Name { get; set; }
    public int ID
    {
        get
        {
            return _id;
        }
        set
        {
            _id = value;
        }
    }

    public double Price { get; set; }
    public int PersonCapacity { get; set; }
    public bool IsAvailable { get; set; } = true;

    public Room(string name, double price, int personCapacity)
    {
        if (name is null || price <= 0 || personCapacity <= 0)
        {
            throw new ArgumentException("Name, Price və PersonCapacity düzgün daxil edilməlidir.");
        }

        ID = _id++;

        Name = name;
        Price = price;
        PersonCapacity = personCapacity;
    }

    public void ShowInfo()
    {
        Console.WriteLine(ToString());
    }

    public override string ToString()
    {
        return $"ID: {ID} | Name: {Name} | Price: {Price} | Capacity: {PersonCapacity} | Available: {IsAvailable}";
    }
}
