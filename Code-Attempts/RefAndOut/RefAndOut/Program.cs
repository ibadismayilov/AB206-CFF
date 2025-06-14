using System;

namespace RefAndOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 1;
            //int b = 2;
            //int temp = 0;

            //Methods usingRef = new Methods();
            //usingRef.UsingRefMethod(ref a, ref b, ref temp);

            //Console.WriteLine($"a: {a}, b: {b}");

            Methods mehhods = new Methods();

            Console.WriteLine("Please enter numbers");
            int numbers1 = Convert.ToInt32(Console.ReadLine());
            int numbers2 = Convert.ToInt32(Console.ReadLine());

            mehhods.PrintArray(numbers1, numbers2);
        }
    }
}
