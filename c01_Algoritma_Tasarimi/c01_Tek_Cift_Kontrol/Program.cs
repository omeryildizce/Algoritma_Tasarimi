using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c01_Tek_Cift_Kontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            tek_cift_kontrol.kontrol(sayi);
        }

     
    }
}
