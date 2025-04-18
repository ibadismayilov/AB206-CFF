using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListForEmpoyee.Models;

public class Department
{
    public int No { get; set; } = 1;
    public Employee Employees { get; set; }
    public int EmployeeLimit
    {
        get
        {
            return EmployeeLimit;
        }
        set
        {
            if (value <= 0  && value>=20)
            {
                Console.WriteLine("EmployeeLimit 0-dan kiçik və 20-dən böyük ola bilməz");
            }
        }
    }
    public Department(int depNo)
    {
        No = depNo;
        depNo++;
    }
}
