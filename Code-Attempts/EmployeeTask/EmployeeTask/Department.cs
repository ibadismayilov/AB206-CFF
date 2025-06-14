
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTask
{
    class Department : IMyMethods
    {
        public int EmployeeLimit { get; set; }

        public Employee[] employees = new Employee[0];

        public void AddEmployee(Employee employee)
        {
            if (employees.Length >= EmployeeLimit)
            {
                Console.WriteLine("Limit");
            }
            else
            {
                Array.Resize(ref employees, employees.Length + 1);
                employees[employees.Length - 1] = employee;
            }
        }

        public Employee[] GetAllEmployees()
        {
            if (employees.Length == 0)
            {
                Console.WriteLine("Heç bir işçi mövcud deyil.");
            }
            else
            {
                foreach (var employee in employees)
                {
                    employee.GetEmployeeInfo();
                }
            }

            return employees;
        }

        public Employee[] GetAllEmployeesBySalary(int minSalary, int maxSalary)
        {
            Employee[] filterEmployees = new Employee[0];

            foreach (var item in employees)
            {
                if (item.Salary > minSalary && item.Salary < maxSalary)
                {
                    Array.Resize(ref filterEmployees, filterEmployees.Length + 1);
                    filterEmployees[filterEmployees.Length - 1] = item;
                }
            }

            if (filterEmployees.Length != 0)
            {
                int count = 1;
                foreach (var employee in filterEmployees)
                {
                    Console.WriteLine(count + ". " + employee.Name + " " + employee.Surname);
                    count++;
                }
            }
            else
            {
                Console.WriteLine("Heç bir işçi mövcud deyil.");
            }

            return filterEmployees;
        }

        public Employee[] GetEmployee(string name, string surname)
        {
            Employee[] filterEmployees = new Employee[0];

            foreach (var item in employees)
            {
                if (item.Name == name && item.Surname == surname)
                {
                    Array.Resize(ref filterEmployees, filterEmployees.Length + 1);
                    filterEmployees[filterEmployees.Length - 1] = item;
                }
            }

            if (filterEmployees.Length == 0)
            {
                Console.WriteLine("Belə işçi yoxdur.");
            }
            {
                foreach (var employee in filterEmployees)
                {
                    employee.GetEmployeeInfo();
                }
            }

            return filterEmployees;
        }
    }
}