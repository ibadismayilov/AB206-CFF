using static SalesProject.SalesComponents;

namespace SalesProject;

internal class Program
{
    static void Main(string[] args)
    {
        Notebook notebook = new Notebook("ibad", "ibad", 1, 100, 1, 32);

        notebook.Sale();
        Console.WriteLine("==============================");
        notebook.ShowFullData();

    }
}
