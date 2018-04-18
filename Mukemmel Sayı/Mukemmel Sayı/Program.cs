using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mukemmel_Sayı
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayıyı Girin : ");
            int a = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;

            for (int i = 1; i < a; i++)
            {
                if (a%i==0)
                {
                    toplam += i;
                }
            }

            if (toplam==a)
            {
                Console.WriteLine("Mükemmel Sayı");
            }
            else
            {
                Console.WriteLine("Mükemmel Sayı Değil");
            }
            Console.ReadKey();
        }
    }
}
