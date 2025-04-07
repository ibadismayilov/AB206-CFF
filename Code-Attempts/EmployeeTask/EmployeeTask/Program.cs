namespace EmployeeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result;
            Department department = new Department();
            department.EmployeeLimit = 20;

            do
            {
                Console.WriteLine("=======================================");

                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("1.Employee əlavə et");
                Console.WriteLine("2.İşci axtar");
                Console.WriteLine("3.Bütün işçilərə bax");
                Console.WriteLine("4.Maaş aralığına görə işçiləri axtarış et");
                Console.Write("0.Proqramı bitir");

                Console.WriteLine("=======================================");
                Console.Write("\nSeçiminizi daxil edin: ");
                bool check = int.TryParse(Console.ReadLine(), out result);

                if (check)
                {
                    switch (result)
                    {
                        case 1:
                            Employee employee = new Employee();
                            Console.Write("Employee adı: ");
                            employee.Name = Console.ReadLine();

                            Console.Write("Employee soyadı: ");
                            employee.Surname = Console.ReadLine();

                            Console.Write("Employee yaşı: ");
                            employee.Age = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Employee maaşı: ");
                            employee.Salary = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Employee əlavə olundu!\n");

                            department.AddEmployee(employee);
                            employee.GetEmployeeInfo();
                            break;

                        case 2:
                            Console.Write("Axtarmaq istədiyiniz işçinin adını daxil edin: ");
                            string name = Console.ReadLine();

                            Console.Write("Axtarmaq istədiyiniz işçinin soyadını daxil edin: ");
                            string surname = Console.ReadLine();

                            department.GetEmployee(name , surname);
                            break;

                        case 3:
                            Console.WriteLine("Departmentdəki bütün işçilər: ");
                            Console.WriteLine(department.GetAllEmployees());
                            break;

                        case 4:
                            Console.WriteLine("Maaş aralığı daxil edin: ");
                            int minSalary = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Maaş aralığı daxil edin: ");
                            int maxSalary = Convert.ToInt32(Console.ReadLine());

                            department.GetAllEmployeesBySalary(minSalary, maxSalary);
                            break;

                        case 0:
                            Console.WriteLine("Təşəkkürlər");
                            break;
                    }
                }
            }
            while (result != 0);
        }
    }
}
