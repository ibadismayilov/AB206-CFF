using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListForHotel.Models;

public class Room : BaseClass
{
    public double Price { get; set; }
    public int PersonCapacity
    {
        get
        {
            return PersonCapacity;
        }
        set
        {
            if (value >= 0 && value <= 4)
            {
                PersonCapacity = value;
            }
        }
    }
    public bool IsAvialable { get; set; } = true;

    public Room(string name, double price, int personCapacity) : base(name)
    {
        Price = price;
        PersonCapacity = personCapacity;
    }
}
