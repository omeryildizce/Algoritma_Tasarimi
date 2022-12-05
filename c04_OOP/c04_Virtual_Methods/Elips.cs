using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c04_Virtual_Methods
{
    public class Elips : Sekil
    {
        public override void Tasi(Pozisyon pozisyon)
        {
            Console.Write("Elips ");
            base.Tasi(pozisyon);
        }
        public override void Ciz() => Console.WriteLine($"Elips {Pozisyon} - {Boyut}");

        public override void YenidenBoyutlandir(int genislik, int yukseklik)
        {
            Boyut.Genislik = genislik;
            Boyut.Yukseklik = yukseklik;
        }
    }
}
