using System;

namespace dikdörgencevrealan
{
    class Program
    {
        static void Main(string[] args)
        {
            int ukenar = 0, kkenar = 0;
            Console.Write("Diktörgenin uzun kenarını giriniz:");
            ukenar = Convert.ToInt32(Console.ReadLine());
            Console.Write("Diktörgenin kısa kenarını giriniz:");
            kkenar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Çevre= {0}", ((ukenar + kkenar) * 2).ToString());
            Console.WriteLine("Alan= {0}", (ukenar * kkenar).ToString());
            Console.ReadKey();
        }
    }
}
