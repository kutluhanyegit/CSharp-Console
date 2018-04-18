using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bas.KüpToplamı_Kendine_Eşit_olanı_bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayıyı Girin : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            double toplam = 0;
            int y;
            y = sayi;
            while (y > 0)
            {
                toplam += Math.Pow((y % 10), 3);
                y /= 10;
            }
            Console.WriteLine("Basamaklarının Küpleri Toplamı : " + toplam);

            if (sayi==toplam)
            {
                Console.WriteLine("Basamak Küp Toplamı Kendisine Eşittir!!");
            }
            else
            {
                Console.WriteLine("Basamak Küp Toplamı Kendisine Eşit Değildir!!");
            }
            Console.ReadKey();
        }
    }
}
