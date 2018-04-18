using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PozSayılarda_Bölme_İşlemini_Çıkarma_ileBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pozitif Sayılarda Bölme İşlemini Çıkarma Yaptırarak Bulma

            Console.Write("Bölünecek Sayıyı Girin : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Böleni Girin : ");
            int b = Convert.ToInt32(Console.ReadLine());
            int bolum = 0;
            while (a>0 && a>=b) //a buyuk 0dan ve a buyuk eşit b oldugu durumlarda !!
            {
                a -= b;
                bolum++;
            }
            Console.Write("Sonuc : " + bolum);
            Console.ReadKey();
        }
    }
}
