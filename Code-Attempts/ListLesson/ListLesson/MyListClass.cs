using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ListLesson;

public class MyListClass<T>
{
    List<T> human = new List<T>();
    public void AddMethod(T element)
    {
        human.Add(element);

        foreach (var item in human)
        {
            Console.WriteLine(item);
        }
    }
}

