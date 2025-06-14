using System;

class Program
{
    static void Main()
    {
        int[] number = new int[10];

        Console.WriteLine("10 ədəd daxil edin:");

        number[0] = Convert.ToInt32(Console.ReadLine());
        int min = number[0];
        int max = number[0];

        for (int i = 1; i < number.Length; i++)
        {
            int userInputValue = Convert.ToInt32(Console.ReadLine());
            number[i] = userInputValue;

            if (number[i] < min)
                min = number[i];

            if (number[i] > max)
                max = number[i];
        }

        Console.WriteLine("\nƏn kiçik element: " + min);
        Console.WriteLine("Ən böyük element: " + max);
    }
}
