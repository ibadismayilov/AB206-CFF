using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOut;

class Methods
{
    //public void UsingRefMethod(ref int a, ref int b, ref int temp)
    //{
    //    temp = a;
    //    a = b;
    //    b = temp;
    //}

    public void PrintArray(int a, int b)
    {
        int one = a;
        int two = b;


        if (int.TryParse(one.ToString(),out one))
        {
            Console.WriteLine($"True: {one}");
        } else
        {
            Console.WriteLine("False");
        }

        if (int.TryParse(two.ToString(), out two))
        {
            Console.WriteLine($"True: {two}");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}

