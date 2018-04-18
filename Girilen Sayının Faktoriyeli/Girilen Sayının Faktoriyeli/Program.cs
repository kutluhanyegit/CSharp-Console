using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girilen_Sayının_Faktoriyeli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Faktoriyelini Almak İstediğiniz Sayıyı Girin : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int faktoriyel = 1; //Çarpma işlemi olcağı için 1 ataması yaptım
            for (int i = 1; i <=sayi; i++)
            {
                faktoriyel *= i;
            }
            Console.WriteLine("Girilen Sayının Faktoriyeli : " + faktoriyel);
            Console.ReadKey();
        }
    }
}
