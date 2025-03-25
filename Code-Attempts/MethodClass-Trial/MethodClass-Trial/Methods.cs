using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass_Trial
{
    class Methods
    {
        public static int GetResult(int number)
        {

            int first = 0, second = 1;

            Console.Write($"{first} {second} "); 

            for (int i = 2; i < number; i++) 
            {
                int next = first + second;
                Console.Write(next + " ");
                first = second;
                second = next;
            }

            return default;
        }
    }
}
