using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle;

class Gallery
{
    List<Vehicle> vehicles = new List<Vehicle>();
    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void ShowVehicles()
    {
        foreach (var vehicle in vehicles)
        {
            vehicle.ShowFullInfo();
        }
    }
}
