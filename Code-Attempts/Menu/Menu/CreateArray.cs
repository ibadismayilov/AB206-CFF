using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu;

class CreateArray
{
    int[] array = new int[0];

    public void AddMethod(int value)
    {
        Array.Resize(ref array, array.Length + 1);
        array[array.Length - 1] = value;
    }

    public void ShowInfo()
    {
        Console.Write("Array elementləri: ");
        foreach (var item in array)
        {
            Console.WriteLine(item + " ");
        }
    }
}
