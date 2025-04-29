namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i = 576;
            object o = i;
            int n = (int)o;
            o = 70;
            Console.WriteLine(n);
            Console.WriteLine(o);
        }
    }
}
