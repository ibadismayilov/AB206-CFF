namespace fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fib1 = 0;
            int fib2 = 1;
            int i = 0;

            while (i < 5)
            {
                fib1 = 2 * (i + 1);
                fib1 += fib2;
                i++;
                Console.WriteLine(fib2);
            }
        }
    }
}
