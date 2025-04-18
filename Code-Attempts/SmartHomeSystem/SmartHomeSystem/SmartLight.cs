using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem;

public class SmartLight : IDevice
{
    void IDevice.TurnOff()
    {
        Console.WriteLine("Işıq söndü");
    }

    void IDevice.TurnOn()
    {
        throw new NotImplementedException();
    }
}
