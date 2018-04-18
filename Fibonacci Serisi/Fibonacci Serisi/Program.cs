using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Serisi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacci = new int[10];
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            Console.WriteLine("1. Terimi "+fibonacci[0]);
            Console.WriteLine("2. Terimi "+fibonacci[1]);
            for (int i = 2; i < 10; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                Console.WriteLine((i+1)+". Terimi "+fibonacci[i]);
            }
            Console.ReadKey();
        }
    }
}
