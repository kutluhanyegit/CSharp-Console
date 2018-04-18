using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_500Arasında_ki_Tam_Sayıların_Toplamı
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            for (int i = 1; i <= 500; i++)
            {
                toplam += i;
            }
            Console.WriteLine("Toplamları : " + toplam);
            Console.ReadKey();
        }
    }
}
