using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoPonavljanjeZadatak8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broj1 = 0;
            int broj2 = 1;
            int fibonacci = 0;
            int n;

            Console.WriteLine("Upišite broj: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Prvih {0} brojeva Fibonaccijeva niza {1} {2} ", n, broj1, broj2);

            for (int i = 2; i < n; i++)
            {
                fibonacci = broj1 + broj2;
                Console.Write("{0} ", fibonacci);
                broj1 = broj2;
                broj2 = fibonacci;
            }

            Console.WriteLine(" {0} član Fibonnacijeva niza: " + fibonacci);
            Console.ReadKey();
        }
    }
}
