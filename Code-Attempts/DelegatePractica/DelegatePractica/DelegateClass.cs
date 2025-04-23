using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractica
{
    public class DelegateClass
    {
        public delegate void MyDelegate(string message);

        public void SayHello(string name)
        {
            Console.WriteLine("Hello");
        }
    }
}
