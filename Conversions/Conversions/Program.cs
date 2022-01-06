using System;

namespace Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Implicit Conversion****");
            int a = 10;
            double b = a;
            int c = (int)b;
            Console.WriteLine("b: "+b);
            Console.WriteLine("c: "+c);

            Console.WriteLine("**** Explicit Conversion****");

            float x = 5.7f;
            byte y = (byte)x;
            Console.WriteLine("y: " + y);

            int xx = 5;
            string yy = xx.ToString();
            Console.WriteLine("yy: " + yy);

        }
    }
}
