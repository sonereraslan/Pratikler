using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Atama ve işlemli atama operatörleri*****");
            Console.WriteLine("a sayısını girin:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b sayısını girin:");
            int b = Convert.ToInt32(Console.ReadLine());
            a += b;
            Console.WriteLine("a+=b işleminin sonucu: "+a);

            Console.WriteLine("*****Mantıksal ve ilişkisel operatörler*****");
            Console.WriteLine("c sayısını girin:");
            int c = Convert.ToInt32(Console.ReadLine());

            if((c>a) && (c > b))
            {
                Console.WriteLine("(c>a && c>b) işleminin sonucu DOĞRU.");
            }
            else
            {
                Console.WriteLine("(c>a && c>b) işleminin sonucu YANLIŞ.");
            }

            Console.WriteLine("*****Aritmetik operatörler*****");
            a++;
            b--;
            Console.WriteLine("a++ işleminin sonucu: " + a);
            Console.WriteLine("b-- işleminin sonucu: " + b);
        }
    }
}
