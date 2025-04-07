using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTask
{
    interface IMyMethods
    {
        void AddEmployee(Employee employee);
        Employee[] GetEmployee(string name, string surname);
        Employee[] GetAllEmployees();
        Employee[] GetAllEmployeesBySalary(int minSalary, int maxSalary);
    }
}
