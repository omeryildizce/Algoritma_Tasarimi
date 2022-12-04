using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c03_Modelleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arac benimAracim = new Arac("Skoda", "SuperB", "Gri", 2020);
            Console.WriteLine($"{benimAracim.Marka}");
            Console.WriteLine($"{benimAracim.Model}");
            Console.WriteLine($"{benimAracim.Renk}");
            Console.WriteLine($"{benimAracim.Yil}");


        }
    }
 
}
