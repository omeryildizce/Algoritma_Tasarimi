using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c05_1_10_Arasi_Sayilarin_Toplami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            One_to_ten_sum();

            int sayi = 10000;
            Toplam(sayi);
        }

        private static void Toplam(int sayi)
        {
            int toplam = 0;
            toplam = (sayi * (sayi + 1)) / 2;
            Console.WriteLine(toplam);
        }

        private static void One_to_ten_sum()
        {
            int sayi = 10;
            int toplam = 0;
            for (int i = 1; i <= sayi; i++)
            {
                toplam += i;
            }

            Console.WriteLine(toplam);
        }
    }


}
