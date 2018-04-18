using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1den10aKadarOlanSayıların_Küp_Toplamı
{
    class Program
    {
        static void Main(string[] args)
        {
            //1den10 a kadar olan sayıların küp toplamı
            double toplam = 0;

            for (int i = 1; i < 11; i++)
            {
                toplam +=Math.Pow(i, 3);
            }
            Console.Write("1den10 a kadar Olan sayıların küplerinin Toplamı = " + toplam);
            Console.ReadKey();
        }
    }
}
