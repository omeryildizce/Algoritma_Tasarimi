using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c01_Tek_Cift_Kontrol
{
    public class tek_cift_kontrol
    {
       /// <summary>
       /// Parametre olarak alınan sayının çift yada tek olduğunu kontrol edip ekrana yazzdırır.
       /// </summary>
       /// <param name="sayi">Girilen sayı</param>
        public static void kontrol(int sayi)
        {
            if (sayi % 2 == 0)
            {
                Console.WriteLine($"{sayi} çift");
            }
            else
            {
                Console.WriteLine("{0} tek", sayi);
            }
        }
    }
}
