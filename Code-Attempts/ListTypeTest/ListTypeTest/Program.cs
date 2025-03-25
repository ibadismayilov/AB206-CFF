namespace ListTypeTest;

internal class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Please enter the numbers in the list.");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Number {i + 1}: ");
            int num = Convert.ToInt32(Console.ReadLine());
            numbers.Add(num);
        }

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine("\nEnter the number you want to delete:");

        int deleteNum = Convert.ToInt32(Console.ReadLine());
        if (numbers.Contains(deleteNum))
        {
            numbers.Remove(deleteNum);
            Console.WriteLine("Was removed from the list.");

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
