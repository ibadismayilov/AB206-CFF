using ListForEmpoyee.Exceptions;
using ListForEmpoyee.Helper;
using ListForEmpoyee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ListForEmpoyee.Services;

public class EmployeeService
{
    public static List<Employee> employeesList = new List<Employee>();

    public void AddEmployee(Employee employee)
    {
        try
        {
            employeesList.Add(employee);
        }
        catch
        {
            throw new EmployeeException("Add methodu islemedi");
        }
    }

    public Employee GetEmployee(int id)
    {
        try
        {
            foreach (Employee item in employeesList)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }
        }
        catch
        {
            throw new EmployeeException("Get Employee alinan zaman xeta bas verdi");
        }

        return null;
    }

    public List<Employee> GetAllEmployees()
    {
        if (employeesList == null || employeesList.Count == 0)
        {
            Console.WriteLine("Employee list boşdur");
            return new List<Employee>();
        }

        return employeesList;
    }

    public void GetAllEmployeesBySalary(double minSalary, double maxSalary)
    {
        List<Employee> salaryList = new List<Employee>();

        try
        {
            foreach (Employee item in employeesList)
            {
                if (s.Salary <= minSalary && s.Salary >= maxSalary)
                {
                    salaryList.Add(s);
                }

                if (salaryList.Count == 0)
                {
                    Console.WriteLine("Bu vəzifədə heç bir işçi tapılmadı");
                }
                else
                {
                    foreach (var s in salaryList)
                    {
                        Console.WriteLine($"ID: {s.ID}, Name: {s.Name}, Surname: {s.Surname}, Age: {s.Age}, DepartmentNo: {s.DepartmentNo}, Position: {s.position}, Salary: {s.Salary}");
                    }
                }
            }
        }
        catch
        {
            throw new EmployeeException("Salary problem var");
        }
    }

    public void GetAllEmployeesByPosition(Positions type)
    {
        List<Employee> employeesPositionList = new List<Employee>();

        try
        {
            foreach (Employee item in employeesList)
            {
                if (item.position == type)
                {
                    employeesPositionList.Add(item);
                }
            }

            if (employeesPositionList.Count == 0)
            {
                Console.WriteLine("Bu vəzifədə heç bir işçi tapılmadı");
            }
            else
            {
                foreach (Employee item in employeesPositionList)
                {
                    Console.WriteLine($"ID: {item.ID}, Name: {item.Name}, Surname: {item.Surname}, Age: {item.Age}, DepartmentNo: {item.DepartmentNo}, Position: {item.position}, Salary: {item.Salary}");
                }
            }
        }
        catch
        {
            throw new EmployeeException("Positiona müraciət zamanı problem çıxdı.");
        }
    }


    public void GetAllEmployeesByDepartmentNo(int departmentNo)
    {
        List<Employee> employeesDepartmenList = new List<Employee>();

        try
        {
            foreach (Employee item in employeesList)
            {
                if (item.DepartmentNo == departmentNo)
                {
                    employeesDepartmenList.Add(item);
                }
            }

            if (employeesDepartmenList.Count == 0)
            {
                Console.WriteLine("Bu vəzifədə heç bir işçi tapılmadı");
            }
            else
            {
                foreach (Employee d in employeesDepartmenList)
                {
                    Console.WriteLine($"ID: {d.ID}, Name: {d.Name}, Surname: {d.Surname}, Age: {d.Age}, Position: {d.position}, Salary: {d.Salary}");
                }
            }
        }
        catch
        {
            throw new EmployeeException("Department no -  muraciet zamani problem cixdi");
        }
    }

    public void UpdateEmployee(int id, Employee newEmployee)
    {
        foreach (Employee item in employeesList)
        {
            if (item.ID == id)
            {
                item.Name = newEmployee.Name;
                item.Surname = newEmployee.Surname;
                item.Age = newEmployee.Age;
                item.Salary = newEmployee.Salary;
                item.DepartmentNo = newEmployee.DepartmentNo;
                item.position = newEmployee.position;
                return;
            }
        }

        throw new EmployeeException($"{id} - tapilmadi ve update olmadı");
    }

    public void DeleteEmployee(int id)
    {
        foreach (Employee? item in employeesList)
        {
            if (item.ID == id)
            {
                employeesList.Remove(item);
            }
        }
    }
}
