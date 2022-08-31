using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c10_for_I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            birden_yuze_kadar_kare_hesapla();
        }

        private static void birden_yuze_kadar_kare_hesapla()
        {
            for (int i = 1; i < 101; i++)
            {
                Console.Write("{0,4} -> {1,5} ", i, i * i);
                if (i % 5 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
