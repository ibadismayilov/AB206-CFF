using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle;

class Car : Vehicle
{
    public int DoorsNum { get; set; }

    public Car(string brand, string model, double mile, int doorsNum) : base(brand, model, mile)
    {
        DoorsNum = doorsNum;
    }

    public override void ShowFullInfo()
    {
        Console.WriteLine($"Car -> Brand: {Brand}, Model: {Model}, Mile: {Mile}, Doors: {DoorsNum}");
    }
}
