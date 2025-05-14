using CarVilla.DAL.Contexts;
using CarVilla.DAL.Models;
using Microsoft.EntityFrameworkCore;
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

    public Car GetCarById(int id)
    {
        var findCar = _appDbContext.Cars.Find(id);
        return findCar;
    }

    public void CreateCar(Car car)
    {
        _appDbContext.Cars.Add(car);
        _appDbContext.SaveChanges();
    }

    public void DeleteCar(int id)
    {
        Car findCar = GetCarById(id);
        if (findCar != null)
        {
            _appDbContext.Cars.Remove(findCar);
            _appDbContext.SaveChanges();
        }
    }

    public void UpdateCar(int id, Car updatedCar)
    {
        var existingCar = _appDbContext.Cars.AsNoTracking().FirstOrDefault(c => c.Id == id);

        if (existingCar != null)
        {
            updatedCar.Id = id;
            _appDbContext.Cars.Update(updatedCar);
            _appDbContext.SaveChanges();
        }
    }

}
