using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaç_Basamaklı_Oldugunu_Bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayıyı Girin : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int basamaksayısı = 0;
            while (sayi > 0)
            {
                sayi /= 10;
                basamaksayısı++;
            }
            Console.Write("Girilen Sayı "+basamaksayısı + " basamaklıdır!");
            Console.ReadKey();
        }
    }
}
