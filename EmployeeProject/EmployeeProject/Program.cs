namespace EmployeeProject;

internal class Program
{
    static void Main(string[] args)
    {
        Manager manager = new Manager("ibad", 19, true, 2000);
        Console.WriteLine(manager.Salary);
    }
}
