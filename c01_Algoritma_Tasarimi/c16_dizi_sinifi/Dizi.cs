using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace c16_dizi_sinifi
{
    public class Dizi
    {
        public int[] Olustur(int limit)
        {
            int[] sayilar = new int[limit];

            for (int i = 0; i < limit; i++)
            {
                sayilar[i] = new Random().Next(1, 101);
                Console.Write("{0,5}", sayilar[i]);
                Thread.Sleep(1);
            }
            Console.WriteLine();
            return sayilar;
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
            int enKucuk = dizi[0];

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
