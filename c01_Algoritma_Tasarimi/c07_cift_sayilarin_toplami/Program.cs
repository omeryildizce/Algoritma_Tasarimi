using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c07_cift_sayilarin_toplami
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int sayi = 13;
          
           Console.WriteLine(CiftSayiToplami.ciftSayilariTopla(sayi));
           Console.WriteLine(CiftSayiToplami.ciftSayilariTopla1(sayi));
           Console.WriteLine(CiftSayiToplami.ciftSayilariTopla2(sayi));

        }
    }
}
