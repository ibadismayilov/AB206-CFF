using System.Security.Cryptography.X509Certificates;

namespace DelegatePractica;

internal class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3, 4, -5, 6, 7, -8, 9 };

        SumNums(nums, IsNegative);
    }
    public delegate void ClickEventHandler();

    public delegate bool DelegatePractica(int num);

    public static void SumNums(int[] nums, DelegatePractica delegatePractica)
    {
        int sum = 0;

        foreach (var item in nums)
        {
            if (delegatePractica(item))
            {
                sum += item;
            }
        }

        Console.WriteLine(sum);
    }

    public static bool IsNegative(int num)
    {
        return num < 0;
    }

    public static bool IsPositive(int num) => num > 2;
}
