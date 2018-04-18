using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doğum_Tarihi_Girilen_Kişinin_Yaşını_Bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Doğum Yılınızı Giriniz : ");
            int dy = Convert.ToInt32(Console.ReadLine());
            int yas = DateTime.Now.Year - dy;
            Console.Write("Yaşınız : " + yas);
            Console.ReadKey();
        }
    }
}
