using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTask;

class Employee
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }

    public int _salary;

    public int Salary
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

    public void GetEmployeeInfo()
    {
        Console.WriteLine($"Employee information:");
        Console.WriteLine($"Name: {Name}\nSurnam: {Surname}\nAge: {Age}\nSalary: {Salary}");
    }
}
