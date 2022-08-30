using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tek_sayilar_toplami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 10;
           
            int toplam = Tek_Sayi_Topla.for_ile_topla(sayi);
            Console.WriteLine("Tek sayıların toplamı: "+ toplam);
            toplam = Tek_Sayi_Topla.for_ve_if_ile_topla(sayi);
            Console.WriteLine("Tek sayıların toplamı: " + toplam);

            Console.WriteLine(Tek_Sayi_Topla.nkare(13));

        }
    }
}
