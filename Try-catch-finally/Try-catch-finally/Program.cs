using System;

namespace Try_catch_finally
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("a değerini girin:");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("b değerini girin:");
                int b = int.Parse(Console.ReadLine());

                int c = a + b;

                Console.WriteLine("a+b= "+c);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bir Hata Oluştu: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }
        }
    }
}
