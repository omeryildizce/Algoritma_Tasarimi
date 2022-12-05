using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c04_Virtual_Methods
{
    public class Dikdortgen : Sekil
    {
        public override void Ciz() => Console.WriteLine($"Dikdörtgen {Pozisyon} - {Boyut}");
        public override void Tasi(Pozisyon pozisyon)
        {
            Console.Write("Dikdörtgen ");
            base.Tasi(pozisyon);
        }

        public override void YenidenBoyutlandir(int genislik, int yukseklik)
        {
            Boyut.Genislik = genislik;
            Boyut.Yukseklik = yukseklik;
        }
    }
}
