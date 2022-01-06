using System;

namespace While_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı girini:");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }

            Console.WriteLine("1'den girilen sayıya kadar olan sayıların ortalaması: "+toplam / sayi);

            string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };
            foreach(var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
