using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girilen_Sayının_İstenilen_Sayıya_Modu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Modunu Almak İstediğiniz Sayıyı Girin : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kaça Mod almak istiyorsunuz : ");
            int b = Convert.ToInt32(Console.ReadLine());
            int sonuc = a % b;
            Console.Write("Mod İşleminin Sonuc : " + sonuc);
            Console.ReadKey();
        }
    }
}
