using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProject;

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public bool IsActive { get; set; }
    private double _salary { get; set; }
    public double Salary
    {
        get
        {
            return _salary;
        }
        set
        {
            _salary = value;
        }
    }

    public Employee(string name, int age, bool isActive, double salary)
    {
        Name = name;
        Age = age;
        IsActive = isActive;
        Salary = salary;
    }
    public void Work(bool isActive)
    {
        IsActive = isActive;
        if(isActive == false)
        {
            Console.WriteLine("İşçi hazırda işləmir");
        } else
        {
            Console.WriteLine("İşçi hazırda işləyir");
        }
    }
}

class Manager : Employee
{
    public int TeamSize { get; set; }

    public Manager(string name, int age, bool isActive, double salary) : base( name,  age,  isActive, salary)
    {
        if(name.Length == 0)
        {
            Console.WriteLine("Obyekt yaradila bilmez");
        } else
        {
            Name = name;
        }
    }
}
