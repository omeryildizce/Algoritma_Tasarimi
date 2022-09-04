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
            //AritmetikOrtalama(X);
            //StandartSapma(X);
            TekSayilarDizisi(X);
            CiftSayilarDizisi(X);
        }

        private static void CiftSayilarDizisi(int[] X)
        {
            Dizi dizi = new Dizi();
            int[] ciftSayilarDizisi = dizi.CiftDiziOlustur(X);
            Dizi.yazdir(ciftSayilarDizisi);
            Console.WriteLine("Cift Sayilarin Sayısı: {0}", ciftSayilarDizisi.Length);
        }

        private static void TekSayilarDizisi(int[] X)
        {
            Dizi dizi = new Dizi();
            int[] tekSayilarDizisi = dizi.TekDiziOlustur(X);
            Dizi.yazdir(tekSayilarDizisi);
            Console.WriteLine("Tek Sayilarin Sayısı: {0}", tekSayilarDizisi.Length);
        }

        private static void StandartSapma(int[] X)
        {
            Console.WriteLine("Dizinin standart sapması: {0,5}", Dizi.StandartSapma(X));
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
