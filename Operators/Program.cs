using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            // b is equal to a and then a is increased by 1
            int b = a++;
            System.Console.WriteLine(a);
            System.Console.WriteLine(b);
            // output a = 2, b = 1

            int c = 1;
            // d is incremented by 1 and then assigned to c
            int d = ++c;
            // output c = 2, d = 2
            Console.WriteLine(c);
            System.Console.WriteLine(d);
        }
    }
}
