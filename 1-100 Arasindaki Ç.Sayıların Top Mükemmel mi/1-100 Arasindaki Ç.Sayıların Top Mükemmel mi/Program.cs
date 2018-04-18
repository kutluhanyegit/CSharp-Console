using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_100_Arasindaki_Ç.Sayıların_Top_Mükemmel_mi
{
    class Program
    {
        static void Main(string[] args)
        {
            int ciftToplam = 0,mukemmelToplam=0;
            for (int i = 1; i <= 100; i++)
            {
                if (i%2==0)
                {
                    ciftToplam += i;
                }
            }
            for (int i = 1; i < ciftToplam; i++)
            {
                if (ciftToplam%i==0)
                {
                    mukemmelToplam += i;
                }
            }
            if (ciftToplam==mukemmelToplam)
            {
                Console.WriteLine("Mukemmeldir!");
            }
            else
            {
                Console.WriteLine("Mukemmel Değildir!");
            }
            Console.ReadKey();
        }
    }
}
