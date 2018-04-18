using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PozSayılarda_Çarpmaİşlemini_Toplama_ileBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Çarpmak İStediğiniz ilk Değeri Girin : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Çarpmak İstediğiniz ikinci Değeri Girin : ");
            int b = Convert.ToInt32(Console.ReadLine());
            int sonuc = 0;
            for (int i = 0; i <b; i++)
            {
                sonuc += a;
            }
            Console.Write("Girilen Değerlerin Sonuc : " + sonuc);
            Console.ReadKey();
        }
    }
}
