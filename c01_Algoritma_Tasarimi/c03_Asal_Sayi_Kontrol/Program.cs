using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c03_Asal_Sayi_Kontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                if (Asal_Sayi_Kontrol.Asalmi(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
