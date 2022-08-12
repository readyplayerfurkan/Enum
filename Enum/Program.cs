using System;

namespace EnumDersi
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Günler.Cumartesi);
            Console.WriteLine((int)Günler.Cumartesi);

            int sıcaklık = Convert.ToInt32(Console.ReadLine());

            if (sıcaklık < (int)HavaDurumu.normal)
                Console.WriteLine("Havanın ısınmasını bekleyelim.");
            else if (sıcaklık >= (int)HavaDurumu.sıcak)
                Console.WriteLine("Havanın biraz soğumasını bekleyelim.");
            else if (sıcaklık < (int)HavaDurumu.sıcak && sıcaklık > (int)HavaDurumu.normal)
                Console.WriteLine("Hadi dışarı çıkalım!");

        }
    }

    enum Günler
    {
        Pazartesi=1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma=26,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        soğuk=5,
        normal=15,
        sıcak=30
    }
}

