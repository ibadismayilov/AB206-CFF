using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem;

public class SmartAirConditioner : IDevice, ITemperatureControl
{
    public void SetTemperature(int temperature)
    {
        throw new NotImplementedException();
    }

    public void TurnOff()
    {
        throw new NotImplementedException();
    }

    public void TurnOn()
    {
        throw new NotImplementedException();
    }
}
