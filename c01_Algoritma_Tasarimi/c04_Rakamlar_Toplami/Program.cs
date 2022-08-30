using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c04_Rakamlar_Toplami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} sayısının rakamları toplamı = {1}",sayi,Rakamlar_Toplami.Rakamlar_Topla(sayi));
        }
    }
}
