using System;

namespace Switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış ayındayız!");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar ayındayız!");
                    break;
                    
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz ayındayız!");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar ayındayız!");
                    break;



            }
        }
    }
}
