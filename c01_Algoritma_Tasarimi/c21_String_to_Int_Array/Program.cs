using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c21_String_to_Int_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ifadeyiDiziyeCevir();
            // ikilikTabanDonusumu();
        }

        private static void ikilikTabanDonusumu()
        {
            //ikilik sayının onluk tabanda yazdırma
            string ikilikSayi = Console.ReadLine();
            // uzunluğu belirleme
            int n = ikilikSayi.Length;
            // her bir basamağın dizide tutulması
            int[] basamaklar = new int[n];
            // onluk karşılığı
            int sayi = 0;
            bool kontrol = true;
            for (int i = 0; i < n; i++)
            {
                if (!(ikilikSayi[i] == '0' || ikilikSayi[i] == '1'))
                {
                    Console.WriteLine("\aHatalı Giriş!");
                    kontrol = false;
                    break;
                }
                basamaklar[i] = (int)(ikilikSayi[i] - '0');
            }
            // 2'lik sistemden 10'luk sisteme geçiş
            if (kontrol)
            {
                for (int i = 0; i < n; i++)
                {
                    sayi += (int)Math.Pow(2, n - 1 - i) * basamaklar[i];
                }
                Console.WriteLine("({0}) ikilik sayı = {1}", ikilikSayi, sayi);
            }
        }

        private static int[] ifadeyiDiziyeCevir()
        {
            // konsldan ifadenin okunması
            Console.WriteLine("Sayıları giriniz.(x,y)");
            string ifade = Console.ReadLine();
            string[] bolunmusIfade = ifade.Split(',');
            int n = bolunmusIfade.Length;
            // sayısal dizi
            int[] sayisalDizi = new int[n];
            // ayrıştırma
            for (int i = 0; i < n; i++)
            {
                sayisalDizi[i] = Convert.ToInt32(bolunmusIfade[i]);
                Console.WriteLine("dizi[{0}] = {1}", i + 1, sayisalDizi[i]);
            }
            return sayisalDizi;

        }
    }
}
