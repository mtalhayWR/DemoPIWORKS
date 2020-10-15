using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12, b = 13;
            Console.WriteLine("Swap before a:" + a + "b:" + b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("Swap after a:" + a + "b:" + b);
        }
    }
}
