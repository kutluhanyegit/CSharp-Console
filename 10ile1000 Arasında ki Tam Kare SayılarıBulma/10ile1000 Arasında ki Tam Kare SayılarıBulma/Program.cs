using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10ile1000_Arasında_ki_Tam_Kare_SayılarıBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            //10 ile 1000 arasında ki tam kare Sayılar
            //1 2 3 kareleri 10dan kucuk oldugu için saymıyoruz

            double sayi = 4;
            while (Math.Pow(sayi,2)<=1000)
            {
                Console.WriteLine(sayi + " Tam Kare Koşulunu Sağlar");
                sayi++;
            }
            Console.ReadKey();
        }
    }
}
