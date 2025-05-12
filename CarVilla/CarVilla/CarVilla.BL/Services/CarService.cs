using CarVilla.DAL.Contexts;
using CarVilla.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarVilla.BL.Services;

public class CarService
{

    private readonly AppDbContext _appDbContext;

    public CarService()
    {
        _appDbContext = new AppDbContext();
    }

    public List<Car> GetAllCar()
    {
        return _appDbContext.Cars.ToList();
    }
}
