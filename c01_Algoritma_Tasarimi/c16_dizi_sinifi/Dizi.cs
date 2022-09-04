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
        /// <summary>
        /// Tek boyutlu dizi oluşturmak için kullanılan fonksiyondur
        /// </summary>
        /// <param name="limit">dizinin uzunluğunu belirtir.</param>
        /// <returns>Belirtilen Uzunlukta rastgele sayilardan oluşmuş diziyi döndürür.</returns>
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
        /// <summary>
        /// Parametre olarak aldığı dizideki en büyük elemanı döndürür.
        /// </summary>
        /// <param name="dizi"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Parametre olarak aldığı dizideki en küçük elemanı döndürür.
        /// </summary>
        /// <param name="dizi"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Parametre olarak aldığı dizinin aritmetik ortalamasını döndürür.
        /// </summary>
        /// <param name="X">Dizi</param>
        /// <returns>Aritmetik Ortalama</returns>
        public static double AritmetikOrtalama(int[] X)
        { 
            double toplam = 0;

            for(int i = 0; i < X.Length; i++)
            {
                toplam += X[i];
            }
            return toplam / X.Length;
        }
        /// <summary>
        /// Parametre olarak aldığı dizinin standart sapmasını döndürür.
        /// </summary>
        /// <param name="dizi"></param>
        /// <returns>Standart sapma</returns>
        public static double StandartSapma(int[] dizi)
        {
            double aritmetikOrtalama = AritmetikOrtalama(dizi);
            double toplam = 0;
            double fark = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                fark = (dizi[i] - aritmetikOrtalama) ;
                toplam += fark * fark;
            } 
            return Math.Sqrt(toplam / (dizi.Length - 1));
        }
    }
}
