namespace ArrayToStringConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] trialFirst = { 1, -4, 9, -8 };
            int[] trialSecond = { 9, -2, 1, 6 };

            ArrayToStringConverter(trialFirst);
            Console.WriteLine("==================================================================");
            ArrayToStringConverter(trialSecond);

        }

        public static string ArrayToStringConverter(int[] numbers)
        {
            string result = "";
            bool check = false;
            int negativeCount = 0;
            int allItemSum = 0;
            int product = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                string str = Convert.ToString(numbers[i]);
                result = string.Join(" ", numbers);

                if (numbers[i] < 0)
                {
                    check = true;
                    negativeCount++;
                }

                allItemSum += numbers[i];
                product *= numbers[i];
            }

            Console.WriteLine(result);

            if (check)
            {
                Console.WriteLine("Negative: " + negativeCount);
            }

            Console.WriteLine("Sum: " + allItemSum );
            Console.WriteLine("Product: " + product);
            return result;
        }
    }
}
