using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c02_Mutlak_Deger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sonuc = Mutlak_Deger.MutlakDeger(sayi);

            Console.WriteLine("{0} sayısının mutlak değeri: |{0}| = {1}", sayi, sonuc);
        }
    }
}
