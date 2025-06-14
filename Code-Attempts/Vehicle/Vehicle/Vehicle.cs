using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle;

class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public double Mile { get; set; }

    public Vehicle(string brand, string model, double mile)
    {
        Brand = brand;
        Model = model;
        Mile = mile;
    }

    public virtual void ShowFullInfo()
    {
        Console.WriteLine($"Vehicle -> Brand: {Brand}, Model: {Model}, Mile: {Mile}");
    }
}
