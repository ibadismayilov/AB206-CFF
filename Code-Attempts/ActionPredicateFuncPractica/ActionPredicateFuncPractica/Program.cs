namespace ActionPredicateFuncPractica
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Action<string> action = str =>  Console.WriteLine($"Hello, {str}");
            action("Ibad");

            Func<int, int, int> add = (a, b) => a + b;

            Console.WriteLine(add(3, 4));

        }
    }
}
