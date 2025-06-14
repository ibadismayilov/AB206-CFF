namespace NullableLesson;

public class Helper
{

    public static void SumNumbers(int? number)
    {

        if (number.HasValue)
        {
            int? sum = number + number;

            Console.WriteLine($"Sum: {sum}");
        } else
        {
            throw new ArgumentNullException("Number value is null");
        }
    }
}
