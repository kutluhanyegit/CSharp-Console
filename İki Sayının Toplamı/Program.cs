using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iki_Sayinin_Toplami
{
    class Program
    {
        static void Main(string[] args)
        {
            //İki Sayının Toplamı

            int a, b, toplam;
            Console.Write("İlk Değeri Girin : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci Değeri Girin :");
            b = Convert.ToInt32(Console.ReadLine());
            toplam = a + b;
            Console.Write("Girilen Değerlerin Toplamı  = " + toplam);

            Console.ReadKey();
        }
    }
}
