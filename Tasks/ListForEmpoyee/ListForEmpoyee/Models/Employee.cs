
using ListForEmpoyee.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListForEmpoyee.Models;

public class Employee
{
    private int _id = 1;
    public int ID
    {
        get
        {
            return _id;
        }
        set
        {
            _id = value;
        }
    }

    public string Name { get; set; }
    public string Surname { get; set; }
    public string Fullname { get => $"{Name} {Surname}"; }
    public int Age { get; set; }
    public int DepartmentNo { get; set; }
    public Positions position { get; set; }
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

    public Employee(string name, string surname, int age, int departmentNo, Positions position, double salary)
    {
        ID = _id++;
        Name = name;
        Surname = surname;
        Age = age;
        DepartmentNo = departmentNo;
        this.position = position;
        Salary = salary;
    }
}
