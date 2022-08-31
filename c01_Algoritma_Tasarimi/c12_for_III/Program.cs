using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c12_for_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit = 0;
            int toplamSayi = 0;
            for (int i = 1000; i >= limit; i -= 5)
            {
                toplamSayi++;
                Console.Write("{0,5}", i);
                if (i % 100 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine(toplamSayi);
        }
    }
}
