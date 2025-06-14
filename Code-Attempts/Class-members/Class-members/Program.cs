using System.Xml.Linq;

namespace Class_members;

internal class Program
{
    static void Main(string[] args)
    {

        Myclass customObject = new Myclass
        {
            name = "Test",
            age = 19,
        };

        Console.WriteLine(customObject.name);

    }
}
