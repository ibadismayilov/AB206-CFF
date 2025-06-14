using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListForHotel.Models;

public class Hotel : BaseClass
{
    private static List<Room> rooms = new List<Room>();
    public Hotel(string name) : base(name)
    {
        
    }
}
