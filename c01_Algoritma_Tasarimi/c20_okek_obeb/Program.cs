using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c20_okek_obeb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ObebOkek();
            //Faktoriyel();
        }

        private static void Faktoriyel()
        {
            int faktoriyel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Hesapla.Faktoriyel(faktoriyel));
        }

        private static void ObebOkek()
        {
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Okek({0},{1}) = {2}", sayi1, sayi2, Hesapla.Okek(sayi1, sayi2));
            Console.WriteLine("Obeb({0},{1}) = {2}", sayi1, sayi2, Hesapla.Obeb(sayi1, sayi2));
        }
    }
}
