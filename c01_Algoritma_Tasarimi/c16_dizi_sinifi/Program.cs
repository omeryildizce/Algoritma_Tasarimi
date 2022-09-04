using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace c16_dizi_sinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n değerini giriniz :");
            int limit = Convert.ToInt32(Console.ReadLine());
            int[] X = new Dizi().Olustur(limit);

            //EnBuyukEnKucuk(X);

            AritmetikOrtalama(X);

        }

        private static void AritmetikOrtalama(int[] X)
        {
            Console.WriteLine("Dizinin aritmetik ortalaması: {0,5}", Dizi.AritmetikOrtalama(X));
        }

        private static void EnBuyukEnKucuk(int[] sayilar)
        {
            int enBuyuk = Dizi.EnBuyuk(sayilar);
            Console.WriteLine("Dizinin en büyük elamanı: {0}", enBuyuk);
            int enKucuk = Dizi.EnKucuk(sayilar);
            Console.WriteLine("Dizinin en küçük elamanı: {0}", enKucuk);
        }

       
    }
}
