using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace c15_dizi_eleman_bul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n değerini giriniz :");
            int limit = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[limit]; 

            for (int i = 0; i < limit; i++)
            { 
                sayilar[i] = new Random().Next(1,101);
                Console.Write("{0,5}", sayilar[i]);
                Thread.Sleep(1);
            }
            Console.WriteLine();

            int enBuyuk = EnBuyuk(sayilar);
            Console.WriteLine("Dizinin en büyük elamanı: {0}", enBuyuk);
            int enKucuk = EnKucuk(sayilar);
            Console.WriteLine("Dizinin en küçük elamanı: {0}", enKucuk);

        }

        public static int EnBuyuk(int[] dizi)
        {
            int enBuyuk = dizi[0];

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] > enBuyuk)
                {
                    enBuyuk = dizi[i];
                }
            }

            return enBuyuk;
        }
        public static int EnKucuk(int[] dizi)
        {
            int enKucuk= dizi[0];

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] < enKucuk)
                {
                    enKucuk = dizi[i];
                }
            }

            return enKucuk;
        }
    }
}
