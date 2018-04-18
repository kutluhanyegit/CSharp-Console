using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girilen_Sayının_5in_Kuvveti_mi_Bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Girilen Sayı 5in Kuvveti mi Bulma
            Console.Write("Sayı Girin : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sayac = 0;

            while (true)
            {
                if (sayi%5==0)
                {
                    sayac++;
                    sayi /= 5;
                    if (sayi==1)
                    {
                        Console.WriteLine("5'in "+sayac +". Kuvveti");
                        
                        break;
                    }
                     
                }
                else
                {
                    Console.WriteLine("Değil");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
