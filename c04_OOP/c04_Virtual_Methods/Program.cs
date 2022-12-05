using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c04_Virtual_Methods
{
    internal class Program
    {
        public static void SekilCiz(Sekil sekil) =>
            sekil.Ciz(); 
        static void Main(string[] args)
        {
            // virtual_method();
            var r = new Elips();
            r.Pozisyon.X = 55;
            r.Pozisyon.Y = 25;
            r.Boyut.Genislik = 200;
            r.Boyut.Yukseklik = 100;
            SekilCiz(r);
            r.Tasi(new Pozisyon { X=20, Y=30 });
            SekilCiz(r);
        }

        private static void virtual_method()
        {
            var r = new Dikdortgen();
            r.Pozisyon.X = 23;
            r.Pozisyon.Y = 43;
            r.Boyut.Genislik = 100;
            r.Boyut.Yukseklik = 50;
            r.Ciz();
            var e = new Sekil();
            e.Pozisyon.X = 23;
            e.Pozisyon.Y = 43;
            e.Boyut.Genislik = 100;
            e.Boyut.Yukseklik = 50;
            e.Ciz();
        }
    }
}
