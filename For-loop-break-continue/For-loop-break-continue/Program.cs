using System;

namespace For_loop_break_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            int tekToplam = 0;
            int ciftToplam = 0;

            for(int i=1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                    tekToplam += i;
                else
                    ciftToplam += i;
            }

            Console.WriteLine("Tek toplam: " + tekToplam);
            Console.WriteLine("Çift toplam: " + ciftToplam);
        }
    }
}
