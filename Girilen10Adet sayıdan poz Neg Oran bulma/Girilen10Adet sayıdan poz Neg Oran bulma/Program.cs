using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girilen10Adet_sayıdan_poz_Neg_Oran_bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Girilen 10 Adet Sayıdan Pozitiflerin Negatiflere Oranı
            int sayi, pozToplam = 0, negToplam = 0;
            double oran;
            for (int i = 0; i < 10; i++)
            {
                Console.Write((i + 1) + ". Değeri Girin : ");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi>0)
                {
                    pozToplam += sayi;   
                }
                if (sayi<0)
                {
                    negToplam += sayi;
                }
            }
            oran = pozToplam / negToplam;
            Console.WriteLine("Girilen Değerlerin Oranı : "+oran);

            

            Console.ReadKey();
        }
    }
}
