using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Güçlü_Sayı
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basamakları Toplamı ve Basamakları Carpımının Toplamı Kendine Eşit Olan Sayılar
            Console.WriteLine("Sayıyı Girin : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int basamaktoplam = 0, basamakcarpım = 1,geneltoplam=0,y;
            y = sayi;
            while (y>0)
            {
                int basamak = y % 10;
                y /= 10;
                basamaktoplam += basamak;
                basamakcarpım *= basamak;
                geneltoplam = basamakcarpım + basamaktoplam;
            }
            if (sayi==geneltoplam)
            {
                Console.WriteLine("Güçlü Sayı ");
            }
            else
            {
                Console.WriteLine("Güçlü Sayı Değil");
            }
            
            Console.ReadKey();
        }
    }
}
