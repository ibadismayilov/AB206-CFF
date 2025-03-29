using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Bicycle : Vehicle
    {
        public int WheelNum { get; set; }

        public Bicycle(string brand, string model, double mile, int wheelNum) : base(brand, model, mile)
        {
            WheelNum = wheelNum;
        }

        public override void ShowFullInfo()
        {
            Console.WriteLine($"Bicycle -> Brand: {Brand}, Model: {Model}, Mile: {Mile}, Wheels: {WheelNum}");
        }
    }
}
