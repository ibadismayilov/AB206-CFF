namespace Vehicle;

internal class Program
{
    static void Main(string[] args)
    {
        Gallery gallery = new Gallery();

        Console.Write("Enter Car Brand: ");
        string brand = Console.ReadLine();

        Console.Write("Enter Car Model: ");
        string model = Console.ReadLine();

        Console.Write("Enter Car Mile: ");
        double mile = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Car Doors Number: ");
        int doorsNum = Convert.ToInt32(Console.ReadLine());

        gallery.AddVehicle(new Car(brand, model, mile, doorsNum));

        gallery.ShowVehicles();
    }
}
