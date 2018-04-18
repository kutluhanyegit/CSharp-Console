using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İki_sayinin_Kareleri_Toplami
{
    class Program
    {
        static void Main(string[] args)
        {
            // İki Sayının Kareleri Toplamı

            Console.Write("İlk Değeri Girin : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci Değeri Girin : ");
            int b = Convert.ToInt32(Console.ReadLine());
            double sonuc = Math.Pow(a, 2) + Math.Pow(b, 2);
            Console.Write("Değerlerin Kareleri Toplamı : " + sonuc);
            Console.ReadKey();

        }
    }
}
