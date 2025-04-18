using ListForEmpoyee.Helper;
using ListForEmpoyee.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListForEmpoyee.Models
{
    public class Menu
    {
        public void CreateMenu()
        {
            int result;
            EmployeeService employeeServices = new EmployeeService();

            do
            {
                Console.WriteLine("1.AddEmployee: ");
                Console.WriteLine("2.GetEmployee: ");
                Console.WriteLine("3.GetAllEmployees: ");
                Console.WriteLine("4.GetAllEmployeesBySalary: ");
                Console.WriteLine("5.GetAllEmployeesByPosition: ");
                Console.WriteLine("6.GetAllEmployeesByDepartmentNo: ");
                Console.WriteLine("7.UpdateEmployee: ");
                Console.WriteLine("8.DeleteEmployee: ");

                bool isCheck = int.TryParse(Console.ReadLine(), out result);

                if (isCheck)
                {
                    switch (result)
                    {
                        case 1:
                            Console.Write("Please enter a name: ");
                            string name = Console.ReadLine();

                            Console.Write("Please enter a surnmae: ");
                            string surname = Console.ReadLine();

                            Console.Write("Please enter a age: ");
                            int age = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Please enter a departmentNo: ");
                            int departmentNo = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Please enter a Position: ");
                            string positionType = Console.ReadLine();
                            Enum.TryParse(positionType, out Positions type);

                            Console.Write("Please enter a Price: ");
                            int price = Convert.ToInt32(Console.ReadLine());

                            Employee employee = new Employee(name, surname, age, departmentNo, type, price);
                            employeeServices.AddEmployee(employee);

                            break;

                        case 2:
                            Console.Write("Please enter a id: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            employeeServices.GetEmployee(id);

                            break;
                        case 3:
                            var allEmployees = employeeServices.GetAllEmployees();

                            foreach (var item in allEmployees)
                            {
                                Console.WriteLine($"ID: {item.ID}, Name: {item.Name}, Surname: {item.Surname}, Age: {item.Age}, DepartmentNo: {item.DepartmentNo}, Position: {item.position}, Salary: {item.Salary}");
                            }

                            break;
                        case 4:
                            Console.Write("Please enter a min salary: ");
                            int min__salary = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Please enter a max salary: ");
                            int max__salary = Convert.ToInt32(Console.ReadLine());

                            employeeServices.GetAllEmployeesBySalary(min__salary, max__salary);
                            break;
                        case 5:

                            int postionResult;

                            do
                            {
                                Console.Write("1. CEO Position, ");
                                Console.Write("2. CMO Position, ");
                                Console.Write("3. CTO Position, ");
                                Console.Write("4. Developer Position, ");
                                Console.WriteLine("5. HR Position");

                                bool isPositonCheck = int.TryParse(Console.ReadLine(), out postionResult);

                                if (isPositonCheck)
                                {
                                    switch (postionResult)
                                    {
                                        case 1:
                                            employeeServices.GetAllEmployeesByPosition(Positions.CEO);
                                            break;
                                        case 2:
                                            employeeServices.GetAllEmployeesByPosition(Positions.CMO);
                                            break;
                                        case 3:
                                            employeeServices.GetAllEmployeesByPosition(Positions.CTO);
                                            break;
                                        case 4:
                                            employeeServices.GetAllEmployeesByPosition(Positions.Developer);
                                            break;
                                        case 5:
                                            employeeServices.GetAllEmployeesByPosition(Positions.HR);
                                            break;

                                    }
                                }
                            }
                            while (postionResult != 0);

                            break;

                        case 6:
                            Console.Write("Please enter a Department No: ");
                            int department__no = Convert.ToInt32(Console.ReadLine());

                            employeeServices.GetAllEmployeesByDepartmentNo(department__no);

                            break;
                    }
                }
            }
            while (result != 0);
        }
    }
}
