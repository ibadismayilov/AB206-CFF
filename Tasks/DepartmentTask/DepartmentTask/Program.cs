using System;
using System.Collections.Generic;

namespace DepartmentTask;

public class CapacityLimitException : Exception
{
    public CapacityLimitException(string message) : base(message) { }
}
public interface IPerson
{
    string Name { get; set; }
    int Age { get; set; }
    string ShowInfo();
}
public class Employee : IPerson
{
    private static int _idCounter = 1;
    public int Id { get; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }

    public Employee(string name, int age, double salary)
    {
        if (string.IsNullOrWhiteSpace(name) || age <= 0 || salary <= 0)
            throw new ArgumentException("Məlumatlar düzgün daxil edilməlidir");

        Id = _idCounter++;
        Name = name;
        Age = age;
        Salary = salary;
    }

    public string ShowInfo() => $"ID: {Id} | Ad: {Name} | Yaş: {Age} | Maaş: {Salary}";
}

public class Department
{
    public string Name { get; }
    public int EmployeeLimit { get; }
    private List<Employee> Employees = new();

    public Department(string name, int limit)
    {
        if (string.IsNullOrWhiteSpace(name) || limit <= 0)
            throw new ArgumentException("Departament adı və limit düzgün olmalıdır");

        Name = name;
        EmployeeLimit = limit;
    }

    public void AddEmployee(Employee emp)
    {
        if (Employees.Count >= EmployeeLimit)
            throw new CapacityLimitException("İşçi limiti keçilib");

        Employees.Add(emp);
    }

    public void ShowEmployees()
    {
        Console.WriteLine($"\n[{Name}] Departamentdəki işçilər:");
        if (Employees.Count == 0)
            Console.WriteLine("İşçi yoxdur.");
        else
            Employees.ForEach(e => Console.WriteLine(e.ShowInfo()));
    }
}
class Program
{
    static void Main()
    {
        Department department = null;

        while (true)
        {
            Console.WriteLine("\n==== MENU ====");
            Console.WriteLine("1. Departament yarat");
            Console.WriteLine("2. İşçi əlavə et");
            Console.WriteLine("3. Bütün işçiləri göstər");
            Console.WriteLine("0. Çıxış");
            Console.Write("Seçim: ");
            string choice = Console.ReadLine();

            try
            {
                switch (choice)
                {
                    case "1":
                        Console.Write("Departament adı: ");
                        string name = Console.ReadLine();
                        Console.Write("İşçi limiti: ");
                        int limit = int.Parse(Console.ReadLine());
                        department = new Department(name, limit);
                        Console.WriteLine("Departament yaradıldı.");
                        break;

                    case "2":
                        if (department == null)
                        {
                            Console.WriteLine("Əvvəlcə departament yaradın.");
                            break;
                        }
                        Console.Write("Ad: ");
                        string empName = Console.ReadLine();
                        Console.Write("Yaş: ");
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("Maaş: ");
                        double salary = double.Parse(Console.ReadLine());
                        department.AddEmployee(new Employee(empName, age, salary));
                        Console.WriteLine("İşçi əlavə edildi.");
                        break;

                    case "3":
                        if (department == null)
                            Console.WriteLine("Əvvəlcə departament yaradın.");
                        else
                            department.ShowEmployees();
                        break;

                    case "0":
                        Console.WriteLine("Çıxılır...");
                        return;

                    default:
                        Console.WriteLine("Yanlış seçim.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Xəta: Rəqəmləri düzgün daxil edin.");
            }
            catch (CapacityLimitException ex)
            {
                Console.WriteLine($"Xəta: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Xəta: {ex.Message}");
            }
        }
    }
}
